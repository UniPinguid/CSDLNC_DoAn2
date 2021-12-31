using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class Discounts : Form
    {
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
    }
}
