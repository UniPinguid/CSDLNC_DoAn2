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

namespace ConCungReplication.forms.personnel
{
    public partial class EmployeePage : Form
    {


        public static string ID;

        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        public EmployeePage()
        {
            InitializeComponent();
        }

        private void clickBack(object sender, EventArgs e)
        {
            EmployeesList list = new EmployeesList();
            list.Show();
            this.Close();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            string truyVan = "select convert(varchar(10), NgaySinhNV, 101 ) as NgaySinh, Ten_NV, CMND_NV, DiaChiNV, PhongBan, Phai_NV, KPI_NV, Luong, NV_ID   ";
            truyVan += "    from NHANVIEN where NV_ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            if (dt.Rows.Count > 0)
            {
                label13.Text = dt.Rows[0]["NV_ID"].ToString();
                string str = dt.Rows[0]["Phai_NV"].ToString();
                if (str == "Nam") gender.Text = "Male";
                else gender.Text = "Female";
                citizenID.Text = dt.Rows[0]["CMND_NV"].ToString();
                label9.Text = dt.Rows[0]["NgaySinh"].ToString();
                label15.Text = dt.Rows[0]["PhongBan"].ToString();
                KPI.Text = dt.Rows[0]["KPI_NV"].ToString();
                label20.Text = dt.Rows[0]["Luong"].ToString() + "đ";
                label12.Text = dt.Rows[0]["Ten_NV"].ToString();
            }


        }
    }
}
