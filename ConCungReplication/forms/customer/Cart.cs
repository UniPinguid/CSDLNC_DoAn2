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
using ConCungReplication.forms;

namespace ConCungReplication
{
    public partial class Cart : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        private static string hdid;
        void loadData()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT sp.SP_ID, sp.TenSP, sp.Gia, sp.ThuongHieu, sp.KhuyenMai, dh.SoLuong ";
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

            conn.Open();

            SqlCommand cmd_cart = new SqlCommand("tinhTien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd_cart.Parameters.Add("@id", SqlDbType.Char).Value = StartUp.id;
            cmd_cart.Parameters.Add("@tongTien", SqlDbType.Float).Value = 0;
            var cost = cmd_cart.ExecuteScalar();
            subtotal.Text = cost.ToString() + "đ";
            label2.Text = cost.ToString() + "\n(VAT included)";
            discount.Text = "0đ";
            conn.Close();
        }
        void loadCustomer()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM KHACHHANG kh, DiaChi_KH addr WHERE kh.KH_ID = addr.KH_ID AND kh.KH_ID LIKE '" + StartUp.id + "'";
            using var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    customerName.Text = reader["TenNguoiNhan"].ToString();
                    address.Text = reader["SoNha"].ToString() + " " + reader["Duong"].ToString() + ", ";
                    address.Text += reader["XaPhuong"].ToString() + ", quan " + reader["Quan"] + ", tinh ";
                    address.Text += reader["Tinh"];
                    break;
                }
            }
            else
            {
                customerName.Text = "";
                address.Text = "";
            }
            conn.Close();
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
            loadCustomer();
            loadData();
        }

        private void inCartData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductPage product = new ProductPage();
            int i = inCartData.CurrentCell.RowIndex;
            product.IDSP = dt.Rows[i]["SP_ID"].ToString();
            product.Show();
            this.Close();
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            while (true)
            {
                string idHoaDon = "HD" + RandomString(8);
                hdid = idHoaDon;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "TaoHoaDon";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@diaChi", SqlDbType.Char).Value = address.Text;
                cmd.Parameters.Add("@idKH", SqlDbType.Char).Value = StartUp.id;
                cmd.Parameters.Add("@result", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@idHD", SqlDbType.Char).Value = idHoaDon;
                cmd.ExecuteNonQuery();
                var result = cmd.Parameters["@result"].Value;

                if (result.Equals(1))
                {
                    MessageBox.Show("Đặt hàng thàng công", "Thông Báo");
                    break;
                }
                else if (result.Equals(-1))
                {
                    MessageBox.Show("Lỗi Hệ Thống", "Thông Báo");
                    break;
                }
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            HomepageCustomer homepageCustomer = new HomepageCustomer();
            homepageCustomer.Show();
            Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            UserLocation userLocation = new UserLocation();
            userLocation.Show();
            Close();
        }

<<<<<<< HEAD
        public static string gethdid()
        {
            return hdid;
        }
        private void label9_Click(object sender, EventArgs e)
=======
        private void clickAboutUs(object sender, EventArgs e)
>>>>>>> 391cf4e498b529ec5d893b271bbb51e8b50c621f
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
