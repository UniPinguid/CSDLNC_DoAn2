﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignUpText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }
    }
}
