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
    public partial class frmAddpayslips : Form
    {

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public frmAddpayslips()
        {
            InitializeComponent();
        }

        private void btn_AddPaySlip_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                //verify employee number exist of users
                int i = 0;
                SqlCommand cmd = new SqlCommand("select * from users where empNum='" + txt_AddPaySlipEmpId.Text + "';", con);
                SqlDataReader RD1 = cmd.ExecuteReader();

                if (RD1.Read())
                {
                    i++;
                    RD1.Close();
                    cmd.Dispose();

                }
                else
                {
                    i = 0;
                    RD1.Close();
                    cmd.Dispose();
                }

                //check that already there is a record

                int j = 0;
                SqlCommand cmd2 = new SqlCommand("select * from payslips where empNum='" + txt_AddPaySlipEmpId.Text + "' and date='"+ dtPicker_AddPaySlipDate.Value.ToString("yyyy-MM-dd") + "';", con);
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







                if (txt_AddPaySlipEmpId.Text == "")
                {


                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_AddPaySlipEmpId, "warning");
                    t.Show("Enter The Employee Number", txt_AddPaySlipEmpId, 2000);




                }
                else if (i == 0)
                {

                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_AddPaySlipEmpId, "warning");
                    t.Show("Your Entered Employee Number is not Found in Our Databases!", txt_AddPaySlipEmpId, 2000);
                }
                else if (j != 0)
                {
                    MessageBox.Show(this, "Looks Like There IS Already A Record On Same Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else 
                {
                    using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true }) 
                    {
                        if (dlg.ShowDialog() == DialogResult.OK) 
                        {
                        DialogResult result = MessageBox.Show(this,"Are You Sure YOu Want To Upload This File ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                            if (result == DialogResult.Yes) 
                            {
                            String fileName=dlg.FileName;


                                FileStream fileStream=File.OpenRead(fileName);
                                byte[] data = new byte[fileStream.Length];
                                fileStream.Read(data, 0, data.Length);//could get a error here notify
                                fileStream.Close();


                                using (SqlCommand cmd1 = new SqlCommand("insert into payslips(payslipId,empNum,date,attachment) values(@slipId,@empNum,@date,@attach)", con))
                                {
                                    String slipId = DateTime.Now.ToString("yyyyMMddHHmmss") + txt_AddPaySlipEmpId.Text;

                                    cmd1.Parameters.AddWithValue("@slipId", slipId);
                                    cmd1.Parameters.AddWithValue("@empNum", txt_AddPaySlipEmpId.Text);
                                    cmd1.Parameters.AddWithValue("@date", dtPicker_AddPaySlipDate.Value.ToString("yyyy-MM-dd"));
                                    cmd1.Parameters.AddWithValue("@attach", data);

                                    int x = cmd1.ExecuteNonQuery();
                                    cmd1.Dispose();

                                    if (x != 0)
                                    {
                                        MessageBox.Show(this, "Uploaded Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_AddPaySlipEmpId.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Uploaded Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txt_AddPaySlipEmpId.Text = "";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DeletePaySlip_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if (txt_DeletePaySlipEmpId.Text == "")
                {


                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_DeletePaySlipEmpId, "warning");
                    t.Show("Enter The Employee Number", txt_DeletePaySlipEmpId, 2000);




                }

                else
                {


                    SqlCommand cmd = new SqlCommand("delete from payslips where empNum=@empNum and date=@date;", con);
                    cmd.Parameters.AddWithValue("@empNum", txt_DeletePaySlipEmpId.Text);
                    cmd.Parameters.AddWithValue("@date", dtPicker_DeletePaySlipDate.Value.ToString("yyyy-MM-dd"));





                    int i = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (i == 0)
                    {
                        MessageBox.Show(this, "There Is No Record Matching With The Information Which You Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else

                    {
                        MessageBox.Show(this, "Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_DeletePaySlipEmpId.Text = "";


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
}
