using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmBasicSettings : Form
    {
        public frmBasicSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_basicSetCas.Text == "")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetCas, "warning");
                t.Show("Enter Casual Leaves", txt_basicSetCas, 2000);



            }
            else if (!Regex.IsMatch(txt_basicSetCas.Text, @"^[0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetCas, "warning");
                t.Show("Not a valid Input", txt_basicSetCas, 2000);


            }

            else
            {
                Properties.Settings.Default.casual_leaves = int.Parse(txt_basicSetCas.Text);
                Properties.Settings.Default.Save();

                MessageBox.Show(this, "Updated");
                txt_basicSetCas.Text = "";


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_basicSetMed.Text == "")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetMed, "warning");
                t.Show("Enter Medical Leaves", txt_basicSetMed, 2000);



            }
            else if (!Regex.IsMatch(txt_basicSetMed.Text, @"^[0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetMed, "warning");
                t.Show("Not a valid Input", txt_basicSetMed, 2000);


            }

            else
            {
                Properties.Settings.Default.mediacal_leave = int.Parse(txt_basicSetMed.Text);
                Properties.Settings.Default.Save();

                MessageBox.Show(this, "Updated");
                txt_basicSetMed.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_basicSetFmla.Text == "")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetFmla, "warning");
                t.Show("Enter FMLA", txt_basicSetFmla, 2000);



            }
            else if (!Regex.IsMatch(txt_basicSetFmla.Text, @"^[0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetFmla, "warning");
                t.Show("Not a valid Input", txt_basicSetFmla, 2000);


            }

            else
            {
                Properties.Settings.Default.FMLA = int.Parse(txt_basicSetFmla.Text);
                Properties.Settings.Default.Save();

                MessageBox.Show(this, "Updated");
                txt_basicSetFmla.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_basicSetMob.Text == "")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetMob, "warning");
                t.Show("Enter Company Mobile", txt_basicSetMob, 2000);



            }
            else if (!Regex.IsMatch(txt_basicSetMob.Text, @"^[0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetMob, "warning");
                t.Show("Not a valid Input", txt_basicSetMob, 2000);


            }

            else
            {
                Properties.Settings.Default.CompanyMobile =txt_basicSetMob.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show(this, "Updated");
                txt_basicSetMob.Text = "";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_basicSetMail.Text == "")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetMail, "warning");
                t.Show("Enter Company Mail", txt_basicSetMail, 2000);



            }
            else if (!Regex.IsMatch(txt_basicSetMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetMail, "warning");
                t.Show("Not a Valid Email", txt_basicSetMail, 2000);


            }


            else
            {
                Properties.Settings.Default.CompanyMail = txt_basicSetMail.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show(this, "Updated");
                txt_basicSetMail.Text = "";


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_basicSetExecT.Text == "")
            {


                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetExecT, "warning");
                t.Show("Enter Execution Time", txt_basicSetExecT, 2000);



            }
            else if (!Regex.IsMatch(txt_basicSetExecT.Text, @"^[0-9]*[0-9]$"))
            {

                ToolTip t = new ToolTip();
                t.UseFading = true;
                t.UseAnimation = true;
                t.IsBalloon = true;
                t.SetToolTip(txt_basicSetExecT, "warning");
                t.Show("Not a valid Input", txt_basicSetExecT, 2000);


            }

            else
            {
                Properties.Settings.Default.ResignationTime = int.Parse(txt_basicSetExecT.Text);
                Properties.Settings.Default.Save();

                MessageBox.Show(this, "Updated");
                txt_basicSetExecT.Text = "";


            }
        }
    }
}
