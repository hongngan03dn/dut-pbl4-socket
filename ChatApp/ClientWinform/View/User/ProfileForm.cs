using ClientWinform.View.User;
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
    public partial class ProfileForm : Form
    {
        private Form activeForm;
        public ProfileForm()
        {
            InitializeComponent();
        }
        public void OpenChilForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            UpdateProfileForm f = new UpdateProfileForm();
            OpenChilForm(f);
        }
    }
}
