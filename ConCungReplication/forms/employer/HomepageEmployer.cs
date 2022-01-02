using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConCungReplication.forms;

namespace ConCungReplication
{
    public partial class HomepageEmployer : Form
    {
        public HomepageEmployer()
        {
            InitializeComponent();
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

        private void clickProducts(object sender, EventArgs e)
        {
            this.Close();
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
        }

        private void clickStorage(object sender, EventArgs e)
        {
            this.Close();
            Storage storage = new Storage();
            storage.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OrderTraces traces = new OrderTraces();
            traces.Show();
            Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            Close();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
