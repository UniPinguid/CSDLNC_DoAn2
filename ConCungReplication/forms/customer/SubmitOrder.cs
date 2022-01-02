using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class SubmitOrder : Form
    {
        public SubmitOrder()
        {
            InitializeComponent();
        }

        private void clickViewPurchaseHistory(object sender, EventArgs e)
        {
            this.Close();
            PurchaseHistory purchaseHistory = new PurchaseHistory();
            purchaseHistory.Show();
        }

        private void clickToHomepage(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
