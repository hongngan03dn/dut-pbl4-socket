﻿using System;
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
using System.Media;
using static Guna.UI2.Native.WinApi;

namespace ClientWinform.SocketHandles
{
    public class MailClient
    {
        delegate void setForm(string[] msg, Form chatListForm, bool bindLogin);
        delegate void setSubForm(int idMsg, Form subForm);
        delegate void returnStatusForm(int status, Form form);
        delegate void CustomClickHandler(object sender, EventArgs e, int userId, int userToId);
        delegate void updateExplore(Form form);

        static String _ipServer = "192.168.1.18";
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
                UpdateListChat(null, formAll, true);
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
        public static void sendNotiSignOut(Nullable<Int32> idFrom)
        {
            byte[] datasend = new byte[1024];
            if (_client.Connected)
            {
                datasend = Encoding.ASCII.GetBytes(idFrom.ToString() + " has signned out");
                _client.Send(datasend, datasend.Length, SocketFlags.None);
                _client.Close(1000);
            }
        }
        public static void sendNotiConnection(Nullable<Int32> idFrom, Nullable<Int32> idTo, int status)
        {
            byte[] datasend = new byte[1024];
            if (_client.Connected)
            {
                datasend = Encoding.ASCII.GetBytes("Connection: " + idFrom.ToString() + " | " + idTo.ToString() + " status: " + status.ToString());
                _client.Send(datasend, datasend.Length, SocketFlags.None);
                
            }
        }
        //public static void receivedMsg(int idMsg, Form form)
        //{
        //    if (form.InvokeRequired)
        //    {
        //        setSubForm d = new setSubForm(receivedMsg);
        //        form.Invoke(d, new object[] { idMsg, form});
        //    }
        //    else
        //    {
        //        if (form is NavigationForm navigationForm)
        //        {
        //            DTO.Message newMessage = BLL.MsgBLL.getMessageById(idMsg);
        //            if(navigationForm.chatForm.chatContentForm != null)
        //            {
        //                List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
        //                if (newMessage.IdFrom == navigationForm.chatForm.chatContentForm.userTo.Id)
        //                {
        //                    BLL.MsgBLL.UpdateMsgesToSeen(idMsg);
        //                    navigationForm.chatForm.chatContentForm.AddStatusPanelToChat(Constants.MessageStatuses.SEEN, false);
        //                    navigationForm.chatForm.chatContentForm.AddMessagesToChatPanel(msg, newMessage.IdTo, navigationForm.chatForm.chatContentForm.flowLayoutPanelChat);
        //                    sendStatusSeen(newMessage.IdFrom);
        //                }
        //                else if(newMessage.IdFrom != userLoggined.Id)
        //                {
        //                    string contentMsg = null;
        //                    if (newMessage.IdFile != null)
        //                    {
        //                        if (Constants.AllowedFileType.IMAGES.Contains(Path.GetExtension(newMessage.ContentMsg)))
        //                            contentMsg = "Sent a photo";
        //                        else if (Constants.AllowedFileType.AUDIOS.Contains(Path.GetExtension(newMessage.ContentMsg)))
        //                            contentMsg = "Sent a voice message";
        //                        else
        //                            contentMsg = "Sent an attachment";
        //                    }
        //                    else
        //                        contentMsg = newMessage.ContentMsg;
        //                    navigationForm.chatForm.notifyMsg.ShowBalloonTip(Constants.Notify.NOTIFY_TIMEOUT, BLL.UserBLL.getUserByID((int)newMessage.IdFrom).Username, contentMsg, ToolTipIcon.None);
        //                    navigationForm.chatForm.notifyMsg.MouseClick += new MouseEventHandler((sender, e) => navigationForm.chatForm.notifyMsg_MouseClick(sender, e, (int)newMessage.IdTo, (int)newMessage.IdFrom));
        //                }
        //                else if(newMessage.IdFile != null && newMessage.IdFile != 0)
        //                {
        //                    navigationForm.chatForm.chatContentForm.AddMessagesToChatPanel(msg, newMessage.IdFrom, navigationForm.chatForm.chatContentForm.flowLayoutPanelChat);
        //                } 
        //            }
        //            else
        //            {
        //                if (newMessage.IdTo == navigationForm.chatForm.user.Id)
        //                {
        //                    string contentMsg = null;
        //                    if (newMessage.IdFile != null)
        //                    {
        //                        if (Constants.AllowedFileType.IMAGES.Contains(Path.GetExtension(newMessage.ContentMsg)))
        //                            contentMsg = "Sent a photo";
        //                        else if (Constants.AllowedFileType.AUDIOS.Contains(Path.GetExtension(newMessage.ContentMsg)))
        //                            contentMsg = "Sent a voice message";
        //                        else
        //                            contentMsg = "Sent an attachment";
        //                    }
        //                    else 
        //                        contentMsg = newMessage.ContentMsg;
        //                    navigationForm.chatForm.notifyMsg.ShowBalloonTip(Constants.Notify.NOTIFY_TIMEOUT, BLL.UserBLL.getUserByID((int)newMessage.IdFrom).Username, contentMsg, ToolTipIcon.None);
        //                    navigationForm.chatForm.notifyMsg.MouseClick += new MouseEventHandler((sender, e) => navigationForm.chatForm.notifyMsg_MouseClick(sender, e, (int)newMessage.IdTo, (int)newMessage.IdFrom));
        //                }
        //            }
        //        }
        //    }
        //}
        public static void receivedMsg(int idMsg, Form form)
        {
            if (form.InvokeRequired)
            {
                setSubForm delegateCall = new setSubForm(receivedMsg);
                form.Invoke(delegateCall, new object[] { idMsg, form });
            }
            else
            {
                if (!(form is NavigationForm navigationForm)) return;
                DTO.Message newMessage = BLL.MsgBLL.getMessageById(idMsg);
                string contentMsg = GetMessageContent(newMessage);
                if (navigationForm.chatForm.chatContentForm != null)
                {
                    HandleChatContentForm(newMessage, navigationForm);
                }
                else if (ShouldShowNotification(newMessage, navigationForm.chatForm.user.Id))
                {
                    ShowNotification(newMessage, navigationForm.chatForm, contentMsg);
                }
            }
        }
        private static void HandleChatContentForm(DTO.Message newMessage, NavigationForm navigationForm)
        {
            List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
            if (newMessage.IdFrom == navigationForm.chatForm.chatContentForm.userTo.Id)
            {
                BLL.MsgBLL.UpdateMsgesToSeen(newMessage.Id);
                navigationForm.chatForm.chatContentForm.AddStatusPanelToChat(Constants.MessageStatuses.SEEN, false);
                navigationForm.chatForm.chatContentForm.AddMessagesToChatPanel(msg, newMessage.IdTo, navigationForm.chatForm.chatContentForm.flowLayoutPanelChat);
                sendStatusSeen(newMessage.IdFrom);
            }
            else if (newMessage.IdFile != null && newMessage.IdFile != 0)
            {
                navigationForm.chatForm.chatContentForm.AddMessagesToChatPanel(msg, newMessage.IdFrom, navigationForm.chatForm.chatContentForm.flowLayoutPanelChat);
            }
        }
        private static string GetMessageContent(DTO.Message newMessage)
        {
            string contentMsg = newMessage.ContentMsg;
            if (newMessage.IdFile != null)
            {
                string fileExtension = Path.GetExtension(newMessage.ContentMsg).ToLower();
                if (Constants.AllowedFileType.IMAGES.Contains(fileExtension))
                    contentMsg = "Sent a photo";
                else if (Constants.AllowedFileType.AUDIOS.Contains(fileExtension))
                    contentMsg = "Sent a voice message";
                else
                    contentMsg = "Sent an attachment";
            }
            return contentMsg;
        }

        private static bool ShouldShowNotification(DTO.Message newMessage, int currentUserId)
        {
            return newMessage.IdTo == currentUserId && newMessage.IdFrom != userLoggined.Id;
        }
        private static void ShowNotification(DTO.Message newMessage, ChatListForm chatForm, string contentMsg)
        {
            chatForm.notifyMsg.ShowBalloonTip(Constants.Notify.NOTIFY_TIMEOUT, BLL.UserBLL.getUserByID((int)newMessage.IdFrom).Username, contentMsg, ToolTipIcon.None);
            //chatForm.notifyMsg.MouseClick += (sender, e) => chatForm.notifyMsg_MouseClick(sender, e, (int)newMessage.IdTo, (int)newMessage.IdFrom);
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
        public static void updateListExplore(Form form)
        {
            if (form.InvokeRequired)
            {
                updateExplore d = new updateExplore(updateListExplore);
                form.Invoke(d, new object[] { form });
            }
            else
            {
                if (form is NavigationForm navigationForm && navigationForm.panelExplore.Visible == true)
                {
                    navigationForm.addExplorePanel("");
                }
            }
        }

        public static void UpdateListChat(string[] message, Form activeForm, bool bindLogin)
        {
            if (message != null)
            {
                string[] partsLogin = message[0].Split(' ');
                bool isParsableToId = int.TryParse(partsLogin[0], out int myId);
            
                
                if (isParsableToId)
                {
                    idLoggined = myId;
                }
                string keyword = "Current onlines: ";

                string onlyIdNumbers = "";
                if (message.Count() >= 2)
                {
                    foreach (string findCurrentOnline in message)
                    {
                        if (findCurrentOnline.Contains("Current onlines: "))
                        {
                            string[] parts = findCurrentOnline.Split(new[] {keyword}, StringSplitOptions.None);
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
                    }
                }
            }
            //delegate
            if (activeForm.InvokeRequired)
            {
                setForm d = new setForm(UpdateListChat);
                activeForm.Invoke(d, new object[] { message, activeForm, bindLogin });
            }
            else
            {
                if (activeForm is NavigationForm navigationForm && idLoggined != 0)
                {
                    optionForm(navigationForm.chatForm, bindLogin, "");
                }
                else if (activeForm is ChatListForm chatList && idLoggined != 0)
                {
                    optionForm(chatList, bindLogin, "");
                }
            }
        }
        public static void optionForm(ChatListForm chatList, bool bindLogin, string txtSearch)
        {
            if(txtSearch != "")
            {
                chatList.flowLayoutPanelListChat.Controls.Clear();
            }
            List<DTO.UserModel> users = BLL.MsgBLL.getUserListChat(userLoggined.Id, txtSearch);
            foreach (Control ctrl in chatList.flowLayoutPanelListChat.Controls)
            {
                if (ctrl is ChatReviewForm)
                {
                    ChatReviewForm userChat = (ChatReviewForm)ctrl;
                        userChat.Visible = false;
                }
            }
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
                        if (bindLogin && BLL.UserBLL.checkIsHaveConnection(user.Id, userLoggined.Id).Status == Constants.ConnectionsDescr.CONNECTED)
                            chat.isPictureBoxOnlineVisible = true;
                        else 
                            chat.isPictureBoxOnlineVisible = false;
                    }
                    if (idOnlines != null)
                    {
                        for (int i = 0; i < idOnlines.Length; i++)
                        {
                        if (user.Id == idOnlines[i] && bindLogin && BLL.UserBLL.checkIsHaveConnection(user.Id, userLoggined.Id).Status == Constants.ConnectionsDescr.CONNECTED)
                            {

                                chat.isPictureBoxOnlineVisible = true;
                            }
                        }
                    }
                    chat.userName = user.Username;
                    DTO.Message msg = BLL.MsgBLL.getMessage(userLoggined.Id, user.Id);
                    if (msg != null)
                    {
                        string contentMsg;
                        if (msg.IdFile != null)
                        {
                            if (Constants.AllowedFileType.IMAGES.Contains(Path.GetExtension(msg.ContentMsg)))
                                contentMsg = "Sent a photo";
                            else if (Constants.AllowedFileType.AUDIOS.Contains(Path.GetExtension(msg.ContentMsg)))
                                contentMsg = "Sent a voice message";
                            else
                                contentMsg = "Sent an attachment";
                        }
                        else
                            contentMsg = msg.ContentMsg;
                        if (msg.IdFrom == userLoggined.Id)
                        {
                            if (("You: " + contentMsg).Length > Constants.MessageTies.MAXLENGTHINREVIEW)
                                chat.message = ("You: " + contentMsg).Substring(0, Constants.MessageTies.MAXLENGTHINREVIEW) + "...";
                            else
                                chat.message = "You: " + contentMsg;
                        }
                        else
                        {
                            if (contentMsg.Length > Constants.MessageTies.MAXLENGTHINREVIEW)
                                chat.message = contentMsg.Substring(0, Constants.MessageTies.MAXLENGTHINREVIEW) + "...";
                            else
                                chat.message = contentMsg;
                        }
                        chat.time = BLL.MsgBLL.formatTime(msg.CreatedDate);
                    }
                    else
                    {
                        chat.message = "";
                    }
                    foreach (Control c in chat.Controls)
                    {
                        if(!chat.isAddEventClick)
                        {
                            EventHandler panelClickHandler = (sender, e) => chatList.chatPanel_Click(sender, e, userLoggined.Id, user.Id);
                            c.Click -= panelClickHandler;
                            c.Click += panelClickHandler;
                            chat.isAddEventClick = true;
                        }
                        //c.Click -= new EventHandler((sender, e) => chatList.chatPanel_Click(sender, e, userLoggined.Id, user.Id));
                        //c.Click += new EventHandler((sender, e) => chatList.chatPanel_Click(sender, e, userLoggined.Id, user.Id));
                    };
                    chatList.flowLayoutPanelListChat.Controls.Add(chat);
                    chat.Visible = true;
                });
            }
        }
        public static async void listenForMessages(Form form)
        {
            while(_client.Connected)
            {
                byte[] data = new byte[1024 * 128];
                int receivedDataLength = _client.Receive(data);
                string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);

                if(string.IsNullOrEmpty(stringData))
                {
                    break;
                }

                SocketPacketModel packet = new SocketPacketModel();
                bool isJsonString;
                try
                {
                    packet = JsonConvert.DeserializeObject<SocketPacketModel>(stringData);
                    isJsonString = true;
                }
                catch (Exception)
                {
                    isJsonString = false;
                }

                if (isJsonString)
                {
                    if (packet.PacketType == Constants.PacketType.GET_FILE)
                    {
                        try
                        {
                            string path = packet.ContentMsg;
                            int receiveByteLen = packet.SubPacketFile.Length;
                            int fnameLen = BitConverter.ToInt32(packet.SubPacketFile, 0);
                            string fname = Encoding.ASCII.GetString(packet.SubPacketFile, 4, fnameLen);

                            // handle load media file
                            if (string.IsNullOrEmpty(path))
                            {
                                if (Constants.AllowedFileType.IMAGES.Contains(Path.GetExtension(fname)))
                                {
                                    Array.Clear(ChatContentForm.imgLoaded, 0, ChatContentForm.imgLoaded.Length);
                                    packet.SubPacketFile.Skip(4 + fnameLen).Take(receiveByteLen - 4 - fnameLen).ToArray().CopyTo(ChatContentForm.imgLoaded, 0);
                                    ChatContentForm.isLoadSuccess = true;
                                    ChatContentForm.isLoaded = true;
                                }
                                else if (Constants.AllowedFileType.AUDIOS.Contains(Path.GetExtension(fname)))
                                {
                                    byte[] audioBytes = new byte[1024 * 1024 * 100];
                                    packet.SubPacketFile.Skip(4 + fnameLen).Take(receiveByteLen - 4 - fnameLen).ToArray().CopyTo(audioBytes, 0);
                                    using (var stream = new MemoryStream(audioBytes))
                                    {
                                        SoundPlayer player = new SoundPlayer(stream);
                                        player.Play();
                                    }
                                }
                                continue;
                            }

                            BinaryWriter writer = new BinaryWriter(System.IO.File.Open(path + "/" + fname, FileMode.Append));
                            writer.Write(packet.SubPacketFile, 4 + fnameLen, receiveByteLen - 4 - fnameLen);
                            writer.Close();
                            MessageBox.Show("Downloaded Successfully!");
                        }
                        catch (Exception e)
                        {
                            if (ChatContentForm.idMsgLoaded != 0 && ChatContentForm.isLoaded == false)
                            {
                                Array.Clear(ChatContentForm.imgLoaded, 0, ChatContentForm.imgLoaded.Length);
                                ChatContentForm.isLoadSuccess = false;
                                ChatContentForm.isLoaded = true;
                            }
                            MessageBox.Show(e.Message);
                        }
                        
                    }
                    else if (packet.PacketType == Constants.PacketType.ERROR)
                    {
                        if (ChatContentForm.idMsgLoaded != 0 && ChatContentForm.isLoaded == false)
                        {
                            Array.Clear(ChatContentForm.imgLoaded, 0, ChatContentForm.imgLoaded.Length);
                            ChatContentForm.isLoadSuccess = false;
                            ChatContentForm.isLoaded = true;
                        }
                        MessageBox.Show(packet.ContentMsg);
                    }
                }
                else if(stringData.Contains("Message: "))
                {
                    string[] messages = stringData.Split(new string[] { "Message: ", " From: ", " To: ", " CreatedDate: ", " IdMsg: " }, StringSplitOptions.None);
                    receivedMsg(Int32.Parse(messages[5]), form);
                    UpdateListChat(null, form, true);
                }
                else if(stringData.Contains("Return status: "))
                {
                    string[] messages = stringData.Split(new string[] { "Return status: " }, StringSplitOptions.None);
                    int status = Int32.Parse(messages[1]);
                    returnStatus(status, form);
                }
                else if (stringData.Contains("Update connnection"))
                {
                    updateListExplore(form);
                }
                else if (stringData.Contains(" has signned out"))
                {
                    string[] messages = stringData.Split(new string[] { "Return status: " }, StringSplitOptions.None);
                    UpdateListChat(messages, form, false);
                }
                else
                {
                    string[] messages = stringData.Split('\n');
                    UpdateListChat(messages, form, true);
                    await Task.Delay(1000);
                }
            }
        }

        public static void sendFile(int myId, int toId, string fname, Nullable<System.DateTime> createdDate)
        {
            // handle fname
            string path = "";
            fname = fname.Replace("\\", "/");
            while (fname.IndexOf("/") > -1)
            {
                path += fname.Substring(0, fname.IndexOf("/") + 1);
                fname = fname.Substring(fname.IndexOf("/") + 1);
            }

            // handle SaveNameFile
            string savedNameFile = myId + "_" + toId + "_" + DateTime.Now.Ticks.ToString() + "_" + fname;

            byte[] fileData = System.IO.File.ReadAllBytes(path + fname);
            byte[] fnameByte = Encoding.ASCII.GetBytes(savedNameFile);
            byte[] fnameLen = BitConverter.GetBytes(fnameByte.Length);
            byte[] clientData = new byte[4 + fnameByte.Length + fileData.Length];
            fnameLen.CopyTo(clientData, 0);
            fnameByte.CopyTo(clientData, 4);
            fileData.CopyTo(clientData, 4 + fnameByte.Length);

            //giống sendMsg
            int idFile = BLL.FileBLL.InsertFile(myId, fname, savedNameFile);
            int idMsg = BLL.MsgBLL.InsertMessage(myId, toId, fname, idFile);
            SocketPacketModel packet = new SocketPacketModel(idMsg, myId, toId, fname, createdDate, Constants.PacketType.FILE);
            packet.SubPacketFile = clientData;
            string sendMsg = JsonConvert.SerializeObject(packet);
            try
            {
                byte[] datasend = Encoding.ASCII.GetBytes(sendMsg);
                _client.Send(datasend, datasend.Length, SocketFlags.None);
                //UpdateListChat(null, formAll, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void sendRequestFile(DTO.Message message, string selectedFolderClient)
        {
            SocketPacketModel packet = new SocketPacketModel(message.Id, 0, 0, selectedFolderClient, DateTime.Now, Constants.PacketType.GET_FILE);
            string sendMsg = JsonConvert.SerializeObject(packet);
            try
            {
                byte[] datasend = Encoding.ASCII.GetBytes(sendMsg);
                _client.Send(datasend, datasend.Length, SocketFlags.None);
                //UpdateListChat(null, formAll, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task sendRequestFileAsync(DTO.Message message, string selectedFolderClient)
        {
            SocketPacketModel packet = new SocketPacketModel(message.Id, 0, 0, selectedFolderClient, DateTime.Now, Constants.PacketType.GET_FILE);
            string sendMsg = JsonConvert.SerializeObject(packet);
            try
            {
                byte[] dataSend = Encoding.ASCII.GetBytes(sendMsg);
                await _client.SendAsync(new ArraySegment<byte>(dataSend), SocketFlags.None); // This line should be asynchronous
            }
            catch (Exception ex)
            {
                throw ex; // Rethrowing the exception like this can lose the stack trace.
            }

        }
    }
}
