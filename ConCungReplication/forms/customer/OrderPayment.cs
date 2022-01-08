using ConCungReplication.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    
    public partial class OrderPayment : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        string hdid = null;
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            string payment = null;
            if (checkMOMO.Checked == true)
            {
                payment = "Momo";
            }
            if (checkZaloPay.Checked == true)
            {
                payment = "ZaloPay";
            }
            if (checkMastercard.Checked == true)
            {
                payment = "MasterCard";
            }
            if(checkVisa.Checked == true)
            {
                payment = "Visa";
            }
            if(checkDelivery.Checked == true)
            {
                payment = "COD";
            }
            conn = new SqlConnection(connectionString);
            conn.Open();
            cmd = new SqlCommand();
            
            cmd.Connection = conn;
            cmd.CommandText = "update hoadon set phuongthucthanhtoan = '" + payment + "' where HD_ID = '" + hdid + "'";
            cmd.ExecuteNonQuery();
            SubmitOrder submitOrder = new SubmitOrder();
            submitOrder.Show();
            this.Close();
        }

        private void clickUser(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile();
            user.Show();
            this.Close();
        }

        private void clickBack(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
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

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void OrderPayment_Load(object sender, EventArgs e)
        {
            hdid = Cart.gethdid();
            //string hdid = "HD00003350";
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapter = new SqlDataAdapter("exec SELECT * FROM CT_HOADON where HD_ID = '" + hdid +"'", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            inCartData.DataSource = dt;
        }
    }
}
