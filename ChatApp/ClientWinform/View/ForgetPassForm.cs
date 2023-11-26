﻿using ClientWinform.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinform.View
{
    public partial class ForgetPassForm : Form
    {
        public ForgetPassForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (UserBLL.IsExistedEmail(txtEmail.Text))
            {
                UserBLL.resetPassword(txtEmail.Text);
                MessageBox.Show("Reset Successfully. Please check your email.");
            }
            else
            {
                MessageBox.Show("Email is not existed.");
            }
        }
    }
}
