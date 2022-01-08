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
    public partial class ProductEdit : Form
    {
        private static string pdid = null;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public ProductEdit()
        {
            InitializeComponent();
        }

        private void clickBack(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
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
        

        private void confirmPanel_Click(object sender, EventArgs e)
        {
            pdid = ProductManagement.getid();
            conn = new SqlConnection(connectionString);
            conn.Open();
            cmd = new SqlCommand("editProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            //@ID char(10), @Ten nvarchar(20), @Gia float,
            //@MoTa nvarchar(50), @SLTon int, @ThuongHieu nvarchar(20), @KhuyenMai float, @NgayBatDau datetime,@NgayKetThuc datetime,
            //@GrSP_ID char(10)
            cmd.Parameters.Add(new SqlParameter("@ID", pdid));
            cmd.Parameters.Add(new SqlParameter("@Ten", nameBox.Text));
            cmd.Parameters.Add(new SqlParameter("@Gia", priceBox.Text));
            cmd.Parameters.Add(new SqlParameter("@MoTa", description.Text));
            cmd.Parameters.Add(new SqlParameter("@SLTon", quantityBox.Text));
            cmd.Parameters.Add(new SqlParameter("@ThuongHieu", brandBox.Text));
            cmd.Parameters.Add(new SqlParameter("@KhuyenMai", discountBox.Text));
            cmd.Parameters.Add(new SqlParameter("@NgayBatDau", dcstartBox.Text));
            cmd.Parameters.Add(new SqlParameter("@NgayKetThuc", dcendBox.Text));
            cmd.Parameters.Add(new SqlParameter("@GrSP_ID", groupBox.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Success!");


        }

        private void ProductEdit_Load_1(object sender, EventArgs e)
        {
            pdid = ProductManagement.getid();
            
            if (pdid!= null)
            {
                
                conn = new SqlConnection(connectionString);
                conn.Open();                
                adapter = new SqlDataAdapter("SELECT * FROM sanpham WHERE SP_ID = '" + pdid + "'",conn);
                dt = new DataTable();
                adapter.Fill(dt);
                
                nameBox.Text = dt.Rows[0][1].ToString();
                priceBox.Text = dt.Rows[0][2].ToString();
                description.Text = dt.Rows[0][3].ToString();
                quantityBox.Text = dt.Rows[0][4].ToString();
                brandBox.Text = dt.Rows[0][5].ToString();
                discountBox.Text = dt.Rows[0][6].ToString();
                dcstartBox.Text = dt.Rows[0][7].ToString();
                dcendBox.Text = dt.Rows[0][8].ToString();
                groupBox.Text = dt.Rows[0][9].ToString();
               
            }
           
        }
    }
}