using ClientWinform.BLL;
using ClientWinform.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinform.View.User
{
    public partial class ChatContentForm : Form
    {
        public DTO.User userFrom = new DTO.User();
        public DTO.User userTo = new DTO.User();
        public ChatContentForm()
        {
            InitializeComponent();
            flowLayoutPanelChat.ControlAdded += FlowLayoutPanel_ControlAdded;
        }
        public ChatContentForm(int idFrom, int idTo) : this()
        {
            this.userFrom.Id = idFrom;
            this.userTo = BLL.UserBLL.getUserByID(idTo);
            labelUsername.Text = this.userTo.Username;
            Panel width = new Panel();
            width.Size = new Size(flowLayoutPanelChat.Width, 0);
            flowLayoutPanelChat.Controls.Add(width);
 
            AddMessagesToChatPanel(BLL.UserBLL.GetTopMessages(idFrom, idTo), userFrom.Id, flowLayoutPanelChat);
            
        }
        public void AddMessagesToChatPanel(List<DTO.Message> messages, int idFrom, FlowLayoutPanel flowLayoutPanel)
        {
            for(int i = messages.Count - 1; i >= 0; i--) 
            {
                string message = messages[i].ContentMsg;
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < message.Length; j += Constants.MessageTies.MAXLENGTHINCONTENT)
                {
                    if (j + Constants.MessageTies.MAXLENGTHINCONTENT < message.Length)
                        sb.AppendLine(message.Substring(j, Constants.MessageTies.MAXLENGTHINCONTENT));
                    else
                        sb.AppendLine(message.Substring(j));
                }
                string result = sb.ToString();
                Panel panel = new Panel();
                panel.AutoSize = true;
                panel.Padding = new Padding(10, 6, 10, 6);

                Label label = new Label();
                label.Text = result;
                label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.AutoSize = true;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleLeft;
                if (messages[i].IdFrom == idFrom)
                {
                    panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    panel.BackColor = Color.FromArgb(114, 214, 200);
                    label.ForeColor = Color.White;
                }
                else
                {
                    panel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    panel.BackColor = Color.FromArgb(233, 233, 236);
                    label.ForeColor = Color.FromArgb(17, 16, 14);
                }

                

                panel.Controls.Add(label);

                Guna2Elipse border = new Guna2Elipse();
                border.BorderRadius = 10;
                border.TargetControl = panel;

                flowLayoutPanel.Controls.Add(panel);
            }
        }
        private void FlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            flowLayoutPanelChat.VerticalScroll.Value = flowLayoutPanelChat.VerticalScroll.Maximum;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void messageTxt_IconRightClick(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(messageTxt.Text))
            {
                DTO.Message newMessage = new DTO.Message();
                newMessage.IdFrom = userFrom.Id;
                newMessage.ContentMsg = messageTxt.Text;

                List<DTO.Message> msg = new List<DTO.Message>() { newMessage };
                AddMessagesToChatPanel(msg, userFrom.Id, flowLayoutPanelChat);
                try
                {
                    //BLL.UserBLL.InsertMessage(userFrom.Id, userTo.Id, messageTxt.Text);
                    SocketHandles.MailClient.sendMsg(userFrom.Id, userTo.Id, messageTxt.Text);
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
