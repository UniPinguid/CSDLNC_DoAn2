using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void incrementQuantity(object sender, EventArgs e)
        {
            int quantity_num = Convert.ToInt32(quantity.Text);
            quantity_num++;

            quantity.Text = Convert.ToString(quantity_num);
        }

        private void decrementQuantity(object sender, EventArgs e)
        {
            int quantity_num = Convert.ToInt32(quantity.Text);
            if (quantity_num > 1)
                quantity_num--;

            quantity.Text = Convert.ToString(quantity_num);
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void clickCart(object sender, EventArgs e)
        {
            this.Close();
            Cart cart = new Cart();
            cart.Show();
        }
    }
}
