using ConCungReplication.forms.personnel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class Rollcall : Form
    {
        public Rollcall()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            HomepagePersonnel homepage = new HomepagePersonnel();
            homepage.Show();
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

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepagePersonnel homepage = new HomepagePersonnel();
            homepage.Show();
            this.Close();
        }

        private void clickEmployees(object sender, EventArgs e)
        {
            EmployeesList list = new EmployeesList();
            list.Show();
            this.Close();
        }
    }
}
