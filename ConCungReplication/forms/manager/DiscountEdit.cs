using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ConCungReplication.forms.manager
{
    public partial class DiscountEdit : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        private string _idSP = "";

        public string IDSP
        { 
            get { return _idSP; }
            set { _idSP = value; }
        }

        void loadData()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT sp.* FROM SANPHAM sp, NhomSP n";
            truyVan += " WHERE spSP_ID LIKE N'%" + _idSP + "%' AND sp.GrSP_ID = n.GrSP_ID";
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;
            using var reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                label9.Text = reader["SP_ID"].ToString();
                label5.Text = reader["TenSP"].ToString();
                label10.Text = reader["TenNhom"].ToString();
                label6.Text = reader["ThuongHieu"].ToString();
                label8.Text = reader["NgayBatDau"].ToString();
                label7.Text = reader["NgayKetThuc"].ToString();
                textBox2.Text = reader["KhuyenMai"].ToString();
                price.Text = reader["Gia"].ToString();
                salesOffPercent.Text = reader["KhuyenMai"].ToString();
                textBox1.Text = label8.Text;
                textBox3.Text=label7.Text;
                label26.Text=price.Text;
                label25.Text=salesOffPercent.Text;

            }
            conn.Close();
        }
        public DiscountEdit()
        {
            InitializeComponent();
        }

        private void DiscountEdit_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void confirmPanel_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "CapNhatKhuyenMai";
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = label9.Text;
            cmd.Parameters.Add("@newGia", SqlDbType.Float).Value = label26.Text;
            cmd.Parameters.Add("@newDiscount",SqlDbType.Float).Value = textBox2.Text;
            cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime2).Value = DateTime.Parse(textBox1.Text);
            cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime2).Value = DateTime.Parse(textBox3.Text);
            cmd.Parameters.Add("@result",SqlDbType.Int).Value = 0;
            cmd.ExecuteNonQuery();
            var result = cmd.Parameters["@result"].Value;
            string mess = "";
            if(result.Equals(0))
            {
                mess = "Cập nhật thất bại.";
            }
            else if(result.Equals(1))
            {
                mess = "Cập nhật thành công.";
            }
            else if(result.Equals(-1))
            {
                mess = "Lỗi hệ thống.";
            }
            MessageBox.Show(mess, "Thông Báo");

        }

        private void label4_Click(object sender, EventArgs e)
        {
            HomepageManager homepageManager = new HomepageManager();
            homepageManager.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Comparison comparison = new Comparison();
            comparison.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            EmployeesPerformance employeesPerformance = new EmployeesPerformance();
            employeesPerformance.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ManagerProfile managerProfile = new ManagerProfile();
            managerProfile.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Discounts discounts = new Discounts();
            discounts.Show();
            this.Close();
        }
    }
}
