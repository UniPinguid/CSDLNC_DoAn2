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
    public partial class Comparison : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt; 
        
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
    }
}
