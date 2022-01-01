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

        static string username = "";
        static string password = "";

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
                    string gender = SignUp.gender;
                    string number = SignUp.number;

                    ID += RandomString(8);

                    string HouseNumber = SignUp2.HouseNumber;
                    string ward = SignUp2.ward;
                    string street = SignUp2.street;
                    string province = SignUp2.province;
                    string district = SignUp2.district;

                    username = textBox6.Text;
                    password = textBox5.Text;


                    try
                    {
                        string command = "EXEC SignUpCustomer '" + ID + "', N'" + name + "','" + number + "','" + email + "', N'" + gender + "', " + birthday + ",'" + HouseNumber + "', N'" + street + "', N'" + ward + "', N'" + district + "', N'" + province + "','" + username + "','" + password + "'";
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
                        MessageBox.Show("Error: Sign up failed");
                    }
                }

            }
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
