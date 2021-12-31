using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication.forms
{
    public partial class SignUp2 : Form
    {
        public SignUp2()
        {
            InitializeComponent();
        }

        private void clickBack(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
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

        private void clickSignIn(object sender, EventArgs e)
        {
            StartUp start = new StartUp();
            start.Show();
            this.Close();
        }

        private void clickContinue(object sender, EventArgs e)
        {
            SignUpFinal signUpFinal = new SignUpFinal();
            signUpFinal.Show();
            this.Close();
        }
    }
}
