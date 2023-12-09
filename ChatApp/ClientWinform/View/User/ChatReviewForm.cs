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
    public partial class ChatReviewForm : UserControl
    {       
        public ChatReviewForm()
        {
            InitializeComponent();
        }
        #region Properties

        private string _userName;
        private string _message;
        private string _time;
        private Image _ava;
        private Image _isOnline;

        [Category("Custom Props")]
        public string userName
        {
            get { return _userName; }
            set { _userName = value; labelUsername.Text = value; }
        }

        [Category("Custom Props")]
        public string message
        {
            get { return _message; }
            set { _message = value; labelMessage.Text = value; }
        }
        [Category("Custom Props")]
        public string time
        {
            get { return _time; }
            set { _time = value; labelTime.Text = value; }
        }

        [Category("Custom Props")]
        public Image ava
        {
            get { return _ava; }
            set { _ava = value; picAva.Image = value; }
        }
        [Category("Custom Props")]
        public Image isOnline
        {
            get { return _isOnline; }
            set { _isOnline = value; pictureBoxOnline.Image = value; pictureBoxOnline.Visible = false; }
        }

        [Category("Custom Props")]
        public bool isPictureBoxOnlineVisible
        {
            get { return pictureBoxOnline.Visible; }
            set { pictureBoxOnline.Visible = value; }
        }

        [Category("Custom Props")]
        public Panel isSelected
        {
            get { return panelMain; }
        }

        [Category("Custom Props")]
        public Font isRead
        {
            get { return labelMessage.Font; }
            set { labelMessage.Font = value; }
        }
        [Category("Custom Props")]
        public Color changeForeColor
        {
            get { return labelMessage.ForeColor; }
            set { labelMessage.ForeColor = value; }
        }
        #endregion

    }
}
