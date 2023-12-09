using ClientWinform.BLL;
using ClientWinform.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ClientWinform.View.User
{
    public partial class ChatContentForm : Form
    {
        public DTO.User userFrom = new DTO.User();
        public DTO.User userTo = new DTO.User();

        Label lblStatus;
        private int loadedMessageCount = 0;
        
        public ChatContentForm()
        {
            InitializeComponent();
            
        }
        public ChatContentForm(int idFrom, int idTo) : this()
        {
            this.userFrom.Id = idFrom;
            this.userTo = BLL.UserBLL.getUserByID(idTo);
            labelUsername.Text = this.userTo.Username;
            BLL.MsgBLL.LoadMsgesToSeen(idFrom, idTo);

            Panel width = new Panel();
            width.Size = new Size(flowLayoutPanelChat.Width, 0);
            flowLayoutPanelChat.Controls.Add(width);
 
            AddMessagesToChatPanel(BLL.MsgBLL.GetTopMessages(idFrom, idTo, loadedMessageCount), userFrom.Id, flowLayoutPanelChat);
            loadedMessageCount += 50;
        }
        public FlowLayoutPanel shapeFormatPanelChat(string messages, Nullable<System.Int32> idFromOfMsg, Nullable<System.Int32> idFrom, Nullable<System.DateTime> time)
        {
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
            label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.AutoSize = true;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleLeft;

            panel.Controls.Add(label);

            Guna2Elipse border = new Guna2Elipse();
            border.BorderRadius = 12;
            border.TargetControl = panel;

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
        public void AddMessagesToChatPanel(List<DTO.Message> messages, Nullable<System.Int32> idFrom, FlowLayoutPanel flowLayoutPanel)
        {
            for (int i = messages.Count - 1; i >= 0; i--)
            {
                if (flowLayoutPanel.IsHandleCreated)
                {
                    flowLayoutPanel.Invoke((MethodInvoker)delegate
                    {
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel = shapeFormatPanelChat(messages[i].ContentMsg, messages[i].IdFrom, idFrom, messages[i].CreatedDate);
                        flowLayoutPanel.Controls.Add(panel);
                        flowLayoutPanel.ScrollControlIntoView(panel);
                    });
                }
                else
                {
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel = shapeFormatPanelChat(messages[i].ContentMsg, messages[i].IdFrom, idFrom, messages[i].CreatedDate);
                    flowLayoutPanel.Controls.Add(panel);
                    flowLayoutPanel.ScrollControlIntoView(panel);
                }

            }
        }
        private void btnLoadmore_Click(object sender, EventArgs e)
        {
            List<DTO.Message> messages = BLL.MsgBLL.GetTopMessages(userFrom.Id, userTo.Id, loadedMessageCount);
            flowLayoutPanelChat.Controls.Remove(btnLoadmore);
            for (int i = 0; i < messages.Count; i++)
            {
                if (flowLayoutPanelChat.IsHandleCreated)
                {
                    flowLayoutPanelChat.Invoke((MethodInvoker)delegate
                    {
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel = shapeFormatPanelChat(messages[i].ContentMsg, messages[i].IdFrom, userFrom.Id, messages[i].CreatedDate);
                        flowLayoutPanelChat.Controls.Add(panel);
                        flowLayoutPanelChat.Controls.SetChildIndex(panel, 0);
                        flowLayoutPanelChat.ScrollControlIntoView(panel);
                    });
                }
                else
                {
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel = shapeFormatPanelChat(messages[i].ContentMsg, messages[i].IdFrom, userFrom.Id, messages[i].CreatedDate);
                    flowLayoutPanelChat.Controls.Add(panel);
                    flowLayoutPanelChat.Controls.SetChildIndex(panel, 0);
                    flowLayoutPanelChat.ScrollControlIntoView(panel);
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

        private void messageTxt_IconRightClick(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(messageTxt.Text))
            {
                DTO.Message newMessage = new DTO.Message();
                newMessage.IdFrom = userFrom.Id;
                newMessage.ContentMsg = messageTxt.Text;
                newMessage.CreatedDate = DateTime.Now;

                List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
                await Task.Run(() => AddMessagesToChatPanel(msg, userFrom.Id, flowLayoutPanelChat));

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
