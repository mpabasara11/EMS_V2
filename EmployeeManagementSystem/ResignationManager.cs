using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace EmployeeManagementSystem
{
    internal class ResignationManager
    {

      
        //get empNum from login
        String employeeNumber = Login.empNumforuser;

        //get connection string from login form
        SqlConnection con = Login.con;


        public ResignationManager()
        {
            Auth.SetUserCredentials("wbLdayIvUbAu3t996IT8AeiJP", "uZ7hNqXvggEJf34zV8SN1BJNZEFtXUEfw5BvWhG9LT6AYi4Krp", "1514301474012266497-sAzZrfz6vwH7jmN6qacqoWPAXPDFxt", "HRTEkZQceXtgUMYIZBEJOInzd0u3wAs528f35c5gOFFqV");
            con.Open();

            try
            {
                String jbops = "";
                int t = 0;
                

                SqlCommand cmd = new SqlCommand("select empNum,empName,gender,jobRole,date,executeCmd,vacancy from resignations", con);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();


                do
                {

                    while (sqlDataReader.Read())
                    {

                        String empNum = (String)sqlDataReader["empNum"];
                        String empName = (String)sqlDataReader["empName"];
                        String gender = (String)sqlDataReader["gender"];
                        String jobRole = (String)sqlDataReader["jobRole"];
                        String date = (String)sqlDataReader["date"];
                        String executeDmd = (String)sqlDataReader["executeCmd"];
                        String vacancy = (String)sqlDataReader["vacancy"];

                     

                        //if date is today or passed
                        DateTime dateTime = DateTime.Parse(executeDmd);
                        if (dateTime <= DateTime.Now)
                        {
                            if (vacancy == "yes")
                            {
                              

                             //   t = 1;

                              //  jbops = jbops + " , " + jobRole;

                                String twmsg = "Just got a job oppotunity for ( " + jobRole + " ) If you are interested,please send us your cv via " + Properties.Settings.Default.CompanyMail + " or Call Us :" + Properties.Settings.Default.CompanyMobile;
                                Tweet.PublishTweet(twmsg);



                                SqlCommand cmd1 = new SqlCommand("delete from users where empNum=@empNum;delete from attendance where empNum=@empNum;delete from leave where empNum=@empNum;delete from resignations where empNum=@empNum;delete from payslips where empNum=@empNum;", con);
                                cmd1.Parameters.AddWithValue("@empNum", empNum);
                                cmd1.ExecuteNonQuery();
                                cmd1.Dispose();




                            }
                            else if (vacancy == "no")
                            {
                                  SqlCommand cmd1 = new SqlCommand("delete from users where empNum=@empNum;delete from attendance where empNum=@empNum;delete from leave where empNum=@empNum;delete from resignations where empNum=@empNum;delete from payslips where empNum=@empNum;", con);
                                  cmd1.Parameters.AddWithValue("@empNum", empNum);
                                  int i = cmd1.ExecuteNonQuery();
                                  cmd1.Dispose();

                                

                            }
                        }




                    }
                } while (sqlDataReader.NextResult());

                sqlDataReader.Close();
                cmd.Dispose();

                if (t >= 1)
                {
                  //  String twmsg = "Just got a job oppotunity for ( " + jbops + " ) If you are interested,please send us your cv via " + Properties.Settings.Default.CompanyMail + " or Call Us :" + Properties.Settings.Default.CompanyMobile;
                  //  Tweet.PublishTweet(twmsg);
                }
               

            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }

            con.Close();


           
        }
    }
}
