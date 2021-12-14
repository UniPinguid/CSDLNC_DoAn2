using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class OrderPayment : Form
    {
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void clickReturn(object sender, EventArgs e)
        {
            this.Close();
            Cart cart = new Cart();
            cart.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            this.Close();
            // Insert data here
            SubmitOrder submitOrder = new SubmitOrder();
            submitOrder.Show();
        }
    }
}
