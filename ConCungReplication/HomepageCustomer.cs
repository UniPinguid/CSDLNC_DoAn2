﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class HomepageCustomer : Form
    {
        public HomepageCustomer()
        {
            InitializeComponent();

            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductPage productPage = new ProductPage();
            productPage.ShowDialog();
        }
    }
}
