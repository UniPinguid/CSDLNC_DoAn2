using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ConCungReplication
{
    public partial class HomepagePersonnel : Form
    {
        public static string name = "";
        public static string personnelID = "";
        public static string gender = "";
        public static string citizenID = "";
        public static string birthday = "";
        public static string department = "";
        public static string kpi = "";
        public static string salary = "";

        public HomepagePersonnel()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        void loadPersonnel(string idnv)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "SELECT * FROM NHANVIEN WHERE NV_ID = '" + idnv + "'";

            SqlCommand cmd = new SqlCommand(truyVan, conn);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader["Ten_NV"].ToString();
                personnelID = reader["NV_ID"].ToString();
                gender = reader["Phai_NV"].ToString();
                citizenID = reader["CMND_NV"].ToString();
                birthday = reader["NgaySinhNV"].ToString();
                department = reader["PhongBan"].ToString();
                kpi = reader["KPI_NV"].ToString();
                salary = reader["Luong"].ToString();
            }
            conn.Close();
        }
        private void clickRollcall(object sender, EventArgs e)
        {
            Rollcall rollcall = new Rollcall();
            rollcall.Show();
            this.Close();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out Verification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void HomepagePersonnel_Load(object sender, EventArgs e)
        {

            loadPersonnel(StartUp.id);
        }
    }
}
