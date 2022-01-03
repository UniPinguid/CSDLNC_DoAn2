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
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            // Insert data here
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
            string hdid = Cart.gethdid();
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("exec ", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            inCartData.DataSource = dt;
        }
    }
}
