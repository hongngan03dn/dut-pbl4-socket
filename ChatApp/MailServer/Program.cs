﻿using System;
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
                getClientInfo(client);

                // tạo Thread nhận tin nhắn của Client -> xử lí tn : Save DB + Sent to targetClient if online
                //...

            }
        }

        public static void getInfoServer()
        {
            string computerName = Dns.GetHostName();
            var hostEntry = Dns.GetHostEntry(computerName);
            IPAddress address = hostEntry.AddressList[3];
            IPEndPoint endPoint = new IPEndPoint(address, 6767);

            Console.WriteLine("INFO IP: " + address.ToString() + "; Port: " + endPoint.Port.ToString() + "\n");
            
            server.Bind(endPoint);
            //server.Listen(10);
            //lbInfo.Text = "Waiting to connect...";
        }
        public static void getClientInfo(object objClient)
        {
            Socket client = objClient as Socket;
            byte[] datarecv = new byte[1024];
            int recv = client.Receive(datarecv);
            string recvStr = Encoding.ASCII.GetString(datarecv, 0, recv);

            String[] splitted = recvStr.Split('|');
            int id = Int32.Parse(splitted[0].Trim());

            clientOnline.Add(new ClientModel()
            {
                Id = id,
                Username = splitted[1].Trim(),
                clientSocket = client,
            });

            Console.WriteLine("INFO Login by: " + id + " | " + splitted[1].Trim() + "\n");
        }
    }
}
