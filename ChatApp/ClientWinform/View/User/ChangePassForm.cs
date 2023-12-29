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

namespace ClientWinform.View.User
{
    public partial class ChangePassForm : Form
    {
        DTO.User _currentUser;

        public ChangePassForm()
        {
            InitializeComponent();
        }
        public ChangePassForm(DTO.User user) : this()
        {
            _currentUser = user;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPW.Text) 
                || string.IsNullOrEmpty(txtNewPW.Text)
                || string.IsNullOrEmpty(txtVerifyPW.Text))
            {
                MessageBox.Show("Please fill all field");
                return;
            }
            if (!txtNewPW.Text.Equals(txtVerifyPW.Text))
            {
                MessageBox.Show("Verify Password not match. Please check again.");
                return;
            }
            try
            {
                UserBLL.changePassword(_currentUser.Id, txtNewPW.Text, txtCurrentPW.Text);
                MessageBox.Show("Change Password Successfully.", "INFO");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            
        }
    }
}
