using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class UserLocation : Form
    {
        public UserLocation()
        {
            InitializeComponent();
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

        private void clickPurchaseHistory(object sender, EventArgs e)
        {
            this.Close();
            PurchaseHistory purchase = new PurchaseHistory();
            purchase.Show();
        }

        private void clickProfile(object sender, EventArgs e)
        {
            this.Close();
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }
    }
}
