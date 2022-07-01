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
    public partial class frmmanagepayslip : Form
    {
        public frmmanagepayslip()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMyPaySlip frm = new frmMyPaySlip();
            frm.TopLevel = false;
            pnpayslip.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAddpayslips frm = new frmAddpayslips();
            frm.TopLevel = false;
            pnpayslip.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void frmmanagepayslip_Load(object sender, EventArgs e)
        {
            frmMyPaySlip frm = new frmMyPaySlip();
            frm.TopLevel = false;
            pnpayslip.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
