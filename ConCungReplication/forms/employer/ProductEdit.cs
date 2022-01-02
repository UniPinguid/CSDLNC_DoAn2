using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication.forms
{
    public partial class ProductEdit : Form
    {
        public ProductEdit()
        {
            InitializeComponent();
        }

        private void clickBack(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
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

        private void confirmPanel_Click(object sender, EventArgs e)
        {
            bool v = ProductManagement.getaddnew();
            if (v == true)
            {

            }
            else
            {

            }
        }
    }
}