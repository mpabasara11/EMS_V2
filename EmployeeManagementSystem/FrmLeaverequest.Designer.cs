namespace EmployeeManagementSystem
{
    partial class FrmLeaverequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_LeaveRequestSubmit = new System.Windows.Forms.Button();
            this.rickTextb_LeaveRequestReason = new System.Windows.Forms.RichTextBox();
            this.dpicker_LeaveRequestLeaveEndDate = new System.Windows.Forms.DateTimePicker();
            this.dpicker_LeaveRequestLeaveStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_LeaveRequestLeaveType = new System.Windows.Forms.ComboBox();
            this.lbl_LeaveRequestEmpId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_leavebalancetakencas = new System.Windows.Forms.Label();
            this.lbl_leavebalancetakenMed = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_leavebalanceavgcas = new System.Windows.Forms.Label();
            this.lbl_leavebalanceavgMed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_leavebalanceremcas = new System.Windows.Forms.Label();
            this.lbl_leavebalancetotcas = new System.Windows.Forms.Label();
            this.lbl_leavebalanceremmed = new System.Windows.Forms.Label();
            this.lbl_leavebalancetotmed = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_leavebalanceremfml = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_leavebalancetotfml = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(895, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "initiate a leave application specifine the required details. a leave application " +
    "once submitted would go through an approval workflow.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "LEAVE APPLICATION";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 565);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btn_LeaveRequestSubmit);
            this.tabPage1.Controls.Add(this.rickTextb_LeaveRequestReason);
            this.tabPage1.Controls.Add(this.dpicker_LeaveRequestLeaveEndDate);
            this.tabPage1.Controls.Add(this.dpicker_LeaveRequestLeaveStartDate);
            this.tabPage1.Controls.Add(this.cmb_LeaveRequestLeaveType);
            this.tabPage1.Controls.Add(this.lbl_LeaveRequestEmpId);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1105, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apply Leave";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_LeaveRequestSubmit
            // 
            this.btn_LeaveRequestSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_LeaveRequestSubmit.ForeColor = System.Drawing.Color.White;
            this.btn_LeaveRequestSubmit.Location = new System.Drawing.Point(407, 421);
            this.btn_LeaveRequestSubmit.Name = "btn_LeaveRequestSubmit";
            this.btn_LeaveRequestSubmit.Size = new System.Drawing.Size(122, 38);
            this.btn_LeaveRequestSubmit.TabIndex = 14;
            this.btn_LeaveRequestSubmit.Text = "Request";
            this.btn_LeaveRequestSubmit.UseVisualStyleBackColor = false;
            this.btn_LeaveRequestSubmit.Click += new System.EventHandler(this.btn_LeaveRequestSubmit_Click);
            // 
            // rickTextb_LeaveRequestReason
            // 
            this.rickTextb_LeaveRequestReason.Location = new System.Drawing.Point(344, 264);
            this.rickTextb_LeaveRequestReason.MaxLength = 255;
            this.rickTextb_LeaveRequestReason.Name = "rickTextb_LeaveRequestReason";
            this.rickTextb_LeaveRequestReason.Size = new System.Drawing.Size(271, 130);
            this.rickTextb_LeaveRequestReason.TabIndex = 13;
            this.rickTextb_LeaveRequestReason.Text = "";
            // 
            // dpicker_LeaveRequestLeaveEndDate
            // 
            this.dpicker_LeaveRequestLeaveEndDate.Location = new System.Drawing.Point(344, 210);
            this.dpicker_LeaveRequestLeaveEndDate.Name = "dpicker_LeaveRequestLeaveEndDate";
            this.dpicker_LeaveRequestLeaveEndDate.Size = new System.Drawing.Size(271, 27);
            this.dpicker_LeaveRequestLeaveEndDate.TabIndex = 12;
            // 
            // dpicker_LeaveRequestLeaveStartDate
            // 
            this.dpicker_LeaveRequestLeaveStartDate.Location = new System.Drawing.Point(344, 156);
            this.dpicker_LeaveRequestLeaveStartDate.Name = "dpicker_LeaveRequestLeaveStartDate";
            this.dpicker_LeaveRequestLeaveStartDate.Size = new System.Drawing.Size(271, 27);
            this.dpicker_LeaveRequestLeaveStartDate.TabIndex = 11;
            this.dpicker_LeaveRequestLeaveStartDate.ValueChanged += new System.EventHandler(this.dpicker_LeaveRequestLeaveStartDate_ValueChanged);
            // 
            // cmb_LeaveRequestLeaveType
            // 
            this.cmb_LeaveRequestLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LeaveRequestLeaveType.FormattingEnabled = true;
            this.cmb_LeaveRequestLeaveType.Items.AddRange(new object[] {
            "Casual",
            "Medical",
            "FMLA"});
            this.cmb_LeaveRequestLeaveType.Location = new System.Drawing.Point(344, 101);
            this.cmb_LeaveRequestLeaveType.Name = "cmb_LeaveRequestLeaveType";
            this.cmb_LeaveRequestLeaveType.Size = new System.Drawing.Size(271, 28);
            this.cmb_LeaveRequestLeaveType.TabIndex = 10;
            this.cmb_LeaveRequestLeaveType.SelectedIndexChanged += new System.EventHandler(this.cmb_LeaveRequestLeaveType_SelectedIndexChanged);
            // 
            // lbl_LeaveRequestEmpId
            // 
            this.lbl_LeaveRequestEmpId.AutoSize = true;
            this.lbl_LeaveRequestEmpId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LeaveRequestEmpId.Location = new System.Drawing.Point(344, 51);
            this.lbl_LeaveRequestEmpId.Name = "lbl_LeaveRequestEmpId";
            this.lbl_LeaveRequestEmpId.Size = new System.Drawing.Size(91, 19);
            this.lbl_LeaveRequestEmpId.TabIndex = 9;
            this.lbl_LeaveRequestEmpId.Text = "#EmployeeID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(65, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Reasons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(65, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Leave End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Leave Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Leave Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1105, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Leave Balance";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(this.lbl_leavebalancetakencas);
            this.panel5.Controls.Add(this.lbl_leavebalancetakenMed);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.lbl_leavebalanceavgcas);
            this.panel5.Controls.Add(this.lbl_leavebalanceavgMed);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(3, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1099, 166);
            this.panel5.TabIndex = 10;
            // 
            // lbl_leavebalancetakencas
            // 
            this.lbl_leavebalancetakencas.AutoSize = true;
            this.lbl_leavebalancetakencas.Location = new System.Drawing.Point(860, 45);
            this.lbl_leavebalancetakencas.Name = "lbl_leavebalancetakencas";
            this.lbl_leavebalancetakencas.Size = new System.Drawing.Size(78, 20);
            this.lbl_leavebalancetakencas.TabIndex = 12;
            this.lbl_leavebalancetakencas.Text = "#TakenCas";
            // 
            // lbl_leavebalancetakenMed
            // 
            this.lbl_leavebalancetakenMed.AutoSize = true;
            this.lbl_leavebalancetakenMed.Location = new System.Drawing.Point(860, 79);
            this.lbl_leavebalancetakenMed.Name = "lbl_leavebalancetakenMed";
            this.lbl_leavebalancetakenMed.Size = new System.Drawing.Size(85, 20);
            this.lbl_leavebalancetakenMed.TabIndex = 11;
            this.lbl_leavebalancetakenMed.Text = "#TakenMed";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(568, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(199, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "Taken Casuals for This Month";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(568, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(209, 20);
            this.label21.TabIndex = 10;
            this.label21.Text = "Taken Medicals for This Month";
            // 
            // lbl_leavebalanceavgcas
            // 
            this.lbl_leavebalanceavgcas.AutoSize = true;
            this.lbl_leavebalanceavgcas.Location = new System.Drawing.Point(347, 45);
            this.lbl_leavebalanceavgcas.Name = "lbl_leavebalanceavgcas";
            this.lbl_leavebalanceavgcas.Size = new System.Drawing.Size(65, 20);
            this.lbl_leavebalanceavgcas.TabIndex = 8;
            this.lbl_leavebalanceavgcas.Text = "#avgCas";
            // 
            // lbl_leavebalanceavgMed
            // 
            this.lbl_leavebalanceavgMed.AutoSize = true;
            this.lbl_leavebalanceavgMed.Location = new System.Drawing.Point(347, 79);
            this.lbl_leavebalanceavgMed.Name = "lbl_leavebalanceavgMed";
            this.lbl_leavebalanceavgMed.Size = new System.Drawing.Size(72, 20);
            this.lbl_leavebalanceavgMed.TabIndex = 7;
            this.lbl_leavebalanceavgMed.Text = "#avgMed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Average Casuals for This Month";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Average Medicals for This Month";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(3, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 40);
            this.panel4.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(454, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Average";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 40);
            this.panel3.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(459, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Overall";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.lbl_leavebalanceremcas);
            this.panel2.Controls.Add(this.lbl_leavebalancetotcas);
            this.panel2.Controls.Add(this.lbl_leavebalanceremmed);
            this.panel2.Controls.Add(this.lbl_leavebalancetotmed);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lbl_leavebalanceremfml);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.lbl_leavebalancetotfml);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 166);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_leavebalanceremcas
            // 
            this.lbl_leavebalanceremcas.AutoSize = true;
            this.lbl_leavebalanceremcas.Location = new System.Drawing.Point(828, 34);
            this.lbl_leavebalanceremcas.Name = "lbl_leavebalanceremcas";
            this.lbl_leavebalanceremcas.Size = new System.Drawing.Size(65, 20);
            this.lbl_leavebalanceremcas.TabIndex = 1;
            this.lbl_leavebalanceremcas.Text = "#remcas";
            // 
            // lbl_leavebalancetotcas
            // 
            this.lbl_leavebalancetotcas.AutoSize = true;
            this.lbl_leavebalancetotcas.Location = new System.Drawing.Point(320, 34);
            this.lbl_leavebalancetotcas.Name = "lbl_leavebalancetotcas";
            this.lbl_leavebalancetotcas.Size = new System.Drawing.Size(58, 20);
            this.lbl_leavebalancetotcas.TabIndex = 1;
            this.lbl_leavebalancetotcas.Text = "#totcas";
            // 
            // lbl_leavebalanceremmed
            // 
            this.lbl_leavebalanceremmed.AutoSize = true;
            this.lbl_leavebalanceremmed.Location = new System.Drawing.Point(828, 68);
            this.lbl_leavebalanceremmed.Name = "lbl_leavebalanceremmed";
            this.lbl_leavebalanceremmed.Size = new System.Drawing.Size(74, 20);
            this.lbl_leavebalanceremmed.TabIndex = 6;
            this.lbl_leavebalanceremmed.Text = "#remMed";
            // 
            // lbl_leavebalancetotmed
            // 
            this.lbl_leavebalancetotmed.AutoSize = true;
            this.lbl_leavebalancetotmed.Location = new System.Drawing.Point(320, 68);
            this.lbl_leavebalancetotmed.Name = "lbl_leavebalancetotmed";
            this.lbl_leavebalancetotmed.Size = new System.Drawing.Size(67, 20);
            this.lbl_leavebalancetotmed.TabIndex = 6;
            this.lbl_leavebalancetotmed.Text = "#totMed";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(568, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Remain Casual Leaves";
            // 
            // lbl_leavebalanceremfml
            // 
            this.lbl_leavebalanceremfml.AutoSize = true;
            this.lbl_leavebalanceremfml.Location = new System.Drawing.Point(828, 102);
            this.lbl_leavebalanceremfml.Name = "lbl_leavebalanceremfml";
            this.lbl_leavebalanceremfml.Size = new System.Drawing.Size(68, 20);
            this.lbl_leavebalanceremfml.TabIndex = 5;
            this.lbl_leavebalanceremfml.Text = "#remFml";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Casual Leaves";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(568, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 20);
            this.label22.TabIndex = 2;
            this.label22.Text = "Remain FML Leaves";
            // 
            // lbl_leavebalancetotfml
            // 
            this.lbl_leavebalancetotfml.AutoSize = true;
            this.lbl_leavebalancetotfml.Location = new System.Drawing.Point(320, 102);
            this.lbl_leavebalancetotfml.Name = "lbl_leavebalancetotfml";
            this.lbl_leavebalancetotfml.Size = new System.Drawing.Size(61, 20);
            this.lbl_leavebalancetotfml.TabIndex = 5;
            this.lbl_leavebalancetotfml.Text = "#totFml";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(568, 68);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(164, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "Remain Medical Leaves";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total FML Leaves";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total Medical Leaves";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // FrmLeaverequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 613);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLeaverequest";
            this.Text = "Leave Request";
            this.Load += new System.EventHandler(this.FrmLeaverequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_LeaveRequestSubmit;
        private RichTextBox rickTextb_LeaveRequestReason;
        private DateTimePicker dpicker_LeaveRequestLeaveEndDate;
        private DateTimePicker dpicker_LeaveRequestLeaveStartDate;
        private ComboBox cmb_LeaveRequestLeaveType;
        private Label lbl_LeaveRequestEmpId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private NotifyIcon notifyIcon1;
        private NotifyIcon notifyIcon2;
        private Panel panel3;
        private Panel panel2;
        private Label lbl_leavebalancetotcas;
        private Label lbl_leavebalancetotmed;
        private Label label8;
        private Label lbl_leavebalancetotfml;
        private Label label10;
        private Label label11;
        private Label label15;
        private Panel panel5;
        private Label lbl_leavebalanceremcas;
        private Label lbl_leavebalanceremmed;
        private Label label20;
        private Label lbl_leavebalanceremfml;
        private Label label22;
        private Label label23;
        private Panel panel4;
        private Label label16;
        private Label label9;
        private Label label13;
        private Label lbl_leavebalanceavgcas;
        private Label lbl_leavebalanceavgMed;
        private Label lbl_leavebalancetakencas;
        private Label lbl_leavebalancetakenMed;
        private Label label19;
        private Label label21;
    }
}