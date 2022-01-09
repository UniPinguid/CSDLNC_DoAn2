using ConCungReplication.forms;
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

namespace ConCungReplication.forms.manager
{

    public partial class ManagerProfile : Form
    {

        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;

        void loadData()
        {
            try

            {

                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string truyVan = "select Ten_NV, KPI_NV, DiaChiNV, PhongBan, Phai_NV, Luong, CMND_NV   ";
                truyVan += "    from NHANVIEN where NV_ID = '" + HomepageManager.ID + "'";
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                textBox5.Text = dt.Rows[0]["Ten_NV"].ToString();
                textBox2.Text = dt.Rows[0]["CMND_NV"].ToString();
                string Gender = dt.Rows[0]["Phai_NV"].ToString();
                textBox3.Text = dt.Rows[0]["DiaChiNV"].ToString();
                KPI.Text = dt.Rows[0]["KPI_NV"].ToString();
                label20.Text = dt.Rows[0]["Luong"].ToString();
                if (Gender == "Nam") GenderSelect.Text = "Male";
                else GenderSelect.Text = "Female";

            }
            catch
            {
                MessageBox.Show("Error! Failed to load your information");

            }

        }


        public ManagerProfile()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (CheckTOS.Checked)
            {
                string TeNV = textBox5.Text;
                string CMND = textBox2.Text;
                string Phai = "";
                string DiaChi = textBox3.Text;
                string str = KPI.Text;
                float kpi = float.Parse(str);
                str = label20.Text;
                int luong = Int32.Parse(str);
                if (GenderSelect.Text == "Male") Phai = "Nam";
                else Phai = "Nữ";

                try
                {
                    string command = "exec UpdateEmployee '" + HomepageManager.ID + "', N'" + TeNV + "', '" + CMND + "', N'" + DiaChi + "', N'" + Phai + "'";

                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    using (SqlCommand cmd = new SqlCommand(command, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("Update Information success");
                    loadData();

                }
                catch
                {
                    MessageBox.Show("Failed to update your information");
                }

            }
            else 
            {
                MessageBox.Show("Error! Failed to load your information");

            }


        }

        private void ManagerProfile_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
