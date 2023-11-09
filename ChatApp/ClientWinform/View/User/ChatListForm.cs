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
    public partial class ChatListForm : Form
    {
        private Panel chat;
        private Form activeForm;
        public ChatListForm()
        {
            InitializeComponent();
        }

        private void searchTxt_IconLeftClick(object sender, EventArgs e)
        {
            chat = new Panel();
            chat.Size = new Size(244, 56);
            chat.BackColor = Color.FromArgb(233, 233, 236);

            chat.Click += new EventHandler(chatPanel_Click);

            flowLayoutPanelListChat.Controls.Add(chat);
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
        private void chatPanel_Click(object sender, EventArgs e)
        {
            ChatContentForm f = new ChatContentForm();
            OpenChilForm(f, sender);
        }
    }
}
