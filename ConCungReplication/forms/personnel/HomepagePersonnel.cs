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
    public partial class HomepagePersonnel : Form
    {
        public HomepagePersonnel()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        void loadPersonnel(string idnv)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT * FROM NHANVIEN WHERE NV_ID = '" + idnv + "'";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label26.Text = reader["Ten_NV"].ToString();
                label27.Text = reader["NV_ID"].ToString();
                gender.Text = reader["Phai_NV"].ToString();
                citizenID.Text = reader["CMND_NV"].ToString();
                label22.Text = reader["NgaySinhNV"].ToString();
                label20.Text = reader["PhongBan"].ToString();
                KPI.Text = reader["KPI_NV"].ToString();
                label28.Text = reader["Luong"].ToString();
            }
            conn.Close();
        }
        private void clickRollcall(object sender, EventArgs e)
        {
            Rollcall rollcall = new Rollcall();
            rollcall.Show();
            this.Close();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void clickSales(object sender, EventArgs e)
        {
            SalesByEmployees sales = new SalesByEmployees();
            sales.Show();
            this.Close();
        }

        private void clickSalaryHistory(object sender, EventArgs e)
        {
            SalaryHistory salary = new SalaryHistory();
            salary.Show();
            this.Close();
        }

        private void clickRewards(object sender, EventArgs e)
        {
            Rewards rewards = new Rewards();
            rewards.Show();
            this.Close();
        }

        private void HomepagePersonnel_Load(object sender, EventArgs e)
        {

            loadPersonnel(StartUp.id);
        }
    }
}
