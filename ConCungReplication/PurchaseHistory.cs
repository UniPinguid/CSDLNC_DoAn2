using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class PurchaseHistory : Form
    {
        public PurchaseHistory()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickTest(object sender, EventArgs e)
        {
            this.Close();
            OrderInfo orderInfo = new OrderInfo();
            orderInfo.Show();
        }
    }
}
