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
    public partial class UserLocation : Form
    {

        public static string customerID = "";
        static int num = 0;

        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;



        void loadData()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "select * from DiaChi_KH where KH_ID = '" + customerID + "'";
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();

        }





        public UserLocation()
        {
            InitializeComponent();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                StartUp login = new StartUp();
                login.Show();
            }
        }

        private void clickPurchaseHistory(object sender, EventArgs e)
        {
            this.Close();
            PurchaseHistory purchase = new PurchaseHistory();
            purchase.Show();
        }

        private void clickProfile(object sender, EventArgs e)
        {
            this.Close();
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
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
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }

        private void clickCart(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void clickUser(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile();
            user.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            string str = dt.Rows[i]["STT"].ToString();
            num = Int32.Parse(str);

            textBox2.Text = dt.Rows[i]["SoNha"].ToString();
            textBox1.Text = dt.Rows[i]["Duong"].ToString();
            textBox3.Text = dt.Rows[i]["XaPhuong"].ToString();
            textBox4.Text = dt.Rows[i]["Quan"].ToString();
            textBox5.Text = dt.Rows[i]["Tinh"].ToString();

            loadData();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                MessageBox.Show("Please choose the address you want to change");
            }
            else
            {
                string str = textBox2.Text;
                int SoNha = Int32.Parse(str);
                string Duong = textBox1.Text;
                string XaPhuong = textBox3.Text;
                string Quan = textBox4.Text;
                string Tinh = textBox5.Text;

                string command = "exec UpdateAddress '" + customerID + "', " + num + ", " + SoNha + ", N'" + Duong + "', N'" + XaPhuong + "', N'" + Quan + "', N'" + Tinh + "' ";
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Your address had been updated successfully!", "Success");
                loadData();


            }
        }

        private void UserLocation_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
