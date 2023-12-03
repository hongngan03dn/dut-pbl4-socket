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
        private Form activeForm;
        //public int idUser;
        public ClientWinform.DTO.User user = new DTO.User();
        public ChatListForm(ClientWinform.DTO.User user)
        {
            this.user = user;
            InitializeComponent();
            this.Activate();
            //Thread listenThread = new Thread(SocketHandles.MailClient.listenForMessages(this));
            //Thread listenThread = new Thread(() => SocketHandles.MailClient.listenForMessages(this));
            //listenThread.Start();
            //listChatOfUser();
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
                if (ctrl is Panel)
                {
                    Panel btn = (Panel)ctrl;
                    btn.BackColor = Color.FromArgb(233, 233, 236);
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
        public void chatPanel_Click(object sender, EventArgs e)
        {
            ChatContentForm f = new ChatContentForm(this.user);
            OpenChilForm(f, sender);
        }
    }
}
