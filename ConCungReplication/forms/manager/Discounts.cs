
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
using ConCungReplication.forms.manager;

namespace ConCungReplication
{
    public partial class Discounts : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        void loadData(int act)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT SP_ID, TenSP, Gia, MoTa, ThuongHieu, KhuyenMai,NgayBatDau, NgayKetThuc FROM SANPHAM ";


            if (act == 2)
            {
                truyVan += " WHERE TenSP LIKE N'%" + textBox1.Text + "%'";
            }

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
                label11.Text = count.ToString() + " result found";
            }
            else
            {
                label11.Text = count.ToString() + " results found";
            }
        }

        public Discounts()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            HomepageManager homepage = new HomepageManager();
            homepage.Show();
            this.Close();
        }

        private void clickStatistics(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.Show();
            this.Close();
        }

        private void clickComparison(object sender, EventArgs e)
        {
            Comparison comparison = new Comparison();
            comparison.Show();
            this.Close();
        }

        private void clickEmployees(object sender, EventArgs e)
        {
            EmployeesPerformance employees = new EmployeesPerformance();
            employees.Show();
            this.Close();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            loadData(2);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            loadData(1);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DiscountEdit discountEdit = new DiscountEdit();
            int i = dataGridView1.CurrentCell.RowIndex;
            discountEdit.IDSP = dt.Rows[i]["SP_ID"].ToString();
            discountEdit.Show();
            Close();

            
        }
    }
}
