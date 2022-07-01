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
    public partial class frmSurvayForm : Form
    {
        String survayId;
        public frmSurvayForm(String survayId)
        {
            InitializeComponent();
            this.survayId = survayId;
        }

       

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;



        private void frmSurvayForm_Load(object sender, EventArgs e)
        {
            picker_surveyFormQ1.SelectedIndex = 4;
            picker_surveyFormQ2.SelectedIndex = 4;
            picker_surveyFormQ3.SelectedIndex = 4;
            picker_surveyFormQ4.SelectedIndex = 4;
            picker_surveyFormQ5.SelectedIndex = 4;



            con.Open();
            try 
            {
                SqlCommand cmd = new SqlCommand("select Q1,Q2,Q3,Q4,Q5 from surveyQ where survayId='" + survayId + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    String Quest1 = dr["Q1"].ToString();
                    String Quest2 = dr["Q2"].ToString();
                    String Quest3 = dr["Q3"].ToString();
                    String Quest4 = dr["Q4"].ToString();
                    String Quest5 = dr["Q5"].ToString();


                    lbl_surveyFormQ1.Text = Quest1;
                    lbl_surveyFormQ2.Text = Quest2;
                    lbl_surveyFormQ3.Text = Quest3;
                    lbl_surveyFormQ4.Text = Quest4;
                    lbl_surveyFormQ5.Text = Quest5;

                    dr.Close();
                    cmd.Dispose();

                }
                else
                {
                    dr.Close();
                    cmd.Dispose();
                }
            
            }
            catch (SqlException ex) 
            {
            
            }
            catch (Exception ex)
            {
            
            }
            con.Close();


        }

        private void btn_surveyFormSubmit_Click(object sender, EventArgs e)
        {
            int q1sa = 0;
            int q1a=0;
            int q1d=0;
            int q1sd=0;
            int q1nc=0;

            int q2sa=0;
            int q2a=0;
            int q2d=0;
            int q2sd=0;
            int q2nc=0;

            int q3sa=0;
            int q3a=0;
            int q3d=0;
            int q3sd=0;
            int q3nc=0;

            int q4sa=0;
            int q4a=0;
            int q4d=0;
            int q4sd=0;
            int q4nc=0;

            int q5sa=0;
            int q5a=0;
            int q5d=0;
            int q5sd=0;
            int q5nc=0;

            int totalAns=0;


            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select [Q1-SA],[Q1-A],[Q1-D],[Q1-SD],[Q1-NC],[Q2-SA],[Q2-A],[Q2-D],[Q2-SD],[Q2-NC],[Q3-SA],[Q3-A],[Q3-D],[Q3-SD],[Q3-NC],[Q4-SA],[Q4-A],[Q4-D],[Q4-SD],[Q4-NC],[Q5-SA],[Q5-A],[Q5-D],[Q5-SD],[Q5-NC],totalAnswered from surveyQ where survayId='" + survayId + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
           

                if (dr.Read())
                {
                    q1sa = (int)dr["Q1-SA"];
                    q1a = (int)dr["Q1-A"];
                    q1d = (int)dr["Q1-D"];
                    q1sd = (int)dr["Q1-SD"];
                    q1nc = (int)dr["Q1-NC"];

                    q2sa = (int)dr["Q2-SA"];
                    q2a = (int)dr["Q2-A"];
                    q2d = (int)dr["Q2-D"];
                    q2sd = (int)dr["Q2-SD"];
                    q2nc = (int)dr["Q2-NC"];

                    q3sa = (int)dr["Q3-SA"];
                    q3a = (int)dr["Q3-A"];
                    q3d = (int)dr["Q3-D"];
                    q3sd = (int)dr["Q3-SD"];
                    q3nc = (int)dr["Q3-NC"];

                    q4sa = (int)dr["Q4-SA"];
                    q4a = (int)dr["Q4-A"];
                    q4d = (int)dr["Q4-D"];
                    q4sd = (int)dr["Q4-SD"];
                    q4nc = (int)dr["Q4-NC"];

                    q5sa = (int)dr["Q5-SA"];
                    q5a = (int)dr["Q5-A"];
                    q5d = (int)dr["Q5-D"];
                    q5sd = (int)dr["Q5-SD"];
                    q5nc = (int)dr["Q5-NC"];


                    totalAns = (int)dr["totalAnswered"];

                 

                    dr.Close();
                    cmd.Dispose();

                }
                else
                {
                    dr.Close();
                    cmd.Dispose();

                 
                }


                ////////////////////////////q1

                if (picker_surveyFormQ1.SelectedIndex == 0)
                {
                    q1sa++;


                }
                else if (picker_surveyFormQ1.SelectedIndex == 1)
                {
                     q1a ++;
                  
                }
                else if (picker_surveyFormQ1.SelectedIndex == 2)
                {
                    q1d++;
                   
                }
                else if (picker_surveyFormQ1.SelectedIndex == 3)
                {
                    q1sd++;
                  
                }
                else if (picker_surveyFormQ1.SelectedIndex == 4)
                {
                     q1nc++;
                }


                ////////////////////////////q2
              
                if (picker_surveyFormQ2.SelectedIndex == 0)
                {
                    q2sa++;


                }
                else if (picker_surveyFormQ2.SelectedIndex == 1)
                {
                    q2a++;

                }
                else if (picker_surveyFormQ2.SelectedIndex == 2)
                {
                    q2d++;

                }
                else if (picker_surveyFormQ2.SelectedIndex == 3)
                {
                    q2sd++;

                }
                else if (picker_surveyFormQ2.SelectedIndex == 4)
                {
                    q2nc++;
                }

                ///////////////////////////////q3
                if (picker_surveyFormQ3.SelectedIndex == 0)
                {
                    q3sa++;


                }
                else if (picker_surveyFormQ3.SelectedIndex == 1)
                {
                    q3a++;

                }
                else if (picker_surveyFormQ3.SelectedIndex == 2)
                {
                    q3d++;

                }
                else if (picker_surveyFormQ3.SelectedIndex == 3)
                {
                    q3sd++;

                }
                else if (picker_surveyFormQ3.SelectedIndex == 4)
                {
                    q3nc++;
                }



                //////////////////////////////////////q4
                if (picker_surveyFormQ4.SelectedIndex == 0)
                {
                    q4sa++;


                }
                else if (picker_surveyFormQ4.SelectedIndex == 1)
                {
                    q4a++;

                }
                else if (picker_surveyFormQ4.SelectedIndex == 2)
                {
                    q4d++;

                }
                else if (picker_surveyFormQ4.SelectedIndex == 3)
                {
                    q4sd++;

                }
                else if (picker_surveyFormQ4.SelectedIndex == 4)
                {
                    q4nc++;
                }

                ////////////////////////////////q5

                if (picker_surveyFormQ5.SelectedIndex == 0)
                {
                    q5sa++;


                }
                else if (picker_surveyFormQ5.SelectedIndex == 1)
                {
                    q5a++;

                }
                else if (picker_surveyFormQ5.SelectedIndex == 2)
                {
                    q5d++;

                }
                else if (picker_surveyFormQ5.SelectedIndex == 3)
                {
                    q5sd++;

                }
                else if (picker_surveyFormQ5.SelectedIndex == 4)
                {
                    q5nc++;
                }


                totalAns++;


                     SqlCommand cmd1 = new SqlCommand("update surveyQ set [Q1-SA]=@q11,[Q1-A]=@q12,[Q1-D]=@q13,[Q1-SD]=@q14,[Q1-NC]=@q15,[Q2-SA]=@q21,[Q2-A]=@q22,[Q2-D]=@q23,[Q2-SD]=@q24,[Q2-NC]=@q25,[Q3-SA]=@q31,[Q3-A]=@q32,[Q3-D]=@q33,[Q3-SD]=@q34,[Q3-NC]=@q35,[Q4-SA]=@q41,[Q4-A]=@q42,[Q4-D]=@q43,[Q4-SD]=@q44,[Q4-NC]=@q45,[Q5-SA]=@q51,[Q5-A]=@q52,[Q5-D]=@q53,[Q5-SD]=@q54,[Q5-NC]=@q55,totalAnswered=@ta where survayId=@sid;", con);

                cmd1.Parameters.AddWithValue("@q11", q1sa);
                cmd1.Parameters.AddWithValue("@q12", q1a);
                cmd1.Parameters.AddWithValue("@q13", q1d);
                cmd1.Parameters.AddWithValue("@q14", q1sd);
                cmd1.Parameters.AddWithValue("@q15", q1nc);
                cmd1.Parameters.AddWithValue("@q21", q2sa);
                cmd1.Parameters.AddWithValue("@q22", q2a);
                cmd1.Parameters.AddWithValue("@q23", q2d);
                cmd1.Parameters.AddWithValue("@q24", q2sd);
                cmd1.Parameters.AddWithValue("@q25", q2nc);
                cmd1.Parameters.AddWithValue("@q31", q3sa);
                cmd1.Parameters.AddWithValue("@q32", q3a);
                cmd1.Parameters.AddWithValue("@q33", q3d);
                cmd1.Parameters.AddWithValue("@q34", q3sd);
                cmd1.Parameters.AddWithValue("@q35", q3nc);
                cmd1.Parameters.AddWithValue("@q41", q4sa);
                cmd1.Parameters.AddWithValue("@q42", q4a);
                cmd1.Parameters.AddWithValue("@q43", q4d);
                cmd1.Parameters.AddWithValue("@q44", q4sd);
                cmd1.Parameters.AddWithValue("@q45", q4nc);
                cmd1.Parameters.AddWithValue("@q51", q5sa);
                cmd1.Parameters.AddWithValue("@q52", q5a);
                cmd1.Parameters.AddWithValue("@q53", q5d);
                cmd1.Parameters.AddWithValue("@q54", q5sd);
                cmd1.Parameters.AddWithValue("@q55", q5nc);
             

                cmd1.Parameters.AddWithValue("@ta", totalAns);

                cmd1.Parameters.AddWithValue("@sid", survayId);

                int i= cmd1.ExecuteNonQuery();
                cmd1.Dispose();

                if (i == 0)
                {
                    MessageBox.Show("something went wrong"); 
                }
                else
                {
                     MessageBox.Show(this,"Your Feedback Submitted","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    picker_surveyFormQ1.SelectedIndex = 4;
                    picker_surveyFormQ2.SelectedIndex = 4;
                    picker_surveyFormQ3.SelectedIndex = 4;
                    picker_surveyFormQ4.SelectedIndex = 4;
                    picker_surveyFormQ5.SelectedIndex = 4;

                    btn_surveyFormSubmit.Enabled = false;
                }



             



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

            }
            con.Close();

        }
    }
}
