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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
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
    }
}
