using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication.forms.employer
{
    public partial class EmployerProfile : Form
    {
        private static string id = null;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string nvid = "NV00616372";
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public EmployerProfile()
        {
            //--NVLouis917710963    	
            //--pw8xygou45928
            //--NV00616372
            InitializeComponent();
        }

        private void EmployerProfile_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM nhanvien WHERE NV_ID = '" + nvid + "'", conn);
            dt = new DataTable();
            adapter.Fill(dt);

            textBox5.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][3].ToString();
            KPI.Text = dt.Rows[0][6].ToString();
            label20.Text = dt.Rows[0][8].ToString();
            textBox3.Text = dt.Rows[0][5].ToString();


        }

        private void label9_Click(object sender, EventArgs e)
        {
            //this.Close();
            ProductManagement pdm = new ProductManagement();
            pdm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //this.Close();
            Storage stg = new Storage();
            stg.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.Close();
            OrderTraces ot = new OrderTraces();
            ot.Show();
        }
    }
}
