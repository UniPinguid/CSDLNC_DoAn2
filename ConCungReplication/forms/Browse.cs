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
    public partial class Browse : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        void loadData()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT SP_ID, TenSP, Gia, MoTa, ThuongHieu, KhuyenMai,NgayBatDau, NgayKetThuc FROM SANPHAM";

            //if(checkedListBox1.CheckedItems.Count > 0)
            //{
            //    truyVan += " WHERE ThuongHieu LIKE N'%"+
            //}

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            int count = dt.Rows.Count;
            if (count == 1 || count == 0)
            {
                label1.Text = count.ToString() + " result found";
            }
            else
            {
                label1.Text = count.ToString() + " results found";
            }
        }
        public Browse()
        {
            InitializeComponent();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
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

        private void doubleClickItem(object sender, DataGridViewCellEventArgs e)
        {
            ProductPage product = new ProductPage();
            int i = dataGridView1.CurrentCell.RowIndex;
            product.IDSP = dt.Rows[i]["SP_ID"].ToString();
            product.Show();
            this.Close();
        }

        private void doubleClickItem(object sender, EventArgs e)
        {
            ProductPage product = new ProductPage();
            int i = dataGridView1.CurrentCell.RowIndex;
            product.IDSP = dt.Rows[i]["SP_ID"].ToString();
            product.Show();
            this.Close();
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
