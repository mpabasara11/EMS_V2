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
using System.Net.Mail;
using System.Net;


namespace EmployeeManagementSystem
{
 
    public partial class frmTalkToHrp2 : Form
    {
        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public frmTalkToHrp2()
        {
            InitializeComponent();
        }

        private void frmTalkToHrContactHr_Load(object sender, EventArgs e)
        {
            //disable send button when load
            btn_contHrSend.Enabled = false;

            dgrid_tlkToH2SelHrs.BackgroundColor = Color.Lavender;

            gridRefresh();
        }

        public void gridRefresh()
        {
            con.Open();


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();



                adp = new SqlDataAdapter("select empName,gender,empContNum,empMail,jobRole from users where empNum like'h%';", con);





                DataTable dtt = new DataTable();
                adp.Fill(dtt);
                dgrid_tlkToH2SelHrs.DataSource = dtt;




                dgrid_tlkToH2SelHrs.Columns[1].HeaderCell.Value = "Name";
                dgrid_tlkToH2SelHrs.Columns[2].HeaderCell.Value = "Gender";
                dgrid_tlkToH2SelHrs.Columns[3].HeaderCell.Value = "Contact Number";
                dgrid_tlkToH2SelHrs.Columns[4].HeaderCell.Value = "Mail";
                dgrid_tlkToH2SelHrs.Columns[5].HeaderCell.Value = "Job Role";

                dgrid_tlkToH2SelHrs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_tlkToH2SelHrs.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_tlkToH2SelHrs.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_tlkToH2SelHrs.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgrid_tlkToH2SelHrs.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;






                // dgrid_resign.Columns[9].Width = 150;







            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dgrid_tlkToH2SelHrs.CurrentRow.Selected = true;
                lbl_contHrTo.Text =  dgrid_tlkToH2SelHrs.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                btn_contHrSend.Enabled = true;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String empMail = "";
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("select empMail from users where empNum='"+ employeeNumber + "'",con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   
                    empMail = (String)dr["empMail"];
                    
                    dr.Close();
                    cmd.Dispose();
                }
                else
                {
                    empMail = "Employee Number" + employeeNumber;
                    dr.Close();
                    cmd.Dispose();
                }


                MailMessage mm = new MailMessage("mpabasara11@gmail.com", lbl_contHrTo.Text);
                mm.Subject = "Problem Report";
                mm.Body = "This is an Auto Generated Mail.Do not Direct Reply to this Message.Please Reply to "+empMail+" Employee Number :"+employeeNumber+" Message :"+txt_contHrMes.Text;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                System.Net.NetworkCredential nc = new System.Net.NetworkCredential(Properties.Settings.Default.mailCredUserName,Properties.Settings.Default.mailCredPaswd);
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(mm);



                MessageBox.Show(this, "Mail Sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_contHrSend.Enabled = false;
                lbl_contHrTo.Text = "";
                txt_contHrMes.Text = "";
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

con.Close();

        }
    }
}
