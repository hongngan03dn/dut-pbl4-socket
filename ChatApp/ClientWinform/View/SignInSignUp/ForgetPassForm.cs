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

namespace ClientWinform.View
{
    public partial class ForgetPassForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public ForgetPassForm()
        {
            InitializeComponent();
        }
        private void ForgetPassForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(780, 560);
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
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (UserBLL.IsExistedEmail(txtEmail.Text))
            {
                UserBLL.resetPassword(txtEmail.Text);
                MessageBox.Show("Reset Successfully. Please check your email.");
            }
            else
            {
                MessageBox.Show("Email is not existed.");
            }
        }

        private void lableBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
