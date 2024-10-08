﻿using ClientWinform.DTO;
using ClientWinform.Properties;
using ClientWinform.View.User;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ClientWinform
{
    public partial class NavigationForm : Form
    {
        private Panel explorePanel;
        private Guna2Button currentBut;
        private Form activeForm;
        private bool mouseDown;
        private Point lastLocation;


        private static User userOwn = new User();
        byte[] images = null;

        public ChatListForm chatForm = null;
        public ProfileForm profileForm = null;
        public NavigationForm()
        {
            InitializeComponent();

        }
        public NavigationForm(User user):this()
        {
            userOwn = user;
            showDetail(user);
            ActiveButton((Guna2Button)chatBtn);
            chatForm = new ChatListForm(userOwn);
            profileForm = new ProfileForm(user);
            OpenStartForm(chatForm);
            
        } 
        public void showDetail(User user)
        {
            lableUsername.Text = user.Username;
            images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);
            if (images == null)
            {
                pictureAva.Image = Resources.defaultAvatar;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(images);
                pictureAva.Image = Image.FromStream(mstream);
            }
        }
        private void DisableButton()
        {
            foreach (Control ctrl in panelBtn.Controls)
            {
                if (ctrl is Guna2Button)
                {
                    Guna2Button btn = (Guna2Button)ctrl;
                    btn.FillColor = Color.FromArgb(122, 151, 244);
                }
            }
        }
        private void ActiveButton(object btnSender)
        {
            DisableButton();
            if (btnSender != null)
            {
                currentBut = (Guna2Button)btnSender;
                currentBut.FillColor = Color.FromArgb(96, 127, 244);

                
                panelLeftMenu.Visible = true;
                panelLeftMenu.Location = new Point(currentBut.Location.X, currentBut.Location.Y);
                panelLeftMenu.Size = new Size(4, currentBut.Size.Height);
            }
        }
        public void OpenStartForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        public void OpenChilForm(Form childForm, object sender)
        {
            ActiveButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Activate();
            childForm.Show();
        }
        private void chatBtn_Click(object sender, EventArgs e)
        {
            OpenChilForm(chatForm, sender);
        }
        private void ActivePanel(object btnSender)
        {
            DisablePanel();
            if (btnSender != null)
            {
                explorePanel = (Panel)btnSender;
                explorePanel.BackColor = Color.FromArgb(204, 218, 251);

            }
        }
        private void DisablePanel()
        {
            foreach (Control ctrl in flowLayoutPanelListExplore.Controls)
            {
                if (ctrl is UserExploreControl)
                {
                    UserExploreControl panel = (UserExploreControl)ctrl;
                    panel.isSelected.BackColor = Color.White;
                }
            }
        }
        private Label createLable(string text)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.AutoSize = true;
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lbl.TextAlign = ContentAlignment.BottomRight;
            lbl.ForeColor = Color.FromArgb(151, 142, 142);
            return lbl;
        }

        public async void addExplorePanel(string txtSearch)
        {
            List<UserModel> friendModel = await Task.Run(() => BLL.MsgBLL.getUserListExplore(userOwn.Id, txtSearch));
            List<User> friends = new List<User>();
            foreach(UserModel frModel in friendModel)
            {
                User fr = BLL.UserBLL.getUserByID(frModel.Id);
                friends.Add(fr);
            }
            List<User> connectings = await Task.Run(() => BLL.UserBLL.getConnectingOfUser(userOwn.Id, txtSearch));
            List<int> idUserExcept = friends.Select(user => user.Id).ToList();
            List<User> explores = await Task.Run(() => BLL.UserBLL.GetUserExplore(userOwn.Id, idUserExcept, connectings, txtSearch));


            flowLayoutPanelListExplore.SuspendLayout();  // Suspend layout logic

            flowLayoutPanelListExplore.Controls.Clear();

            AddUsersToPanel("Friend", friends);

            AddUsersToPanel("Connecting", connectings);

            AddUsersToPanel("Explore", explores);

            flowLayoutPanelListExplore.ResumeLayout();  // Resume layout logic

        }

        private void AddUsersToPanel(string categoryLabel, List<User> users)
        {
            if (users.Any())
            {
                flowLayoutPanelListExplore.Controls.Add(createLable(categoryLabel));
                foreach (var user in users)
                {
                    UserExploreControl userExplore = flowLayoutPanelListExplore.Controls.OfType<UserExploreControl>().FirstOrDefault(c => c.userName == user.Username);
                    if (userExplore == null)
                    {
                        userExplore = new UserExploreControl();
                        flowLayoutPanelListExplore.Controls.Add(userExplore);
                    }
                    byte[] images = BLL.UserBLL.getAvaLinkById((Nullable<System.Int32>)user.IdAvatar);

                    if (images == null)
                    {
                        userExplore.ava = Resources.defaultAvatar;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(images);
                        userExplore.ava = Image.FromStream(mstream);
                    }
                    userExplore.userName = user.Username;
                    userExplore.name = BLL.UserBLL.getUserByID(user.Id).Name;
                    foreach (Control c in userExplore.Controls)
                    {
                        c.Click -= new EventHandler((sender, e) => exploreUserPanel_Click(sender, e, user.Id));
                        c.Click += new EventHandler((sender, e) => exploreUserPanel_Click(sender, e, user.Id));
                    };
                    flowLayoutPanelListExplore.Controls.Add(userExplore);
                }
            }
        }
        private void exploreBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            panelExplore.Size = new Size(350, panelChild.Height);
            panelExplore.Location = new Point(0, 0);
            panelExplore.Visible = true;
            panelExplore.BringToFront();
            flowLayoutPanelListExplore.Controls.Clear();
            addExplorePanel("");
        }
        private void searchTxt_IconLeftClick(object sender, EventArgs e)
        {
            addExplorePanel(searchTxt.Text);
        }
        private void exploreUserPanel_Click(object sender, EventArgs e, int userId)
        {
            ActivePanel(sender);
            ProfileExplorerForm f = new ProfileExplorerForm(userOwn.Id, userId);
            f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            f.d += new ProfileExplorerForm.MyDel(addExplorePanel);
            f.ShowDialog();
        }
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisablePanel();
        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            OpenChilForm(profileForm, sender);
            profileForm.del += new ProfileForm.MyDel(showDetail);
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

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo );
            if(result == DialogResult.Yes )
            {
                this.Hide();
                this.Close();
                SocketHandles.MailClient.sendNotiSignOut(userOwn.Id);
                loginForm f = new loginForm();
                f.ShowDialog();
            }

        }

        private void NavigationForm_Load(object sender, EventArgs e)
        {
            Size s = new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height - 40);
            this.Location = new Point(0, 0);
            this.Size = s;
            foreach(UserModel fr in BLL.MsgBLL.getUserListExplore(userOwn.Id, ""))
            {
                User user = BLL.UserBLL.getUserByID(fr.Id);
                string gender;
                if (user.Gender == false) gender = "she";
                else gender = "he";
                if (user.BOD != null && user.BOD.Value.Day == DateTime.Now.Day && user.BOD.Value.Month == DateTime.Now.Month )
                    notifyMain.ShowBalloonTip(Constants.Notify.NOTIFY_TIMEOUT, "Hi, " + userOwn.Username, "Today is " + user.Username + "'s birthday. Let's give " + gender + " a wish", ToolTipIcon.None);
            }
        }
    }
}
