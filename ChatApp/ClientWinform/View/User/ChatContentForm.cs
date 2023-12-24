using ClientWinform.BLL;
using ClientWinform.DTO;
using ClientWinform.SocketHandles;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ClientWinform.View.User
{
    public partial class ChatContentForm : Form
    {
        public DTO.User userFrom = new DTO.User();
        public DTO.User userTo = new DTO.User();

        Label lblStatus;
        private int loadedMessageCount = 0;
        Nullable<System.DateTime> previousTime = null;

        public ChatContentForm()
        {
            InitializeComponent();

        }
        public ChatContentForm(int idFrom, int idTo): this()
        {
            
            this.userFrom.Id = idFrom;
            this.userTo = BLL.UserBLL.getUserByID(idTo);
            labelUsername.Text = this.userTo.Username;
            Panel width = new Panel();
            width.Size = new Size(flowLayoutPanelChat.Width, 0);
            flowLayoutPanelChat.Controls.Add(width);
            LoadData(idFrom, idTo);

            if(BLL.UserBLL.checkIsHaveConnection(userFrom.Id, userTo.Id).Status == Constants.ConnectionsDescr.NOTCONNECT)
            {
                MessageBox.Show("Your connection had been deleted. You cannot chat with \"" + userTo.Username + "\"");
            }
            else
            {
                BLL.MsgBLL.LoadMsgesToSeen(idFrom, idTo);
                try
                {
                    SocketHandles.MailClient.sendStatusSeen(userTo.Id);
                    messageTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }
        public async void LoadData(int idFrom, int idTo)
        {
            var messages = await Task.Run(() => BLL.MsgBLL.GetTopMessages(idFrom, idTo, loadedMessageCount));
            await AddMessagesToChatPanel(messages, userFrom.Id, flowLayoutPanelChat);
            loadedMessageCount += 50;
        }
        public async Task AddMessagesToChatPanel(List<DTO.Message> messages, Nullable<System.Int32> idFrom, FlowLayoutPanel flowLayoutPanel)
        {
            for (int i = messages.Count - 1; i >= 0; i--)
            {
                if (flowLayoutPanel.IsHandleCreated)
                {
                    var message = messages[i];

                    await Task.Run(() => flowLayoutPanel.Invoke((MethodInvoker)async delegate
                    {
                        if (previousTime != null && (messages[i].CreatedDate.Value - previousTime.Value).TotalMinutes > 20)
                        {
                            Label timeSectionLabel = new Label();
                            timeSectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            timeSectionLabel.AutoSize = true;
                            timeSectionLabel.TextAlign = ContentAlignment.MiddleCenter;
                            timeSectionLabel.ForeColor = Color.FromArgb(151, 142, 142);
                            timeSectionLabel.Text = BLL.MsgBLL.formatTimeInChatContent(messages[i].CreatedDate);
                            timeSectionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                            flowLayoutPanel.Controls.Add(timeSectionLabel);
                        }
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel = await shapeFormatPanelChat(message, message.IdFrom, idFrom, message.CreatedDate);
                        flowLayoutPanel.Controls.Add(panel);
                        flowLayoutPanel.ScrollControlIntoView(panel);
                        previousTime = messages[i].CreatedDate;
                        if (i == 0)
                        {
                            if (messages[i].IdFrom == idFrom)
                            {
                                if (messages[i].Status == Constants.MessageStatuses.SEEN)
                                {
                                    AddStatusPanelToChat(Constants.MessageStatuses.SEEN, true);
                                }
                                else
                                {
                                    AddStatusPanelToChat(Constants.MessageStatuses.SENT, true);
                                }
                            }
                        }
                    }));
                }
                else
                {
                    var message = messages[i];
                    if (previousTime != null && (messages[i].CreatedDate.Value - previousTime.Value).TotalMinutes > 20)
                    {
                        Label timeSectionLabel = new Label();
                        timeSectionLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        timeSectionLabel.AutoSize = true;
                        timeSectionLabel.TextAlign = ContentAlignment.MiddleCenter;
                        timeSectionLabel.ForeColor = Color.FromArgb(151, 142, 142);
                        timeSectionLabel.Text = BLL.MsgBLL.formatTimeInChatContent(messages[i].CreatedDate);
                        timeSectionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        flowLayoutPanel.Controls.Add(timeSectionLabel);
                    }
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel = await shapeFormatPanelChat(messages[i], messages[i].IdFrom, idFrom, messages[i].CreatedDate);
                    flowLayoutPanel.Controls.Add(panel);
                    flowLayoutPanel.ScrollControlIntoView(panel);
                    previousTime = messages[i].CreatedDate;
                    if (i == 0)
                    {
                        if (messages[i].IdFrom == idFrom)
                        {
                            if (messages[i].Status == Constants.MessageStatuses.SEEN)
                            {
                                AddStatusPanelToChat(Constants.MessageStatuses.SEEN, true);
                            }
                            else
                            {
                                AddStatusPanelToChat(Constants.MessageStatuses.SENT, true);
                            }
                        }
                    }
                }
            }
        }
        public async Task<FlowLayoutPanel> shapeFormatPanelChat(DTO.Message messageObject, Nullable<System.Int32> idFromOfMsg, Nullable<System.Int32> idFrom, Nullable<System.DateTime> time)
        {
            string messages = messageObject.ContentMsg;
            FontStyle styleMsg = (messageObject.IdFile != null && messageObject.IdFile != 0) ? FontStyle.Underline : FontStyle.Regular;
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < messages.Length; j += Constants.MessageTies.MAXLENGTHINCONTENT)
            {
                if (j + Constants.MessageTies.MAXLENGTHINCONTENT < messages.Length)
                    sb.AppendLine(messages.Substring(j, Constants.MessageTies.MAXLENGTHINCONTENT));
                else
                    sb.AppendLine(messages.Substring(j));
            }
            string result = sb.ToString();
            Panel panel = new FlowLayoutPanel();
            panel.AutoSize = true;
            panel.Padding = new Padding(10, 6, 10, 6);

            Label lblTime = new Label();
            lblTime.Text = BLL.MsgBLL.formatTimeInChatContent(time);
            lblTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTime.AutoSize = true;
            lblTime.Dock = DockStyle.Bottom;
            lblTime.TextAlign = ContentAlignment.BottomRight;
            lblTime.ForeColor = Color.FromArgb(151, 142, 142);

            Label label = new Label();
            label.Text = result;
            label.Font = new System.Drawing.Font("Segoe UI", 10F, styleMsg, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleLeft;

            panel.Controls.Add(label);

            Guna2Elipse border = new Guna2Elipse();
            border.BorderRadius = 12;
            border.TargetControl = panel;

            panel.Click += (sender, e) => DownloadFile(sender, e, messageObject);
            label.Click += (sender, e) => DownloadFile(sender, e, messageObject);

            FlowLayoutPanel panelContainTime = new FlowLayoutPanel();
            panelContainTime.AutoSize = true;
            panelContainTime.FlowDirection = FlowDirection.BottomUp;
            panelContainTime.WrapContents = false;
            
            
            if (idFromOfMsg == idFrom)
            {
                
                panelContainTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                panel.Anchor = AnchorStyles.Right;
                panel.BackColor = Color.FromArgb(114, 214, 200);
                label.ForeColor = Color.White;
                
            }
            else
            {
                panelContainTime.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panel.Anchor = AnchorStyles.Left;
                panel.BackColor = Color.FromArgb(233, 233, 236);
                label.ForeColor = Color.FromArgb(17, 16, 14);
                lblTime.Anchor = AnchorStyles.Left;
            }

            panelContainTime.Controls.Add(panel);
            panelContainTime.Controls.Add(lblTime);

            return panelContainTime;
        }
        
        public void DownloadFile(object sender, EventArgs e, DTO.Message messageObject)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select a folder to download file...";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                selectedPath = selectedPath.Replace("\\", "/");
                MailClient.sendRequestFile(messageObject, selectedPath);
            }
        }
        public void AddStatusPanelToChat(int status, bool condition)
        {
            if(condition)
            {
                flowLayoutPanelChat.Controls.Remove(lblStatus);
                lblStatus = new Label();
                if(status == Constants.MessageStatuses.SEEN)
                {
                    lblStatus.Text = "Seen";
                }
                else
                {
                    lblStatus.Text = "Sent";
                }
                lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblStatus.AutoSize = true;
                lblStatus.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
                lblStatus.TextAlign = ContentAlignment.BottomRight;
                lblStatus.ForeColor = Color.FromArgb(151, 142, 142);

                flowLayoutPanelChat.Controls.Add(lblStatus);
                flowLayoutPanelChat.ScrollControlIntoView(lblStatus);
            }
            else
            {
                flowLayoutPanelChat.Controls.Remove(lblStatus);
            }

        }

        private async void btnLoadmore_Click(object sender, EventArgs e)
        {
            List<DTO.Message> messages = BLL.MsgBLL.GetTopMessages(userFrom.Id, userTo.Id, loadedMessageCount);
            flowLayoutPanelChat.Controls.Remove(btnLoadmore);
            Nullable<System.DateTime> previousTimeInClick = null;
            Label timeSectionLabel = new Label();
            timeSectionLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeSectionLabel.AutoSize = true;
            timeSectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            timeSectionLabel.ForeColor = Color.FromArgb(151, 142, 142);
            timeSectionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            for (int i = 0; i < messages.Count; i++)
            {
                if (flowLayoutPanelChat.IsHandleCreated)
                {
                    if (previousTimeInClick != null && (previousTimeInClick.Value - messages[i].CreatedDate.Value).TotalMinutes > 20)
                    {
                        timeSectionLabel.Text = BLL.MsgBLL.formatTimeInChatContent(previousTimeInClick.Value);
                        flowLayoutPanelChat.Controls.Add(timeSectionLabel);
                        flowLayoutPanelChat.Controls.SetChildIndex(timeSectionLabel, 0);
                    }
                    flowLayoutPanelChat.Invoke((MethodInvoker)async delegate
                    {
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel = await shapeFormatPanelChat(messages[i], messages[i].IdFrom, userFrom.Id, messages[i].CreatedDate);
                        flowLayoutPanelChat.Controls.Add(panel);
                        flowLayoutPanelChat.Controls.SetChildIndex(panel, 0);
                        flowLayoutPanelChat.ScrollControlIntoView(panel);
                        previousTimeInClick = messages[i].CreatedDate;
                    });
                }
                else
                {
                    if (previousTimeInClick != null && (previousTimeInClick.Value - messages[i].CreatedDate.Value).TotalMinutes > 20)
                    {
                        timeSectionLabel.Text = BLL.MsgBLL.formatTimeInChatContent(previousTimeInClick.Value);
                        flowLayoutPanelChat.Controls.Add(timeSectionLabel);
                        flowLayoutPanelChat.Controls.SetChildIndex(timeSectionLabel, 0);
                    }
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel = await shapeFormatPanelChat(messages[i], messages[i].IdFrom, userFrom.Id, messages[i].CreatedDate);
                    flowLayoutPanelChat.Controls.Add(panel);
                    flowLayoutPanelChat.Controls.SetChildIndex(panel, 0);
                    flowLayoutPanelChat.ScrollControlIntoView(panel);
                    previousTimeInClick = messages[i].CreatedDate;
                }
            }
            flowLayoutPanelChat.Controls.Add(btnLoadmore);
            flowLayoutPanelChat.Controls.SetChildIndex(btnLoadmore, 0);
            loadedMessageCount += 50;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void messageTxt_IconRightClick(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                messageTxt.Text = fd.FileName; // Path.GetFileName(fd.FileName);

                // copy btnSubmit_Click
                if (BLL.UserBLL.checkIsHaveConnection(userFrom.Id, userTo.Id).Status == Constants.ConnectionsDescr.NOTCONNECT)
                {
                    MessageBox.Show("Your connection had been deleted. You cannot chat with \"" + userTo.Username + "\"");
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(messageTxt.Text))
                    {
                        DTO.Message newMessage = new DTO.Message();
                        newMessage.IdFrom = userFrom.Id;
                        newMessage.ContentMsg = Path.GetFileName(messageTxt.Text);
                        newMessage.CreatedDate = DateTime.Now;
                        loadedMessageCount++;
                        List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
                        await AddMessagesToChatPanel(msg, userFrom.Id, flowLayoutPanelChat);

                        messageTxt.Focus();
                        try
                        {
                            SocketHandles.MailClient.sendFile(userFrom.Id, userTo.Id, messageTxt.Text, newMessage.CreatedDate);
                            messageTxt.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BLL.UserBLL.checkIsHaveConnection(userFrom.Id, userTo.Id).Status == Constants.ConnectionsDescr.NOTCONNECT)
            {
                MessageBox.Show("Your connection had been deleted. You cannot chat with \"" + userTo.Username + "\"");
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(messageTxt.Text))
                {
                    DTO.Message newMessage = new DTO.Message();
                    newMessage.IdFrom = userFrom.Id;
                    newMessage.ContentMsg = Path.GetFileName(messageTxt.Text);
                    newMessage.CreatedDate = DateTime.Now;
                    loadedMessageCount ++;
                    List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
                    await AddMessagesToChatPanel(msg, userFrom.Id, flowLayoutPanelChat);

                    messageTxt.Focus();
                    try
                    {
                        SocketHandles.MailClient.sendMsg(userFrom.Id, userTo.Id, messageTxt.Text, newMessage.CreatedDate);
                        messageTxt.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }

        }
    }
}
