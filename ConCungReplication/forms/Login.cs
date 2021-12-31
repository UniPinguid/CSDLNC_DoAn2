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
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void clickLogin(object sender, EventArgs e)
        {
            //// If username is in Customer database
            //HomepageCustomer homepageCustomer = new HomepageCustomer();
            //homepageCustomer.ShowDialog();

            //// If username is in Employer database
            //HomepageEmployer homepageEmployer = new HomepageEmployer();
            //homepageEmployer.ShowDialog();

            // If username is in Manager database
            HomepageManager homepageManager = new HomepageManager();
            homepageManager.ShowDialog();

            //// If username is in Personnel database
            //HomepagePersonnel homepagePersonnel = new HomepagePersonnel();
            //homepagePersonnel.Show();

            this.Hide();
        }
    }
}
