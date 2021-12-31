using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class SalesByEmployees : Form
    {
        public SalesByEmployees()
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

        private void clickSalaryHistory(object sender, EventArgs e)
        {
            SalaryHistory salaryHistory = new SalaryHistory();
            salaryHistory.Show();
            this.Close();
        }

        private void clickRewards(object sender, EventArgs e)
        {
            Rewards rewards = new Rewards();
            rewards.Show();
            this.Close();
        }
    }
}
