using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClientWinform.View.User;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ClientWinform.SocketHandles
{
    public class MailClient
    {
        delegate void setForm(string msg, Form chatListForm);
        static String _ipServer = "192.168.56.1";
        static int _port = 6767;
        static IPEndPoint _ipep;
        static Socket _client;

        public static void connectServer(int myId, String username, Form activeForm)
        {
            _ipep = new IPEndPoint(IPAddress.Parse(_ipServer), _port);
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                // kết nối Server
                _client.Connect(_ipep);

                //gửi ID + Username cho Server
                byte[] datasend = new byte[1024];
                datasend = Encoding.ASCII.GetBytes(myId.ToString() + " | " + username);
                _client.Send(datasend, datasend.Length, SocketFlags.None);

                Thread listenThread = new Thread(() => listenForMessages(activeForm));
                listenThread.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateListChat(string message, Form activeForm)
        {
            //ChatListForm form = activeForm as ChatListForm;
            //string txt = form.idUser.ToString();
            //System.Console.WriteLine(txt);
            if(activeForm.InvokeRequired)
            {
                setForm d = new setForm(UpdateListChat);
                activeForm.Invoke(d, new object[] { message, activeForm });
            }
            else
            {
                if (activeForm is NavigationForm navigationForm)
                {
                    navigationForm.chatForm.listBox1.Items.Add(message);
                }
            }
        }
        public static void listenForMessages(Form form)
        {
            while(true)
            {
                byte[] data = new byte[1024];
                int receivedDataLength = _client.Receive(data);
                string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                UpdateListChat(stringData, form);
            }
        }
    }
}
