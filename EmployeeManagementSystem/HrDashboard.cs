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
    public partial class HrDashboard : Form
    { //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public HrDashboard()
        {
            InitializeComponent();
        }

        private void tab_leavemanage_Click(object sender, EventArgs e)
        {
         
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_requestleave_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_authorize_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_leavestatus_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_training_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_initiated_Click(object sender, EventArgs e)
        {
        
        }

        private void btn_addpay_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_mypay_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.TopLevel = false;
            pnhrdash.Controls.Add(frmHome);
            frmHome.BringToFront();
            frmHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmleavemanagement frm = new frmleavemanagement();
            frm.TopLevel = false;
            pnhrdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmKeepAttendance frm = new frmKeepAttendance();
            frm.TopLevel = false;
            pnhrdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmmanagepayslip frm = new frmmanagepayslip();
            frm.TopLevel = false;
            pnhrdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmResignations frm = new frmResignations();
            frm.TopLevel = false;
            pnhrdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmmanagesurvey frm = new frmmanagesurvey();
            frm.TopLevel = false;
            pnhrdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HrDashboard_Load(object sender, EventArgs e)
        {
            String empName;

            FrmHome frmHome = new FrmHome();
            frmHome.TopLevel = false;
            pnhrdash.Controls.Add(frmHome);
            frmHome.BringToFront();
            frmHome.Show();


            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select empName from users where empNum='" + employeeNumber + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    empName = (String)dr["empName"];


                    dr.Close();
                    cmd.Dispose();


                    lbl_hrDashName.Text = empName;
                    lbl_hrDashId.Text = employeeNumber;



                    if (Regex.IsMatch(employeeNumber, @"^[mM][0-9]*[0-9]$"))
                    {
                        lbl_hrDashPosition.Text = "Manager";

                    }
                    if (Regex.IsMatch(employeeNumber, @"^[eE][0-9]*[0-9]$"))
                    {
                        lbl_hrDashPosition.Text = "Employee";

                    }
                    if (Regex.IsMatch(employeeNumber, @"^[hH][0-9]*[0-9]$"))
                    {

                        lbl_hrDashPosition.Text = "HR";
                    }
                    if (Regex.IsMatch(employeeNumber, @"^[aA][0-9]*[0-9]$"))
                    {
                        lbl_hrDashPosition.Text = "HR Manager";

                    }


                }
                else
                {
                    cmd.Dispose();
                    dr.Close();
                }

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            con.Close();


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //sign out 
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmInstructionManagement frm = new frmInstructionManagement();
            frm.TopLevel = false;
            pnhrdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmBasicSettings frm = new frmBasicSettings();
            frm.TopLevel = false;
            pnhrdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
