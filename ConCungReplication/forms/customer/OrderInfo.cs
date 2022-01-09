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
    public partial class OrderInfo : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        
        public void loadCT()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string truyVan = "SELECT * FROM CT_HoaDon WHERE HD_ID LIKE '" + PurchaseHistory.IdHD + "'";
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                productList.DataSource = dt;
                productList.AutoResizeColumns();
                productList.AutoResizeRows();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        
        public void loadHD()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string truyVan = "SELECT * FROM HoaDon WHERE HD_ID LIKE '" + PurchaseHistory.IdHD + "'";
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    date.Text=dr["NgayMua"].ToString();
                    orderID.Text = dr["HD_ID"].ToString();
                    customerName.Text = "X";
                    address.Text = dr["DiaChi"].ToString();
                    subtotal.Text = dr["TienHang"].ToString();
                    discount.Text = dr["GiamGia"].ToString();
                    label6.Text = dr["PhiVanChuyen"].ToString();
                    label2.Text = dr["ThanhTien"].ToString();
                    status.Text = dr["TrangThai"].ToString();
                }
                conn.Close ();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        
        public OrderInfo()
        {
            InitializeComponent();
        }

        private void clickUser(object sender, EventArgs e)
        {
            this.Close();
            UserProfile user = new UserProfile();
            user.Show();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void clickBack(object sender, EventArgs e)
        {
            OrderPayment payment = new OrderPayment();
            payment.Show();
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

        private void clickCart(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void clickAboutUs(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }

        private void clickBrowse(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            browse.Show();
            this.Close();
        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {
            loadCT();
            loadHD();
        }

        private void productList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductPage product = new ProductPage();
            int i = productList.CurrentCell.RowIndex;
            product.IDSP = dt.Rows[i]["SP_ID"].ToString();
            product.Show();
            this.Close();
        }
    }
}
