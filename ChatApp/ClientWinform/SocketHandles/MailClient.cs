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
using ClientWinform.Properties;
using System.IO;
using ClientWinform.DTO;
using Newtonsoft.Json;
using System.Drawing;

namespace ClientWinform.SocketHandles
{
    public class MailClient
    {
        delegate void setForm(string msg, Form chatListForm);
        static String _ipServer = "192.168.1.21";
        static int _port = 6767;
        static IPEndPoint _ipep;
        static Socket _client;

        static User user;
        static int idLoggined = 0;
        public static void connectServer(int myId, String username, Form activeForm)
        {
            _ipep = new IPEndPoint(IPAddress.Parse(_ipServer), _port);
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            user = BLL.UserBLL.getUserByID(myId);


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
        public static void sendMsg(int myId, int toId, String content)
        {
            byte[] datasend = new byte[1024];
            SocketPacketModel packet = new SocketPacketModel(myId, toId, content);
            string sendMsg = JsonConvert.SerializeObject(packet); // chuyển Object thành JsonString
            try
            {
                datasend = Encoding.ASCII.GetBytes(sendMsg);
                _client.Send(datasend, datasend.Length, SocketFlags.None);

                //Thread recvMss = new Thread(receiveMessage);
                //recvMss.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateListChat(string message, Form activeForm)
        {
            bool isParsableToId = int.TryParse(message, out int myId);
            
            int[] idOnlines = null;
            if (isParsableToId)
            {
                idLoggined = myId;
            }
            else
            {
                string keyword = "Current onlines: ";

                string onlyIdNumbers = "";

                string[] parts = message.Split(new[] {keyword}, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    if (parts[0] != "")
                        idLoggined = int.Parse(parts[0].Trim());

                    onlyIdNumbers = parts[1];
                }
                string[] onlineStrings = onlyIdNumbers.Trim().Split(',');

                idOnlines = new int[onlineStrings.Length];
                for (int i = 0; i < onlineStrings.Length; i++)
                {
                    if (int.Parse(onlineStrings[i].Trim()) != idLoggined)
                    {
                        idOnlines[i] = int.Parse(onlineStrings[i].Trim());
                    }
                }
                Array.Resize(ref idOnlines, idOnlines.Length - 1);

                //delegate
                if(activeForm.InvokeRequired)
                {
                    setForm d = new setForm(UpdateListChat);
                    activeForm.Invoke(d, new object[] { message, activeForm });
                }
                else
                {

                    if (activeForm is NavigationForm navigationForm && idLoggined != 0)
                    {
                        List<DTO.User> users = BLL.UserBLL.getUserListChat(user.Id);
                        byte[] images = null;
                        foreach (DTO.User user in users)
                        {
                            ChatReviewForm chat = new ChatReviewForm();
                            images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
                            if (images == null)
                            {
                                chat.ava = Resources.defaultAvatar;
                            }
                            else
                            {
                                MemoryStream mstream = new MemoryStream(images);
                                chat.ava = Image.FromStream(mstream);
                            }
                            if(user.Id == idLoggined)
                            {
                                chat.isPictureBoxOnlineVisible = true;
                            }
                            if (idOnlines != null)
                            {
                                for (int i = 0; i < idOnlines.Length; i++)
                                {
                                    if(user.Id == idOnlines[i])
                                        chat.isPictureBoxOnlineVisible = true;
                                }
                            }
                            chat.userName = user.Username;
                            navigationForm.chatForm.Invoke((MethodInvoker)delegate {

                                foreach (Control c in chat.Controls)
                                {
                                    c.Click += new EventHandler(navigationForm.chatForm.chatPanel_Click);
                                }
                                navigationForm.chatForm.flowLayoutPanelListChat.Controls.Add(chat);
                            });
                        }
                    }
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
