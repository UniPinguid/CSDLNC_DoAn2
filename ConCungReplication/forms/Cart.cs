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
    public partial class Cart : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        void loadData()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT sp.SP_ID, sp.TenSP, sp.Gia, sp.ThuongHieu, sp.KhuyenMai ";
            truyVan += "FROM KH_DATHANG dh, SANPHAM sp ";
            truyVan += "WHERE dh.SP_ID = sp.SP_ID AND dh.KH_ID = '" + StartUp.id + "'";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            inCartData.DataSource = dt;
            inCartData.AutoResizeColumns();
            inCartData.AutoResizeRows();
        }
        void loadCustomer()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM KHACHHANG WHERE KH_ID LIKE '" + StartUp.id + "'";
            using var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    customerName.Text = reader["TenKH"].ToString();
                }
            }
        }
            
        public Cart()
        {
            InitializeComponent();
        }

        private void ContinueClick(object sender, EventArgs e)
        {
            this.Hide();
            OrderPayment receipt = new OrderPayment();
            receipt.Show();
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
            UserProfile profile = new UserProfile();
            profile.Show();
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

        private void Cart_Load(object sender, EventArgs e)
        {

        }
    }
}
