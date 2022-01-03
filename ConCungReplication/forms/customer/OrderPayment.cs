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

        private void clickReturn(object sender, EventArgs e)
        {
            this.Close();
            Cart cart = new Cart();
            cart.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            this.Close();
            // Insert data here
            SubmitOrder submitOrder = new SubmitOrder();
            submitOrder.Show();
        }

        private void clickUser(object sender, EventArgs e)
        {
            this.Close();
            UserProfile user = new UserProfile();
            user.Show();
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
