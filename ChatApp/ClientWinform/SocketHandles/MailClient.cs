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
using Guna.UI2.WinForms;
using System.Globalization;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientWinform.SocketHandles
{
    public class MailClient
    {
        delegate void setForm(string[] msg, Form chatListForm);
        delegate void setSubForm(int idMsg, Form subForm);
        delegate void returnStatusForm(int status, Form form);
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
        public static void sendMsg(int myId, int toId, String content, Nullable<System.DateTime> createdDate)
        {
            byte[] datasend = new byte[1024];
            int idMsg = BLL.MsgBLL.InsertMessage(myId, toId, content);
            SocketPacketModel packet = new SocketPacketModel(idMsg, myId, toId, content, createdDate);
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
        public static void sendStatusSeen(Nullable<Int32> idFrom)
        {
            byte[] datasend = new byte[1024];
            if(_client.Connected)
            {
                datasend = Encoding.ASCII.GetBytes("Already seen. Sent confirm for: " + idFrom.ToString());
                _client.Send(datasend, datasend.Length, SocketFlags.None);
            }
        }
        public static void receivedMsg(int idMsg, Form form)
        {
            if (form.InvokeRequired)
            {
                setSubForm d = new setSubForm(receivedMsg);
                form.Invoke(d, new object[] { idMsg, form});
            }
            else
            {
                if (form is NavigationForm navigationForm && navigationForm.chatForm.chatContentForm != null)
                {
                    DTO.Message newMessage = BLL.MsgBLL.getMessageById(idMsg);
                    if (newMessage.IdFrom == navigationForm.chatForm.chatContentForm.userTo.Id)
                    {
                        List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
                        BLL.MsgBLL.UpdateMsgesToSeen(idMsg);
                        
                        navigationForm.chatForm.chatContentForm.AddStatusPanelToChat(Constants.MessageStatuses.SEEN, false);
                        navigationForm.chatForm.chatContentForm.AddMessagesToChatPanel(msg, newMessage.IdTo, navigationForm.chatForm.chatContentForm.flowLayoutPanelChat);

                        sendStatusSeen(newMessage.IdFrom);
                    }
                    
                }
            }
        }
        public static void returnStatus(int status, Form form)
        {
            if (form.InvokeRequired)
            {
                returnStatusForm d = new returnStatusForm(returnStatus);
                form.Invoke(d, new object[] { status, form });
            }
            else
            {
                if (form is NavigationForm navigationForm && navigationForm.chatForm.chatContentForm != null)
                {
                    navigationForm.chatForm.chatContentForm.AddStatusPanelToChat(status, true);
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
                    optionForm(navigationForm.chatForm);
                }
                else if (activeForm is ChatListForm chatList && idLoggined != 0)
                {
                    optionForm(chatList);
                }
            }
        }
        public static void optionForm(ChatListForm chatList)
        {
            List<DTO.UserModel> users = BLL.MsgBLL.getUserListChat(userLoggined.Id);
            foreach (DTO.UserModel user in users)
            {
                chatList.Invoke((MethodInvoker)delegate
                {
                    ChatReviewForm chat = chatList.flowLayoutPanelListChat.Controls.OfType<ChatReviewForm>()
                                                                                                  .FirstOrDefault(c => c.userName == user.Username);
                    if (chat == null)
                    {
                        chat = new ChatReviewForm();
                        chatList.flowLayoutPanelListChat.Controls.Add(chat);
                    }
                    byte[] images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
                    if (images == null)
                    {
                        chat.ava = Resources.defaultAvatar;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(images);
                        chat.ava = System.Drawing.Image.FromStream(mstream);
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
                    DTO.Message msg = BLL.MsgBLL.getMessage(userLoggined.Id, user.Id);
                    if (msg != null)
                    {
                        if (msg.IdFrom == userLoggined.Id)
                        {
                            if (("You: " + msg.ContentMsg).Length > Constants.MessageTies.MAXLENGTHINREVIEW)
                                chat.message = ("You: " + msg.ContentMsg).Substring(0, Constants.MessageTies.MAXLENGTHINREVIEW) + "...";
                            else
                                chat.message = "You: " + msg.ContentMsg;
                        }
                        else
                        {
                            if (msg.ContentMsg.Length > Constants.MessageTies.MAXLENGTHINREVIEW)
                                chat.message = msg.ContentMsg.Substring(0, Constants.MessageTies.MAXLENGTHINREVIEW) + "...";
                            else
                                chat.message = msg.ContentMsg;
                        }
                        chat.time = BLL.MsgBLL.formatTime(msg.CreatedDate);
                    }
                    else
                    {
                        chat.message = "";
                    }


                    foreach (Control c in chat.Controls)
                    {
                        c.Click -= new EventHandler((sender, e) => chatList.chatPanel_Click(sender, e, userLoggined.Id, user.Id));
                        c.Click += new EventHandler((sender, e) => chatList.chatPanel_Click(sender, e, userLoggined.Id, user.Id));
                    };
                    chatList.flowLayoutPanelListChat.Controls.Add(chat);
                });
            }
        }
        public static void listenForMessages(Form form)
        {
            while(true)
            {
                byte[] data = new byte[1024];
                int receivedDataLength = _client.Receive(data);
                string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                if(stringData.Contains("Message: "))
                {
                    string[] messages = stringData.Split(new string[] { "Message: ", " From: ", " To: ", " CreatedDate: ", " IdMsg: " }, StringSplitOptions.None);
                    receivedMsg(Int32.Parse(messages[5]), form);
                    UpdateListChat(null, form);
                }
                else if(stringData.Contains("Return status: "))
                {
                    string[] messages = stringData.Split(new string[] { "Return status: " }, StringSplitOptions.None);
                    int status = Int32.Parse(messages[1]);
                    returnStatus(status, form);
                }
                else
                {
                    string[] messages = stringData.Split('\n');
                    UpdateListChat(messages, form);
                }

            }
        }
    }
}
