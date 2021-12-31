using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void ContinueClick(object sender, EventArgs e)
        {
            this.Hide();
            OrderPayment receipt = new OrderPayment();
            receipt.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickUser(object sender, EventArgs e)
        {
            this.Close();
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void clickBrowse(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            browse.Show();
            this.Close();
        }
    }
}
