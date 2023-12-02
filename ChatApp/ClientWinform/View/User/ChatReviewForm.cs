﻿using System;
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
        public Image ava
        {
            get { return _ava; }
            set { _ava = value; picAva.Image = value; }
        }
        [Category("Custom Props")]
        public Image isOnline
        {
            get { return _isOnline; }
            set { _isOnline = value; pictureBoxOnline.Image = value; }
        }



        #endregion
    }
}
