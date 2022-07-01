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
    public partial class frmSurvey : Form
    {
        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public frmSurvey()
        {
            InitializeComponent();
        }

        private void frmSurvey_Load(object sender, EventArgs e)
        {
            dataGridViewRefresh();
        }

        private void dataGridViewRefresh()
        {
            con.Open();


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();           

              

          
                    adp = new SqlDataAdapter("select survayId,date,survayType,totalAnswered from surveyQ", con);

              



                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgrid_survView.DataSource = dt;

                dgrid_survView.Columns[1].HeaderCell.Value = "Survey ID";
                dgrid_survView.Columns[2].HeaderCell.Value = "Date";
                dgrid_survView.Columns[3].HeaderCell.Value = "Survay Type";
                dgrid_survView.Columns[4].HeaderCell.Value = "Total Feedbacks Recieved";
               


                dgrid_survView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_survView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_survView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;             
                dgrid_survView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            catch (SqlException ex) { }
            catch (Exception ex) { }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                try
                {
                    dgrid_survView.CurrentRow.Selected = true;
                   String  sid = dgrid_survView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                    frmSurvayForm frmSurvayForm = new frmSurvayForm(sid);
                    frmSurvayForm.ShowDialog();

                }
              
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                dataGridViewRefresh();

            }
        }
    }
}
