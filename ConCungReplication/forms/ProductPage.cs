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
        private string _idSP = "";
        public ProductPage()
        {
            InitializeComponent();
        }
        public string IDSP
        {
            get { return _idSP; }
            set { _idSP = value; }
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

        private void clickBack(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            browse.Show();
            this.Close();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void clickUser(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Close();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
            panel1.VerticalScroll.Value = 0;
        }
    }
}
