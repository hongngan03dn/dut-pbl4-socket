using ClientWinform.DTO;
using ClientWinform.View.User;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinform
{
    public partial class NavigationForm : Form
    {
        private Guna2Button currentBut;
        private Form activeForm;
        private Panel exploreUser;

        private User user = new User();
        byte[] images = null;
        public NavigationForm()
        {
            InitializeComponent();
        }
        public NavigationForm(User user):this()
        {
            this.user = user;
            showDetail(user);
            ActiveButton((Guna2Button)chatBtn);
            ChatListForm f = new ChatListForm();
            OpenStartForm(f); 
        }
        public void showDetail(User user)
        {
            lableUsername.Text = user.Username;
            images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
            if (images == null)
            {
                pictureAva.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(images);
                pictureAva.Image = Image.FromStream(mstream);
            }
        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            ProfileForm f = new ProfileForm(user);
            OpenChilForm(f, sender);
            f.del += new ProfileForm.MyDel(showDetail);
        }
        private void ActiveButton(object btnSender)
        {
            DisableButton();
            if (btnSender != null)
            {
                currentBut = (Guna2Button)btnSender;
                currentBut.FillColor = Color.FromArgb(96, 127, 244);

                
                panelLeftMenu.Visible = true;
                panelLeftMenu.Location = new Point(currentBut.Location.X, currentBut.Location.Y);
                panelLeftMenu.Size = new Size(4, currentBut.Size.Height);
            }
        }
        private void DisableButton()
        {
            foreach (Control ctrl in panelBtn.Controls)
            {
                if (ctrl is Guna2Button)
                {
                    Guna2Button btn = (Guna2Button)ctrl;
                    btn.FillColor = Color.FromArgb(122, 151, 244);
                }
            }
        }

        public void OpenStartForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void OpenChilForm(Form childForm, object sender)
        {
            //if (activeForm != null)
            //{
            //    activeForm.Close();
            //}
            ActiveButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            ChatListForm f = new ChatListForm();
            OpenChilForm(f, sender);
        }


        private void exploreBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            panelExplore.Size = new Size(300, panelChild.Height);
            panelExplore.Location = new Point(0, 0);
            panelExplore.Visible = true;
            panelExplore.BringToFront();
        }
        private void searchTxt_IconLeftClick(object sender, EventArgs e)
        {
            exploreUser = new Panel();
            exploreUser.Size = new Size(268, 56);
            exploreUser.BackColor = Color.FromArgb(233, 233, 236);

            exploreUser.Click += new EventHandler(exploreUserPanel_Click);

            flowLayoutPanelListExplore.Controls.Add(exploreUser);
        }
        private void exploreUserPanel_Click(object sender, EventArgs e)
        {
            ProfileExplorerForm f = new ProfileExplorerForm();
            f.ShowDialog();
        }




    }
}
