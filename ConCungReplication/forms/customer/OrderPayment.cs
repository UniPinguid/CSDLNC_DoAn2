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
using System.Linq;

namespace ConCungReplication
{
    
    public partial class OrderPayment : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        private static Random random = new Random();
        private static string hdid = "";
        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        void loadCart()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string truyVan = "SELECT * FROM KH_DATHANG WHERE KH_ID = '" + StartUp.id + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        void loadInfo()
        {
            customerName.Text = Cart._nguoiNhan;
            address.Text = Cart._address;
            subtotal.Text = Cart._subTotal;
            discount.Text= Cart._discount;
            label2.Text = Cart._total;
        }
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            // Insert data here
            try
            {
                
                while (true)
                {
                    conn = new SqlConnection(ConnectionString);
                    conn.Open(); 
                    string idHoaDon = "HE" + RandomString(8);
                    hdid = idHoaDon;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "TaoHoaDon";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@diaChi", SqlDbType.Char).Value = address.Text;
                    cmd.Parameters.Add("@idKH", SqlDbType.Char).Value = StartUp.id;
                    cmd.Parameters.Add("@idHD", SqlDbType.Char).Value = idHoaDon;
                    cmd.Parameters.Add("@result", SqlDbType.Int).Value = 0;
                    cmd.Parameters["@result"].Direction = ParameterDirection.InputOutput;
                    cmd.ExecuteNonQuery();
                    var result = cmd.Parameters["@result"].Value;
                    if (result.Equals(1))
                    {
                        conn.Close();
                        SqlCommand cmd2 = new SqlCommand();
                        conn = new SqlConnection(ConnectionString);
                        cmd2.Connection = conn;
                        conn.Open();
                        cmd2.CommandText = "ThemChiTietHoaDon";
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@idKH", SqlDbType.Char).Value = StartUp.id;
                        cmd2.Parameters.Add("@idHD", SqlDbType.Char).Value = idHoaDon;
                        cmd2.Parameters.Add("@result", SqlDbType.Int).Value = 0;
                        cmd2.Parameters["@result"].Direction = ParameterDirection.InputOutput;
                        cmd2.ExecuteNonQuery();
                        var res = cmd2.Parameters["@result"].Value;
                        if (res.Equals(1))
                        {
                            //MessageBox.Show("Đặt hàng thàng công", "Thông Báo");
                            conn.Close();
                            SubmitOrder submitOrder1 = new SubmitOrder();
                            submitOrder1.Show();
                            return;
                        }
                        else if(res.Equals(0))
                        {
                            conn.Close();
                            MessageBox.Show("Giỏ hàng trống", "Thông Báo");
                            return;
                        }
                        else if(res.Equals(-1))
                        {
                            conn.Close();
                            MessageBox.Show("Lỗi Hệ Thống", "Thông Báo");
                            return;
                        }
                    }
                    else if (result.Equals(-1))
                    {
                        MessageBox.Show("Lỗi Hệ Thống", "Thông Báo");
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
                return;
            }
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
            ////string hdid = Cart.gethdid();
            //string hdid = "HD00003350";
            //conn = new SqlConnection(connectionString);
            //conn.Open();
            //adapter = new SqlDataAdapter("exec SELECT * FROM CT_HOADON where HD_ID = '" + hdid +"'", conn);
            //dt = new DataTable();
            //adapter.Fill(dt);
            //inCartData.DataSource = dt;
            loadCart();
            loadInfo();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            Close();
        }
    }
}
