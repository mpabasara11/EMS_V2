namespace EmployeeManagementSystem
{
    partial class frmKeepAttendance
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
            this.btn_keepAttenCheckIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_keepAttenCheckOut = new System.Windows.Forms.Button();
            this.lbl_keepAttenCheckIn = new System.Windows.Forms.Label();
            this.lbl_keepAttenCheckOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_keepAttenCheckIn
            // 
            this.btn_keepAttenCheckIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_keepAttenCheckIn.ForeColor = System.Drawing.Color.White;
            this.btn_keepAttenCheckIn.Location = new System.Drawing.Point(94, 77);
            this.btn_keepAttenCheckIn.Name = "btn_keepAttenCheckIn";
            this.btn_keepAttenCheckIn.Size = new System.Drawing.Size(121, 40);
            this.btn_keepAttenCheckIn.TabIndex = 0;
            this.btn_keepAttenCheckIn.Text = "Check In";
            this.btn_keepAttenCheckIn.UseVisualStyleBackColor = false;
            this.btn_keepAttenCheckIn.Click += new System.EventHandler(this.btn_keepAttenCheckIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(370, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checked In Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(370, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Checked Out Time";
            // 
            // btn_keepAttenCheckOut
            // 
            this.btn_keepAttenCheckOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_keepAttenCheckOut.ForeColor = System.Drawing.Color.White;
            this.btn_keepAttenCheckOut.Location = new System.Drawing.Point(94, 77);
            this.btn_keepAttenCheckOut.Name = "btn_keepAttenCheckOut";
            this.btn_keepAttenCheckOut.Size = new System.Drawing.Size(121, 40);
            this.btn_keepAttenCheckOut.TabIndex = 2;
            this.btn_keepAttenCheckOut.Text = "Check Out";
            this.btn_keepAttenCheckOut.UseVisualStyleBackColor = false;
            this.btn_keepAttenCheckOut.Click += new System.EventHandler(this.btn_keepAttenCheckOut_Click);
            // 
            // lbl_keepAttenCheckIn
            // 
            this.lbl_keepAttenCheckIn.AutoSize = true;
            this.lbl_keepAttenCheckIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_keepAttenCheckIn.ForeColor = System.Drawing.Color.Black;
            this.lbl_keepAttenCheckIn.Location = new System.Drawing.Point(731, 85);
            this.lbl_keepAttenCheckIn.Name = "lbl_keepAttenCheckIn";
            this.lbl_keepAttenCheckIn.Size = new System.Drawing.Size(20, 25);
            this.lbl_keepAttenCheckIn.TabIndex = 4;
            this.lbl_keepAttenCheckIn.Text = "-";
            // 
            // lbl_keepAttenCheckOut
            // 
            this.lbl_keepAttenCheckOut.AutoSize = true;
            this.lbl_keepAttenCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_keepAttenCheckOut.ForeColor = System.Drawing.Color.Black;
            this.lbl_keepAttenCheckOut.Location = new System.Drawing.Point(731, 85);
            this.lbl_keepAttenCheckOut.Name = "lbl_keepAttenCheckOut";
            this.lbl_keepAttenCheckOut.Size = new System.Drawing.Size(20, 25);
            this.lbl_keepAttenCheckOut.TabIndex = 5;
            this.lbl_keepAttenCheckOut.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_keepAttenCheckIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_keepAttenCheckIn);
            this.panel1.Location = new System.Drawing.Point(81, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 206);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_keepAttenCheckOut);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_keepAttenCheckOut);
            this.panel2.Location = new System.Drawing.Point(81, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 206);
            this.panel2.TabIndex = 7;
            // 
            // frmKeepAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKeepAttendance";
            this.Text = "frmattendance";
            this.Load += new System.EventHandler(this.frmKeepAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_keepAttenCheckIn;
        private Label label1;
        private Label label2;
        private Button btn_keepAttenCheckOut;
        private Label lbl_keepAttenCheckIn;
        private Label lbl_keepAttenCheckOut;
        private Panel panel1;
        private Panel panel2;
    }
}