namespace EmployeeManagementSystem
{
    partial class frmAddpayslips
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtPicker_AddPaySlipDate = new System.Windows.Forms.DateTimePicker();
            this.txt_AddPaySlipEmpId = new System.Windows.Forms.TextBox();
            this.btn_AddPaySlip = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPicker_DeletePaySlipDate = new System.Windows.Forms.DateTimePicker();
            this.txt_DeletePaySlipEmpId = new System.Windows.Forms.TextBox();
            this.btn_DeletePaySlip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 48);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Payslips";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Employee Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Payment Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtPicker_AddPaySlipDate);
            this.panel2.Controls.Add(this.txt_AddPaySlipEmpId);
            this.panel2.Controls.Add(this.btn_AddPaySlip);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 240);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtPicker_AddPaySlipDate
            // 
            this.dtPicker_AddPaySlipDate.Location = new System.Drawing.Point(361, 109);
            this.dtPicker_AddPaySlipDate.Name = "dtPicker_AddPaySlipDate";
            this.dtPicker_AddPaySlipDate.Size = new System.Drawing.Size(284, 27);
            this.dtPicker_AddPaySlipDate.TabIndex = 37;
            // 
            // txt_AddPaySlipEmpId
            // 
            this.txt_AddPaySlipEmpId.Location = new System.Drawing.Point(361, 51);
            this.txt_AddPaySlipEmpId.MaxLength = 255;
            this.txt_AddPaySlipEmpId.Name = "txt_AddPaySlipEmpId";
            this.txt_AddPaySlipEmpId.Size = new System.Drawing.Size(284, 27);
            this.txt_AddPaySlipEmpId.TabIndex = 36;
            // 
            // btn_AddPaySlip
            // 
            this.btn_AddPaySlip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AddPaySlip.ForeColor = System.Drawing.Color.White;
            this.btn_AddPaySlip.Location = new System.Drawing.Point(432, 153);
            this.btn_AddPaySlip.Name = "btn_AddPaySlip";
            this.btn_AddPaySlip.Size = new System.Drawing.Size(128, 59);
            this.btn_AddPaySlip.TabIndex = 35;
            this.btn_AddPaySlip.Text = "Upload";
            this.btn_AddPaySlip.UseVisualStyleBackColor = false;
            this.btn_AddPaySlip.Click += new System.EventHandler(this.btn_AddPaySlip_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1123, 48);
            this.panel3.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remove Payslips";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Employee Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(66, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Payment Date";
            // 
            // dtPicker_DeletePaySlipDate
            // 
            this.dtPicker_DeletePaySlipDate.Location = new System.Drawing.Point(361, 439);
            this.dtPicker_DeletePaySlipDate.Name = "dtPicker_DeletePaySlipDate";
            this.dtPicker_DeletePaySlipDate.Size = new System.Drawing.Size(284, 27);
            this.dtPicker_DeletePaySlipDate.TabIndex = 41;
            // 
            // txt_DeletePaySlipEmpId
            // 
            this.txt_DeletePaySlipEmpId.Location = new System.Drawing.Point(361, 381);
            this.txt_DeletePaySlipEmpId.MaxLength = 255;
            this.txt_DeletePaySlipEmpId.Name = "txt_DeletePaySlipEmpId";
            this.txt_DeletePaySlipEmpId.Size = new System.Drawing.Size(284, 27);
            this.txt_DeletePaySlipEmpId.TabIndex = 40;
            // 
            // btn_DeletePaySlip
            // 
            this.btn_DeletePaySlip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DeletePaySlip.ForeColor = System.Drawing.Color.White;
            this.btn_DeletePaySlip.Location = new System.Drawing.Point(432, 486);
            this.btn_DeletePaySlip.Name = "btn_DeletePaySlip";
            this.btn_DeletePaySlip.Size = new System.Drawing.Size(128, 59);
            this.btn_DeletePaySlip.TabIndex = 39;
            this.btn_DeletePaySlip.Text = "Delete";
            this.btn_DeletePaySlip.UseVisualStyleBackColor = false;
            this.btn_DeletePaySlip.Click += new System.EventHandler(this.btn_DeletePaySlip_Click);
            // 
            // frmAddpayslips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 616);
            this.Controls.Add(this.dtPicker_DeletePaySlipDate);
            this.Controls.Add(this.txt_DeletePaySlipEmpId);
            this.Controls.Add(this.btn_DeletePaySlip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddpayslips";
            this.Text = "frmAddpayslips";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private DateTimePicker dtPicker_AddPaySlipDate;
        private TextBox txt_AddPaySlipEmpId;
        private Button btn_AddPaySlip;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtPicker_DeletePaySlipDate;
        private TextBox txt_DeletePaySlipEmpId;
        private Button btn_DeletePaySlip;
    }
}