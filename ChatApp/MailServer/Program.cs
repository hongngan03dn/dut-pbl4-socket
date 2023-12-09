﻿using MailServer.DBHelpers;
using MailServer.Entities;
using MailServer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailServer
{
    internal class Program
    {
        static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static List<ClientModel> clientOnline = new List<ClientModel>();
        static List<string> queueActivity = new List<string>();

        static void Main(string[] args)
        {

            getInfoServer();

            // lắng nghe client
            server.Listen(10);

            while (true)
            {
                Socket client = server.Accept();

                // lấy IDUser + Username của client
                //getClientInfo(client);

                onClientConnect(client);

                // tạo Thread nhận tin nhắn của Client -> xử lí tn : Save DB + Sent to targetClient if online
                Thread threadListenClient = new Thread(listenMsgClient);
                threadListenClient.Start(client);

            }
        }

        public static void getInfoServer()
        {
            string computerName = Dns.GetHostName();
            var hostEntry = Dns.GetHostEntry(computerName);
            IPAddress address = hostEntry.AddressList[1];
            IPEndPoint endPoint = new IPEndPoint(address, 6767);

            Console.WriteLine("INFO IP: " + address.ToString() + "; Port: " + endPoint.Port.ToString() + "\n");
            
            server.Bind(endPoint);
            //server.Listen(10);
            //lbInfo.Text = "Waiting to connect...";
        }

        public static ClientModel getClientInfo(object objClient)
        {
            Socket client = objClient as Socket;
            byte[] datarecv = new byte[1024];
            int recv = client.Receive(datarecv);
            string recvStr = Encoding.ASCII.GetString(datarecv, 0, recv);
            String[] splitted = recvStr.Split('|');
            int id = Int32.Parse(splitted[0].Trim());

            //clientOnline.Add(new ClientModel()
            //{
            //    Id = id,
            //    Username = splitted[1].Trim(),
            //    clientSocket = client,
            //});
            ClientModel newClient = new ClientModel()
            {
                Id = id,
                Username = splitted[1].Trim(),
                clientSocket = client,
            };

            clientOnline.Add(newClient);

            Console.WriteLine("INFO Login by: " + id + " | " + splitted[1].Trim() + "\n");
            //broadcastMessage(newClient.Username + " has logged in.");
            return newClient;
        }
        public static void broadcastMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message + "\n");
            foreach (ClientModel client in clientOnline)
            {
                client.clientSocket.Send(data);
            }
        }
        public static void onClientConnect(Socket client)
        {
            ClientModel newClient = getClientInfo(client);
            string message = newClient.Id.ToString() + " has loggined ";
            broadcastMessage(message);
            string onlineClients = string.Join(", ", clientOnline.Select(c => c.Id));
            byte[] currentOnline = Encoding.ASCII.GetBytes("Current onlines: " + onlineClients + "\n");
            newClient.clientSocket.Send(currentOnline);
        }

        
        public static void listenMsgClient(object objClient)
        {
            Socket client = objClient as Socket;
            while (true)
            {
                byte[] datarecv = new byte[1024];
                try
                {
                    int recv = client.Receive(datarecv);
                    string recvStr = Encoding.ASCII.GetString(datarecv, 0, recv);


                    if(recvStr.Contains("Already seen"))
                    {
                        string[] messages = recvStr.Split(new string[] { "Already seen. Sent confirm for: " }, StringSplitOptions.None);
                        ClientModel clientSendMsg = clientOnline.Where(x => x.Id == Int32.Parse(messages[1])).FirstOrDefault();
                        if(clientSendMsg != null)
                        {
                            byte[] msg = Encoding.ASCII.GetBytes("Return status: " + Constants.MessageStatuses.READ);
                            clientSendMsg.clientSocket.Send(msg);
                        }

                    }
                    else
                    {
                        SocketPacketModel packet = JsonConvert.DeserializeObject<SocketPacketModel>(recvStr);

                        ClientModel onlineToClient = clientOnline.Where(x => x.Id == packet.IdTo).FirstOrDefault();
                        ClientModel clientSendMsg = clientOnline.Where(x => x.Id == packet.IdFrom).FirstOrDefault();

                        MessageHelper messageHelper = new MessageHelper();


                        if (onlineToClient != null)
                        {
                            messageHelper.UpdateMesageToReceived(packet.IdMsg);
                            byte[] msg = Encoding.ASCII.GetBytes("Message: " + packet.ContentMsg + " From: " + packet.IdFrom + " To: " + packet.IdTo + " CreatedDate: " + packet.CreatedDate + " IdMsg: " + packet.IdMsg);
                            onlineToClient.clientSocket.Send(msg);
                        }
                        else
                        {
                        }
                        if(clientSendMsg != null)
                        {
                            if (onlineToClient != null)
                            {
                                byte[] msg = Encoding.ASCII.GetBytes("Return status: " + Constants.MessageStatuses.RECEIVED);
                                clientSendMsg.clientSocket.Send(msg);
                            }
                            else
                            {
                                byte[] msg = Encoding.ASCII.GetBytes("Return status: " + Constants.MessageStatuses.SENT);
                                clientSendMsg.clientSocket.Send(msg);
                            }
                            Console.WriteLine("INFO Listen from: " + packet.IdFrom + " | " + packet.IdTo + " | " + packet.ContentMsg + "\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR " + ex.Message);
                }
            }
        }

    }
}
