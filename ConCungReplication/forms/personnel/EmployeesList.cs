using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace ConCungReplication.forms.personnel
{

    public partial class EmployeesList : Form
    {

        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        public EmployeesList()
        {
            InitializeComponent();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "select Ten_NV, CMND_NV, Phai_NV, PhongBan, KPI_NV, Luong, NV_ID from NHANVIEN ";
            if (textBox2.Text != "")
            {
                string name = textBox2.Text;
                truyVan += "   where Ten_NV like N'%" + name + "%'";
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

        private void EmployeesList_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "select Ten_NV, CMND_NV, Phai_NV, PhongBan, KPI_NV, Luong, NV_ID from NHANVIEN";
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PersonnelProfile profile = new PersonnelProfile();
            profile.Show();
            this.Close();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeePage employee = new EmployeePage();
            int i = dataGridView1.CurrentCell.RowIndex;
            EmployeePage.ID = dt.Rows[i]["NV_ID"].ToString();
            employee.Show();
            this.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            HomepagePersonnel homepagePersonnel = new HomepagePersonnel();
            homepagePersonnel.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Rollcall rollcall = new Rollcall();
            rollcall.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            EmployeesList employeesList = new EmployeesList();
            employeesList.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Close();
        }
    }
}
