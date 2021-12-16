using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication
{
    public partial class SignUpFinal : Form
    {
        public SignUpFinal()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your account had been created successfully!","Success");
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
