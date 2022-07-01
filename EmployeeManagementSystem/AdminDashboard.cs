using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        //get connection string from login form
        SqlConnection con = Login.con;


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //date time picker max date
            addPickDob.MaxDate = DateTime.Now;
            updPickDob.MaxDate = DateTime.Now;


            addGender.SelectedIndex = 0;
            addJobRole.SelectedIndex = 0;




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void addUsrName_MouseClick(object sender, MouseEventArgs e)
        {
            if (addUsrName.Text == "Username")
            {
                addUsrName.Text = "";
            }
        }

        private void addUsrName_Leave(object sender, EventArgs e)
        {
            if (addUsrName.Text == "")
            {
                addUsrName.Text = "Username";
            }
        }

        private void addPwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (addPwd.Text == "Password")
            {
                addPwd.Text = "";
            }
        }

        private void addPwd_Leave(object sender, EventArgs e)
        {
            if (addPwd.Text == "")
            {
                addPwd.Text = "Password";
            }
        }

        private void addEmpName_MouseClick(object sender, MouseEventArgs e)
        {
            if (addEmpName.Text == "Employee Name")
            {
                addEmpName.Text = "";
            }
        }

        private void addEmpName_Leave(object sender, EventArgs e)
        {
            if (addEmpName.Text == "")
            {
                addEmpName.Text = "Employee Name";
            }


          


        }

        private void addEmpNum_MouseClick(object sender, MouseEventArgs e)
        {
            if (addEmpNum.Text == "Employee Number")
            {
                addEmpNum.Text = "";
            }
        }

        private void addEmpNum_Leave(object sender, EventArgs e)
        {
            if (addEmpNum.Text == "")
            {
                addEmpNum.Text = "Employee Number";
            }







        }

        private void addContNo_MouseClick(object sender, MouseEventArgs e)
        {
            if (addContNo.Text == "Contact Number")
            {
                addContNo.Text = "";
            }
        }

        private void addContNo_Leave(object sender, EventArgs e)
        {
            if (addContNo.Text == "")
            {
                addContNo.Text = "Contact Number";
            }
        }

        private void addAddrs_MouseClick(object sender, MouseEventArgs e)
        {
            if (addAddrs.Text == "Address")
            {
                addAddrs.Text = "";
            }
        }

        private void addAddrs_Leave(object sender, EventArgs e)
        {
            if (addAddrs.Text == "")
            {
                addAddrs.Text = "Address";
            }
        }

        private void addMail_MouseClick(object sender, MouseEventArgs e)
        {
            if (addMail.Text == "Email")
            {
                addMail.Text = "";
            }
        }

        private void addMail_Leave(object sender, EventArgs e)
        {
            if (addMail.Text == "")
            {
                addMail.Text = "Email";
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            //validation

            if (addUsrName.Text == "Username")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addUsrName, "warning");
                t.Show("Enter Username", addUsrName, 2000);



            }

            else if (addEmpName.Text == "Employee Name")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addEmpName, "warning");
                t.Show("Enter Employee Name", addEmpName, 2000);


            }

            else if (addPickDob.Value.ToString("yyyyddmm") == DateTime.Now.ToString("yyyyddmm"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addPickDob, "warning");
                t.Show("Select Employee DOB", addPickDob, 2000);


            }


            else if (addAddrs.Text == "Address")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addAddrs, "warning");
                t.Show("Enter Employee Address", addAddrs, 2000);


            }

            else if (addMail.Text == "Email")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addMail, "warning");
                t.Show("Enter Employee Email", addMail, 2000);


            }
            else if (!Regex.IsMatch(addMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addMail, "warning");
                t.Show("Not a Valid Email", addMail, 2000);


            }

            else if (addEmpNum.Text == "Employee Number")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addEmpNum, "warning");
                t.Show("Enter Employee Number", addEmpNum, 2000);


            }


            //e E -employee
            //m M -managers
            //h H -hr
            //a A -hr manager
            else if (!Regex.IsMatch(addEmpNum.Text, @"^[eEmMhHaA][0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addEmpNum, "warning");
                t.Show("Not a valid Employee Number", addEmpNum, 2000);


            }

            else if (addContNo.Text == "Contact Number")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addContNo, "warning");
                t.Show("Enter Contact Number", addContNo, 2000);


            }

            else if (!Regex.IsMatch(addContNo.Text, @"^[0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addContNo, "warning");
                t.Show("Not a valid Contact Number", addContNo, 2000);


            }

            else if (addPwd.Text == "Password")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addPwd, "warning");
                t.Show("Enter Password", addPwd, 2000);


            }

            else if (addConpwd.Text == "Confirm Password")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addConpwd, "warning");
                t.Show("Enter Password again", addConpwd, 2000);


            }

            else if (addPwd.Text != addConpwd.Text)
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(addConpwd, "warning");
                t.Show("Confirmation password is wrong", addConpwd, 2000);


            }


            else
            {
                con.Open();
                try
                {

                  



                    SqlCommand cmd0 = new SqlCommand("select empNum from users where empUsrName like @username;", con);
                    cmd0.Parameters.AddWithValue("@username", addUsrName.Text);
                    SqlDataReader dr = cmd0.ExecuteReader();
                    cmd0.Dispose();




                    if (dr.Read())
                    {
                        MessageBox.Show(this, "Username Already excists on Employee Number:" + dr.GetValue(0) + ", Try different Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                    }



                    else
                    {


                        dr.Close();

                        //getting these values from login form 
                        int casual_leaves = Properties.Settings.Default.casual_leaves;
                        int medical_leaves = Properties.Settings.Default.mediacal_leave;
                        int FLMA = Properties.Settings.Default.FMLA;
                        int total_leaves = casual_leaves + medical_leaves;

                   //  Byte[] aa=   Hasher.GetSHA1(addUsrName.Text, addPwd.Text);


                        if (Regex.IsMatch(addEmpNum.Text, @"^[eEmMhH][0-9]*[0-9]$"))
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd = new SqlCommand("insert into users values(@usrName,@empName,@empDob,@empAddr,@empMail,@empNum,@empContNum,CONVERT(varbinary(MAX), @empPass),@joinedDate,@lRecordyear,@remMedical,@remCasual,@remFMLA,@remTotal,@gender,@jobRole);", con);
                            cmd.Parameters.AddWithValue("@usrName", addUsrName.Text);
                            cmd.Parameters.AddWithValue("@empName", addEmpName.Text);
                            cmd.Parameters.AddWithValue("@empDob", addPickDob.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@empAddr", addAddrs.Text);
                            cmd.Parameters.AddWithValue("@empMail", addMail.Text);
                            cmd.Parameters.AddWithValue("@empNum", addEmpNum.Text);
                            cmd.Parameters.AddWithValue("@empContNum", addContNo.Text);
                            cmd.Parameters.AddWithValue("@empPass", Hasher.GetSHA1(addUsrName.Text, addPwd.Text) );
                            cmd.Parameters.AddWithValue("@joinedDate", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@lRecordyear",DateTime.Now.Year);
                            cmd.Parameters.AddWithValue("@remMedical", medical_leaves);
                            cmd.Parameters.AddWithValue("@remCasual", casual_leaves);
                            cmd.Parameters.AddWithValue("@remFMLA", FLMA);
                            cmd.Parameters.AddWithValue("@remTotal", total_leaves);
                            cmd.Parameters.AddWithValue("@gender", addGender.Text);
                            cmd.Parameters.AddWithValue("@jobRole", addJobRole.Text);
                            int i = cmd.ExecuteNonQuery();
                            cmd.Dispose();

                            //success
                            if (i == 1)
                            {




                                    MessageBox.Show(this, "Data saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    addUsrName.Text = "Username";
                                    addEmpName.Text = "Employee Name";
                                    addAddrs.Text = "Address";
                                    addMail.Text = "Email";
                                    addEmpNum.Text = "Employee Number";
                                    addContNo.Text = "Contact Number";
                                    addPwd.Text = "Password";
                                    addConpwd.Text = "Confirm Password";


                            }
                            //not success
                            else
                            {

                                MessageBox.Show(this, "Data could not save into users", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else if (Regex.IsMatch(addEmpNum.Text, @"^[aA][0-9]*[0-9]$"))
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd = new SqlCommand("insert into users values(@usrName,@empName,@empDob,@empAddr,@empMail,@empNum,@empContNum,CONVERT(varbinary(MAX), @empPass),@joinedDate,@lRecordyear,@remMedical,@remCasual,@remFMLA,@remTotal,@gender,@jobRole);", con);
                            cmd.Parameters.AddWithValue("@usrName", addUsrName.Text);
                            cmd.Parameters.AddWithValue("@empName", addEmpName.Text);
                            cmd.Parameters.AddWithValue("@empDob", addPickDob.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@empAddr", addAddrs.Text);
                            cmd.Parameters.AddWithValue("@empMail", addMail.Text);
                            cmd.Parameters.AddWithValue("@empNum", addEmpNum.Text);
                            cmd.Parameters.AddWithValue("@empContNum", addContNo.Text);
                            cmd.Parameters.AddWithValue("@empPass", Hasher.GetSHA1(addUsrName.Text, addPwd.Text));
                            cmd.Parameters.AddWithValue("@joinedDate", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@lRecordyear", DateTime.Now.Year);
                            cmd.Parameters.AddWithValue("@remMedical", 0);
                            cmd.Parameters.AddWithValue("@remCasual", 0);
                            cmd.Parameters.AddWithValue("@remFMLA", 0);
                            cmd.Parameters.AddWithValue("@remTotal", 0);
                            cmd.Parameters.AddWithValue("@gender", addGender.Text);
                            cmd.Parameters.AddWithValue("@jobRole", addJobRole.Text);
                            int i = cmd.ExecuteNonQuery();
                            cmd.Dispose();

                            if (i == 1)
                            {
                                MessageBox.Show(this, "Data saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                addUsrName.Text = "Username";
                                addEmpName.Text = "Employee Name";
                                addAddrs.Text = "Address";
                                addMail.Text = "Email";
                                addEmpNum.Text = "Employee Number";
                                addContNo.Text = "Contact Number";
                                addPwd.Text = "Password";
                                addConpwd.Text = "Confirm Password";


                            }
                            else
                            {
                                MessageBox.Show(this, "Data could not save into users", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


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

        private void txtConpwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (addConpwd.Text == "Confirm Password")
            {
                addConpwd.Text = "";
            }
        }

        private void txtConpwd_Leave(object sender, EventArgs e)
        {
            if (addConpwd.Text == "")
            {
                addConpwd.Text = "Confirm Password";
            }
        }

        private void updBtnSubmit_Click(object sender, EventArgs e)
        {

            //validation

            if (updUsrName.Text == "Username")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updUsrName, "warning");
                t.Show("Enter Username", updUsrName, 2000);



            }

            else if (updEmpName.Text == "Employee Name")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updEmpName, "warning");
                t.Show("Enter Employee Name", updEmpName, 2000);


            }

            else if (updPickDob.Value.ToString("yyyyddmm") == DateTime.Now.ToString("yyyyddmm"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updPickDob, "warning");
                t.Show("Select Employee DOB", updPickDob, 2000);


            }



            else if (updAddrs.Text == "Address")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updAddrs, "warning");
                t.Show("Enter Employee Address", updAddrs, 2000);


            }

            else if (updMail.Text == "Email")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updMail, "warning");
                t.Show("Enter Employee Email", updMail, 2000);


            }
            else if (!Regex.IsMatch(updMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updMail, "warning");
                t.Show("Not a Valid Email", updMail, 2000);


            }

            else if (updEmpNum.Text == "Employee Number")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updEmpNum, "warning");
                t.Show("Enter Employee Number", updEmpNum, 2000);


            }


            //e E -employee
            //m M -managers
            //h H -hr
            //a A -hr manager
            else if (!Regex.IsMatch(updEmpNum.Text, @"^[eEmMhHaA][0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updEmpNum, "warning");
                t.Show("Not a valid Employee Number", updEmpNum, 2000);


            }


            else if (updContNo.Text == "Contact Number")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updContNo, "warning");
                t.Show("Enter Contact Number", updContNo, 2000);


            }



            else if (!Regex.IsMatch(updContNo.Text, @"^[0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updContNo, "warning");
                t.Show("Not a valid Mobile Number", updContNo, 2000);


            }


            else
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();

                try
                {
                    cmd = new SqlCommand("update users set empUsrName=@usrName,empName=@empName,empDob=@empDob,empAddr=@empAddr,empMail=@empMail,empNum=@empNum,empContNum=@empContNum where empUsrName=@usrName;", con);
                   
                    cmd.Parameters.AddWithValue("@usrName", updUsrName.Text);
                    cmd.Parameters.AddWithValue("@empName", updEmpName.Text);
                    cmd.Parameters.AddWithValue("@empDob", updPickDob.Value);
                    cmd.Parameters.AddWithValue("@empAddr", updAddrs.Text);
                    cmd.Parameters.AddWithValue("@empMail", updMail.Text);
                    cmd.Parameters.AddWithValue("@empNum", updEmpNum.Text);
                    cmd.Parameters.AddWithValue("@empContNum", updContNo.Text);
                   
                    int i = cmd.ExecuteNonQuery();
                    cmd.Dispose();


                    //seccess
                    if (i == 1)
                    {
                        MessageBox.Show(this, "Data saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updUsrName.Text = "Username";
                        updEmpName.Text = "Employee Name";
                        updAddrs.Text = "Address";
                        updMail.Text = "Email";
                        updEmpNum.Text = "Employee Number";
                        updContNo.Text = "Contact Number";


                    }
                    //not success
                    else
                    {
                        MessageBox.Show(this, "There is no such Username as" + updUsrName.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void updUsrName_MouseClick(object sender, MouseEventArgs e)
        {
            if (updUsrName.Text == "Username")
            {
                updUsrName.Text = "";
            }
        }

        private void updUsrName_Leave(object sender, EventArgs e)
        {

            if (updUsrName.Text == "")
            {
                updUsrName.Text = "Username";
            }
        }

        private void updPwd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void updPwd_Leave(object sender, EventArgs e)
        {

        }

        private void updEmpName_MouseClick(object sender, MouseEventArgs e)
        {
            if (updEmpName.Text == "Employee Name")
            {
                updEmpName.Text = "";
            }
        }

        private void updEmpName_Leave(object sender, EventArgs e)
        {
            if (updEmpName.Text == "")
            {
                updEmpName.Text = "Employee Name";
            }
        }

        private void updEmpNum_MouseClick(object sender, MouseEventArgs e)
        {
            if (updEmpNum.Text == "Employee Number")
            {
                updEmpNum.Text = "";
            }
        }

        private void updEmpNum_Leave(object sender, EventArgs e)
        {
            if (updEmpNum.Text == "")
            {
                updEmpNum.Text = "Employee Number";
            }
        }

        private void updContNo_MouseClick(object sender, MouseEventArgs e)
        {
            if (updContNo.Text == "Contact Number")
            {
                updContNo.Text = "";
            }
        }

        private void updContNo_Leave(object sender, EventArgs e)
        {
            if (updContNo.Text == "")
            {
                updContNo.Text = "Contact Number";
            }
        }

        private void updAddrs_MouseClick(object sender, MouseEventArgs e)
        {
            if (updAddrs.Text == "Address")
            {
                updAddrs.Text = "";
            }
        }

        private void updAddrs_Leave(object sender, EventArgs e)
        {
            if (updAddrs.Text == "")
            {
                updAddrs.Text = "Address";
            }
        }

        private void updMail_MouseClick(object sender, MouseEventArgs e)
        {
            if (updMail.Text == "Email")
            {
                updMail.Text = "";
            }
        }

        private void updMail_Leave(object sender, EventArgs e)
        {
            if (updMail.Text == "")
            {
                updMail.Text = "Email";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void updConpwd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void updConpwd_Leave(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void delUsrName_MouseClick(object sender, MouseEventArgs e)
        {
            if (delUsrName.Text == "Username")
            {
                delUsrName.Text = "";
            }
        }

        private void delUsrName_Leave(object sender, EventArgs e)
        {
            if (delUsrName.Text == "")
            {
                delUsrName.Text = "Username";
            }
        }

        private void pResetUsrName_MouseClick(object sender, MouseEventArgs e)
        {
            if (pResetUsrName.Text == "Username")
            {
                pResetUsrName.Text = "";
            }
        }

        private void pResetUsrName_Leave(object sender, EventArgs e)
        {
            if (pResetUsrName.Text == "")
            {
                pResetUsrName.Text = "Username";
            }
        }

      
      
        private void pResetNewPswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (pResetNewPswd.Text == "New Password")
            {
                pResetNewPswd.Text = "";
            }
        }

        private void pResetNewPswd_Leave(object sender, EventArgs e)
        {
            if (pResetNewPswd.Text == "")
            {
                pResetNewPswd.Text = "New Password";
            }
        }

        private void pResetVerifyNewPswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (pResetVerifyNewPswd.Text == "Verify New Password")
            {
                pResetVerifyNewPswd.Text = "";
            }
        }

        private void pResetVerifyNewPswd_Leave(object sender, EventArgs e)
        {
            if (pResetVerifyNewPswd.Text == "")
            {
                pResetVerifyNewPswd.Text = "Verify New Password";
            }
        }

        private void addBtnLogOut_Click(object sender, EventArgs e)
        {
            //sign out 
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void delBtnDrop_Click(object sender, EventArgs e)
        {
            if (delUsrName.Text == "Username")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.IsBalloon = true;
                t.UseAnimation = true;
                t.SetToolTip(delUsrName, "warning");
                t.Show("Enter The Username", delUsrName, 2000);


            }
            else
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("select empNum from users where empUsrName=@usrName;", con);
                    cmd.Parameters.AddWithValue("@usrName", delUsrName.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    cmd.Dispose();

                    if (dr.Read())

                    {
                        String employeeNum = (String)dr.GetValue(0);
                        dr.Close();



                            cmd = new SqlCommand("delete from users where empNum=@empNum;delete from attendance where empNum=@empNum;delete from leave where empNum=@empNum;delete from resignations where empNum=@empNum;delete from payslips where empNum=@empNum;", con);
                            cmd.Parameters.AddWithValue("@empNum", employeeNum);                 

                        int i = cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        if (i == 0)
                        {
                            MessageBox.Show("Username  which you entered not found in our database!");

                        }

                        else

                        {
                            MessageBox.Show("User Removed");
                            delUsrName.Text = "Username";


                        }


                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Username  which you entered not found in database!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (pResetUsrName.Text == "Username")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(pResetUsrName, "warning");
                t.Show("Enter Username", pResetUsrName, 2000);



            }

            else if (pResetNewPswd.Text == "New Password")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(pResetNewPswd, "warning");
                t.Show("Enter New Password", pResetNewPswd, 2000);


            }
            else if (pResetVerifyNewPswd.Text == "Verify New Password")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(pResetVerifyNewPswd, "warning");
                t.Show("Verify New Password", pResetVerifyNewPswd, 2000);


            }

            else if (pResetNewPswd.Text != pResetVerifyNewPswd.Text)
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(pResetVerifyNewPswd, "warning");
                t.Show("Confirmation password is wrong", pResetVerifyNewPswd, 2000);


            }

            else
            {
                

                SqlCommand cmd = new SqlCommand();
                con.Open();

                int pswdHash= pResetNewPswd.Text.GetHashCode();

                try 
                {
                    cmd = new SqlCommand("update users set empPwd=CONVERT(varbinary(MAX), @empPwd) where empUsrName=@usrName;", con);
                    cmd.Parameters.AddWithValue("@usrName", pResetUsrName.Text);
                    cmd.Parameters.AddWithValue("@empPwd", Hasher.GetSHA1(pResetUsrName.Text, pResetNewPswd.Text));
                    int i=cmd.ExecuteNonQuery();
                    cmd.Dispose();


                    if (i == 1)
                    {
                        MessageBox.Show(this, "Password Succesfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pResetUsrName.Text = "Username";
                        pResetNewPswd.Text = "New Password";
                        pResetVerifyNewPswd.Text = "Verify New Password";

                    }

                    else                    
                   {
                        MessageBox.Show(this, "We Could Not Find the Username You Entered In Out Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (updAdminUserName.Text == "Username")
            {
                updAdminUserName.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (updAdminUserName.Text == "")
            {
                updAdminUserName.Text = "Username";
            }
        }

        private void updAdminPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (updAdminPassword.Text == "Password")
            {
                updAdminPassword.Text = "";
            }
        }

        private void updAdminPassword_Leave(object sender, EventArgs e)
        {
            if (updAdminPassword.Text == "")
            {
                updAdminPassword.Text = "Password";
            }
        }

        private void updAdminConPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (updAdminConPassword.Text == "Confirm Password")
            {
                updAdminConPassword.Text = "";
            }
        }

        private void updAdminConPassword_Leave(object sender, EventArgs e)
        {

            if (updAdminConPassword.Text == "")
            {
                updAdminConPassword.Text = "Confirm Password";
            }
        }

        private void btn_updateAdmin_Click(object sender, EventArgs e)
        {
            if (updAdminUserName.Text == "Username")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updAdminUserName, "warning");
                t.Show("Enter Username", updAdminUserName, 2000);



            }

            else if (updAdminPassword.Text == "Password")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updAdminPassword, "warning");
                t.Show("Enter a Password", updAdminPassword, 2000);


            }
            else if (updAdminConPassword.Text == "Confirm Password")
            {
                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updAdminConPassword, "warning");
                t.Show("Enter Confirm Password", updAdminConPassword, 2000);


            }
            else if (updAdminPassword.Text != updAdminConPassword.Text)
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(updAdminConPassword, "warning");
                t.Show("Confirmation password is wrong", updAdminConPassword, 2000);


            }

            else
            {


                Properties.Settings.Default.AdminUserName = updAdminUserName.Text;
                Properties.Settings.Default.AdminPassword = updAdminPassword.Text;
                Properties.Settings.Default.Save();



                MessageBox.Show(this, "Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                updAdminUserName.Text = "Username";
                updAdminPassword.Text = "Password";
                updAdminConPassword.Text = "Confirm Password";


            }
        }

        private void addEmpName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void addEmpNum_TextChanged(object sender, EventArgs e)
        {

            if (Regex.IsMatch(addEmpNum.Text, @"^[mM][0-9]*[0-9]$"))
            {

                addJobRole.Enabled = false;
                addJobRole.Text = "Manager";


            }

            else if (Regex.IsMatch(addEmpNum.Text, @"^[hH][0-9]*[0-9]$"))
            {

                addJobRole.Enabled = false;
                addJobRole.Text = "HR";


            }

            else if (Regex.IsMatch(addEmpNum.Text, @"^[aA][0-9]*[0-9]$"))
            {

                addJobRole.Enabled = false;
                addJobRole.Text = "HR Manager";


            }
            else if (Regex.IsMatch(addEmpNum.Text, @"^[eE][0-9]*[0-9]$"))
            {
                addJobRole.Enabled = true;

            }
        }
    }
}