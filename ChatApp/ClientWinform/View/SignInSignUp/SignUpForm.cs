using ClientWinform.DTO;
using ClientWinform.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinform
{
    public partial class SignUpForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUpForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void SignUpForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void SignUpForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(780, 560);

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            loginForm f = new loginForm();
            f.ShowDialog();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            // validate
            if (String.IsNullOrWhiteSpace(txtEmail.Text) 
                || String.IsNullOrWhiteSpace(txtName.Text)
                || String.IsNullOrWhiteSpace(txtUsername.Text)
                || String.IsNullOrWhiteSpace(txtPassword.Text)
                || String.IsNullOrWhiteSpace(txtVerifyPW.Text)
                )
            {
                MessageBox.Show("Please fill all information.", "ERROR");
                return;
            }
            if(txtPassword.Text != txtVerifyPW.Text)
            {
                MessageBox.Show("Verify Password fail.", "ERROR");
                return;
            }

            // Sign Up
            User user = new User()
            {
                IdRole = Constants.Roles.USER,
                Name = txtName.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Status = Constants.Statuses.ACTIVE,
                CreatedDate = DateTime.Now
            };
            try
            {
                UserBLL.SignUp(user);
                MessageBox.Show("Sign Up Successfully.", "INFO");
                this.Hide();
                loginForm f = new loginForm();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
