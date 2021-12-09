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
            this.Close();
            MessageBox.Show("Your account had been created successfully!","Success");
        }
    }
}
