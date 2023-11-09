using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientWinform.SocketHandles
{
    internal class MailClient
    {
        String IpServer = "127.0.0.0";
        int Port = 6767;
        IPEndPoint ipep;
        Socket client;
        int myId;
        public MailClient() 
        {

        } 

        //public void connectServer()
        //{
        //    ipep = new IPEndPoint(IPAddress.Parse(IpServer), Port);
        //    client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //    try
        //    {
        //        client.Connect(ipep);

        //        //send MyId
        //        byte[] datasend = new byte[1024];
        //        datasend = Encoding.ASCII.GetBytes(myId.ToString());
        //        client.Send(datasend, datasend.Length, SocketFlags.None);

        //        Thread recvMss = new Thread(receiveMessage);
        //        recvMss.Start();
        //        lbInfo.Text = "Connected";
        //    }
        //    catch (Exception ex)
        //    {
        //        lbInfo.Text = ex.Message;
        //    }
        //}
    }
}
