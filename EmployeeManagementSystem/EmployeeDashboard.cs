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
    public partial class EmployeeDashboard : Form
    {

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public static Panel employeeHomepanel;
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmempleavemanagement frm = new frmempleavemanagement();
            frm.TopLevel = false;
            pnedashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            frmKeepAttendance frm = new frmKeepAttendance();
            frm.TopLevel = false;
            pnedashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMyPaySlip frm = new frmMyPaySlip();
            frm.TopLevel = false;
            pnedashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void pnedashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTalkToHrp1 frm = new frmTalkToHrp1();
            frm.TopLevel = false;
            pnedashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            frmSurvey frm = new frmSurvey();
            frm.TopLevel = false;
            pnedashboard.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmHome frmHome = new FrmHome();
            frmHome.TopLevel = false;
            pnedashboard.Controls.Add(frmHome);
            frmHome.BringToFront();
            frmHome.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

          
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            String empName;

            employeeHomepanel = pnedashboard;

            //load home form 
            FrmHome frmHome = new FrmHome();
            frmHome.TopLevel = false;
            pnedashboard.Controls.Add(frmHome);
            frmHome.BringToFront();
            frmHome.Show();

              con.Open();
            try       
            {
                SqlCommand cmd = new SqlCommand("select empName,jobRole from users where empNum='" + employeeNumber + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    empName = (String)dr["empName"];
                    lbl_empDashPosition.Text = (String)dr["jobRole"];


                    dr.Close();
                    cmd.Dispose();


                    lbl_empDashName.Text = empName;
                    lbl_empDashId.Text = employeeNumber;



                 

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //sign out 
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
