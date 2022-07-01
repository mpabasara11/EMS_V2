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
    public partial class FrmLeaverequest : Form
    {
        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;






        public FrmLeaverequest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLeaverequest_Load(object sender, EventArgs e)
        {


            //leave balance label load 
            lbl_leavebalancetotcas.Text = Properties.Settings.Default.casual_leaves.ToString();
            lbl_leavebalancetotmed.Text = Properties.Settings.Default.mediacal_leave.ToString();
            lbl_leavebalancetotfml.Text = Properties.Settings.Default.FMLA.ToString();



  
            lbl_LeaveRequestEmpId.Text = employeeNumber;



            //date time pickers default value setting 
            dpicker_LeaveRequestLeaveStartDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            dpicker_LeaveRequestLeaveStartDate.MinDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
            dpicker_LeaveRequestLeaveStartDate.Value = DateTime.Today;

            dpicker_LeaveRequestLeaveEndDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            dpicker_LeaveRequestLeaveEndDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dpicker_LeaveRequestLeaveEndDate.Value = DateTime.Today;



            con.Open();

            try
            {
                //get current year
                SqlCommand cmd = new SqlCommand("select lRecordyear from users where empNum='" + employeeNumber + "';", con);
                int year = (int)cmd.ExecuteScalar();
                cmd.Dispose();


                //getting these values from login form 
                int casual_leaves = Properties.Settings.Default.casual_leaves;
                int medical_leaves = Properties.Settings.Default.mediacal_leave;
                int FLMA = Properties.Settings.Default.FMLA;
                int total_leaves = casual_leaves + medical_leaves;


                //if current year and year in db table doesnt match
                if (DateTime.Now.Year != year)
                {
                    SqlCommand cmd1 = new SqlCommand("update users set lRecordyear='" + DateTime.Now.Year + "', remCasual='" + casual_leaves + "' ,remMedical='" + medical_leaves + "' ,remTotal='" + total_leaves + "' where empNum='" + employeeNumber + "';", con);
                    int i = cmd1.ExecuteNonQuery();

                    cmd1.Dispose();

                    if (i == 1)
                    {




                    }


                }

                else
                {




                }


                SqlCommand cmd2 = new SqlCommand("select remMedical,remCasual,remFMLA from users where empNum='" + employeeNumber + "';", con);
                SqlDataReader r1 = cmd2.ExecuteReader();
                if (r1.Read())
                {
                    int remMedical = (int)r1["remMedical"];
                   int remCasual = (int)r1["remCasual"];
                   int remFml = (int)r1["remFMLA"];


                    //load labels in leave balance
                    lbl_leavebalanceremcas.Text =remCasual.ToString();
                    lbl_leavebalanceremmed.Text = remMedical.ToString();
                    lbl_leavebalanceremfml.Text = remFml.ToString();
                }
                else 
                {
                
                }

                cmd2.Dispose();
                r1.Close();

            }
            catch (SqlException ex)
            {
              
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


          
          con.Close();

            notifier();

        }

        public void notifier()
        {

        


            con.Open();

            try 
            {
              

                ////////////////////////////////////////////////////////////monthly review of casual leaves///////////////////////////////////////////////////////////////////////////

               int[] totalLeaveTakenCas=new int[13];

          
                for (int month=1;month<=12;month++) 
                {
                    String stDate1 = DateTime.Now.Year + "-" +"0"+ month + "-%";
                    String stDate2 = DateTime.Now.Year + "-" + month + "-%";

            
                   
                    SqlCommand cmd = new SqlCommand("select startDate,endDate from leave where leaveType='casual' and (empNum='" + employeeNumber+"' and status='approved') and (startDate like'"+ stDate1 + "' or startDate like'"+stDate2+"')", con);
          
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    do
                    {

                        while (sqlDataReader.Read())
                        {
                            String StartDate = (String)sqlDataReader["startDate"];
                            String endDate = (String)sqlDataReader["endDate"];


                            TimeSpan dayDifference = DateTime.Parse(endDate) - DateTime.Parse(StartDate);
                            int leaveRequestedTotalDays = dayDifference.Days;

                            totalLeaveTakenCas[month] = totalLeaveTakenCas[month] + leaveRequestedTotalDays;

                           
                           
                        }
                    } while (sqlDataReader.NextResult());


                       sqlDataReader.Close();
                       cmd.Dispose();
                    


                }


                int janC = totalLeaveTakenCas[1];
                int febC= totalLeaveTakenCas[2];
                int marchC= totalLeaveTakenCas[3];
                int aprilC = totalLeaveTakenCas[4];
                int mayC = totalLeaveTakenCas[5];
                int junC = totalLeaveTakenCas[6];
                int julC = totalLeaveTakenCas[7];
                int augC = totalLeaveTakenCas[8];
                int sepC = totalLeaveTakenCas[9];
                int octC = totalLeaveTakenCas[10];
                int novC = totalLeaveTakenCas[11];
                int decC = totalLeaveTakenCas[12];


                int remainingMonthsThisYear1 =13- DateTime.Now.Month;

                int averageCasPerMonth = Properties.Settings.Default.casual_leaves / remainingMonthsThisYear1;

                //load leave balance label
                lbl_leavebalanceavgcas.Text = averageCasPerMonth.ToString();

                int totalTakenCas= janC+ febC+ marchC+aprilC+mayC+junC+julC+augC+sepC+octC+novC+decC;


               
                //load leave balance label
                lbl_leavebalancetakencas.Text= totalLeaveTakenCas[DateTime.Now.Month].ToString();



                int isCasOver = 0;

                if (Properties.Settings.Default.casual_leaves == totalTakenCas)
                {
                    notifyIcon1.Icon = Properties.Resources.warning;
                    notifyIcon1.Text = "My FlightZone EMS";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Casual Leaves Limit Reached";
                    notifyIcon1.BalloonTipText = "You have no casual leaves left.Please Contact HR for further leaves with No pay";
                    notifyIcon1.ShowBalloonTip(5000);


               

                    isCasOver =1;
                }

                else if (Properties.Settings.Default.casual_leaves * 3 / 4 < totalTakenCas)
                {
                  
                    notifyIcon1.Icon = Properties.Resources.warning;
                    notifyIcon1.Text = "My FlightZone EMS";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Casual Leaves";
                    notifyIcon1.BalloonTipText = "More than 3/4 of your casual leaves are over";
                    notifyIcon1.ShowBalloonTip(5000);

                }
                else if (Properties.Settings.Default.casual_leaves * 2 / 4 < totalTakenCas)
                {

                  
                    notifyIcon1.Icon = Properties.Resources.warning;
                    notifyIcon1.Text = "My FlightZone EMS";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Casual Leaves";
                    notifyIcon1.BalloonTipText = "More than 1/2 of your casual leaves are over";
                    notifyIcon1.ShowBalloonTip(5000);

                }



                if ((averageCasPerMonth < totalLeaveTakenCas[DateTime.Now.Month])&& isCasOver ==0)
                {

                    
                    notifyIcon1.Icon = Properties.Resources.warning;
                    notifyIcon1.Text = "My FlightZone EMS";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "Monthly Average Casual Leaves";
                    notifyIcon1.BalloonTipText = "You have passed your average casual leave count for this month.You may have no pays in next few months if you don’t manage your leaves properly";
                    notifyIcon1.ShowBalloonTip(5000);

                }



                ////////////////////////////////////////////////////////////////////monthly review of medical leaves///////////////////////////////////////////////////////

                int[] totalLeaveTakenMed = new int[13];


                for (int month = 1; month <= 12; month++)
                {
                    String stDate1 = DateTime.Now.Year + "-" + "0" + month + "-%";
                    String stDate2 = DateTime.Now.Year + "-" + month + "-%";



                    SqlCommand cmd = new SqlCommand("select startDate,endDate from leave where leaveType='medical' and (empNum='" + employeeNumber + "' and status='approved') and (startDate like'" + stDate1 + "' or startDate like'" + stDate2 + "')", con);

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    do
                    {

                        while (sqlDataReader.Read())
                        {
                            String StartDate = (String)sqlDataReader["startDate"];
                            String endDate = (String)sqlDataReader["endDate"];


                            TimeSpan dayDifference = DateTime.Parse(endDate) - DateTime.Parse(StartDate);
                            int leaveRequestedTotalDays = dayDifference.Days;

                            totalLeaveTakenMed[month] = totalLeaveTakenMed[month] + leaveRequestedTotalDays;



                        }
                    } while (sqlDataReader.NextResult());


                    sqlDataReader.Close();
                    cmd.Dispose();



                }


                int janM = totalLeaveTakenMed[1];
                int febM = totalLeaveTakenMed[2];
                int marchM = totalLeaveTakenMed[3];
                int aprilM = totalLeaveTakenMed[4];
                int mayM = totalLeaveTakenMed[5];
                int junM = totalLeaveTakenMed[6];
                int julM = totalLeaveTakenMed[7];
                int augM = totalLeaveTakenMed[8];
                int sepM = totalLeaveTakenMed[9];
                int octM = totalLeaveTakenMed[10];
                int novM = totalLeaveTakenMed[11];
                int decM = totalLeaveTakenMed[12];

                int remainingMonthsThisYear2 = 13 - DateTime.Now.Month;

                int averageMedPerMonth = Properties.Settings.Default.mediacal_leave / remainingMonthsThisYear2;


                //load leave balance label
                lbl_leavebalanceavgMed.Text = averageMedPerMonth.ToString();

                int totalTakenMed = janM + febM + marchM + aprilM + mayM + junM + julM + augM + sepM + octM + novM + decM;

                //load leave balance label
                lbl_leavebalancetakenMed.Text = totalLeaveTakenMed[DateTime.Now.Month].ToString();

                int isMedOver = 0;


              

                if (Properties.Settings.Default.mediacal_leave == totalTakenMed)
                {
                    notifyIcon2.Icon = Properties.Resources.warning;
                    notifyIcon2.Text = "My FlightZone EMS";
                    notifyIcon2.Visible = true;
                    notifyIcon2.BalloonTipTitle = "Medical Leaves Limit Reached";
                    notifyIcon2.BalloonTipText = "You have no medical leaves left.Please Contact HR for further leaves with No pay";
                    notifyIcon2.ShowBalloonTip(5000);
                    

                    isMedOver = 1;
                }
                else if (Properties.Settings.Default.mediacal_leave * 3 / 4 < totalTakenMed)
                {
                    notifyIcon2.Icon = Properties.Resources.warning;
                    notifyIcon2.Text = "My FlightZone EMS";
                    notifyIcon2.Visible = true;
                    notifyIcon2.BalloonTipTitle = "Medical Leaves";
                    notifyIcon2.BalloonTipText = "More than 3/4 of your medical leaves are over";
                    notifyIcon2.ShowBalloonTip(5000);
                    

                }
                else if (Properties.Settings.Default.mediacal_leave * 2 / 4 < totalTakenMed)
                {
                    notifyIcon2.Icon = Properties.Resources.warning;
                    notifyIcon2.Text = "My FlightZone EMS";
                    notifyIcon2.Visible = true;
                    notifyIcon2.BalloonTipTitle = "Medical Leaves";
                    notifyIcon2.BalloonTipText = "More than 1/2 of your medical leaves are over";
                    notifyIcon2.ShowBalloonTip(5000);
                    

                }


                if ((averageMedPerMonth < totalLeaveTakenMed[DateTime.Now.Month])&& isMedOver == 0)
                {
                    notifyIcon2.Icon = Properties.Resources.warning;
                    notifyIcon2.Text = "My FlightZone EMS";
                    notifyIcon2.Visible = true;
                    notifyIcon2.BalloonTipTitle = "Monthly Average Medical Leaves";
                    notifyIcon2.BalloonTipText = "You have passed your average medical leave count for this month.You may have no pays in next few months if you don’t manage your leaves properly";
                    notifyIcon2.ShowBalloonTip(5000);
                  



                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
            con.Close();
        }



        private void btn_LeaveRequestSubmit_Click(object sender, EventArgs e)
        {
            int leave_eligible_daysDB=0;


            con.Open();
            try
            {
                string leaveType = "";



                if (cmb_LeaveRequestLeaveType.SelectedIndex == 0)
                {
                   SqlCommand cmd = new SqlCommand("select remCasual from users where empNum='" + employeeNumber + "';", con);
                    leaveType = "casual";

                    leave_eligible_daysDB = (int)cmd.ExecuteScalar();
                    cmd.Dispose();
                }


                else if (cmb_LeaveRequestLeaveType.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select remMedical from users where empNum='" + employeeNumber + "';", con);
                    leaveType = "medical";

                   leave_eligible_daysDB = (int)cmd.ExecuteScalar();
                    cmd.Dispose();
                }
                else if (cmb_LeaveRequestLeaveType.SelectedIndex == 2)
                {
                    SqlCommand cmd = new SqlCommand("select remFMLA from users where empNum='" + employeeNumber + "';", con);
                    leaveType = "FMLA";

                    leave_eligible_daysDB = (int)cmd.ExecuteScalar();
                    cmd.Dispose();
                }


                TimeSpan dayDifference = dpicker_LeaveRequestLeaveEndDate.Value - dpicker_LeaveRequestLeaveStartDate.Value;
                int number_of_leaves_selected = dayDifference.Days;


         


                //validate

                if (cmb_LeaveRequestLeaveType.SelectedIndex==-1)
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.IsBalloon = true;
                    t.UseAnimation = true;
                    t.SetToolTip(cmb_LeaveRequestLeaveType, "warning");
                    t.Show("Select A Leave Type", cmb_LeaveRequestLeaveType, 2000);
                }
                else if (number_of_leaves_selected == 0)
                {

                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.IsBalloon = true;
                    t.UseAnimation = true;
                    t.SetToolTip(dpicker_LeaveRequestLeaveEndDate, "warning");
                    t.Show("Zero Leave dates Selected", dpicker_LeaveRequestLeaveEndDate, 2000);
                }
                else if (leave_eligible_daysDB < number_of_leaves_selected)
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.IsBalloon = true;
                    t.UseAnimation = true;
                    t.SetToolTip(dpicker_LeaveRequestLeaveEndDate, "warning");
                    t.Show("Selected Leave days are not avilable for you", dpicker_LeaveRequestLeaveEndDate, 2000);
                }

                else if (rickTextb_LeaveRequestReason.Text == "")
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.IsBalloon = true;
                    t.UseAnimation = true;
                    t.SetToolTip(rickTextb_LeaveRequestReason, "warning");
                    t.Show("Reason Field cannot be empty", rickTextb_LeaveRequestReason, 2000);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into leave values('" + DateTime.Now.ToString("yyyyMMddHHmmss") + "','" + employeeNumber + "','" + leaveType + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + dpicker_LeaveRequestLeaveStartDate.Value.ToString("yyyy-MM-dd") + "','" + dpicker_LeaveRequestLeaveEndDate.Value.ToString("yyyy-MM-dd") + "','" + rickTextb_LeaveRequestReason.Text + "','" + "pending" + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    //success
                    if (i == 1)
                    {

                        //checking remaining total leaves
                        SqlCommand cmd1 = new SqlCommand("select remTotal from users where empNum='" + employeeNumber + "';", con);
                        int total_leave_eligible_daysDB = (int)cmd1.ExecuteScalar();
                        cmd1.Dispose();

                        //checking remaining casual leaves
                        SqlCommand cmd2 = new SqlCommand("select remCasual from users where empNum='" + employeeNumber + "';", con);
                        int casual_leave_eligible_daysDB = (int)cmd2.ExecuteScalar();
                        cmd2.Dispose();


                        //checking remaining medical leaves
                        SqlCommand cmd3 = new SqlCommand("select remMedical from users where empNum='" + employeeNumber + "';", con);
                        int medical_leave_eligible_daysDB = (int)cmd3.ExecuteScalar();
                        cmd3.Dispose();

                        //checking remaining FMLA leaves
                        SqlCommand cmd4 = new SqlCommand("select remFMLA from users where empNum='" + employeeNumber + "';", con);
                        int FMLA_leave_eligible_daysDB = (int)cmd4.ExecuteScalar();
                        cmd4.Dispose();






                        //update remaining leave info on db(casual leaves)
                        if (cmb_LeaveRequestLeaveType.SelectedIndex == 0)
                        {
                            cmd = new SqlCommand("update users set remCasual='" + (casual_leave_eligible_daysDB - number_of_leaves_selected) + "',remTotal='" + (total_leave_eligible_daysDB - number_of_leaves_selected) + "' where empNum='" + employeeNumber + "';", con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();


                        }


                        //update remaining leave info on db(medical leaves)
                        else if (cmb_LeaveRequestLeaveType.SelectedIndex == 1)
                        {
                            cmd = new SqlCommand("update users set remMedical='" + (medical_leave_eligible_daysDB - number_of_leaves_selected) + "',remTotal='" + (total_leave_eligible_daysDB - number_of_leaves_selected) + "' where empNum='" + employeeNumber + "';", con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();


                        }
                        //update remaining leave info on db(FMLA)
                        else if (cmb_LeaveRequestLeaveType.SelectedIndex == 2)
                        {
                            cmd = new SqlCommand("update users set remFMLA='" + (FMLA_leave_eligible_daysDB - number_of_leaves_selected) + "' where empNum='" + employeeNumber + "';", con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();


                        }

                        MessageBox.Show(this, "Leave Requested Succesfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        //leave type combo box default value
                        cmb_LeaveRequestLeaveType.SelectedIndex = 0;

                        //reset date time pickers
                        dpicker_LeaveRequestLeaveStartDate.Value = DateTime.Today;
                        dpicker_LeaveRequestLeaveEndDate.Value = DateTime.Today;

                        //reset reason ricktextbox
                        rickTextb_LeaveRequestReason.Text = "";
                    }

                    else
                    {
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
         
            }


          con.Close();

        }

        private void dpicker_LeaveRequestLeaveStartDate_ValueChanged(object sender, EventArgs e)
        {

            if (cmb_LeaveRequestLeaveType.SelectedIndex == 0)
            {
                dpicker_LeaveRequestLeaveEndDate.MinDate = dpicker_LeaveRequestLeaveStartDate.Value;
            }
            else if (cmb_LeaveRequestLeaveType.SelectedIndex == 1)
            {
                dpicker_LeaveRequestLeaveEndDate.MinDate = dpicker_LeaveRequestLeaveStartDate.Value;
            }
            else if (cmb_LeaveRequestLeaveType.SelectedIndex == 2) 
            {

              

                dpicker_LeaveRequestLeaveEndDate.Value = dpicker_LeaveRequestLeaveStartDate.Value.AddDays(+Properties.Settings.Default.FMLA);

            }

        

        }

        private void cmb_LeaveRequestLeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_LeaveRequestLeaveType.SelectedIndex == 0)
            {
                dpicker_LeaveRequestLeaveEndDate.Enabled = true;

                //date time pickers default value setting 
                dpicker_LeaveRequestLeaveStartDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
                dpicker_LeaveRequestLeaveStartDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dpicker_LeaveRequestLeaveStartDate.Value = DateTime.Today;

                dpicker_LeaveRequestLeaveEndDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
                dpicker_LeaveRequestLeaveEndDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dpicker_LeaveRequestLeaveEndDate.Value = DateTime.Today;

            }
            else if (cmb_LeaveRequestLeaveType.SelectedIndex == 1)
            {
                dpicker_LeaveRequestLeaveEndDate.Enabled = true;

                //date time pickers default value setting 
                dpicker_LeaveRequestLeaveStartDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
                dpicker_LeaveRequestLeaveStartDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dpicker_LeaveRequestLeaveStartDate.Value = DateTime.Today;

                dpicker_LeaveRequestLeaveEndDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
                dpicker_LeaveRequestLeaveEndDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dpicker_LeaveRequestLeaveEndDate.Value = DateTime.Today;

            }
            else if(cmb_LeaveRequestLeaveType.SelectedIndex == 2)
            {

                MessageBox.Show(this, "Since Family and Medical Leave Act a One time Leave.All your available " + Properties.Settings.Default.FMLA + "will be deducted at once!", "Please Aware", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dpicker_LeaveRequestLeaveEndDate.Enabled = false;



                //date time pickers default value setting 
                dpicker_LeaveRequestLeaveStartDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
                dpicker_LeaveRequestLeaveStartDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dpicker_LeaveRequestLeaveStartDate.Value = DateTime.Today;

                dpicker_LeaveRequestLeaveEndDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
                dpicker_LeaveRequestLeaveEndDate.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dpicker_LeaveRequestLeaveEndDate.Value = DateTime.Today;
            }


         

        }

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
