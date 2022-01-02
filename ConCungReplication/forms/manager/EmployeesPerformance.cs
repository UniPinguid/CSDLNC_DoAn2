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
    public partial class EmployeesPerformance : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        //act = 1: load form
        //act = 2: search
        void loadData(int act)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT * FROM NHANVIEN ";
            if (act == 2)
            {
                truyVan += " WHERE Ten_NV LIKE '%' + N'" + search.Text + "' + '%'";
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
        }
        void loadEmployee(string idnv)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT * FROM NHANVIEN WHERE NV_ID = '" + idnv + "'";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label5.Text = reader["Ten_NV"].ToString();
                label6.Text = reader["NV_ID"].ToString();
                label7.Text = reader["Phai_NV"].ToString();
                citizenID.Text = reader["CMND_NV"].ToString();
                label8.Text = reader["NgaySinhNV"].ToString();
                label15.Text = reader["PhongBan"].ToString();
                KPI.Text = reader["KPI_NV"].ToString();
            }
            conn.Close();
        }
        public EmployeesPerformance()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageManager homepage = new HomepageManager();
            homepage.Show();
        }

        private void clickStatistics(object sender, EventArgs e)
        {
            this.Close();
            Statistics stats = new Statistics();
            stats.Show();
        }

        private void clickComparison(object sender, EventArgs e)
        {
            this.Close();
            Comparison comparison = new Comparison();
            comparison.Show();
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

        private void clickDiscounts(object sender, EventArgs e)
        {
            Discounts discounts = new Discounts();
            discounts.Show();
            this.Close();
        }

        private void EmployeesPerformance_Load(object sender, EventArgs e)
        {
            loadData(1);
            loadEmployee(StartUp.id);
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            loadData(2);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            string nv = dt.Rows[i]["NV_ID"].ToString();
            if (nv == "")
            {
                return;
            }
            loadEmployee(nv);
        }
    }
}
