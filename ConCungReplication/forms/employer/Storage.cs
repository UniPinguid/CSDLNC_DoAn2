using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace ConCungReplication
{
    public partial class Storage : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        void LoadProduct(int act)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "select SP_ID, TenSP, SLTon from SANPHAM";
            if (act == 2)
            {
                string ProductName = textBox1.Text;
                truyVan += " where TenSP like N'%" + ProductName + "%'";
            }
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

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

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageEmployer homepage = new HomepageEmployer();
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

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter product mame");
            }
            else
            {
                LoadProduct(2);
            }


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            string ID = dt.Rows[i]["SP_ID"].ToString();
            string storage = dt.Rows[i]["SLTon"].ToString();

            label15.Text = storage;
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "select SP_ID, TenSP, SLTon from SANPHAM";
            truyVan += " where SP_ID = '" + ID + "'";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            string ID = dt.Rows[i]["SP_ID"].ToString();

            ProductPageEmployer product = new ProductPageEmployer();
            product.ShowDialog();
            this.Close();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            LoadProduct(1);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LoadProduct(1);
            label15.Text = "";
        }
    }
}
