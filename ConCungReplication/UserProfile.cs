using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void clickPurchase(object sender, EventArgs e)
        {
            this.Close();
            PurchaseHistory purchase = new PurchaseHistory();
            purchase.Show();
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

        private void clickLocation(object sender, EventArgs e)
        {
            this.Close();
            UserLocation userLocation = new UserLocation();
            userLocation.Show();
        }
    }
}
