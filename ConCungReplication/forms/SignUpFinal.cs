using ConCungReplication.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class SignUpFinal : Form
    {
        public SignUpFinal()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your account had been created successfully!","Success");
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void clickBack(object sender, EventArgs e)
        {
            SignUp2 signUp2 = new SignUp2();
            signUp2.Show();
            this.Close();
        }

        private void clickSignIn(object sender, EventArgs e)
        {
            StartUp start = new StartUp();
            start.Show();
            this.Close();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
