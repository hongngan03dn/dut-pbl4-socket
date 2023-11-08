using ClientWinform.View.User;
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

namespace ClientWinform
{
    public partial class NavigationForm : Form
    {
        private Guna2Button currentBut;
        private Form activeForm;
        public NavigationForm()
        {
            InitializeComponent();
            ActiveButton((Guna2Button)chatBtn);
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
            if (activeForm != null)
            {
                activeForm.Close();
            }
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
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ProfileForm f = new ProfileForm();
            OpenChilForm(f, sender);
        }
    }
}
