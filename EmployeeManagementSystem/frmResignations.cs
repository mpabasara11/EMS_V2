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
using Tweetinvi;


namespace EmployeeManagementSystem
{
 


    public partial class frmResignations : Form
    {
        public object ExceptionHandler { get; private set; }

        public frmResignations()
        {
            InitializeComponent();

           
        }

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;




        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmvacancymanagement_Load(object sender, EventArgs e)
        {
            dgrid_resign.BackgroundColor = Color.Lavender;
            dataGridViewRefresh();
            
        }

        private void dataGridViewRefresh()
        {
            con.Open();


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();


           
                    adp = new SqlDataAdapter("select empNum,empName,gender,empDob,empAddr,jobRole,joinedDate,empMail,empContNum from users where empNum not like'a%'", con);

               



                DataTable dtt = new DataTable();
                adp.Fill(dtt);
                dgrid_resign.DataSource = dtt;


               

                dgrid_resign.Columns[1].HeaderCell.Value = "Employee Number";
                dgrid_resign.Columns[2].HeaderCell.Value = "Name";
                dgrid_resign.Columns[3].HeaderCell.Value = "Gender";
                dgrid_resign.Columns[4].HeaderCell.Value = "Date Of Birth";
                dgrid_resign.Columns[5].HeaderCell.Value = "Residence";
                dgrid_resign.Columns[6].HeaderCell.Value = "Position";
                dgrid_resign.Columns[7].HeaderCell.Value = "Joined Date";
                dgrid_resign.Columns[8].HeaderCell.Value = "Mail";
                dgrid_resign.Columns[9].HeaderCell.Value = "Contact No";



                dgrid_resign.Columns[1].AutoSizeMode= DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_resign.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                // dgrid_resign.Columns[9].Width = 150;







            }
            catch (SqlException ex) { }
            catch (Exception ex) { }

            con.Close();
        }

        private void dgrid_resign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) 
            {
                string empNum = dgrid_resign.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                string empName = dgrid_resign.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                string gender = dgrid_resign.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                string jobRole = dgrid_resign.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                con.Open();



                try 
                {
                SqlCommand cmd=new SqlCommand("select date from resignations where empNum='"+empNum+"'",con);
                  SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        String date = (String)sqlDataReader["date"];

                        sqlDataReader.Close();
                        cmd.Dispose();



                        DialogResult dialogResult=MessageBox.Show(this, "Employee Number " + empNum + " is already in pending resignation list since " + date + " .Do you Want to Remove him From resignation List?", "Already in The List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {


                            SqlCommand cmd1 = new SqlCommand("delete from resignations where empNum='" + empNum + "';",con);
                            int i = cmd1.ExecuteNonQuery();
                            cmd1.Dispose();

                            if (i == 0)
                            {
                                MessageBox.Show(this, "Could not delete the record,please contact system admin","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                            }

                            else
                            {
                                MessageBox.Show(this, "User removed from the resignation list","Done" ,MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }



                        }
                        else if (dialogResult == DialogResult.No) 
                        {
                        
                        }

                      
                    }
                    else
                    {
                        sqlDataReader.Close();//could cause bugs /////////
                        cmd.Dispose();


                        DialogResult dialogResult=MessageBox.Show(this,"Are you sure you want to proceed?","Warning!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            DialogResult dialogResult2 = MessageBox.Show(this, "Do you want to post a job vacancy too", "Vacancy Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult2 == DialogResult.Yes)
                            {
                                SqlCommand cmd2 = new SqlCommand("insert into resignations values(@resId,@empNum,@empName,@gender,@jobRole,@date,@executeCmd,@vacancy);", con);
                                cmd2.Parameters.AddWithValue("@resId", empNum + DateTime.Now.ToString("yyyyMMddHHmmss"));
                                cmd2.Parameters.AddWithValue("@empNum", empNum);
                                cmd2.Parameters.AddWithValue("@empName", empName);
                                cmd2.Parameters.AddWithValue("@gender", gender);
                                cmd2.Parameters.AddWithValue("@jobRole", jobRole);
                                cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                                cmd2.Parameters.AddWithValue("@executeCmd", DateTime.Now.AddMonths(Properties.Settings.Default.ResignationTime).ToString("yyyy-MM-dd")); ////resignation rxecution time
                                cmd2.Parameters.AddWithValue("@vacancy", "yes");

                                int y = cmd2.ExecuteNonQuery();
                                cmd2.Dispose();
                                if (y == 0)
                                {

                                }
                                else if (y == 1)
                                {
                                    MessageBox.Show(this, "Employee " + empNum + " in in resignation list.his account will be removed from the system in " + DateTime.Now.AddMonths(Properties.Settings.Default.ResignationTime).ToString("yyyy-MM-dd"), "success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                            }
                            else if (dialogResult2 == DialogResult.No) 
                            {
                                SqlCommand cmd2 = new SqlCommand("insert into resignations values(@resId,@empNum,@empName,@gender,@jobRole,@date,@executeCmd,@vacancy);", con);
                                cmd2.Parameters.AddWithValue("@resId", empNum + DateTime.Now.ToString("yyyyMMddHHmmss"));
                                cmd2.Parameters.AddWithValue("@empNum", empNum);
                                cmd2.Parameters.AddWithValue("@empName", empName);
                                cmd2.Parameters.AddWithValue("@gender", gender);
                                cmd2.Parameters.AddWithValue("@jobRole", jobRole);
                                cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                                cmd2.Parameters.AddWithValue("@executeCmd", DateTime.Now.AddMonths(Properties.Settings.Default.ResignationTime).ToString("yyyy-MM-dd")); ////resignation rxecution time
                                cmd2.Parameters.AddWithValue("@vacancy", "no");

                                int y = cmd2.ExecuteNonQuery();
                                cmd2.Dispose();
                                if (y == 0)
                                {

                                }
                                else if (y == 1)
                                {
                                    MessageBox.Show(this, "Employee " + empNum + " in in resignation list.his account will be removed from the system in " + DateTime.Now.AddMonths(Properties.Settings.Default.ResignationTime).ToString("yyyy-MM-dd"), "success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                           
                        }
                        else { }
                    }

                    


                }
                catch (SqlException ex) { MessageBox.Show(ex.Message.ToString()); }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

                con.Close();
            }
        }
    }
}
