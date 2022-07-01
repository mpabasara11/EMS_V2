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
    public partial class frmMyPaySlip : Form
    {
        public frmMyPaySlip()
        {
            InitializeComponent();
        }

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_mypayDownload_Click(object sender, EventArgs e)
        {
            con.Open();
            try {



                int j = 0;
                SqlCommand cmd2 = new SqlCommand("select * from payslips where empNum='" + lbl_mypayslipEmpNum.Text + "' and date='" + picker_mypayslipDate.Value.ToString("yyyy-MM-dd") + "';", con);
                SqlDataReader RD3 = cmd2.ExecuteReader();

                if (RD3.Read())
                {
                    j++;
                    RD3.Close();
                    cmd2.Dispose();

                }
                else
                {
                    j = 0;
                    RD3.Close();
                    cmd2.Dispose();
                }





                if (j == 0) 
                {
                MessageBox.Show(this,"No Attachment Found On Selected Date","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if(j == 1)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Pdf Documents(*.pdf)|*.pdf", ValidateNames = true })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure you want to download this file? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes)
                            {
                                String fileName = saveFileDialog.FileName;


                                using (SqlCommand cmd = new SqlCommand("select attachment from payslips where empNum='" + lbl_mypayslipEmpNum.Text + "' and date='" + picker_mypayslipDate.Value.ToString("yyyy-MM-dd") + "'", con))
                                {
                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            byte[] filedata = (byte[])reader.GetValue(0);
                                            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
                                            {
                                                using (BinaryWriter bw = new BinaryWriter(fs))
                                                {
                                                    bw.Write(filedata);
                                                    bw.Close();
                                                }
                                            }
                                            MessageBox.Show("Download Done!");
                                        }
                                        else
                                        {

                                            MessageBox.Show("Something Went Wrong,Please Contact System Admin");
                                        }

                                    }

                                }
                            }

                        }


                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void frmMyPaySlip_Load(object sender, EventArgs e)
        {
            lbl_mypayslipEmpNum.Text = employeeNumber;
        }
    }
}
