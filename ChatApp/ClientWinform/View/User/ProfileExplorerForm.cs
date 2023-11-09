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
    public partial class ProfileExplorerForm : Form
    {
        public ProfileExplorerForm()
        {
            InitializeComponent();
        }

        private void ProfileExplorerForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 600);
        }
    }
}
