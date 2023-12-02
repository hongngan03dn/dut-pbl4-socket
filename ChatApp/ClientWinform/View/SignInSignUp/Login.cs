using ClientWinform.BLL;
using ClientWinform.DTO;
using ClientWinform.View;
using ClientWinform.View.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientWinform
{
    public partial class loginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public loginForm()
        {
            InitializeComponent();
        }
        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void loginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void loginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(780, 560);

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm f = new SignUpForm();
            f.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // validate
            if (String.IsNullOrWhiteSpace(txtUsername.Text)
                || String.IsNullOrWhiteSpace(txtPassword.Text)
                )
            {
                MessageBox.Show("Please fill all information.", "ERROR");
                return;
            }

            // Sign In
            int id = UserBLL.SignIn(txtUsername.Text, txtPassword.Text);
            User user = UserBLL.getUserByID(id);
            int idRole;

            if (id == 0)
            {
                MessageBox.Show("Username or Password is wrong", "ERROR");
            }
            else
            {
                // phân quyền
                // kết nối Mail Server
                try
                {
                    idRole = UserBLL.getRole(id);
                    this.Hide();
                    if (idRole == Constants.Roles.USER)
                    {
                        NavigationForm f = new NavigationForm(user);
                        SocketHandles.MailClient.connectServer(id, txtUsername.Text, f);
                        f.ShowDialog();
                    }
                    else if (idRole == Constants.Roles.ADMIN)
                    {
                        AdminHomeForm f = new AdminHomeForm();
                        SocketHandles.MailClient.connectServer(id, txtUsername.Text, f);
                        f.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Sign In Successfully.", "INFO");

                // kết nối Mail Server
                try
                {
                    SocketHandles.MailClient.connectServer(id, txtUsername.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                // điều hướng

                if (idRole == Constants.Roles.USER)
                {
                    this.Hide();
                    NavigationForm f = new NavigationForm(user);
                    f.ShowDialog();
                }
                if(idRole == Constants.Roles.ADMIN)
                {
                    this.Hide();
                    AdminHomeForm f = new AdminHomeForm();
                    f.ShowDialog();
                }
            }
        }

        private void recoverPassBtn_Click(object sender, EventArgs e)
        {
            ForgetPassForm f = new ForgetPassForm();
            f.ShowDialog();
        }
    }
}
