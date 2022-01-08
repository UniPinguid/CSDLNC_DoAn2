using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ConCungReplication.forms;
using ConCungReplication.forms.employer;

namespace ConCungReplication
{
    public partial class ImportExport : Form
    {
        private static string id = "";
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt1;
        DataTable dt2;

        void loadData(int act)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT * FROM ";


            if (act == 1)
            {
                truyVan += " DonNhapHang WHERE SP_ID = " + id;
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);

                dt1 = new DataTable();
                adapter1.Fill(dt1);

                conn.Close();

                importList.DataSource = dt1;
                importList.AutoResizeColumns();
                importList.AutoResizeRows();
            }
            if (act == 2)
            {
                truyVan += " XuatHang WHERE SP_ID = " + id;
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);

                dt2 = new DataTable();
                adapter2.Fill(dt2);
                exportList.DataSource = dt2;
                exportList.AutoResizeColumns();
                exportList.AutoResizeRows();
            }
            conn.Close();
        }

        public void loadProduct()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string truyVan = "SELECT * FROM SANPHAM sp, NhomSP gr WHERE sp.SP_ID = '" + id + "' AND sp.GrSP_ID = gr.GrSP_ID";
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;
            var result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                result.Read();
                label7.Text = id;
                productName.Text = result["TenSP"].ToString();
                brand.Text = result["ThuongHieu"].ToString();
                label9.Text = result["TenNhom"].ToString();
            }
        }
        
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

        private void ImportExport_Load(object sender, EventArgs e)
        {
            id = ProductManagement.getid();
            loadData(1);
            loadData(2);
            loadProduct();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            EmployerProfile profile = new EmployerProfile();
            profile.Show();
            Close();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
