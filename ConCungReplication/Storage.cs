﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        private void clickProducts(object sender, EventArgs e)
        {
            this.Close();
            ProductManagement product = new ProductManagement();
            product.Show();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageEmployer homepage = new HomepageEmployer();
            homepage.Show();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void clickIE(object sender, EventArgs e)
        {
            this.Close();
            ImportExport ie = new ImportExport();
            ie.Show();
        }

        private void clickTraces(object sender, EventArgs e)
        {
            this.Close();
            OrderTraces traces = new OrderTraces();
            traces.Show();
        }
    }
}
