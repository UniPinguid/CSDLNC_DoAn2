using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ConCungReplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public string id = "";

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
            //HomepageManager homepageManager = new HomepageManager();
            //homepageManager.ShowDialog();

            //// If username is in Personnel database
            //HomepagePersonnel homepagePersonnel = new HomepagePersonnel();
            //homepagePersonnel.Show();
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM NGUOIDUNG WHERE username = '" + usernameInput.Text + "' AND password ='"+passwordInput.Text+"'";
                using var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string customerID = "";
                    string employeeID = "";
                    while (reader.Read())
                    {
                        customerID = reader["KH_ID"].ToString();
                        employeeID = reader["NV_ID"].ToString();
                    }
                    conn.Close();
                    if (customerID!="")
                    {
                        UserProfile.customerID = customerID;
                        UserLocation.customerID = customerID;
                        HomepageCustomer homepageCustomer = new HomepageCustomer();
                        homepageCustomer.ShowDialog();
                        id = customerID;
                    }
                    else if (employeeID != "")
                    {
                        id = employeeID;
                        conn.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM NHANVIEN WHERE NV_ID = '" + id + "'";
                        using var reader2 = cmd.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            string role = "";
                            while (reader2.Read())
                            {
                                role = reader2["PhongBan"].ToString();
                            }
                            conn.Close();
                            if (role == "Nhân Sự")
                            {
                                HomepagePersonnel homepagePersonnel = new HomepagePersonnel();
                                homepagePersonnel.Show();
                            }
                            else
                            {
                                if (role == "Quản Lý")
                                {

                                    HomepageManager homepageManager = new HomepageManager();
                                    homepageManager.ShowDialog();

                                }
                                else
                                {
                                    if (role == "Quản Trị")
                                    {
                                        HomepageEmployer homepageEmployer = new HomepageEmployer();
                                        homepageEmployer.ShowDialog();
                                    }
                                }
                            }
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi hệ thống.", "Thông Báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập.", "Thông Báo");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống.", "Thông Báo");
            }
            this.Hide();
        }
    }
}
