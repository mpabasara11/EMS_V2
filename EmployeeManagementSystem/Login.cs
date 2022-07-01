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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        //////////////////////////////////////////////////////Configurations are retrieved from application settings file///////////////////////////////////////////////////////

        //connection string //conection string is modified to use multiple quaries same time
        public static SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection_String);

    


        public static string empNumforuser;


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        private void Login_Load(object sender, EventArgs e)
        {

            //multi thread using to run other tasks 
            telegramBackgroundWorker.RunWorkerAsync();
            resignationManageBackgroundWorker.RunWorkerAsync(); 


        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            TeleBot teleBot = new TeleBot();
           
        }
        private void resignationManageBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ResignationManager resignationManager_BackgroundWorker = new ResignationManager();
        }



        private void lgnUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (lgnUsername.Text == "Username")
            {
                lgnUsername.Text = "";
            }
        }

        private void lgnUsername_Leave(object sender, EventArgs e)
        {
            if (lgnUsername.Text == "")
            {
                lgnUsername.Text = "Username";
            }
        }

        private void lgnPswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (lgnPswd.Text == "Password")
            {
                lgnPswd.Text = "";
            }
        }

        private void lgnPswd_Leave(object sender, EventArgs e)
        {

            if (lgnPswd.Text == "")
            {
                lgnPswd.Text = "Password";
            }
        }

        private void lgnBtnLogin_Click(object sender, EventArgs e)
        {
         
            //validation

            if (lgnUsername.Text == "Username")
            { 
        

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(lgnUsername, "warning");
                t.Show("Enter Username", lgnUsername, 2000);



            }

            else if (lgnPswd.Text == "Password")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(lgnPswd, "warning");
                t.Show("Enter Password", lgnPswd, 2000);


            }

            else
            {
                con.Open();
                try
                {
                  
                    //open admin form
                    if (lgnUsername.Text == Properties.Settings.Default.AdminUserName && lgnPswd.Text == Properties.Settings.Default.AdminPassword)
                    {

                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                    }

                    else
                    {  string empNum;

                        SqlCommand Comm1 = new SqlCommand("select empPwd from users where empUsrName like @username;", con);
                        Comm1.Parameters.AddWithValue("@username", lgnUsername.Text);                   
                        SqlDataReader dr1 = Comm1.ExecuteReader();


                        if (dr1.Read())
                        {
                            byte[] salt = (byte[])dr1["empPwd"];

                            dr1.Close();
                            Comm1.Dispose();



                            if (Hasher.MatchSHA1(salt, Hasher.GetSHA1(lgnUsername.Text, lgnPswd.Text)))
                            {

                                SqlCommand Comm2 = new SqlCommand("select empNum from users where empUsrName like @username;", con);
                                Comm2.Parameters.AddWithValue("@username", lgnUsername.Text);
                                SqlDataReader dr2 = Comm2.ExecuteReader();

                                if (dr2.Read())
                                {
                                    empNum = dr2.GetValue(0).ToString();
                                    dr2.Close();
                                    Comm2.Dispose();

                                    empNumforuser = empNum;

                                    //open manager
                                    if (Regex.IsMatch(empNum, @"^[mM][0-9]*[0-9]$"))
                                    {
                                        con.Close();
                                        Managerdashboard managerdashboard = new Managerdashboard();
                                        this.Hide();
                                        managerdashboard.Show();    


                                    }
                                    //open employee
                                    else if (Regex.IsMatch(empNum, @"^[eE][0-9]*[0-9]$"))
                                    {
                                        con.Close();
                                 


                                        EmployeeDashboard empDashboard = new EmployeeDashboard();
                                        this.Hide();
                                        empDashboard.Show();

                                    }
                                    //open hr
                                    else if (Regex.IsMatch(empNum, @"^[hH][0-9]*[0-9]$"))
                                    {
                                        con.Close();
                                  
                                        HrDashboard hrDashbord = new HrDashboard();
                                        this.Hide();
                                        hrDashbord.Show();

                                    }
                                    //open hr manager(manager)
                                    else if (Regex.IsMatch(empNum, @"^[aA][0-9]*[0-9]$"))
                                    {
                                        con.Close();

                                        Managerdashboard managerdashboard = new Managerdashboard();
                                        this.Hide();
                                        managerdashboard.Show();



                                    }
                                }
                                else 
                                {
                                    dr2.Close();
                                    Comm2.Dispose();
                                }
                              






                            }
                            else
                            {



                                MessageBox.Show("Password Is Incorrect!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Could Not Find the Username On Our Database");
                        }



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

        private void label1_Click(object sender, EventArgs e)
        {

        }

   
    }
}
