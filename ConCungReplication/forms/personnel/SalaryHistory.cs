using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ConCungReplication
{
    public partial class SalaryHistory : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

        void LoadEmployee(int act, string ID)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            string truyVan = "select * from NHANVIEN ";
            if (act == 2)
            {
                truyVan += " WHERE NV_ID = '" + ID + "'";
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


        void SearchEmployee()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            string truyVan = "select * from NHANVIEN ";
            truyVan += " WHERE Ten_NV LIKE N'%" + search.Text + "%'";

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

        void LoadSalaryHistory(string ID)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            string truyVan = "select * from LichSuLuong where NV_ID = '" + ID + "'";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            dataGridView2.DataSource = dt;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();


        }


        public SalaryHistory()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            HomepagePersonnel homepage = new HomepagePersonnel();
            homepage.Show();
            this.Close();
        }

        private void clickRollcall(object sender, EventArgs e)
        {
            Rollcall rollcall = new Rollcall();
            rollcall.Show();
            this.Close();
        }

        private void clickSales(object sender, EventArgs e)
        {
            SalesByEmployees sales = new SalesByEmployees();
            sales.Show();
            this.Close();
        }

        private void clickRewards(object sender, EventArgs e)
        {
            Rewards rewards = new Rewards();
            rewards.Show();
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

        private void SalaryHistory_Load(object sender, EventArgs e)
        {
            LoadEmployee(1, "");
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                MessageBox.Show("Please enter your name !!");
            }
            else
            {
                SearchEmployee();
            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            string ID = dt.Rows[i]["NV_ID"].ToString();
            if (ID == "")
            {
                return;
            }
            else
            {
                string _ID = "MNV ";
                _ID += dt.Rows[i]["NV_ID"].ToString();
                string _salary = dt.Rows[i]["Luong"].ToString();
                _salary += "đ";
                string _KPI = dt.Rows[i]["KPI_NV"].ToString();
                string _citizenID = dt.Rows[i]["CMND_NV"].ToString();
                string _gender = dt.Rows[i]["Phai_NV"].ToString();
                string _birthday = dt.Rows[i]["NgaySinhNV"].ToString();
                string _department = dt.Rows[i]["PhongBan"].ToString();
                string _name = dt.Rows[i]["Ten_NV"].ToString();

                LoadSalaryHistory(ID);
                LoadEmployee(2, ID);

                KPI.Text = _KPI;
                label28.Text = _salary;
                label27.Text = _ID;
                label26.Text = _name;
                gender.Text = _gender;
                citizenID.Text = _citizenID;
                label22.Text = _birthday;
                label20.Text = _department;
            }

        }
    }
}
