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
    public partial class frmAuthoriseleave : Form
    {

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public frmAuthoriseleave()
        {
            InitializeComponent();
        }

        private void frmAuthoriseleave_Load(object sender, EventArgs e)
        {
            dataGridViewRefresh();
            dgrid_leaveAuth.BackgroundColor = Color.Lavender;
        }

        private void dataGridViewRefresh()
        {
            con.Open();


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();


                if (Regex.IsMatch(employeeNumber, @"^[mM][0-9]*[0-9]$"))
                {
                    adp = new SqlDataAdapter("select status,leaveId,empNum,leaveType,date,startDate,endDate,reason from leave where empNum like'e%'", con);

                }


                else if (Regex.IsMatch(employeeNumber, @"^[hH][0-9]*[0-9]$"))
                {
                    adp = new SqlDataAdapter("select status,leaveId,empNum,leaveType,date,startDate,endDate,reason from leave where empNum like'm%'", con);
                }


                else if (Regex.IsMatch(employeeNumber, @"^[aA][0-9]*[0-9]$"))
                {
                    adp = new SqlDataAdapter("select status,leaveId,empNum,leaveType,date,startDate,endDate,reason from leave where empNum like'h%'", con);

                }



                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgrid_leaveAuth.DataSource = dt;

                dgrid_leaveAuth.Columns[1].HeaderCell.Value = "Status";
                dgrid_leaveAuth.Columns[2].HeaderCell.Value = "Leave ID";
                dgrid_leaveAuth.Columns[3].HeaderCell.Value = "Employee Number";
                dgrid_leaveAuth.Columns[4].HeaderCell.Value = "Leave Type";
                dgrid_leaveAuth.Columns[5].HeaderCell.Value = "Date";
                dgrid_leaveAuth.Columns[6].HeaderCell.Value = "Leave Start";
                dgrid_leaveAuth.Columns[7].HeaderCell.Value = "Leave End";
                dgrid_leaveAuth.Columns[8].HeaderCell.Value = "Reason";


                dgrid_leaveAuth.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_leaveAuth.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_leaveAuth.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_leaveAuth.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_leaveAuth.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_leaveAuth.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_leaveAuth.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_leaveAuth.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;







            }
            catch (SqlException ex) { }
            catch (Exception ex) { }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                string leave_id = dgrid_leaveAuth.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                string current_status = dgrid_leaveAuth.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();



                if (current_status == "pending")
                {
                    try
                    {

                        DialogResult dialogResult = MessageBox.Show("Do You Want To Approve This Request", "", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update leave set status='Approved' where leaveId='" + leave_id + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            cmd.Dispose();

                            dataGridViewRefresh();


                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update leave set status='Disapproved' where leaveId='" + leave_id + "';", con);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();



                            //update employees remain leaves back to normal cause leave is disaproved
                            SqlCommand cmd1 = new SqlCommand("select startDate,endDate,leaveType,empNum from leave where leaveId='" + leave_id + "';", con);
                            SqlDataReader rd2 = cmd1.ExecuteReader();

                            if (rd2.Read())
                            {

                                String leaveStart = (String)rd2["startDate"];
                                String leaveEnd = (String)rd2["endDate"];
                                String leaveType = (String)rd2["leaveType"];
                                String empNumber = (String)rd2["empNum"];

                                TimeSpan dayDifference = DateTime.Parse(leaveEnd) - DateTime.Parse(leaveStart);
                                int leaveRequestedTotalDays = dayDifference.Days;

                                rd2.Close();
                                cmd1.Dispose();




                                SqlCommand cmd2 = new SqlCommand("select remMedical from users where empNum='" + empNumber + "';", con);
                                int remedical = (int)cmd2.ExecuteScalar();
                                cmd2.Dispose();


                                SqlCommand cmd3 = new SqlCommand("select remCasual from users where empNum='" + empNumber + "';", con);
                                int recasual = (int)cmd3.ExecuteScalar();
                                cmd3.Dispose();





                                if (leaveType == "medical")
                                {
                                    int remainigTotal = recasual + remedical + leaveRequestedTotalDays;
                                    SqlCommand cmd5 = new SqlCommand("update users set remMedical='" + (remedical + leaveRequestedTotalDays) + "',remTotal='" + remainigTotal + "' where empNum='" + empNumber + "';", con);
                                    cmd5.ExecuteNonQuery();
                                    cmd5.Dispose();

                                }
                                else if (leaveType == "casual")
                                {
                                    int remainigTotal = remedical + recasual + leaveRequestedTotalDays;
                                    SqlCommand cmd5 = new SqlCommand("update users set remCasual='" + (recasual + leaveRequestedTotalDays) + "',remTotal='" + remainigTotal + "' where empNum='" + empNumber + "';", con);
                                    cmd5.ExecuteNonQuery();
                                    cmd5.Dispose();

                                }
                                else if (leaveType == "FMLA")
                                {
                                    int remainigTotal = Properties.Settings.Default.FMLA;
                                    SqlCommand cmd5 = new SqlCommand("update users set remFMLA='" + remainigTotal + "' where empNum='" + empNumber + "';", con);
                                    cmd5.ExecuteNonQuery();
                                    cmd5.Dispose();

                                }







                            }
                            else
                            {
                                rd2.Close();
                                cmd1.Dispose();
                            }







                            con.Close();

                            dataGridViewRefresh();


                        }

                        else if (dialogResult == DialogResult.Cancel)
                        {

                            dataGridViewRefresh();
                        }


                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    MessageBox.Show("Feedback Has Been Sent Already");
                }

            }
        }

        private void leaveBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgrid_leaveAuth_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        { }



        private void dgrid_leaveAuth_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

    }
    }

