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
using ConCungReplication.forms.manager;

namespace ConCungReplication
{
    public partial class Comparison : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt1;
        DataTable dt2;


        int convertMonth(string month)
        {
            if (month == "0")
                return 0;
            if (month == "January")
            {
                return 1;
            }
            else if (month == "February")
            { return 2; }
            else if (month == "March")
            { return 3; }
            else if (month == "April")
            { return 4; }
            else if (month == "May")
                return 5;
            else if (month == "June")
                return 6;
            else if (month == "July")
                return 7;
            else if (month == "August")
            { return 8; }
            else if (month == "September")
                return 9;
            else if (month == "October")
                return 10;
            else if (month == "November")
            { return 11; }
            else if (month == "December")
                return 12;
            return 0;
        }

        double loadTongDoanhThu(string month, string year)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "";
            truyVan = "TinhDoanhThu";
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@month", SqlDbType.Int).Value = convertMonth(month);
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = Convert.ToInt32(year);

            cmd.Parameters.Add("@tongDoanhThu", SqlDbType.Float).Value = 0;
            cmd.ExecuteNonQuery();

            double totalRevenue = Convert.ToDouble(cmd.Parameters["@tongDoanhThu"].Value);
            conn.Close();
            return totalRevenue;
        }

        int loadSales(string month, string year)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "";
            truyVan = "TinhSales";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();

            cmd.Parameters.Add("@month", SqlDbType.Int).Value = convertMonth(month);
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = Convert.ToInt32(year);

            cmd.Parameters.Add("@tongSale", SqlDbType.Float).Value = 0;

            cmd.ExecuteNonQuery();

            int totalSales = Convert.ToInt32(cmd.Parameters["@tongSale"].Value);

            conn.Close();
            return totalSales;
        }
        void loadData(int act, string month, string year)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "";

            if (month == "0")
            {
                truyVan = "SELECT * FROM HOADON WHERE YEAR(NgayMua) = " + year;
            }
            else
            {
                truyVan = "SELECT * FROM HOADON WHERE MONTH(NgayMua) = " + convertMonth(month).ToString();
                truyVan += " AND YEAR(NgayMua) = " + year;
            }



            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);


            if (act == 1)
            {
                dt1 = new DataTable();
                adapter.Fill(dt1);
                dataGridView1.DataSource = dt1;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();

            }
            else if (act == 2)
            {
                dt2 = new DataTable();
                adapter.Fill(dt2);
                dataGridView2.DataSource = dt2;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoResizeRows();
            }
            conn.Close();
        }

        public Comparison()
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

        private void clickEmployees(object sender, EventArgs e)
        {
            this.Close();
            EmployeesPerformance employees = new EmployeesPerformance();
            employees.Show();
        }

        private void clickDiscounts(object sender, EventArgs e)
        {
            Discounts discounts = new Discounts();
            discounts.Show();
            this.Close();
        }

        private void Comparison_Load(object sender, EventArgs e)
        {

        }

        private void panel14_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            loadData(1, selectMonthRevenue.Text, selectYearRevenue.Text);
            loadData(2, comboBox2.Text, comboBox1.Text);

            double revenueA = loadTongDoanhThu(selectMonthRevenue.Text, selectYearRevenue.Text);
            double revenueB = loadTongDoanhThu(comboBox2.Text, comboBox1.Text);

            int salesA = loadSales(selectMonthRevenue.Text, selectYearRevenue.Text);
            int salesB = loadSales(comboBox2.Text, comboBox1.Text);

            revenue.Text = (revenueB - revenueA).ToString();
            label13.Text = (salesB - salesA).ToString();

            double tiLeRev = revenueB / revenueA * 100.0;
            double tileSales = Convert.ToDouble(salesB) / salesA * 100.0;
            label10.Text = tiLeRev.ToString() + "%";
            label16.Text = tileSales.ToString() + "%";
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            loadData(1, "0", comboBox5.Text);
            loadData(2, "0", comboBox3.Text);

            double revenueA = loadTongDoanhThu("0", comboBox5.Text);
            double revenueB = loadTongDoanhThu("0", comboBox3.Text);

            int salesA = loadSales("0", comboBox5.Text);
            int salesB = loadSales("0", comboBox3.Text);

            label24.Text = (revenueB - revenueA).ToString();
            label20.Text = (salesB - salesA).ToString();

            double tiLeRev = revenueB / revenueA * 100.0;
            double tileSales = Convert.ToDouble(salesB) / salesA * 100.0;
            label19.Text = tiLeRev.ToString() + "%";
            label17.Text = tileSales.ToString() + "%";
        }
    }
}
