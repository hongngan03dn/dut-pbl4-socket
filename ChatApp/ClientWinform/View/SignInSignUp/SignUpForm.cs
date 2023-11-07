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
    }
}
