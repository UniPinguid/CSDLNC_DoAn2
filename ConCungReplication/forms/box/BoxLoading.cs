using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ConCungReplication.forms.box
{
    public partial class BoxLoading : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public BoxLoading()
        {
            InitializeComponent();
        }

        private void BoxLoading_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Enter(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
