namespace EmployeeManagementSystem
{
    partial class frmMyPaySlip
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
            this.btn_mypayDownload = new System.Windows.Forms.Button();
            this.picker_mypayslipDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mypayslipEmpNum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mypayDownload
            // 
            this.btn_mypayDownload.BackColor = System.Drawing.Color.Black;
            this.btn_mypayDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mypayDownload.ForeColor = System.Drawing.Color.White;
            this.btn_mypayDownload.Location = new System.Drawing.Point(527, 290);
            this.btn_mypayDownload.Name = "btn_mypayDownload";
            this.btn_mypayDownload.Size = new System.Drawing.Size(265, 34);
            this.btn_mypayDownload.TabIndex = 25;
            this.btn_mypayDownload.Text = "Download Attachments";
            this.btn_mypayDownload.UseVisualStyleBackColor = false;
            this.btn_mypayDownload.Click += new System.EventHandler(this.btn_mypayDownload_Click);
            // 
            // picker_mypayslipDate
            // 
            this.picker_mypayslipDate.Location = new System.Drawing.Point(515, 235);
            this.picker_mypayslipDate.Name = "picker_mypayslipDate";
            this.picker_mypayslipDate.Size = new System.Drawing.Size(353, 27);
            this.picker_mypayslipDate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(307, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Payment Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 48);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usually Paylips will be available at the end of the month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "MY PAY SLIPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(307, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Employee Number";
            // 
            // lbl_mypayslipEmpNum
            // 
            this.lbl_mypayslipEmpNum.AutoSize = true;
            this.lbl_mypayslipEmpNum.Location = new System.Drawing.Point(515, 183);
            this.lbl_mypayslipEmpNum.Name = "lbl_mypayslipEmpNum";
            this.lbl_mypayslipEmpNum.Size = new System.Drawing.Size(79, 20);
            this.lbl_mypayslipEmpNum.TabIndex = 31;
            this.lbl_mypayslipEmpNum.Text = "#EMPNum";
            // 
            // frmMyPaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.Controls.Add(this.lbl_mypayslipEmpNum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_mypayDownload);
            this.Controls.Add(this.picker_mypayslipDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMyPaySlip";
            this.Text = "frmMyPaySlip";
            this.Load += new System.EventHandler(this.frmMyPaySlip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_mypayDownload;
        private DateTimePicker picker_mypayslipDate;
        private Label label5;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lbl_mypayslipEmpNum;
    }
}