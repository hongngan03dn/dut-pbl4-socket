using MailServer.DBHelpers;
using MailServer.Entities;
using MailServer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MailServer
{
    internal class Program
    {
        static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static List<ClientModel> clientOnline = new List<ClientModel>();
        static List<string> queueActivity = new List<string>();
        static string pathServer = "../../../FileStorage";

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
            IPAddress address = IPAddress.Parse("192.168.1.16"); //hostEntry.AddressList[9]; 
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
                byte[] datarecv = new byte[1024 * 128];
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
                    else if (recvStr.Contains(" has signned out"))
                    {
                        string[] messages = recvStr.Split(new string[] { " has signned out" }, StringSplitOptions.None);
                        ClientModel clientSendMsg = clientOnline.Where(x => x.Id == Int32.Parse(messages[0].Trim())).FirstOrDefault();
                        clientOnline.Remove(clientSendMsg);
                        if(clientOnline.Count > 0)
                        {
                            broadcastMessage(recvStr);
                        }
                        Console.WriteLine("INFO Logout by: " + Int32.Parse(messages[0].Trim()) + "\n");
                    }
                    else if (recvStr.Contains("Connection"))
                    {
                        string[] messages = recvStr.Split(new string[] { "Connection: ", " | ", " status: " }, StringSplitOptions.None);
                        ClientModel clientSendMsg = clientOnline.Where(x => x.Id == Int32.Parse(messages[2].Trim())).FirstOrDefault();
                        if (clientSendMsg != null)
                        {
                            byte[] msg = Encoding.ASCII.GetBytes("Update connnection");
                            clientSendMsg.clientSocket.Send(msg);
                            string onlineClients = string.Join(", ", clientOnline.Select(c => c.Id));
                            broadcastMessage("\nCurrent onlines: " + onlineClients + "\n");
                        }
                    }
                    else
                    {
                        SocketPacketModel packet = JsonConvert.DeserializeObject<SocketPacketModel>(recvStr);
                        MessageHelper messageHelper = new MessageHelper();

                        // handle request download file
                        if (packet.PacketType == Constants.PacketType.GET_FILE)
                        {
                            string result;
                            try
                            {
                                Entities.File file = messageHelper.getFileNameByIdMsg(packet.IdMsg);
                                string fname = file.Path;
                                string userNameFile = file.Name;

                                byte[] fileData = System.IO.File.ReadAllBytes(pathServer + "/" + fname);
                                byte[] fnameByte = Encoding.ASCII.GetBytes(userNameFile);
                                byte[] fnameLen = BitConverter.GetBytes(fnameByte.Length);
                                byte[] clientData = new byte[4 + fnameByte.Length + fileData.Length];
                                fnameLen.CopyTo(clientData, 0);
                                fnameByte.CopyTo(clientData, 4);
                                fileData.CopyTo(clientData, 4 + fnameByte.Length);

                                
                                SocketPacketModel packetDownload = new SocketPacketModel(packet.IdMsg, 0, 0, packet.ContentMsg, DateTime.Now, Constants.PacketType.GET_FILE);
                                packetDownload.SubPacketFile = clientData;
                                result = JsonConvert.SerializeObject(packetDownload);
                            }
                            catch (Exception e)
                            {
                                SocketPacketModel packetDownload = new SocketPacketModel(packet.IdMsg, 0, 0, e.Message, DateTime.Now, Constants.PacketType.ERROR);
                                result = JsonConvert.SerializeObject(packetDownload);
                            }

                            byte[] msg = Encoding.ASCII.GetBytes(result);
                            client.Send(msg);

                            continue;
                        }
                        // end handle request download file

                        ClientModel onlineToClient = clientOnline.Where(x => x.Id == packet.IdTo).FirstOrDefault();
                        ClientModel clientSendMsg = clientOnline.Where(x => x.Id == packet.IdFrom).FirstOrDefault();

                        // Start handle File
                        if (packet.PacketType == Constants.PacketType.FILE)
                        {
                            int receiveByteLen = packet.SubPacketFile.Length;
                            int fnameLen = BitConverter.ToInt32(packet.SubPacketFile, 0);
                            string fname = Encoding.ASCII.GetString(packet.SubPacketFile, 4, fnameLen);
                            BinaryWriter writer = new BinaryWriter(System.IO.File.Open(pathServer + "/" + fname, FileMode.Append));
                            writer.Write(packet.SubPacketFile, 4 + fnameLen, receiveByteLen - 4 - fnameLen);
                            writer.Close();
                        }

                        // End handle File


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
