using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MailServer
{
    internal class Program
    {
        static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            getInfoServer();
        }

        public static void getInfoServer()
        {
            string computerName = Dns.GetHostName();
            var hostEntry = Dns.GetHostEntry(computerName);
            IPAddress address = hostEntry.AddressList[8];
            IPEndPoint endPoint = new IPEndPoint(address, 6767);

            Console.WriteLine("INFO IP: " + address.ToString() + "; Port: " + endPoint.Port.ToString() + "\n");
            
            server.Bind(endPoint);
            //server.Listen(10);
            //lbInfo.Text = "Waiting to connect...";
        }
    }
}
