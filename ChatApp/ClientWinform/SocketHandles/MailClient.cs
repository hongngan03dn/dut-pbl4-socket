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
    public class MailClient
    {
        static String _ipServer = "192.168.32.1";
        static int _port = 6767;
        static IPEndPoint _ipep;
        static Socket _client;
        static int _myId;

        public static void connectServer(String username)
        {
            _ipep = new IPEndPoint(IPAddress.Parse(_ipServer), _port);
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                // kết nối Server
                _client.Connect(_ipep);

                //gửi ID + Username cho Server
                byte[] datasend = new byte[1024];
                datasend = Encoding.ASCII.GetBytes(_myId.ToString() + " | " + username);
                _client.Send(datasend, datasend.Length, SocketFlags.None);

                //Thread recvMss = new Thread(receiveMessage);
                //recvMss.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
