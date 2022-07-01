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
    public partial class frmmanagesurvey : Form
    {
        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;
        public frmmanagesurvey()
        {
            InitializeComponent();
        }

        private void btn_SurvaymngAddsur_Click(object sender, EventArgs e)
        {
            if (txt_SurvaymngQ1.Text == "")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_SurvaymngQ1, "warning");
                t.Show("Field Cannot Be Empty", txt_SurvaymngQ1, 2000);



            }

            else if (txt_SurvaymngQ2.Text == "")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_SurvaymngQ2, "warning");
                t.Show("Field Cannot Be Empty", txt_SurvaymngQ2, 2000);


            }
            else if (txt_SurvaymngQ3.Text == "")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_SurvaymngQ3, "warning");
                t.Show("Field Cannot Be Empty", txt_SurvaymngQ3, 2000);


            }
            else if (txt_SurvaymngQ4.Text == "")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_SurvaymngQ4, "warning");
                t.Show("Field Cannot Be Empty", txt_SurvaymngQ4, 2000);


            }
            else if (txt_SurvaymngQ5.Text == "")
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_SurvaymngQ5, "warning");
                t.Show("Field Cannot Be Empty", txt_SurvaymngQ5, 2000);


            }
            else            
            {con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("insert into surveyQ values(@sid,@date,@stype,@q1,@q1sa,@q1a,@q1d,@q1sd,@q1nc,@q2,@q2sa,@q2a,@q2d,@q2sd,@q2nc,@q3,@q3sa,@q3a,@q3d,@q3sd,@q3nc,@q4,@q4sa,@q4a,@q4d,@q4sd,@q4nc,@q5,@q5sa,@q5a,@q5d,@q5sd,@q5nc,@totanswd);", con);

                    cmd.Parameters.AddWithValue("@sid", DateTime.Now.ToString("yyyyMMddHHmmss"));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                    cmd.Parameters.AddWithValue("@stype", picker_SurvayType.Text);

                    cmd.Parameters.AddWithValue("@q1", txt_SurvaymngQ1.Text);
                    cmd.Parameters.AddWithValue("@q1sa",0);
                    cmd.Parameters.AddWithValue("@q1a",0);
                    cmd.Parameters.AddWithValue("@q1d",0);
                    cmd.Parameters.AddWithValue("@q1sd",0);
                    cmd.Parameters.AddWithValue("@q1nc",0);

                    cmd.Parameters.AddWithValue("@q2", txt_SurvaymngQ2.Text);
                    cmd.Parameters.AddWithValue("@q2sa", 0);
                    cmd.Parameters.AddWithValue("@q2a", 0);
                    cmd.Parameters.AddWithValue("@q2d", 0);
                    cmd.Parameters.AddWithValue("@q2sd", 0);
                    cmd.Parameters.AddWithValue("@q2nc", 0);

                    cmd.Parameters.AddWithValue("@q3", txt_SurvaymngQ3.Text);
                    cmd.Parameters.AddWithValue("@q3sa", 0);
                    cmd.Parameters.AddWithValue("@q3a", 0);
                    cmd.Parameters.AddWithValue("@q3d", 0);
                    cmd.Parameters.AddWithValue("@q3sd", 0);
                    cmd.Parameters.AddWithValue("@q3nc", 0);

                    cmd.Parameters.AddWithValue("@q4", txt_SurvaymngQ4.Text);
                    cmd.Parameters.AddWithValue("@q4sa", 0);
                    cmd.Parameters.AddWithValue("@q4a", 0);
                    cmd.Parameters.AddWithValue("@q4d", 0);
                    cmd.Parameters.AddWithValue("@q4sd", 0);
                    cmd.Parameters.AddWithValue("@q4nc", 0);

                    cmd.Parameters.AddWithValue("@q5", txt_SurvaymngQ5.Text);
                    cmd.Parameters.AddWithValue("@q5sa", 0);
                    cmd.Parameters.AddWithValue("@q5a", 0);
                    cmd.Parameters.AddWithValue("@q5d", 0);
                    cmd.Parameters.AddWithValue("@q5sd", 0);
                    cmd.Parameters.AddWithValue("@q5nc", 0);

                    cmd.Parameters.AddWithValue("@totanswd", 0);

                    int i=cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if(i == 0) {MessageBox.Show(this,"Something went wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);  }
                    else { MessageBox.Show(this, "Survey Submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }



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

                dataGridViewRefresh();

            }
        }

        private void frmmanagesurvey_Load(object sender, EventArgs e)
        {
            dataGridViewRefresh();

            picker_SurvayType.SelectedIndex = 0;
        }

        private void dataGridViewRefresh()
        {
            con.Open();


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();



                adp = new SqlDataAdapter("select survayId,date,survayType,totalAnswered from surveyQ", con);





                DataTable dtt = new DataTable();
                adp.Fill(dtt);
                dgrid_mngSurvViewDel.DataSource = dtt;




                dgrid_mngSurvViewDel.Columns[1].HeaderCell.Value = "Survay ID";
                dgrid_mngSurvViewDel.Columns[2].HeaderCell.Value = "Date";
                dgrid_mngSurvViewDel.Columns[3].HeaderCell.Value = "Type";
                dgrid_mngSurvViewDel.Columns[4].HeaderCell.Value = "Total Answered";




                dgrid_mngSurvViewDel.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_mngSurvViewDel.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_mngSurvViewDel.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_mngSurvViewDel.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;




            }
            catch (SqlException ex) { }
            catch (Exception ex) { }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                string survayId = dgrid_mngSurvViewDel.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                con.Open();
                SqlCommand cmd = new SqlCommand("delete from surveyQ where survayId='" + survayId + "'", con);
                int i = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                if (i == 0) { MessageBox.Show(this, "Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { MessageBox.Show(this, "Deleted Succesfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                dataGridViewRefresh();

            }
            else if (e.ColumnIndex != 0 && e.RowIndex >= 0)
            {
                string survayId = dgrid_mngSurvViewDel.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                updateListView(survayId);
            }
              
        }

        public void updateListView(String survayId)
        {
            ltsv_mngSurvVRes.Items.Clear();
            ltsv_mngSurvVRes.Columns.Clear();
            con.Open();


            try
            {

              

                ltsv_mngSurvVRes.Columns.Add("Question", 400, HorizontalAlignment.Center);

                ltsv_mngSurvVRes.Columns.Add("Strongly Agree", 200, HorizontalAlignment.Center);

                ltsv_mngSurvVRes.Columns.Add("Agree", 200, HorizontalAlignment.Center);

                ltsv_mngSurvVRes.Columns.Add("Disagree", 200, HorizontalAlignment.Center);

                ltsv_mngSurvVRes.Columns.Add("Strongly Disagree", 200, HorizontalAlignment.Center);

                ltsv_mngSurvVRes.Columns.Add("No Comments", 200, HorizontalAlignment.Center);







                ltsv_mngSurvVRes.View = View.Details;

                ltsv_mngSurvVRes.GridLines = true;

             

                ltsv_mngSurvVRes.BackColor = Color.Lavender;

                ltsv_mngSurvVRes.ForeColor = Color.Black;



                SqlCommand cmd = new SqlCommand("select Q1,[Q1-SA],[Q1-A],[Q1-D],[Q1-SD],[Q1-NC],Q2,[Q2-SA],[Q2-A],[Q2-D],[Q2-SD],[Q2-NC],Q3,[Q3-SA],[Q3-A],[Q3-D],[Q3-SD],[Q3-NC],Q4,[Q4-SA],[Q4-A],[Q4-D],[Q4-SD],[Q4-NC],Q5,[Q5-SA],[Q5-A],[Q5-D],[Q5-SD],[Q5-NC],totalAnswered from surveyQ where survayId='" + survayId + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    String q1= (String)dr["Q1"];
                    double  q1sa = (int)dr["Q1-SA"];
                    double q1a = (int)dr["Q1-A"];
                    double q1d = (int)dr["Q1-D"];
                    double q1sd = (int)dr["Q1-SD"];
                    double q1nc = (int)dr["Q1-NC"];

                    String q2 = (String)dr["Q2"];
                    double q2sa = (int)dr["Q2-SA"];                   
                    double q2a = (int)dr["Q2-A"];
                    double q2d = (int)dr["Q2-D"];
                    double q2sd = (int)dr["Q2-SD"];
                    double q2nc = (int)dr["Q2-NC"];

                    String q3 = (String)dr["Q3"];
                    double q3sa = (int)dr["Q3-SA"];
                    double q3a = (int)dr["Q3-A"];
                    double q3d = (int)dr["Q3-D"];
                    double q3sd = (int)dr["Q3-SD"];
                    double q3nc = (int)dr["Q3-NC"];

                    String q4 = (String)dr["Q4"];
                    double q4sa = (int)dr["Q4-SA"];
                    double q4a = (int)dr["Q4-A"];
                    double q4d = (int)dr["Q4-D"];
                    double q4sd = (int)dr["Q4-SD"];
                    double q4nc = (int)dr["Q4-NC"];

                    String q5 = (String)dr["Q5"];
                    double q5sa = (int)dr["Q5-SA"];
                    double q5a = (int)dr["Q5-A"];
                    double q5d = (int)dr["Q5-D"];
                    double q5sd = (int)dr["Q5-SD"];
                    double q5nc = (int)dr["Q5-NC"];


                   int totalAns = (int)dr["totalAnswered"];











                    ltsv_mngSurvVRes.Items.Add(q1);
                    ltsv_mngSurvVRes.Items[0].SubItems.Add(q1sa/ totalAns*100+"%");
                    ltsv_mngSurvVRes.Items[0].SubItems.Add(q1a / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[0].SubItems.Add(q1d / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[0].SubItems.Add(q1sd / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[0].SubItems.Add(q1nc / totalAns * 100 + "%");

                    ltsv_mngSurvVRes.Items.Add(q2);
                    ltsv_mngSurvVRes.Items[1].SubItems.Add(q2sa / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[1].SubItems.Add(q2a / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[1].SubItems.Add(q2d / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[1].SubItems.Add(q2sd / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[1].SubItems.Add(q2nc / totalAns * 100 + "%");

                    ltsv_mngSurvVRes.Items.Add(q3);
                    ltsv_mngSurvVRes.Items[2].SubItems.Add(q3sa / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[2].SubItems.Add(q3a / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[2].SubItems.Add(q3d / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[2].SubItems.Add(q3sd / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[2].SubItems.Add(q3nc / totalAns * 100 + "%");

                    ltsv_mngSurvVRes.Items.Add(q4);
                    ltsv_mngSurvVRes.Items[3].SubItems.Add(q4sa / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[3].SubItems.Add(q4a / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[3].SubItems.Add(q4d / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[3].SubItems.Add(q4sd / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[3].SubItems.Add(q4nc / totalAns * 100 + "%");

                    ltsv_mngSurvVRes.Items.Add(q5);
                    ltsv_mngSurvVRes.Items[4].SubItems.Add(q5sa / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[4].SubItems.Add(q5a / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[4].SubItems.Add(q5d / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[4].SubItems.Add(q5sd / totalAns * 100 + "%");
                    ltsv_mngSurvVRes.Items[4].SubItems.Add(q5nc / totalAns * 100 + "%");






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
    }
}
