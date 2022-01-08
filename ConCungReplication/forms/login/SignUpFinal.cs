using ConCungReplication.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Linq;
namespace ConCungReplication
{
    public partial class SignUpFinal : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

        public static string username = "";
        public static string password = "";



        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public SignUpFinal()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {
            int checkEmpty = 0;
            if (textBox6.Text == "")
            {
                MessageBox.Show("Username is empty");
                checkEmpty = 1;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Password is empty");
                checkEmpty = 1;
            }

            if(textBox6.Text.Length>10)
            {
                MessageBox.Show("Account has no more than 10 characters");
                checkEmpty = 1;
            }


            if (textBox5.Text.Length > 20)
            {
                MessageBox.Show("Password has no more than 20 characters");
                checkEmpty = 1;
            }

            if (!CheckTOS.Checked)
            {
                MessageBox.Show("Please make sure you accept out Term and Policy");
                checkEmpty = 1;
            }

            if (checkEmpty == 0)

            {
                if (!textBox3.Text.Equals(textBox5.Text))
                {
                    MessageBox.Show("Password and confirm password do not match");
                }
                else
                {
                    string ID = "KH";
                    string name = SignUp.name;
                    string email = SignUp.email;
                    string birthday = SignUp.birthday;
                    string gender;
                    if (SignUp.gender == "Male") gender = "Nam";
                    else gender = "Nữ";
                    string number = SignUp.number;

                    ID += RandomString(8);

                    int HouseNumber = SignUp2.HouseNumber;
                    string ward = SignUp2.ward;
                    string street = SignUp2.street;
                    string province = SignUp2.province;
                    string district = SignUp2.district;

                    username = textBox6.Text;
                    password = textBox5.Text;


                    try
                    {
                        string command = "exec SignUpCustomer '" + ID + "', N'" + name + "', '" + number + "', '" + email + "', N'" + gender + "', '" + birthday + "', " + HouseNumber + ", '" + street + "', '" + ward + "', '" + district + "', '" + province + "', '" + username + "', '" + password + "' ";

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(command, conn))
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Your account had been created successfully!", "Success");
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error!!! Sign up failed");
                    }

                }

            }

        }
    }
}
