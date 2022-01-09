using ConCungReplication.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace ConCungReplication
{
    public partial class UserProfile : Form
    {
        public static string customerID = "";
        static int num = 0;

        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        DataTable dt2 = null;

        void LoadCustomerInformation()
        {
            try

            {

                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string truyVan = "select CONVERT(varchar(10), NgaySinh, 101) as NgaySinh , TenKH, Phai, SoDienThoai,  Email from KHACHHANG where KH_ID = '" + customerID + "' ";
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                textBox5.Text = dt.Rows[0]["TenKH"].ToString();
                textBox2.Text = dt.Rows[0]["SoDienThoai"].ToString();
                string str_Phai = dt.Rows[0]["Phai"].ToString();
                if (str_Phai == "Nam") GenderSelect.Text = "Male";
                else GenderSelect.Text = "Female";
                textBox3.Text = dt.Rows[0]["NgaySinh"].ToString();
                textBox4.Text = dt.Rows[0]["Email"].ToString();
            }
            catch
            {
                MessageBox.Show("Error! Failed to load your information");

            }
        }

        void LoadCustomerKid()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string truyVan = "select Ten, STT, Phai, CONVERT(varchar(10), NgaySinh, 101) as NgaySinh from Con_KH where KH_ID = '" + customerID + "'";
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt2 = new DataTable();
                adapter.Fill(dt2);

                conn.Close();
                userKids.DataSource = dt2;
                userKids.AutoResizeColumns();
                userKids.AutoResizeRows();
            }
            catch
            {
                MessageBox.Show("Cannot get your children information. Make sure you have added their information to the system");
            }

        }


        public UserProfile()
        {
            InitializeComponent();

        }

        private void clickLogout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void clickLocation(object sender, EventArgs e)
        {
            this.Close();
            UserLocation userLocation = new UserLocation();
            userLocation.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickPurchaseHistory(object sender, EventArgs e)
        {
            PurchaseHistory purchase = new PurchaseHistory();
            purchase.Show();
            this.Close();
        }

        private void clickExit(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void clickBrowse(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            browse.Show();
            this.Close();
        }

        private void clickAboutUs(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            LoadCustomerInformation();
            LoadCustomerKid();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            string TenKH = textBox5.Text;
            string Phai;
            if (GenderSelect.Text == "Male") Phai = "Nam";
            else Phai = "Nữ";
            string SoDienThoai = textBox2.Text;
            string Email = textBox4.Text;
            string NgaySinh = textBox3.Text;
            try
            {
                string command = "exec UpdateCustomer '" + customerID + "', N'" + TenKH + "', '" + Email + "', '" + NgaySinh + "',N'" + Phai + "', '" + SoDienThoai + "'";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Your information had been updated successfully!", "Success");
                LoadCustomerInformation();
            }
            catch
            {
                MessageBox.Show("Error! Update has failed");
            }

        }

        private void userKids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = userKids.CurrentCell.RowIndex;
            string str = dt2.Rows[i]["STT"].ToString();
            num = Int32.Parse(str);

            string str_Phai = dt2.Rows[i]["Phai"].ToString();
            if (str_Phai == "Nam") comboBox1.Text = "Male";
            else comboBox1.Text = "Female";
            textBox7.Text = dt2.Rows[i]["Ten"].ToString();
            textBox6.Text = dt2.Rows[i]["NgaySinh"].ToString();
            LoadCustomerKid();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string Phai;
            if (comboBox1.Text == "Male") Phai = "Nam";
            else Phai = "Nữ";
            string Ten = textBox7.Text;
            string NgaySinh = textBox6.Text;
            string command = "exec UpdateKid '" + customerID + "', N'" + Ten + "', N'" + Phai + "', '" + NgaySinh + "', " + num + "";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Your KID information had been updated successfully!", "Success");
            LoadCustomerKid();

        }

        private void logo_Click(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            string TenKH = textBox5.Text;
            string Phai;
            if (GenderSelect.Text == "Male") Phai = "Nam";
            else Phai = "Nữ";
            string SoDienThoai = textBox2.Text;
            string Email = textBox4.Text;
            string NgaySinh = textBox3.Text;
            try
            {
                string command = "exec UpdateCustomer '" + customerID + "', N'" + TenKH + "', '" + Email + "', '" + NgaySinh + "',N'" + Phai + "', '" + SoDienThoai + "'";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Your information had been updated successfully!", "Success");
                LoadCustomerInformation();
            }
            catch
            {
                MessageBox.Show("Error! Update has failed");
            }
        }
    }
}
