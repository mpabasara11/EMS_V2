using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmempleavemanagement : Form
    {
        public frmempleavemanagement()
        {
            InitializeComponent();
        }

        private void btn_requestleave_Click(object sender, EventArgs e)
        {
            FrmLeaverequest frm = new FrmLeaverequest();
            frm.TopLevel = false;
            pnemlvmanagement.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void frmempleavemanagement_Load(object sender, EventArgs e)
        {
            FrmLeaverequest frm = new FrmLeaverequest();
            frm.TopLevel = false;
            pnemlvmanagement.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btn_authorize_Click(object sender, EventArgs e)
        {
            FrmLeavestatus frm = new FrmLeavestatus();
            frm.TopLevel = false;
            pnemlvmanagement.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
