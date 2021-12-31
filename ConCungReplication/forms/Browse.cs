using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void doubleClickItem(object sender, DataGridViewCellEventArgs e)
        {
            ProductPage product = new ProductPage();
            product.Show();
            this.Close();
        }

        private void doubleClickItem(object sender, EventArgs e)
        {
            ProductPage product = new ProductPage();
            product.Show();
            this.Close();
        }
    }
}
