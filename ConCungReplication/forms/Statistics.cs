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
    public partial class Statistics : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public Statistics()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageManager homepage = new HomepageManager();
            homepage.Show();
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

        private void clickComparison(object sender, EventArgs e)
        {
            this.Close();
            Comparison comparison = new Comparison();
            comparison.Show();
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

        private void Statistics_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            // Get data top sellers daily
            SqlDataAdapter sda = new SqlDataAdapter("EXEC getTopSellerDaily", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dailyStats.DataSource = dt;

            // Get data top sellers weekly
            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getTopSellerWeekly", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            weeklyStats.DataSource = dt1;

            // Get data top sellers monthly
            SqlDataAdapter sda2 = new SqlDataAdapter("EXEC getTopSellerMonthly", cnn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            monthlyStats.DataSource = dt2;

            // Get data top sellers yearly
            SqlDataAdapter sda3 = new SqlDataAdapter("EXEC getTopSellerYearly", cnn);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            yearlyStats.DataSource = dt3;
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getRevenueMonthly '" + selectYearRevenue2.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            revenueMonthly.DataSource = dt;
        }

        private void dailyStats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string productID = dailyStats.Rows[e.RowIndex].Cells[0].Value.ToString();

                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC getProduct '" + productID + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Display information
                proID.Text = productID;
                productName.Text = dt.Rows[0][1].ToString();
                brandName.Text = dt.Rows[0][5].ToString();
                amountLeft.Text = dt.Rows[0][4].ToString();
                sold.Text = dt.Rows[0][12].ToString();
                category.Text = dt.Rows[0][11].ToString();
                price.Text = dt.Rows[0][2].ToString();
                salesOffPercent.Text = dt.Rows[0][6].ToString();
                
                double baseprice = (Convert.ToDouble(price.Text) / (100 - Convert.ToDouble(salesOffPercent.Text) / 100));
                basePrice.Text = baseprice.ToString();
            }
        }

        private void weeklyStats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string productID = weeklyStats.Rows[e.RowIndex].Cells[0].Value.ToString();

                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC getProduct '" + productID + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Display information
                proID.Text = productID;
                productName.Text = dt.Rows[0][1].ToString();
                brandName.Text = dt.Rows[0][5].ToString();
                amountLeft.Text = dt.Rows[0][4].ToString();
                sold.Text = dt.Rows[0][12].ToString();
                category.Text = dt.Rows[0][11].ToString();
                price.Text = dt.Rows[0][2].ToString();
                salesOffPercent.Text = dt.Rows[0][6].ToString();

                double baseprice = (Convert.ToDouble(price.Text) / (100 - Convert.ToDouble(salesOffPercent.Text) / 100));
                basePrice.Text = baseprice.ToString();
            }
        }

        private void monthlyStats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string productID = monthlyStats.Rows[e.RowIndex].Cells[0].Value.ToString();

                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC getProduct '" + productID + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Display information
                proID.Text = productID;
                productName.Text = dt.Rows[0][1].ToString();
                brandName.Text = dt.Rows[0][5].ToString();
                amountLeft.Text = dt.Rows[0][4].ToString();
                sold.Text = dt.Rows[0][12].ToString();
                category.Text = dt.Rows[0][11].ToString();
                price.Text = dt.Rows[0][2].ToString();
                salesOffPercent.Text = dt.Rows[0][6].ToString();

                double baseprice = (Convert.ToDouble(price.Text) / (100 - Convert.ToDouble(salesOffPercent.Text) / 100));
                basePrice.Text = baseprice.ToString();
            }
        }

        private void yearlyStats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string productID = yearlyStats.Rows[e.RowIndex].Cells[0].Value.ToString();

                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC getProduct '" + productID + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Display information
                proID.Text = productID;
                productName.Text = dt.Rows[0][1].ToString();
                brandName.Text = dt.Rows[0][5].ToString();
                amountLeft.Text = dt.Rows[0][4].ToString();
                sold.Text = dt.Rows[0][12].ToString();
                category.Text = dt.Rows[0][11].ToString();
                price.Text = dt.Rows[0][2].ToString();
                salesOffPercent.Text = dt.Rows[0][6].ToString();

                double baseprice = (Convert.ToDouble(price.Text) / (100 - Convert.ToDouble(salesOffPercent.Text) / 100));
                basePrice.Text = baseprice.ToString();
            }
        }
    }
}
