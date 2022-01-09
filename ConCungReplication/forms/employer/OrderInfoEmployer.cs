using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication.forms
{
    public partial class OrderInfoEmployer : Form
    {
        private static string odid = null;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public OrderInfoEmployer()
        {
            InitializeComponent();
        }

        private void clickBack(object sender, EventArgs e)
        {
            OrderTraces traces = new OrderTraces();
            traces.Show();
            this.Close();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageEmployer homepage = new HomepageEmployer();
            homepage.Show();
            this.Close();
        }

        private void productList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductPageEmployer product = new ProductPageEmployer();
            product.ShowDialog();
        }

        private void OrderInfoEmployer_Load(object sender, EventArgs e)
        {
            odid = OrderTraces.getid();

            if (odid != null)
            {

                conn = new SqlConnection(connectionString);
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM hoadon WHERE hd_ID = '" + odid + "'", conn);
                dt = new DataTable();
                adapter.Fill(dt);

                orderID.Text = dt.Rows[0][0].ToString();
                date.Text = dt.Rows[0][1].ToString();
                address.Text = dt.Rows[0][2].ToString();
                label11.Text = dt.Rows[0][6].ToString();
                discount.Text = dt.Rows[0][7].ToString();
                label6.Text = dt.Rows[0][5].ToString();
                label2.Text = dt.Rows[0][8].ToString();

                
                adapter = new SqlDataAdapter("SELECT * FROM ct_hoadon WHERE hd_ID = '" + odid + "'", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                productList.DataSource = dt;
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
