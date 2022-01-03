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
    public partial class OrderInfo : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public OrderInfo()
        {
            InitializeComponent();
        }

        private void clickReturn(object sender, EventArgs e)
        {
            this.Close();
            PurchaseHistory purHist = new PurchaseHistory();
            purHist.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickUser(object sender, EventArgs e)
        {
            this.Close();
            UserProfile user = new UserProfile();
            user.Show();
        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM SANPHAM", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            productList.DataSource = dt;
        }
    }
}
