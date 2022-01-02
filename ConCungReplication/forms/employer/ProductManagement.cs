﻿using ConCungReplication.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class ProductManagement : Form
    {
        private static string id = null;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public ProductManagement()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("SELECT * FROM SANPHAM", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageEmployer homepage = new HomepageEmployer();
            homepage.Show();
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

        private void addPanel_Click(object sender, EventArgs e)
        {   
            
            ProductEdit addProduct = new ProductEdit();
            addProduct.Show();
            
        }
        static public string getid()
        {
            return id;
        }

       
        private void editPanel_Click(object sender, EventArgs e)
        {
            //id = "false";
            ProductEdit editProduct = new ProductEdit();
            editProduct.Show();
        }
    }
}
