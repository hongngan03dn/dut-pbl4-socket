using System;
using ClientWinform.DTO;
using ClientWinform.View.User;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ClientWinform.View.User
{
    public partial class UpdateProfileForm : Form
    {
        private DTO.User user = new DTO.User();
        private string imgLocation = "";
        byte[] images = null;
        public delegate void MyDel(DTO.User user);
        public MyDel d { get; set; }
        public UpdateProfileForm(DTO.User user)
        {
            InitializeComponent();
            this.user = user;
            txtName.Text = user.Name;
            txtUsername.Text = user.Username;
            txtMail.Text = user.Email;
            txtBio.Text = user.Bio;
            if (user.Gender == true)
            {
                maleBtn.Checked = true;
            }
            else
            {
                femaleBtn.Checked = true;
            }
            dtPickerBirth.Text = user.BOD.ToString();
            images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
            if (images == null)
            {
                pictBoxAva.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(images);
                pictBoxAva.Image = Image.FromStream(mstream);
            }
        }
        private void changeAvaBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictBoxAva.ImageLocation = imgLocation;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return emailRegex.IsMatch(email);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            if (!IsValidEmail(txtMail.Text))
            {
                labelInvalidemail.Visible = true;
                btnSubmit.Enabled = false;
                return;
            }
            else
            {
                labelInvalidemail.Visible = false;
                btnSubmit.Enabled = true;
                return;
            }
        }
        public void updateUser()
        {
            bool isChanged = false;
            int idImg = 0;
            byte[] imagecChanged = null;
            bool gender;
            if (maleBtn.Checked == true)
                gender = true;
            else 
                gender = false;
            string name = txtName.Text;
            string username = txtUsername.Text;
            string email = txtMail.Text;
            string bio = txtBio.Text;
            if(imgLocation != "")
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                imagecChanged = brs.ReadBytes((int)stream.Length);
                idImg = BLL.UserBLL.changeAva(imagecChanged, user);

            }
            DateTime birth = Convert.ToDateTime(dtPickerBirth.Text);
            if(name != user.Name || username != user.Username || birth != user.BOD || gender != user.Gender || bio != user.Bio || idImg != 0)
            {

                isChanged = true;
                user.Name = name;
                if (idImg != 0)
                    user.IdAvatar = idImg;
                else
                    user.IdAvatar = user.IdAvatar;
                user.Username = username;
                user.Email = email;
                user.Bio = bio;
                user.Gender = gender;
                user.BOD = birth;
                BLL.UserBLL.updateUser(user);
            }
            if(isChanged == true)
                MessageBox.Show("Update profile successfully");
            else 
                MessageBox.Show("You have not changed at all");
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {            
            if(txtUsername.Text != "" && txtMail.Text != "")
            {
                foreach (string i in BLL.UserBLL.checkExistedEmail(user.Email))
                {
                    if (i == txtMail.Text)
                    {
                        MessageBox.Show("Email already existed!");
                        txtMail.Text = user.Email;
                        txtMail.SelectionStart = txtMail.Text.Length;
                        break;
                    }
                }
                foreach (string i in BLL.UserBLL.checkExistedUsername(user.Username))
                {
                    if (i == txtUsername.Text)
                    {
                        MessageBox.Show("Username already existed!");
                        txtUsername.Text = user.Username;
                        txtUsername.SelectionStart = txtUsername.Text.Length;
                        break;
                    }
                }
                updateUser();
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Warning");
                return;
            }
            this.Close();
            d(user);
        }
    }
}

