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
    public partial class Managerdashboard : Form
    {   //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public static Panel managerHomepanel;

        
        public Managerdashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmKeepAttendance frm = new frmKeepAttendance();
            frm.TopLevel = false;
            pnamanagerdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmleavemanagement frm = new frmleavemanagement();
            frm.TopLevel = false;
            pnamanagerdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMyPaySlip frm = new frmMyPaySlip();
            frm.TopLevel = false;
            pnamanagerdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTalkToHrp1 frm = new frmTalkToHrp1();
            frm.TopLevel = false;
            pnamanagerdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         FrmHome frmHome = new FrmHome();
            frmHome.TopLevel = false;
            pnamanagerdash.Controls.Add(frmHome);
            frmHome.BringToFront();
            frmHome.Show();
        }

        private void Managerdashboard_Load(object sender, EventArgs e)
        {
            managerHomepanel = pnamanagerdash;

            // hr manager(manager)
            if (Regex.IsMatch(employeeNumber, @"^[aA][0-9]*[0-9]$"))
            {
                button3.Enabled = true;

            }

            else { button3.Enabled = false; }



            String empName;
            FrmHome frmHome = new FrmHome();
            frmHome.TopLevel = false;
            pnamanagerdash.Controls.Add(frmHome);
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


                    lbl_managerDashName.Text = empName;
                    lbl_managerDashId.Text = employeeNumber;



                    if (Regex.IsMatch(employeeNumber, @"^[mM][0-9]*[0-9]$"))
                    {
                        lbl_managerDashPosition.Text = "Manager";

                    }
                    if (Regex.IsMatch(employeeNumber, @"^[eE][0-9]*[0-9]$"))
                    {
                        lbl_managerDashPosition.Text = "Employee";

                    }
                    if (Regex.IsMatch(employeeNumber, @"^[hH][0-9]*[0-9]$"))
                    {

                        lbl_managerDashPosition.Text = "HR";
                    }
                    if (Regex.IsMatch(employeeNumber, @"^[aA][0-9]*[0-9]$"))
                    {
                        lbl_managerDashPosition.Text = "HR Manager";

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

        private void button7_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.TopLevel = false;
            pnamanagerdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmResignations frm = new frmResignations();
            frm.TopLevel = false;
            pnamanagerdash.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //sign out 
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
