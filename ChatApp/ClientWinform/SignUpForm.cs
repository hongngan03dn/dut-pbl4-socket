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
        public SignUpForm()
        {
            InitializeComponent();
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
