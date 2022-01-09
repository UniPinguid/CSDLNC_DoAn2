using ConCungReplication.forms.box;
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
    public partial class StartUp : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public static string id = "";

        public StartUp()
        {
            InitializeComponent();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickSignUp(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void clickLogin(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM NGUOIDUNG WHERE username = '" + textBox1.Text + "' AND password ='" + textBox2.Text + "'";
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
                    if (customerID != "")
                    {
                        UserLocation.customerID = customerID;
                        UserProfile.customerID = customerID;

                        id = customerID;

                        HomepageCustomer homepageCustomer = new HomepageCustomer();
                        homepageCustomer.Show();

                        this.Hide();
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
                                BoxLoading BoxLoading = new BoxLoading();
                                BoxLoading.ShowDialog();

                                HomepagePersonnel homepagePersonnel = new HomepagePersonnel();
                                homepagePersonnel.Show(); 

                                this.Hide();
                            }
                            else if (role == "Quản Lý")
                            {
                                BoxLoading BoxLoading = new BoxLoading();
                                BoxLoading.ShowDialog();

                                HomepageManager.ID = employeeID;
                                HomepageManager homepageManager = new HomepageManager();
                                homepageManager.Show();

                                this.Hide();
                            }
                             else if (role == "Quản Trị")
                             {
                                BoxLoading BoxLoading = new BoxLoading();
                                BoxLoading.ShowDialog();

                                HomepageEmployer homepageEmployer = new HomepageEmployer();
                                homepageEmployer.ShowDialog();

                                this.Hide();
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
        }
    }
}
