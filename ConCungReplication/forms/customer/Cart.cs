using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ConCungReplication.forms;

namespace ConCungReplication
{
    public partial class Cart : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        private static string hdid = "";
        public static string _address = "";
        public static string _nguoiNhan = "";
        public static string _subTotal = "";
        public static string _discount = "";
        public static string _total = "";
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
            cmd_cart.CommandType = CommandType.StoredProcedure;
            cmd_cart.Parameters.Add("@id", SqlDbType.Char).Value = StartUp.id;
            
            cmd_cart.Parameters.Add("@tongTien", SqlDbType.Float).Value = 10;
            cmd_cart.Parameters["@tongTien"].Direction = ParameterDirection.InputOutput;
            cmd_cart.ExecuteNonQuery();
            subtotal.Text = cmd_cart.Parameters["@tongTien"].Value.ToString();
            label2.Text = subtotal.Text;
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
        
        private void panel14_Click(object sender, EventArgs e)
        {
            _nguoiNhan = customerName.Text;
            _address = address.Text;
            _discount = discount.Text;
            _subTotal = subtotal.Text;
            _total = label2.Text; 
            OrderPayment pay = new OrderPayment();
            pay.Show();
            this.Close();

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


        public static string gethdid()
        {
            return hdid;
        }
        private void clickAboutUs(object sender, EventArgs e)
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
