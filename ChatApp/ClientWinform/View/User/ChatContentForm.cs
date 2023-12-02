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
        private ClientWinform.DTO.User user = new DTO.User();
        public ChatContentForm()
        {
            InitializeComponent();
        }
        public ChatContentForm(ClientWinform.DTO.User user) : this()
        {
            this.user = user;
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
                try
                {
                    SocketHandles.MailClient.sendMsg(user.Id, 2, messageTxt.Text);
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
