using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication.forms
{
    public partial class OrderInfoEmployer : Form
    {
        public OrderInfoEmployer()
        {
            InitializeComponent();
        }

        private void clickBack(object sender, EventArgs e)
        {
            OrderTraces traces = new OrderTraces();
            traces.Show();
            this.Close();
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageEmployer homepage = new HomepageEmployer();
            homepage.Show();
            this.Close();
        }

        private void productList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductPageEmployer product = new ProductPageEmployer();
            product.ShowDialog();
        }
    }
}
