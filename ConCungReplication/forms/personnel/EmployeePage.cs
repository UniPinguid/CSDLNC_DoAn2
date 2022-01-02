using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConCungReplication.forms.personnel
{
    public partial class EmployeePage : Form
    {
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
    }
}
