using ClientWinform.DTO;
using ClientWinform.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinform.View.User
{
    public partial class ProfileExplorerForm : Form
    {
        private DTO.User user = new DTO.User();
        private DTO.User userConnect = new DTO.User();
        private int idConnection = 0;
        public delegate void MyDel(string txt);
        public MyDel d { get; set; }
        public ProfileExplorerForm(int idUser, int idTo)
        {
            InitializeComponent();
            user = BLL.UserBLL.getUserByID(idUser);
            userConnect = BLL.UserBLL.getUserByID(idTo);
            
            DTO.Message check = BLL.UserBLL.checkIsHaveConnection(idUser, idTo);
            if(check != null )
            {
                if(check.Status == Constants.ConnectionsDescr.NOTCONNECT)
                {
                    btnConnection.Text = "Connect";
                    btnDisconnect.Visible = false;
                }
                if(check.Status == Constants.ConnectionsDescr.CONNECTED)
                {
                    btnConnection.Text = "Connected";
                    //btnDisconnect.Visible = false;
                }
                else if(check.Status == Constants.ConnectionsDescr.CONNECTING)
                {
                    if(check.IdFrom == idUser)
                    {
                        btnConnection.Text = "Connecting";
                        btnDisconnect.Text = "Cancel";
                    }
                    else
                    {
                        btnConnection.Text = "Confirm";
                        btnDisconnect.Text = "Delete";
                    }
                }
                idConnection = check.Id;
            }
            else
            {
                btnConnection.Text = "Connect";
                btnDisconnect.Visible = false;
            }
            showDetail(userConnect);
        }
        public void showDetail(DTO.User user)
        {
            labelUsername.Text = user.Username;
            labelName.Text = user.Name;
            byte[] images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
            if (images == null)
            {
                picBoxAva.Image = Resources.defaultAvatar;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(images);
                picBoxAva.Image = Image.FromStream(mstream);
            }
            labelBio.Text = user.Bio;
        }
        private void ProfileExplorerForm_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(340, 550);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (btnConnection.Text == "Connect")
            {
                BLL.UserBLL.InsertConnection(user.Id, userConnect.Id);
                btnConnection.Text = "Connecting";
                btnDisconnect.Text = "Cancel";
                d("");
                try
                {
                    SocketHandles.MailClient.sendNotiConnection(user.Id, userConnect.Id, Constants.ConnectionsDescr.CONNECTING);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this.Close();
            }
            if(btnConnection.Text == "Confirm")
            {
                BLL.UserBLL.UpdateConnectionToConnected(idConnection, user.Id);
                btnConnection.Text = "Connected";
                btnDisconnect.Text = "Disconnect";
                d("");
                try
                {
                    SocketHandles.MailClient.sendNotiConnection(user.Id, userConnect.Id, Constants.ConnectionsDescr.CONNECTED);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this.Close();
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Remove connection with \"" + userConnect.Username + "\"?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                BLL.UserBLL.UpdateConnectionToDisConnect(idConnection, user.Id);
                d("");
                try
                {
                    SocketHandles.MailClient.sendNotiConnection(user.Id, userConnect.Id, Constants.ConnectionsDescr.NOTCONNECT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            this.Close();
        }
    }
}
