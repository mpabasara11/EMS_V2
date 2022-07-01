using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmKeepAttendance : Form
    {

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public frmKeepAttendance()
        {
            InitializeComponent();
        }

        private void frmKeepAttendance_Load(object sender, EventArgs e)
        {
         

            con.Open();
            try
            {


                //create a attendance record if not exist      

                SqlCommand cmd = new SqlCommand("select * from attendance where empNum='" + employeeNumber + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "';", con);
                SqlDataReader dr2 = cmd.ExecuteReader();

                if (dr2.Read())
                {
                    cmd.Dispose();
                    dr2.Close();
                }
                else
                {
                    cmd.Dispose();
                    dr2.Close();

                    String attenId = DateTime.Now.ToString("yyyyMMdd")+employeeNumber;
                    String checkIn = "-";
                    String checkOut = "-";

                    cmd = new SqlCommand("insert into attendance values('" + attenId + "','" + employeeNumber + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + checkIn + "','" + checkOut + "');", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();


                }
             


                //check in label load with current data on db
                cmd = new SqlCommand("select checkIn from attendance where empNum='" + employeeNumber + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ;", con);
                String chkIn = (String)cmd.ExecuteScalar();
                cmd.Dispose();


                lbl_keepAttenCheckIn.Text = chkIn;
             


                 //check out label load with current data on db
                 cmd = new SqlCommand("select checkOut from attendance where empNum='" + employeeNumber + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "';", con);
                String chkOut = (String)cmd.ExecuteScalar();
                cmd.Dispose();

                lbl_keepAttenCheckOut.Text = chkOut;


                //disable check in button if already checked in
                if (lbl_keepAttenCheckIn.Text != "-")
                {
                    btn_keepAttenCheckIn.Enabled = false;
                }

                //disable check out button if already checked out or not chekced in at all
                if (lbl_keepAttenCheckIn.Text == "-")
                {
                    btn_keepAttenCheckOut.Enabled = false;
                }






            }
            catch (SqlException ex) 
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            con.Close();

        }

        private void btn_keepAttenCheckIn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("update attendance set checkIn='" + DateTime.Now.ToString("HH:mm:ss") + "'where empNum='" + employeeNumber + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "';", con);
                int y = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                if (y == 1)
                {
                    // MessageBox.Show("checked in");
                    lbl_keepAttenCheckIn.Text = DateTime.Now.ToString("HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("something went wrong");
                }



            }
            catch (SqlException ex) 
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btn_keepAttenCheckOut_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("update attendance set checkOut='" + DateTime.Now.ToString("HH:mm:ss") + "'where empNum='" + employeeNumber + "' and date='" + DateTime.Now.ToString("yyyy-MM-dd") + "';", con);
                int y = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                if (y == 1)
                {
                    // MessageBox.Show("checked in");
                    lbl_keepAttenCheckOut.Text = DateTime.Now.ToString("HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("something went wrong");
                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}
