using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class ImportExport : Form
    {
        public ImportExport()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageEmployer homepage = new HomepageEmployer();
            homepage.Show();
        }

        private void clickProducts(object sender, EventArgs e)
        {
            this.Close();
            ProductManagement product = new ProductManagement();
            product.Show();
        }

        private void clickStorage(object sender, EventArgs e)
        {
            this.Close();
            Storage storage = new Storage();
            storage.Show();
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

        private void clickTraces(object sender, EventArgs e)
        {
            this.Close();
            OrderTraces traces = new OrderTraces();
            traces.Show();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            HomepageEmployer employer = new HomepageEmployer();
            employer.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HomepageEmployer employer = new HomepageEmployer();
            employer.Show();
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            Close ();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OrderTraces orderTraces = new OrderTraces();
            orderTraces.Show();
            Close();
        }
    }
}
