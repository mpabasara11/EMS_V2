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
    public partial class frmInstructionManagement : Form
    {
        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;

        public frmInstructionManagement()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                //verify employee number exist of users
                int i = 0;
                SqlCommand cmd = new SqlCommand("select * from basicTroubleshoot where issueType='"+picker_instructionMngIType.Text+ "' and issueDesc='"+ txt_instructionMngIDes .Text+ "';", con);
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

               





                if (txt_instructionMngIDes.Text == "")
                {


                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_instructionMngIDes, "warning");
                    t.Show("Enter the description", txt_instructionMngIDes, 2000);




                }
                else if (i != 0)
                {

                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_instructionMngIDes, "warning");
                    t.Show("Entry with a same description found!", txt_instructionMngIDes, 2000);
                }
            
                else
                {
                    using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult result = MessageBox.Show(this, "Are You Sure YOu Want To Upload This File ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                String fileName = dlg.FileName;


                                FileStream fileStream = File.OpenRead(fileName);
                                byte[] data = new byte[fileStream.Length];
                                fileStream.Read(data, 0, data.Length);//could get a error here notify
                                fileStream.Close();


                                using (SqlCommand cmd1 = new SqlCommand("insert into basicTroubleshoot(issueType,issueDesc,attachment) values(@type,@des,@attach)", con))
                                {
                                   

                                    cmd1.Parameters.AddWithValue("@type", picker_instructionMngIType.Text);
                                    cmd1.Parameters.AddWithValue("@des", txt_instructionMngIDes.Text);                               
                                    cmd1.Parameters.AddWithValue("@attach", data);

                                    int x = cmd1.ExecuteNonQuery();
                                    cmd1.Dispose();

                                    if (x != 0)
                                    {
                                        MessageBox.Show(this, "Uploaded Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        picker_instructionMngIType.SelectedIndex =0;
                                        txt_instructionMngIDes.Text = "";
                                        

                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Uploaded Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                     
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
            gridRefresh();
        }

        private void frmInstructionManagement_Load(object sender, EventArgs e)
        {
            picker_instructionMngIType.SelectedIndex = 0;
            dgrid_instrDelInstr.BackgroundColor= Color.Lavender;

            gridRefresh();
        }

        public void gridRefresh() 
        {
            con.Open();


            try
            {
                SqlDataAdapter adp = new SqlDataAdapter();



                adp = new SqlDataAdapter("select issueType,issueDesc from basicTroubleshoot;", con);





                DataTable dtt = new DataTable();
                adp.Fill(dtt);
                dgrid_instrDelInstr.DataSource = dtt;




                dgrid_instrDelInstr.Columns[1].HeaderCell.Value = "Issue Type";
                dgrid_instrDelInstr.Columns[2].HeaderCell.Value = "Issue Description";
              

                dgrid_instrDelInstr.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;              
                dgrid_instrDelInstr.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;






                // dgrid_resign.Columns[9].Width = 150;







            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { String type = "";
            String desc = "";
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
             
                try
                {
                    dgrid_instrDelInstr.CurrentRow.Selected = true;
                    type = dgrid_instrDelInstr.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    desc = dgrid_instrDelInstr.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("delete from basicTroubleshoot where issueType='"+type+ "' and issueDesc='"+desc+"';",con);
               int i=sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    con.Close();

                    if (i == 0) { MessageBox.Show(this, "Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else { gridRefresh(); }

                
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
