using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class ProductPageEmployer : Form
    {
        public ProductPageEmployer()
        {
            InitializeComponent();
        }

        private void ProductPageEmployer_Load(object sender, EventArgs e)
        {
            this.HorizontalScroll.Enabled = false;
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageEmployer homepage = new HomepageEmployer();
            homepage.Show();
            this.Close();
        }

        private void clickBack(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
