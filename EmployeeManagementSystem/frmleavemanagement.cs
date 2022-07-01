using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmleavemanagement : Form
    {

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;


        public frmleavemanagement()
        {
            InitializeComponent();
        }

        private void btn_authorize_Click(object sender, EventArgs e)
        {
            frmAuthoriseleave frm = new frmAuthoriseleave();
            frm.TopLevel = false;
            pnleavemanagement.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btn_requestleave_Click(object sender, EventArgs e)
        {
            FrmLeaverequest frm = new FrmLeaverequest();
            frm.TopLevel = false;
            pnleavemanagement.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btn_leavestatus_Click(object sender, EventArgs e)
        {
            FrmLeavestatus frm = new FrmLeavestatus();
            frm.TopLevel = false;
            pnleavemanagement.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void frmleavemanagement_Load(object sender, EventArgs e)
        {
            // manager
            if (Regex.IsMatch(employeeNumber, @"^[mM][0-9]*[0-9]$"))
            {
                FrmLeaverequest frm = new FrmLeaverequest();
                frm.TopLevel = false;
                pnleavemanagement.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();


            }
            //employee
            else if (Regex.IsMatch(employeeNumber, @"^[eE][0-9]*[0-9]$"))
            {

                btn_requestleave.Enabled = true;
                btn_leavestatus.Enabled = true;
                btn_authorize.Enabled = true;




            }
            // hr
            else if (Regex.IsMatch(employeeNumber, @"^[hH][0-9]*[0-9]$"))
            {
                btn_requestleave.Enabled = true;
                btn_leavestatus.Enabled = true;
                btn_authorize.Enabled = true;



                FrmLeaverequest frm = new FrmLeaverequest();
                frm.TopLevel = false;
                pnleavemanagement.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();
            }
            // hr manager(manager)
            else if (Regex.IsMatch(employeeNumber, @"^[aA][0-9]*[0-9]$"))
            {
                btn_requestleave.Enabled=false;
                btn_leavestatus.Enabled=false;
                btn_authorize.Enabled=true;


                frmAuthoriseleave frm = new frmAuthoriseleave();
                frm.TopLevel = false;
                pnleavemanagement.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }
        }
    }
}
