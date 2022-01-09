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

namespace ConCungReplication
{
    public partial class ProductPage : Form
    {
        private string _idSP = "";
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt1;
        DataTable dt2;
        bool kiemTraKhuyenMai(DateTime start, DateTime end)
        {
            DateTime now = DateTime.Now;
            if(now.Year>end.Year||now.Year<start.Year)
            {
                return false;
            }
            if(now.Year==start.Year)
            {
                if(now.Month < start.Month||(now.Month==start.Month&&now.Day<start.Day))
                {
                    return false;
                }
                if(now.Month>end.Month||(now.Month==end.Month&&now.Day>end.Day))
                {
                    return false;
                }
            }
            return true;
        }
        
        void loadData()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT * FROM SANPHAM ";
            truyVan += " WHERE SP_ID LIKE '" + _idSP + "'";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            var reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                label1.Text = _idSP;
                productName.Text=reader["TenSP"].ToString();
                brand.Text = reader["ThuongHieu"].ToString();
                description.Text= reader["MoTa"].ToString();
                basePrice.Text = reader["Gia"].ToString();
                amountLeft.Text = reader["SLTon"].ToString();

                string endSale = reader["NgayKetThuc"].ToString();
                DateTime EndDay =DateTime.Parse(endSale);
                DateTime StartDay = DateTime.Parse(reader["NgayBatDau"].ToString());
                bool test = kiemTraKhuyenMai(StartDay, EndDay);
                if(test)
                {

                    salesOffPercent.Text = "-" + reader["KhuyenMai"].ToString() + "%";
                    double km = Convert.ToDouble(reader["KhuyenMai"]);
                    double curPrice = Convert.ToDouble(basePrice.Text) * (1 - km / 100);
                    price.Text = curPrice.ToString() + "đ";
                    int SaleDays = (EndDay.Date - DateTime.Now.Date).Days;
                    discountDuration.Text = SaleDays.ToString() + " days";
                }
                else
                {
                    salesOffPercent.Text = "0";
                    price.Text = basePrice.Text + "đ";
                }

            }
            conn.Close();

        }

        void loadSameBrand()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string truyVan = "SELECT * FROM SANPHAM WHERE ThuongHieu LIKE N'" + brand.Text + "'";

                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt1 = new DataTable();
                adapter.Fill(dt1);

                conn.Close();

                dataGridView2.DataSource = dt1;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoResizeRows();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        void loadSameGroup()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string truyVan = "SELECT * FROM SANPHAM WHERE TenSP LIKE N'" + productName.Text + "'";

                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt2 = new DataTable();
                adapter.Fill(dt2);

                conn.Close();

                dataGridView1.DataSource = dt1;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        public ProductPage()
        {
            InitializeComponent();
        }
        public string IDSP
        {
            get { return _idSP; }
            set { _idSP = value; }
        }
        private void incrementQuantity(object sender, EventArgs e)
        {
            int quantity_num = Convert.ToInt32(quantity.Text);
            int sl = Convert.ToInt32(amountLeft.Text);
            if(quantity_num < sl)
            {
                quantity_num++;
            }

            quantity.Text = Convert.ToString(quantity_num);
        }

        private void decrementQuantity(object sender, EventArgs e)
        {
            int quantity_num = Convert.ToInt32(quantity.Text);
            if (quantity_num > 1)
                quantity_num--;

            quantity.Text = Convert.ToString(quantity_num);
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void clickCart(object sender, EventArgs e)
        {
            this.Close();
            Cart cart = new Cart();
            cart.Show();
        }

        private void clickBack(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            browse.Show();
            this.Close();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void clickUser(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Close();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
            panel1.VerticalScroll.Value = 0;
            loadData();
            loadSameBrand();
            loadSameGroup();
        }

        private void clickAboutUs(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string truyVan = "DatHang";
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@idSP", SqlDbType.Char).Value = _idSP;
                cmd.Parameters.Add("@idKH", SqlDbType.Char).Value = StartUp.id;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = Convert.ToInt32(quantity.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm vào giỏ hàng.", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductPage product2 = new ProductPage();
            int i = dataGridView2.CurrentCell.RowIndex;
            product2.IDSP = dt1.Rows[i]["SP_ID"].ToString();
            product2.Show();
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductPage product1 = new ProductPage();
            int i = dataGridView1.CurrentCell.RowIndex;
            product1.IDSP = dt2.Rows[i]["SP_ID"].ToString();
            product1.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            panel8_Click(sender, e);
        }
    }
}
