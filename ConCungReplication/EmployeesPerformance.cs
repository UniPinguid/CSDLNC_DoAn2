﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class EmployeesPerformance : Form
    {
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
    }
}
