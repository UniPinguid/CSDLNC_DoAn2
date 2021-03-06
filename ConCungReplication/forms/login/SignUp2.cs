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

        public static int HouseNumber;
        public static string street = "";
        public static string ward = "";
        public static string province = "";
        public static string district = "";


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
            int checkEmpty = 0;

            if (textBox6.Text == "")
            {
                MessageBox.Show("House number is empty");
                checkEmpty = 1;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Street is empty");
                checkEmpty = 1;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Ward is empty");
                checkEmpty = 1;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("District is empty");
                checkEmpty = 1;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Province is empty");
                checkEmpty = 1;
            }


            if (checkEmpty == 0)
            {
                street = textBox3.Text;


                string str = textBox6.Text;
                int n = Int32.Parse(str);
                HouseNumber = n;

                ward = textBox5.Text;
                district = textBox2.Text;
                province = textBox1.Text;

                SignUpFinal signUpFinal = new SignUpFinal();

                signUpFinal.Show();
                this.Close();

            }
        }

        private void SignUp2_Load(object sender, EventArgs e)
        {
            if (HouseNumber >= 0) textBox6.Text = HouseNumber.ToString();
            if (street != "") textBox3.Text = street;
            if (ward != "") textBox5.Text = ward;
            if (district != "") textBox2.Text = district;
            if (province != "") textBox1.Text = province;
        }
    }
}
