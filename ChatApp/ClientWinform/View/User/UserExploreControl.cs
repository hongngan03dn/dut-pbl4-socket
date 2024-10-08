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
    public partial class UserExploreControl : UserControl
    {
        public UserExploreControl()
        {
            InitializeComponent();
        }

        #region Properties

        private string _userName;
        private string _name;
        private Image _ava;

        [Category("Custom Props")]
        public string userName
        {
            get { return _userName; }
            set { _userName = value; labelUsername.Text = value; }
        }

        [Category("Custom Props")]
        public string name
        {
            get { return _name; }
            set { _name = value; lableName.Text = value; }
        }

        [Category("Custom Props")]
        public Image ava
        {
            get { return _ava; }
            set { _ava = value; picAva.Image = value; }
        }

        [Category("Custom Props")]
        public Panel isSelected
        {
            get { return panelMain; }
        }
        #endregion
    }
}
