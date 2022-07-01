using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EmployeeManagementSystem
{

    public partial class FrmHome : Form
    {
        //get empNum from login
        String employeeNumber = Login.empNumforuser;

        //get connection string from login form
        SqlConnection con = Login.con;


       
        public FrmHome()
        {
            InitializeComponent();


            
        }

        public void showQuote()
        {
        
            String a = "“We cannot solve problems with the kind of thinking we employed when we came up with them.” — Albert Einstein";
            String b = "“Learn as if you will live forever, live like you will die tomorrow.” — Mahatma Gandhi";
            String c = "“Stay away from those people who try to disparage your ambitions. Small minds will always do that, but great minds will give you a feeling that you can become great too.” — Mark Twain";
            String d = "“When you give joy to other people, you get more joy in return.You should give a good thought to happiness that you can give out.”— Eleanor Roosevelt";
            String e = "“When you change your thoughts, remember to also change your world.”—Norman Vincent Peale";
            String f = "“It is only when we take chances, when our lives improve. The initial and the most difficult risk that we need to take is to become honest” —Walter Anderson";
            String g = "“Nature has given us all the pieces required to achieve exceptional wellness and health, but has left it to us to put these pieces together”—Diane McLaren";
            String h = "“Success is not final; failure is not fatal: It is the courage to continue that counts” — Winston S. Churchill";
             String i = "“It is better to fail in originality than to succeed in imitation” — Herman Melville";
            String j = "“The road to success and the road to failure are almost exactly the same.” — Colin R. Davis";
             String k = "“Success usually comes to those who are too busy looking for it.” — Henry David Thoreau";
             String l = "“Develop success from failures.Discouragement and failure are two of the surest stepping stones to success.” —Dale Carnegie";
             String m = "“Nothing in the world can take the place of Persistence. Talent will not; nothing is more common than unsuccessful men with talent. Genius will not; unrewarded genius is almost a proverb. Education will not; the world is full of educated derelicts. The slogan 'Press On' has solved and always will solve the problems of the human race.” —Calvin Coolidge";
             String n = "“There are three ways to ultimate success: The first way is to be kind.The second way is to be kind.The third way is to be kind.” —Mister Rogers";
             String o = "“Success is peace of mind, which is a direct result of self - satisfaction in knowing you made the effort to become the best of which you are capable.” —John Wooden";
             String p = "“I never dreamed about success.I worked for it.” —Estée Lauder";
             String q = "“Success is getting what you want, happiness is wanting what you get.” ―W.P.Kinsella";

            String[] quotes = { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q };

            Random rand = new Random();
            int number = rand.Next(0,16);

            lbl_homeQuote.Text=quotes[number];




        }
  

            private void FrmDashboard_Load(object sender, EventArgs e)
            {
            showQuote();






            timer1.Start();
            

           
         

            String EmpName, EmpMail, EmpDepart;
            con.Open();
            try 
            {
                SqlCommand cmd = new SqlCommand("select empName,empMail from users where empNum='" + employeeNumber + "'",con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    EmpName=(String)dr["empName"];
                    EmpMail = (String)dr["empMail"];

                    dr.Close();
                    cmd.Dispose();


                    lbl_homeName1.Text = EmpName;
                    lbl_homeName2.Text = EmpName;
                    lbl_homeMail.Text = EmpMail;
                    lbl_homeNum.Text = employeeNumber;


                    if (Regex.IsMatch(employeeNumber, @"^[mM][0-9]*[0-9]$"))
                    {
                        lbl_homeDepart.Text = "Management";

                    }
                    if (Regex.IsMatch(employeeNumber, @"^[eE][0-9]*[0-9]$"))
                    {
                        lbl_homeDepart.Text = "Employee";

                    }
                    if (Regex.IsMatch(employeeNumber, @"^[hH][0-9]*[0-9]$"))
                    {

                        lbl_homeDepart.Text = "Human Resources";
                    }
                    if (Regex.IsMatch(employeeNumber, @"^[aA][0-9]*[0-9]$"))
                    {
                        lbl_homeDepart.Text = "Management";

                    }



                }
                else 
                {
                cmd.Dispose();
                    dr.Close();
                }

            
            
            
            }
            catch(SqlException ex) { MessageBox.Show(ex.Message); }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
con.Close();
        }

        private void NetworkChange_NetworkAvailabilityChanged(object? sender, NetworkAvailabilityEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_homeTime.Text = DateTime.Now.ToString("HH:mm");
            lbl_homeTimeSec.Text = DateTime.Now.ToString("ss");
            lbl_homeTimett.Text=DateTime.Now.ToString("tt");
            lbl_homeDate.Text= DateTime.Now.ToString("dd-MM-yyyy");
            lbl_homeDay.Text = DateTime.Now.ToString("dddd");


        


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
