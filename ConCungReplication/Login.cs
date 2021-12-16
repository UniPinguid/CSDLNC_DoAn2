using System;
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

        private void clickLogin(object sender, EventArgs e)
        {
            this.Hide();
            //// If username is in Customer database
            //HomepageCustomer homepageCustomer = new HomepageCustomer();
            //homepageCustomer.Show();

            //// If username is in Employer database
            //HomepageEmployer homepageEmployer = new HomepageEmployer();
            //homepageEmployer.Show();

            // If username is in Manager database
            HomepageManager homepageManager = new HomepageManager();
            homepageManager.Show();
        }
    }
}
