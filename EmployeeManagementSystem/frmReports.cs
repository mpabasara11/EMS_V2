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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace EmployeeManagementSystem
{
    public partial class frmReports : Form
    {

        //get empNum from login
        String employeeNumber = Login.empNumforuser;


        //get connection string from login form
        SqlConnection con = Login.con;


        public frmReports()
        {
            InitializeComponent();


            picker_reportLeaveDate.Format = DateTimePickerFormat.Custom;
            picker_reportLeaveDate.CustomFormat = "yyyy";
            picker_reportLeaveDate.ShowUpDown = true;


            picker_reportAttenDate.Format = DateTimePickerFormat.Custom;
            picker_reportAttenDate.CustomFormat = "yyyy";
            picker_reportAttenDate.ShowUpDown = true;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files|*.pdf" })
            {

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        PdfContentByte pdfContent = pdfWriter.DirectContent;
                        iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);

                        ///all font styles are defined here
                        iTextSharp.text.Font tableheaderFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, 1, BaseColor.BLACK);
                        iTextSharp.text.Font tablecolFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, BaseColor.BLACK);
                        iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 20, BaseColor.BLACK);


                        Paragraph p0 = new Paragraph("My Flight Zone Company Limited");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph("No: 37/1, Colombo Road,");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph("Kurana,Katunayake,");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph("Sri Lanka");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        LineSeparator lineSeparator = new LineSeparator();
                        doc.Add(lineSeparator);

                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);



                        p0 = new Paragraph();

                        p0.Add(new Chunk("Employee Report", headerFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        doc.Add(p0);

                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph("General");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        //////////////////////////////////////general employees

                        PdfPTable table0 = new PdfPTable(7);
                        table0.WidthPercentage = 100;


                        PdfPCell cell00 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Emp Num", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell00.AddElement(p0);
                        cell00.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell00.Border = 0;
                        table0.AddCell(cell00);

                        PdfPCell cell01 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Name", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell01.AddElement(p0);
                        cell01.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell01.Border = 0;
                        table0.AddCell(cell01);

                        PdfPCell cell02 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Job Role", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell02.AddElement(p0);
                        cell02.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell02.Border = 0;
                        table0.AddCell(cell02);

                        PdfPCell cell03 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Address", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell03.AddElement(p0);
                        cell03.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell03.Border = 0;
                        table0.AddCell(cell03);

                        PdfPCell cell04 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Email", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell04.AddElement(p0);
                        cell04.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell04.Border = 0;
                        table0.AddCell(cell04);

                        PdfPCell cell05 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Mobile", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell05.AddElement(p0);
                        cell05.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell05.Border = 0;
                        table0.AddCell(cell05);

                        PdfPCell cell06 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Service Time", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell06.AddElement(p0);
                        cell06.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell06.Border = 0;
                        table0.AddCell(cell06);



                        SqlCommand sqlCommand0 = new SqlCommand("select * from users where empNum like'e%'", con);
                        SqlDataReader sqlDataReader0 = sqlCommand0.ExecuteReader();


                        do
                        {

                            while (sqlDataReader0.Read())
                            {

                                String EmployeNum = sqlDataReader0["empNum"].ToString();
                                String EmployeName = sqlDataReader0["empName"].ToString();
                                String jobRole = sqlDataReader0["jobRole"].ToString();
                                String address = sqlDataReader0["empAddr"].ToString();
                                String email = sqlDataReader0["empMail"].ToString();
                                String mobile = sqlDataReader0["empContNum"].ToString();
                                String joinedD = sqlDataReader0["joinedDate"].ToString();


                                DateTime manJoinedD2 = Convert.ToDateTime(joinedD);
                                DateTime today = DateTime.Now;
                                TimeSpan duration = today - manJoinedD2;








                                PdfPCell pdfPCell0 = new PdfPCell();
                                Paragraph par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(EmployeNum, tablecolFont));
                                pdfPCell0.AddElement(par);
                                pdfPCell0.Border = 0;
                                table0.AddCell(pdfPCell0);


                                PdfPCell pdfPCell1 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(EmployeName, tablecolFont));
                                pdfPCell1.AddElement(par);
                                pdfPCell1.Border = 0;
                                table0.AddCell(pdfPCell1);


                                PdfPCell pdfPCell2 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(jobRole, tablecolFont));
                                pdfPCell2.AddElement(par);
                                pdfPCell2.Border = 0;
                                table0.AddCell(pdfPCell2);


                                PdfPCell pdfPCell3 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(address, tablecolFont));
                                pdfPCell3.AddElement(par);
                                pdfPCell3.Border = 0;
                                table0.AddCell(pdfPCell3);


                                PdfPCell pdfPCell4 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(email, tablecolFont));
                                pdfPCell4.AddElement(par);
                                pdfPCell4.Border = 0;
                                table0.AddCell(pdfPCell4);


                                PdfPCell pdfPCell5 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(mobile, tablecolFont));
                                pdfPCell5.AddElement(par);
                                pdfPCell5.Border = 0;
                                table0.AddCell(pdfPCell5);


                                PdfPCell pdfPCell6 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(duration.Days.ToString() + " Days", tablecolFont));
                                pdfPCell6.AddElement(par);
                                pdfPCell6.Border = 0;
                                table0.AddCell(pdfPCell6);
                            }
                        }
                        while (sqlDataReader0.NextResult());


                        sqlDataReader0.Close();
                        sqlCommand0.Dispose();

                        doc.Add(table0);

                        ///////////////////////////////////////////////////////managers///////////////////
                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph("Management");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);


                        PdfPTable table1 = new PdfPTable(7);
                        table1.WidthPercentage = 100;


                        PdfPCell cell10 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Emp Num", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell10.AddElement(p0);
                        cell10.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell10.Border = 0;
                        table1.AddCell(cell10);

                        PdfPCell cell11 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Name", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell11.AddElement(p0);
                        cell11.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell11.Border = 0;
                        table1.AddCell(cell11);

                        PdfPCell cell12 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Job Role", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell12.AddElement(p0);
                        cell12.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell12.Border = 0;
                        table1.AddCell(cell12);

                        PdfPCell cell13 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Address", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell13.AddElement(p0);
                        cell13.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell13.Border = 0;
                        table1.AddCell(cell13);

                        PdfPCell cell14 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Email", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell14.AddElement(p0);
                        cell14.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell14.Border = 0;
                        table1.AddCell(cell14);

                        PdfPCell cell15 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Mobile", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell15.AddElement(p0);
                        cell15.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell15.Border = 0;
                        table1.AddCell(cell15);

                        PdfPCell cell16 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Service Time", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell16.AddElement(p0);
                        cell16.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell16.Border = 0;
                        table1.AddCell(cell16);








                        SqlCommand sqlCommand1 = new SqlCommand("select * from users where (empNum like'm%')or (empNum like'a%')", con);
                        SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();


                        do
                        {

                            while (sqlDataReader1.Read())
                            {

                                String EmployeNum = sqlDataReader1["empNum"].ToString();
                                String EmployeName = sqlDataReader1["empName"].ToString();
                                String jobRole = sqlDataReader1["jobRole"].ToString();
                                String address = sqlDataReader1["empAddr"].ToString();
                                String email = sqlDataReader1["empMail"].ToString();
                                String mobile = sqlDataReader1["empContNum"].ToString();
                                String joinedD = sqlDataReader1["joinedDate"].ToString();


                                DateTime manJoinedD2 = Convert.ToDateTime(joinedD);
                                DateTime today = DateTime.Now;
                                TimeSpan duration = today - manJoinedD2;








                                PdfPCell pdfPCell0 = new PdfPCell();
                                Paragraph par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(EmployeNum, tablecolFont));
                                pdfPCell0.AddElement(par);
                                pdfPCell0.Border = 0;
                                table1.AddCell(pdfPCell0);


                                PdfPCell pdfPCell1 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(EmployeName, tablecolFont));
                                pdfPCell1.AddElement(par);
                                pdfPCell1.Border = 0;
                                table1.AddCell(pdfPCell1);


                                PdfPCell pdfPCell2 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(jobRole, tablecolFont));
                                pdfPCell2.AddElement(par);
                                pdfPCell2.Border = 0;
                                table1.AddCell(pdfPCell2);


                                PdfPCell pdfPCell3 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(address, tablecolFont));
                                pdfPCell3.AddElement(par);
                                pdfPCell3.Border = 0;
                                table1.AddCell(pdfPCell3);


                                PdfPCell pdfPCell4 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(email, tablecolFont));
                                pdfPCell4.AddElement(par);
                                pdfPCell4.Border = 0;
                                table1.AddCell(pdfPCell4);


                                PdfPCell pdfPCell5 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(mobile, tablecolFont));
                                pdfPCell5.AddElement(par);
                                pdfPCell5.Border = 0;
                                table1.AddCell(pdfPCell5);


                                PdfPCell pdfPCell6 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(duration.Days.ToString() + " Days", tablecolFont));
                                pdfPCell6.AddElement(par);
                                pdfPCell6.Border = 0;
                                table1.AddCell(pdfPCell6);
                            }
                        }
                        while (sqlDataReader1.NextResult());


                        sqlDataReader1.Close();
                        sqlCommand1.Dispose();

                        doc.Add(table1);
                        ///////////////////////////////////////hr/////////////////////////////////////////
                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph("HR");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);

                        p0 = new Paragraph(" ");
                        p0.Alignment = Element.ALIGN_LEFT;
                        doc.Add(p0);


                        PdfPTable table2 = new PdfPTable(7);
                        table2.WidthPercentage = 100;


                        PdfPCell cell20 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Emp Num", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell20.AddElement(p0);
                        cell20.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell20.Border = 0;
                        table2.AddCell(cell20);

                        PdfPCell cell21 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Name", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell21.AddElement(p0);
                        cell21.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell21.Border = 0;
                        table2.AddCell(cell21);

                        PdfPCell cell22 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Job Role", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell22.AddElement(p0);
                        cell22.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell22.Border = 0;
                        table2.AddCell(cell12);

                        PdfPCell cell23 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Address", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell23.AddElement(p0);
                        cell23.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell23.Border = 0;
                        table2.AddCell(cell23);

                        PdfPCell cell24 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Email", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell24.AddElement(p0);
                        cell24.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell24.Border = 0;
                        table2.AddCell(cell24);

                        PdfPCell cell25 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Mobile", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell25.AddElement(p0);
                        cell25.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell25.Border = 0;
                        table2.AddCell(cell25);

                        PdfPCell cell26 = new PdfPCell();
                        p0 = new Paragraph();
                        p0.Add(new Chunk("Service Time", tableheaderFont));
                        p0.Alignment = Element.ALIGN_CENTER;
                        cell26.AddElement(p0);
                        cell26.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                        cell26.Border = 0;
                        table2.AddCell(cell26);



                        SqlCommand sqlCommand2 = new SqlCommand("select * from users where empNum like'h%'", con);
                        SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();


                        do
                        {

                            while (sqlDataReader2.Read())
                            {

                                String EmployeNum = sqlDataReader2["empNum"].ToString();
                                String EmployeName = sqlDataReader2["empName"].ToString();
                                String jobRole = sqlDataReader2["jobRole"].ToString();
                                String address = sqlDataReader2["empAddr"].ToString();
                                String email = sqlDataReader2["empMail"].ToString();
                                String mobile = sqlDataReader2["empContNum"].ToString();
                                String joinedD = sqlDataReader2["joinedDate"].ToString();


                                DateTime manJoinedD2 = Convert.ToDateTime(joinedD);
                                DateTime today = DateTime.Now;
                                TimeSpan duration = today - manJoinedD2;


                                PdfPCell pdfPCell0 = new PdfPCell();
                                Paragraph par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(EmployeNum, tablecolFont));
                                pdfPCell0.AddElement(par);
                                pdfPCell0.Border = 0;
                                table2.AddCell(pdfPCell0);


                                PdfPCell pdfPCell1 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(EmployeName, tablecolFont));
                                pdfPCell1.AddElement(par);
                                pdfPCell1.Border = 0;
                                table2.AddCell(pdfPCell1);


                                PdfPCell pdfPCell2 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(jobRole, tablecolFont));
                                pdfPCell2.AddElement(par);
                                pdfPCell2.Border = 0;
                                table2.AddCell(pdfPCell2);


                                PdfPCell pdfPCell3 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(address, tablecolFont));
                                pdfPCell3.AddElement(par);
                                pdfPCell3.Border = 0;
                                table2.AddCell(pdfPCell3);


                                PdfPCell pdfPCell4 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(email, tablecolFont));
                                pdfPCell4.AddElement(par);
                                pdfPCell4.Border = 0;
                                table2.AddCell(pdfPCell4);


                                PdfPCell pdfPCell5 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(mobile, tablecolFont));
                                pdfPCell5.AddElement(par);
                                pdfPCell5.Border = 0;
                                table2.AddCell(pdfPCell5);


                                PdfPCell pdfPCell6 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(duration.Days.ToString() + " Days", tablecolFont));
                                pdfPCell6.AddElement(par);
                                pdfPCell6.Border = 0;
                                table2.AddCell(pdfPCell6);
                            }
                        }
                        while (sqlDataReader2.NextResult());


                        sqlDataReader2.Close();
                        sqlCommand2.Dispose();

                        doc.Add(table2);

                        doc.Close();

                        MessageBox.Show(this,"You have successfully exported the file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            String employeeName="";
            String jobRole="";
            String joinedDate="";        
            String remTotalLeaves="";
            String remMedicalLeaves="";
            String remCasualLeaves="";
            String remFMLA="";
   

            con.Open();
            try
            {
                //verify employee number exist of users
                int i = 0;
                SqlCommand cmd = new SqlCommand("select * from users where empNum='" + txt_reportLeaveEmpNum.Text + "';", con);
                SqlDataReader RD1 = cmd.ExecuteReader();

                //if exist get his info
                if (RD1.Read())
                {
                                      
                    employeeName= RD1["empName"].ToString();
                    jobRole= RD1["jobRole"].ToString();
                    joinedDate = RD1["joinedDate"].ToString();
                    remTotalLeaves = RD1["remTotal"].ToString();
                    remMedicalLeaves = RD1["remMedical"].ToString();
                    remCasualLeaves = RD1["remCasual"].ToString();
                    remFMLA = RD1["remFMLA"].ToString();


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
                String dt =picker_reportLeaveDate.Value.ToString("yyyy");
                String ddt = dt + "-%";

                int j = 0;
                SqlCommand cmd2 = new SqlCommand("select * from leave where empNum='" + txt_reportLeaveEmpNum.Text + "' and date like'" + ddt + "';", con);
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




                if (txt_reportLeaveEmpNum.Text == "")
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_reportLeaveEmpNum, "warning");
                    t.Show("Enter The Employee Number", txt_reportLeaveEmpNum, 2000);
                }

                else if (i == 0)
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_reportLeaveEmpNum, "warning");
                    t.Show("Employee number is not found on the system", txt_reportLeaveEmpNum, 2000);
                }
                else if (j == 0)
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(picker_reportLeaveDate, "warning");
                    t.Show("No leave record found on the system", picker_reportLeaveDate, 2000);
                }
                else if(i!=0 && j!=0)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files|*.pdf" })
                    {

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {

                            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();

                            PdfContentByte pdfContent = pdfWriter.DirectContent;
                            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);

                            ///all font styles are defined here
                            iTextSharp.text.Font tableheaderFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, 1, BaseColor.BLACK);
                            iTextSharp.text.Font tablecolFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, BaseColor.BLACK);
                            iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 20,1, BaseColor.BLACK);
                            iTextSharp.text.Font empDtl = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.BLACK);
                            iTextSharp.text.Font subheaderFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12,1, BaseColor.BLACK);

                            Paragraph p0 = new Paragraph("My Flight Zone Company Limited");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph("No: 37/1, Colombo Road,");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph("Kurana,Katunayake,");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph("Sri Lanka");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            LineSeparator lineSeparator = new LineSeparator();
                            doc.Add(lineSeparator);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);



                            p0 = new Paragraph();
                            p0.Add(new Chunk("Individual Leave Report", headerFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);


                            p0 = new Paragraph();
                            p0.Add(new Chunk("Name:"+employeeName, empDtl));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph();
                            p0.Add(new Chunk("Job Role:" + jobRole, empDtl));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph();
                            p0.Add(new Chunk("Joined Date:" + joinedDate, empDtl));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                             lineSeparator = new LineSeparator();
                            doc.Add(lineSeparator);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            ///////////////////////
                        
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Summery", subheaderFont));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);


                            PdfPTable table0 = new PdfPTable(4);
                            table0.WidthPercentage = 100;


                            PdfPCell cell00 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Medical Leaves", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell00.AddElement(p0);
                            cell00.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell00.Border = 0;
                            table0.AddCell(cell00);

                            PdfPCell cell01 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Casual Leaves", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell01.AddElement(p0);
                            cell01.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell01.Border = 0;
                            table0.AddCell(cell01);

                            PdfPCell cell02 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Total Leaves", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell02.AddElement(p0);
                            cell02.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell02.Border = 0;
                            table0.AddCell(cell02);

                            PdfPCell cell03 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("FMLA", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell03.AddElement(p0);
                            cell03.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell03.Border = 0;
                            table0.AddCell(cell03);


                            int mlt = Properties.Settings.Default.mediacal_leave - int.Parse(remMedicalLeaves);

                            PdfPCell pdfPCell04 = new PdfPCell();
                            Paragraph par = new Paragraph();
                            par.Alignment = Element.ALIGN_CENTER;
                            par.Add(new Chunk(mlt.ToString(), tablecolFont));
                            pdfPCell04.AddElement(par);
                            pdfPCell04.Border = 0;
                            table0.AddCell(pdfPCell04);

                            int clt = Properties.Settings.Default.casual_leaves - int.Parse(remCasualLeaves);

                            PdfPCell pdfPCell05 = new PdfPCell();
                             par = new Paragraph();
                            par.Alignment = Element.ALIGN_CENTER;
                            par.Add(new Chunk(clt.ToString(), tablecolFont));
                            pdfPCell05.AddElement(par);
                            pdfPCell05.Border = 0;
                            table0.AddCell(pdfPCell05);

                            int tlt = (Properties.Settings.Default.casual_leaves + Properties.Settings.Default.mediacal_leave) - int.Parse(remTotalLeaves);

                            PdfPCell pdfPCell06 = new PdfPCell();
                            par = new Paragraph();
                            par.Alignment = Element.ALIGN_CENTER;
                            par.Add(new Chunk(tlt.ToString(), tablecolFont));
                            pdfPCell06.AddElement(par);
                            pdfPCell06.Border = 0;
                            table0.AddCell(pdfPCell06);

                            int FMLAlt = Properties.Settings.Default.FMLA - int.Parse(remFMLA);

                          
                                PdfPCell pdfPCell07 = new PdfPCell();
                                par = new Paragraph();
                                par.Alignment = Element.ALIGN_CENTER;
                                par.Add(new Chunk(Properties.Settings.Default.FMLA.ToString(), tablecolFont));
                                pdfPCell07.AddElement(par);
                                pdfPCell07.Border = 0;
                                table0.AddCell(pdfPCell07);
                      

                            doc.Add(table0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);


                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph();
                            p0.Add(new Chunk("Detailed", subheaderFont));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);


                            PdfPTable table1 = new PdfPTable(7);
                            table1.WidthPercentage = 100;

                            PdfPCell cell10 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Leave ID", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell10.AddElement(p0);
                            cell10.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell10.Border = 0;
                            table1.AddCell(cell10);

                            PdfPCell cell11 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Leave Type", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell11.AddElement(p0);
                            cell11.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell11.Border = 0;
                            table1.AddCell(cell11);

                            PdfPCell cell12 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Date", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell12.AddElement(p0);
                            cell12.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell12.Border = 0;
                            table1.AddCell(cell12);

                            PdfPCell cell13 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Start Date", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell13.AddElement(p0);
                            cell13.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell13.Border = 0;
                            table1.AddCell(cell13);

                            PdfPCell cell14 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("End Date", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell14.AddElement(p0);
                            cell14.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell14.Border = 0;
                            table1.AddCell(cell14);

                            PdfPCell cell15 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Reason", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell15.AddElement(p0);
                            cell15.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell15.Border = 0;
                            table1.AddCell(cell15);

                            PdfPCell cell16 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("decision", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell16.AddElement(p0);
                            cell16.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell16.Border = 0;
                            table1.AddCell(cell16);


                            ///////////////////////////////////

                            SqlCommand cmd3= new SqlCommand("select * from leave where empNum='" + txt_reportLeaveEmpNum.Text + "' and date like'" + ddt + "';", con);
                            SqlDataReader sqlDataReader2 = cmd3.ExecuteReader();


                            do
                            {

                                while (sqlDataReader2.Read())
                                {

                                    String leaveId = sqlDataReader2["leaveId"].ToString();
                                    String leaveType = sqlDataReader2["leaveType"].ToString();
                                    String date = sqlDataReader2["date"].ToString();
                                    String sDate = sqlDataReader2["startDate"].ToString();
                                    String eDate = sqlDataReader2["endDate"].ToString();
                                    String reason = sqlDataReader2["reason"].ToString();
                                    String decision = sqlDataReader2["status"].ToString();


                                   


                                    PdfPCell pdfPCell0 = new PdfPCell();
                                    Paragraph par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(leaveId, tablecolFont));
                                    pdfPCell0.AddElement(par1);
                                    pdfPCell0.Border = 0;
                                    table1.AddCell(pdfPCell0);


                                    PdfPCell pdfPCell1 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(leaveType, tablecolFont));
                                    pdfPCell1.AddElement(par1);
                                    pdfPCell1.Border = 0;
                                    table1.AddCell(pdfPCell1);


                                    PdfPCell pdfPCell2 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(date, tablecolFont));
                                    pdfPCell2.AddElement(par1);
                                    pdfPCell2.Border = 0;
                                    table1.AddCell(pdfPCell2);


                                    PdfPCell pdfPCell3 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(sDate, tablecolFont));
                                    pdfPCell3.AddElement(par1);
                                    pdfPCell3.Border = 0;
                                    table1.AddCell(pdfPCell3);


                                    PdfPCell pdfPCell4 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(eDate, tablecolFont));
                                    pdfPCell4.AddElement(par1);
                                    pdfPCell4.Border = 0;
                                    table1.AddCell(pdfPCell4);


                                    PdfPCell pdfPCell5 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(reason, tablecolFont));
                                    pdfPCell5.AddElement(par1);
                                    pdfPCell5.Border = 0;
                                    table1.AddCell(pdfPCell5);


                                    PdfPCell pdfPCell6 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(decision, tablecolFont));
                                    pdfPCell6.AddElement(par1);
                                    pdfPCell6.Border = 0;
                                    table1.AddCell(pdfPCell6);
                                }
                            }
                            while (sqlDataReader2.NextResult());


                            sqlDataReader2.Close();
                            cmd3.Dispose();


                          


                            doc.Add(table1);
                        
                            doc.Close();

                            MessageBox.Show(this, "You have successfully exported the file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void button3_Click(object sender, EventArgs e)
        {

            String employeeName = "";
            String jobRole = "";
            String joinedDate = "";
           


            con.Open();
            try
            {
                //verify employee number exist of users
                int i = 0;
                SqlCommand cmd = new SqlCommand("select * from users where empNum='" + txt_reportAttenEmpNum.Text + "';", con);
                SqlDataReader RD1 = cmd.ExecuteReader();

                //if exist get his info
                if (RD1.Read())
                {

                    employeeName = RD1["empName"].ToString();
                    jobRole = RD1["jobRole"].ToString();
                    joinedDate = RD1["joinedDate"].ToString();
                   


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
                String dt = picker_reportAttenDate.Value.ToString("yyyy");
                String ddt = dt + "-%";

                int j = 0;
                SqlCommand cmd2 = new SqlCommand("select * from attendance where empNum='" + txt_reportAttenEmpNum.Text + "' and date like'" + ddt + "';", con);
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




                if (txt_reportAttenEmpNum.Text == "")
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_reportAttenEmpNum, "warning");
                    t.Show("Enter The Employee Number", txt_reportAttenEmpNum, 2000);
                }

                else if (i == 0)
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(txt_reportAttenEmpNum, "warning");
                    t.Show("Employee number is not found on the system", txt_reportAttenEmpNum, 2000);
                }
                else if (j == 0)
                {
                    ToolTip t = new ToolTip();
                    t.UseFading = true;
                    t.UseAnimation = true;
                    t.IsBalloon = true;
                    t.SetToolTip(picker_reportAttenDate, "warning");
                    t.Show("No attendance record found on the system", picker_reportAttenDate, 2000);
                }
                else if (i != 0 && j != 0)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files|*.pdf" })
                    {

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {

                            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();

                            PdfContentByte pdfContent = pdfWriter.DirectContent;
                            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);

                            ///all font styles are defined here
                            iTextSharp.text.Font tableheaderFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, 1, BaseColor.BLACK);
                            iTextSharp.text.Font tablecolFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 8, BaseColor.BLACK);
                            iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 20, 1, BaseColor.BLACK);
                            iTextSharp.text.Font empDtl = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.BLACK);
                            iTextSharp.text.Font subheaderFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, 1, BaseColor.BLACK);

                            Paragraph p0 = new Paragraph("My Flight Zone Company Limited");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph("No: 37/1, Colombo Road,");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph("Kurana,Katunayake,");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph("Sri Lanka");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            LineSeparator lineSeparator = new LineSeparator();
                            doc.Add(lineSeparator);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);



                            p0 = new Paragraph();
                            p0.Add(new Chunk("Individual Attendance Report", headerFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);


                            p0 = new Paragraph();
                            p0.Add(new Chunk("Name : " + employeeName, empDtl));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph();
                            p0.Add(new Chunk("Job Role : " + jobRole, empDtl));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph();
                            p0.Add(new Chunk("Joined Date : " + joinedDate, empDtl));
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                        

                            p0 = new Paragraph(" ");
                            p0.Alignment = Element.ALIGN_LEFT;
                            doc.Add(p0);

                        


                            PdfPTable table1 = new PdfPTable(4);
                            table1.WidthPercentage = 100;

                            PdfPCell cell10 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Attendance ID", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell10.AddElement(p0);
                            cell10.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell10.Border = 0;
                            table1.AddCell(cell10);

                            PdfPCell cell11 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("Date", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell11.AddElement(p0);
                            cell11.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell11.Border = 0;
                            table1.AddCell(cell11);

                            PdfPCell cell12 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("CheckIn Time", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell12.AddElement(p0);
                            cell12.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell12.Border = 0;
                            table1.AddCell(cell12);

                            PdfPCell cell13 = new PdfPCell();
                            p0 = new Paragraph();
                            p0.Add(new Chunk("CheckOut Time", tableheaderFont));
                            p0.Alignment = Element.ALIGN_CENTER;
                            cell13.AddElement(p0);
                            cell13.BackgroundColor = new BaseColor(System.Drawing.Color.Gray);
                            cell13.Border = 0;
                            table1.AddCell(cell13);

                         
                          

                            ///////////////////////////////////

                            SqlCommand cmd3 = new SqlCommand("select * from attendance where empNum='" + txt_reportAttenEmpNum.Text + "' and date like'" + ddt + "';", con);
                            SqlDataReader sqlDataReader2 = cmd3.ExecuteReader();


                            do
                            {

                                while (sqlDataReader2.Read())
                                {

                                    String attenId = sqlDataReader2["attenId"].ToString();
                                    String date = sqlDataReader2["date"].ToString();
                                    String chekin = sqlDataReader2["checkIn"].ToString();
                                    String checkout = sqlDataReader2["checkOut"].ToString();
                                  





                                    PdfPCell pdfPCell0 = new PdfPCell();
                                    Paragraph par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(attenId, tablecolFont));
                                    pdfPCell0.AddElement(par1);
                                    pdfPCell0.Border = 0;
                                    table1.AddCell(pdfPCell0);


                                    PdfPCell pdfPCell1 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(date, tablecolFont));
                                    pdfPCell1.AddElement(par1);
                                    pdfPCell1.Border = 0;
                                    table1.AddCell(pdfPCell1);


                                    PdfPCell pdfPCell2 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(chekin, tablecolFont));
                                    pdfPCell2.AddElement(par1);
                                    pdfPCell2.Border = 0;
                                    table1.AddCell(pdfPCell2);


                                    PdfPCell pdfPCell3 = new PdfPCell();
                                    par1 = new Paragraph();
                                    par1.Alignment = Element.ALIGN_CENTER;
                                    par1.Add(new Chunk(checkout, tablecolFont));
                                    pdfPCell3.AddElement(par1);
                                    pdfPCell3.Border = 0;
                                    table1.AddCell(pdfPCell3);


                                  
                                }
                            }
                            while (sqlDataReader2.NextResult());


                            sqlDataReader2.Close();
                            cmd3.Dispose();





                            doc.Add(table1);

                            doc.Close();

                            MessageBox.Show(this, "You have successfully exported the file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
    }
    }
