using ClientWinform.BLL;
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
        }
        public ChatContentForm(int idFrom, int idTo) : this()
        {
            this.userFrom.Id = idFrom;
            this.userTo = BLL.UserBLL.getUserByID(idTo);
            labelUsername.Text = this.userTo.Username;
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
                listBox1.Items.Add("You: " + messageTxt.Text);
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
