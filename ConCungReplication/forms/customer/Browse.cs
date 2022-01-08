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
    public partial class Browse : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        void loadData(int act)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT SP_ID, TenSP, Gia, MoTa, ThuongHieu, KhuyenMai,NgayBatDau, NgayKetThuc FROM SANPHAM ";

            if (act == 1)
            {
                truyVan = "AdvancedSearch";
            }

            if (act == 2)
            {
                truyVan += " WHERE TenSP LIKE N'%" + textBox1.Text + "%'";
            }

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            if (act == 1)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@name", SqlDbType.NChar).Value = textBox1.Text;
                string tHieu = checkedListBox1.SelectedIndex.ToString();
                string loai = checkedListBox2.SelectedIndex.ToString();
                cmd.Parameters.Add("@brand", SqlDbType.NChar).Value = tHieu;
                cmd.Parameters.Add("@department", SqlDbType.NChar).Value = loai;
            }
            if (act == 2)
            {
                cmd.CommandType = CommandType.Text;
            }

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
        private void Browse_Load(object sender, EventArgs e)
        {
            loadData(1);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            loadData(2);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            loadData(1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            Close();
        }

        private void clickAboutUs(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }
    }
}
