using ClientWinform.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientWinform.DTO;

namespace ClientWinform.View.User
{
    public partial class ChatListForm : Form
    {
        private Panel chat;
        public ChatContentForm chatContentForm = null;
        private Form activeForm;
        public DTO.User user = new DTO.User();
        public ChatListForm(DTO.User user)
        {
            this.user = user;
            InitializeComponent();
            this.Activate();
            searchTxt.KeyDown += new KeyEventHandler(searchTxt_KeyDown);
        }
        private void ChatListForm_Load(object sender, EventArgs e)
        {
            notifyMsg.ShowBalloonTip(Constants.Notify.NOTIFY_TIMEOUT, "Notify", "You have " + BLL.MsgBLL.CountMessageUnRead(user.Id).ToString() + " new messages", ToolTipIcon.Info);
        }
        private void ActiveButton(object btnSender)
        {
            DisableButton();
            if (btnSender != null)
            {
                chat = (Panel)btnSender;
                chat.BackColor = Color.FromArgb(204, 218, 251);

            }
        }
        private void DisableButton()
        {
            foreach (Control ctrl in flowLayoutPanelListChat.Controls)
            {
                if (ctrl is ChatReviewForm)
                {
                    ChatReviewForm panel = (ChatReviewForm)ctrl;
                    panel.isSelected.BackColor = Color.White;
                    panel.isClicked = false;
                }
            }
        }
        public void OpenChilForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChatContent.Controls.Add(childForm);
            this.panelChatContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void chatPanel_Click(object sender, EventArgs e, int userId, int userToId)
        {
            chatContentForm = new ChatContentForm(userId, userToId);
            OpenChilForm(chatContentForm, sender);
        }
        private void searchTxt_IconLeftClick(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanelListChat.Controls)
            {
                if (ctrl is ChatReviewForm)
                {
                    ChatReviewForm userChat = (ChatReviewForm)ctrl;
                    if(userChat.userName.Contains(searchTxt.Text))
                    {
                        userChat.Visible = true;
                    }
                    else
                    {
                        userChat.Visible = false;
                    }
                }
            }
        }
        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchTxt_IconLeftClick(sender, e);
            }
        }


    }
}
