using ClientWinform.DTO;
using ClientWinform.View.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinform
{
    public partial class ProfileForm : Form
    {
        private Form activeForm;
        private User user = new User();
        public delegate void MyDel(User user);
        public MyDel del { get; set; }
        public ProfileForm(User user)
        {
            InitializeComponent();
            this.user = user;
            showDetail(user);
        }
        public void showDetail(User user)
        {
            labelUsername.Text = user.Username;
            labelName.Text = user.Name;
            labelBio.Text = user.Bio;
            if(user.Gender == true)
            {
                maleBtn.Checked = true;
            }
            else
            {
                femaleBtn.Checked = true;
            }
            dtPickerBirth.Text = user.BOD.ToString();
            txtMail.Text = user.Email;
            txtPass.Text = user.Password;
            byte[] images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
            if(images == null ) 
            {
                picBoxAva.Image = null;            
            }
            else
            {
                MemoryStream mstream = new MemoryStream(images);
                picBoxAva.Image = Image.FromStream(mstream);
            }
            if(del != null)
            {
                del(user);
            }
            
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
            UpdateProfileForm f = new UpdateProfileForm(user);
            OpenChilForm(f);
            f.d += new UpdateProfileForm.MyDel(showDetail);
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            ChangePassForm f = new ChangePassForm();
            f.ShowDialog();
        }
    }
}
