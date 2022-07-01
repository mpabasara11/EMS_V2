using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmTalkToHrp1 : Form 
    {
        //get empNum from login
        String employeeNumber = Login.empNumforuser;

        //get connection string from login form
        SqlConnection con = Login.con;

        public frmTalkToHrp1()
        {
            InitializeComponent();
        }
        
    

        private void button1_Click(object sender, EventArgs e)
        {
            // hr manager(manager)
            if (Regex.IsMatch(employeeNumber, @"^[eE][0-9]*[0-9]$"))
            {
                frmTalkToHrp2 frm = new frmTalkToHrp2();
                frm.TopLevel = false;
                EmployeeDashboard.employeeHomepanel.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }
          else  if (Regex.IsMatch(employeeNumber, @"^[mM][0-9]*[0-9]$"))
            {

                frmTalkToHrp2 frm = new frmTalkToHrp2();
                 frm.TopLevel = false;
                 Managerdashboard.managerHomepanel.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }
            else if (Regex.IsMatch(employeeNumber, @"^[aA][0-9]*[0-9]$"))
            {

                frmTalkToHrp2 frm = new frmTalkToHrp2();
                frm.TopLevel = false;
                Managerdashboard.managerHomepanel.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if (picker_talkToHr1issueType.Text=="")
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(picker_talkToHr1issueType, "warning");
                    t.Show("Select Issue Type", picker_talkToHr1issueType, 2000);
                }
                else if (picker_talkToHr1issueDesc.Text=="")
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(picker_talkToHr1issueDesc, "warning");
                    t.Show("Select Issue Description", picker_talkToHr1issueDesc, 2000);
                }
                else {
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Pdf Documents(*.pdf)|*.pdf", ValidateNames = true })
                   
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure you want to download this file? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes)
                            {
                                String fileName = saveFileDialog.FileName;


                                using (SqlCommand cmd = new SqlCommand("select attachment from basicTroubleshoot where issueType='" + picker_talkToHr1issueType.Text + "' and issueDesc='" + picker_talkToHr1issueDesc.Text + "'", con))
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

                                            MessageBox.Show("Something Went Wrong!");
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

        private void frmTalkToHrp1_Load(object sender, EventArgs e)
        {con.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("select issueType from basicTroubleshoot ORDER BY issueType  ASC", con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //used to store issue type temparaly
                String tmp = "";
                do 
                {
                    while(sqlDataReader.Read())
                    {

                        String type = (String)sqlDataReader["issueType"];
                     
                     


                        if (tmp == type)
                        {

                        }
                        else
                        {
                            picker_talkToHr1issueType.Items.Add(type);
                        }


                        tmp = type;
            


                    }            
                
                
                
             
                
                }
                while(sqlDataReader.NextResult());
            
                sqlDataReader.Close();
                sqlCommand.Dispose();
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

        private void picker_talkToHr1issueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker_talkToHr1issueDesc.Items.Clear();

            con.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("select issueDesc from basicTroubleshoot where issueType='"+picker_talkToHr1issueType.Text+"' ORDER BY issueDesc  ASC", con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

         
                do
                {
                    while (sqlDataReader.Read())
                    {

                        String desc = (String)sqlDataReader["issueDesc"];

                     
                            picker_talkToHr1issueDesc.Items.Add(desc);
                       


                    }





                }
                while (sqlDataReader.NextResult());

                sqlDataReader.Close();
                sqlCommand.Dispose();
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
    }
}
