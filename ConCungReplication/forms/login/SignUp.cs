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
    public partial class SignUp : Form
    {
        public static string name = "";
        public static string email = "";
        public static string number = "";
        public static string birthday = "";
        public static string gender = "";

        public SignUp()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpFinal signUpFinal = new SignUpFinal();
            signUpFinal.ShowDialog();
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

        private void clickContinue(object sender, EventArgs e)
        {
            int checkEmpty = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Full name is empty");
                checkEmpty = 1;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Contact number is empty");
                checkEmpty = 1;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Birthday is empty");
                checkEmpty = 1;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Email is empty");
                checkEmpty = 1;
            }

            if (GenderSelect.Text == "")
            {
                MessageBox.Show("Gender is empty");
                checkEmpty = 1;
            }

            if (checkEmpty == 0)
            {
                name = textBox1.Text;
                number = textBox2.Text;
                gender = GenderSelect.Text;
                email = textBox4.Text;
                birthday = textBox3.Text;

                this.Hide();
                SignUp2 signUp2 = new SignUp2();

                SignUp2.name = name;
                SignUp2.number = number;
                SignUp2.email = email;
                SignUp2.birthday = birthday;
                SignUp2.gender = gender;

                signUp2.ShowDialog();

            }
        }
    }
}
