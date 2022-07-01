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
    public partial class FrmLeavestatus : Form
    {

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public FrmLeavestatus()
        {
            InitializeComponent();
        }

        private void FrmLeavestatus_Load(object sender, EventArgs e)
        {
            updateListViewPending();
            updateListViewFeedback();
        }



        public void updateListViewPending()
        {
            lstview_LeaveStatusPending.Items.Clear();
            lstview_LeaveStatusPending.Columns.Clear();
            con.Open();


            try
            {

                SqlDataAdapter adp = new SqlDataAdapter("select * from leave where  empNum='" + employeeNumber + "' AND status='pending'", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                lstview_LeaveStatusPending.Columns.Add("Leave ID", 80, HorizontalAlignment.Center);

                lstview_LeaveStatusPending.Columns.Add("Employee Num", 70, HorizontalAlignment.Center);

                lstview_LeaveStatusPending.Columns.Add("Leave Type", 90, HorizontalAlignment.Center);

                lstview_LeaveStatusPending.Columns.Add("Date", 100, HorizontalAlignment.Center);

                lstview_LeaveStatusPending.Columns.Add("Leave Start", 100, HorizontalAlignment.Center);

                lstview_LeaveStatusPending.Columns.Add("Leave End", 100, HorizontalAlignment.Center);

                lstview_LeaveStatusPending.Columns.Add("Reason", 200, HorizontalAlignment.Center);

                lstview_LeaveStatusPending.Columns.Add("Status", 115, HorizontalAlignment.Center);





                lstview_LeaveStatusPending.View = View.Details;

                lstview_LeaveStatusPending.GridLines = false;

                lstview_LeaveStatusPending.BackColor = Color.Lavender;

                lstview_LeaveStatusPending.ForeColor = Color.Black;


                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)

                {

                    lstview_LeaveStatusPending.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    lstview_LeaveStatusPending.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lstview_LeaveStatusPending.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    lstview_LeaveStatusPending.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    lstview_LeaveStatusPending.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    lstview_LeaveStatusPending.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    lstview_LeaveStatusPending.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    lstview_LeaveStatusPending.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());







                }
            }
            catch(SqlException ex) 
            {
            
            }
            catch (Exception ex)
            {

            }


            con.Close();


        }


        public void updateListViewFeedback()
        {
            lstview_LeaveStatusFeedback.Items.Clear();
            lstview_LeaveStatusFeedback.Columns.Clear();
            con.Open();


            try
            {

                SqlDataAdapter adp = new SqlDataAdapter("select * from leave where  empNum='" + employeeNumber + "' AND (status='Approved' OR status='Disapproved' )", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                lstview_LeaveStatusFeedback.Columns.Add("Leave ID", 80, HorizontalAlignment.Center);

                lstview_LeaveStatusFeedback.Columns.Add("Employee Num", 70, HorizontalAlignment.Center);

                lstview_LeaveStatusFeedback.Columns.Add("Leave Type", 90, HorizontalAlignment.Center);

                lstview_LeaveStatusFeedback.Columns.Add("Date", 100, HorizontalAlignment.Center);

                lstview_LeaveStatusFeedback.Columns.Add("Leave Start", 100, HorizontalAlignment.Center);

                lstview_LeaveStatusFeedback.Columns.Add("Leave End", 100, HorizontalAlignment.Center);

                lstview_LeaveStatusFeedback.Columns.Add("Reason", 200, HorizontalAlignment.Center);

                lstview_LeaveStatusFeedback.Columns.Add("Status", 115, HorizontalAlignment.Center);





                lstview_LeaveStatusFeedback.View = View.Details;

                lstview_LeaveStatusFeedback.GridLines = false;

                lstview_LeaveStatusFeedback.BackColor = Color.Lavender;

                lstview_LeaveStatusFeedback.ForeColor = Color.Black;


                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)

                {

                    lstview_LeaveStatusFeedback.Items.Add(dt.Rows[i].ItemArray[0].ToString());

                    lstview_LeaveStatusFeedback.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lstview_LeaveStatusFeedback.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    lstview_LeaveStatusFeedback.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    lstview_LeaveStatusFeedback.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    lstview_LeaveStatusFeedback.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    lstview_LeaveStatusFeedback.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    lstview_LeaveStatusFeedback.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());







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

     

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
