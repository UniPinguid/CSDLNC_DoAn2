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

namespace ConCungReplication
{
    public partial class PurchaseHistory : Form
    {
        SqlConnection conn;
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        DataTable dt;
        private static string _idHD = "";

        public static string IdHD
        { get { return _idHD; } set { _idHD = value; } }
        public PurchaseHistory()
        {
            InitializeComponent();
        }

        private void clickLogo(object sender, EventArgs e)
        {
            this.Close();
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
        }

        private void clickTest(object sender, EventArgs e)
        {
            this.Close();
            OrderInfo orderInfo = new OrderInfo();
            orderInfo.Show();
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

        private void clickProfile(object sender, EventArgs e)
        {
            this.Close();
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void clickLocation(object sender, EventArgs e)
        {
            this.Close();
            UserLocation location = new UserLocation();
            location.Show();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickHomepage(object sender, EventArgs e)
        {
            HomepageCustomer homepage = new HomepageCustomer();
            homepage.Show();
            this.Close();
        }

        private void clickBrowse(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            browse.Show();
            this.Close();
        }

        private void clickAboutUs(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string truyVan = "SELECT * FROM HOADON WHERE KH_ID LIKE '" + StartUp.id + "'";
                SqlCommand cmd = new SqlCommand(truyVan, conn);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                purchaseHistoryList.DataSource = dt;
                purchaseHistoryList.AutoResizeColumns();
                purchaseHistoryList.AutoResizeRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void purchaseHistoryList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            OrderInfo orderInfo = new OrderInfo();
            orderInfo.Show();
        }
    }
}
