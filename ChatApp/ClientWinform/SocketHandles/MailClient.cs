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
        delegate void setForm(string[] msg, Form chatListForm);
        delegate void setSubForm(int idTo, int idFrom, string msg, Form subForm);
        delegate void CustomClickHandler(object sender, EventArgs e, int userId, int userToId);


        static String _ipServer = "192.168.2.17";
        static int _port = 6767;
        static IPEndPoint _ipep;
        static Socket _client;

        static User userLoggined;
        static int[] idOnlines = null;
        static int idLoggined = 0;

        static Form formAll;
        public static void connectServer(int myId, String username, Form activeForm)
        {
            _ipep = new IPEndPoint(IPAddress.Parse(_ipServer), _port);
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            userLoggined = BLL.UserBLL.getUserByID(myId);
            formAll = activeForm;

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
            int idMsg = BLL.UserBLL.InsertMessage(myId, toId, content);
            SocketPacketModel packet = new SocketPacketModel(idMsg, myId, toId, content);
            string sendMsg = JsonConvert.SerializeObject(packet); // chuyển Object thành JsonString
            try
            {
                datasend = Encoding.ASCII.GetBytes(sendMsg);
                _client.Send(datasend, datasend.Length, SocketFlags.None);
                UpdateListChat(null, formAll);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void receivedMsg(int idTo, int idFrom, string content, Form form)
        {
            if (form.InvokeRequired)
            {
                setSubForm d = new setSubForm(receivedMsg);
                form.Invoke(d, new object[] { idTo, idFrom, content, form });
            }
            else
            {
                if (form is NavigationForm navigationForm)
                {
                    if(idFrom == navigationForm.chatForm.chatContentForm.userTo.Id)
                    {
                        navigationForm.chatForm.chatContentForm.listBox1.Items.Add(content);
                    }
                    
                }
            }
        }
        public static void UpdateListChat(string[] message, Form activeForm)
        {
            if(message != null)
            {
                string[] partsLogin = message[0].Split(' ');
                bool isParsableToId = int.TryParse(partsLogin[0], out int myId);
            
                
                if (isParsableToId)
                {
                    idLoggined = myId;
                }
                string keyword = "Current onlines: ";

                string onlyIdNumbers = "";

                string[] parts = message[1].Split(new[] {keyword}, StringSplitOptions.None);
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
                    if (onlineStrings[i].Trim() != "" && int.Parse(onlineStrings[i].Trim()) != idLoggined)
                    {
                        idOnlines[i] = int.Parse(onlineStrings[i].Trim());
                    }
                }
                Array.Resize(ref idOnlines, idOnlines.Length - 1);
            }


            //delegate
            if (activeForm.InvokeRequired)
            {
                setForm d = new setForm(UpdateListChat);
                activeForm.Invoke(d, new object[] { message, activeForm });
            }
            else
            {

                if (activeForm is NavigationForm navigationForm && idLoggined != 0)
                {
                    List<DTO.UserModel> users = BLL.UserBLL.getUserListChat(userLoggined.Id);
                    foreach (DTO.UserModel user in users)
                    {
                        navigationForm.chatForm.Invoke((MethodInvoker)delegate
                        {
                            ChatReviewForm chat = navigationForm.chatForm.flowLayoutPanelListChat.Controls.OfType<ChatReviewForm>()
                                                                                                          .FirstOrDefault(c => c.userName == user.Username);
                            if (chat == null)
                            {
                                chat = new ChatReviewForm();
                                navigationForm.chatForm.flowLayoutPanelListChat.Controls.Add(chat);
                            }
                            byte[] images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
                            if (images == null)
                            {
                                chat.ava = Resources.defaultAvatar;
                            }
                            else
                            {
                                MemoryStream mstream = new MemoryStream(images);
                                chat.ava = Image.FromStream(mstream);
                            }
                            if (user.Id == idLoggined)
                            {
                                chat.isPictureBoxOnlineVisible = true;
                            }
                            if (idOnlines != null)
                            {
                                for (int i = 0; i < idOnlines.Length; i++)
                                {
                                    if (user.Id == idOnlines[i])
                                        chat.isPictureBoxOnlineVisible = true;
                                }
                            }
                            chat.userName = user.Username;
                            DTO.Message msg = BLL.UserBLL.getMessage(userLoggined.Id, user.Id);
                            if(msg != null)
                            {
                                if (BLL.UserBLL.getMessage(userLoggined.Id, user.Id).IdFrom == userLoggined.Id)

                                {
                                    chat.message = "You: " + BLL.UserBLL.getMessage(userLoggined.Id, user.Id).ContentMsg;
                                }
                                else
                                {
                                    chat.message = BLL.UserBLL.getMessage(userLoggined.Id, user.Id).ContentMsg;
                                }
                            }
                            else
                            {
                                chat.message = "";
                            }

                            foreach (Control c in chat.Controls)
                            {
                                c.Click -= new EventHandler((sender, e) => navigationForm.chatForm.chatPanel_Click(sender, e, userLoggined.Id, user.Id));
                                c.Click += new EventHandler((sender, e) => navigationForm.chatForm.chatPanel_Click(sender, e, userLoggined.Id, user.Id));
                            };
                            navigationForm.chatForm.flowLayoutPanelListChat.Controls.Add(chat);
                        });
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
                if(!stringData.Contains("Message: "))
                {
                    string[] messages = stringData.Split('\n');
                    UpdateListChat(messages, form);
                }
                else
                {
                    string[] messages = stringData.Split(new string[] { "Message: ", " From: ", " To: " }, StringSplitOptions.None);
                    receivedMsg(Int32.Parse(messages[3]), Int32.Parse(messages[2]), messages[1], form);
                    UpdateListChat(null, form);
                }

            }
        }
    }
}
