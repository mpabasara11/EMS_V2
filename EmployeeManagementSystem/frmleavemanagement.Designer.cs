namespace EmployeeManagementSystem
{
    partial class frmleavemanagement
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_leavestatus = new System.Windows.Forms.Button();
            this.btn_requestleave = new System.Windows.Forms.Button();
            this.btn_authorize = new System.Windows.Forms.Button();
            this.pnleavemanagement = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Location = new System.Drawing.Point(-4, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(249, 816);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Controls.Add(this.tableLayoutPanel2);
            this.panel8.Location = new System.Drawing.Point(3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 327);
            this.panel8.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_leavestatus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_requestleave, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_authorize, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4127F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5873F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 795);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_leavestatus
            // 
            this.btn_leavestatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_leavestatus.FlatAppearance.BorderSize = 0;
            this.btn_leavestatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leavestatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_leavestatus.ForeColor = System.Drawing.Color.White;
            this.btn_leavestatus.Location = new System.Drawing.Point(3, 129);
            this.btn_leavestatus.Name = "btn_leavestatus";
            this.btn_leavestatus.Size = new System.Drawing.Size(231, 59);
            this.btn_leavestatus.TabIndex = 1;
            this.btn_leavestatus.Text = "My Leave Status";
            this.btn_leavestatus.UseVisualStyleBackColor = false;
            this.btn_leavestatus.Click += new System.EventHandler(this.btn_leavestatus_Click);
            // 
            // btn_requestleave
            // 
            this.btn_requestleave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_requestleave.FlatAppearance.BorderSize = 0;
            this.btn_requestleave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_requestleave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_requestleave.ForeColor = System.Drawing.Color.White;
            this.btn_requestleave.Location = new System.Drawing.Point(3, 3);
            this.btn_requestleave.Name = "btn_requestleave";
            this.btn_requestleave.Size = new System.Drawing.Size(231, 55);
            this.btn_requestleave.TabIndex = 0;
            this.btn_requestleave.Text = "Request Leave";
            this.btn_requestleave.UseVisualStyleBackColor = false;
            this.btn_requestleave.Click += new System.EventHandler(this.btn_requestleave_Click);
            // 
            // btn_authorize
            // 
            this.btn_authorize.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_authorize.FlatAppearance.BorderSize = 0;
            this.btn_authorize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_authorize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_authorize.ForeColor = System.Drawing.Color.White;
            this.btn_authorize.Location = new System.Drawing.Point(3, 64);
            this.btn_authorize.Name = "btn_authorize";
            this.btn_authorize.Size = new System.Drawing.Size(231, 59);
            this.btn_authorize.TabIndex = 0;
            this.btn_authorize.Text = "Authorize Leave";
            this.btn_authorize.UseVisualStyleBackColor = false;
            this.btn_authorize.Click += new System.EventHandler(this.btn_authorize_Click);
            // 
            // pnleavemanagement
            // 
            this.pnleavemanagement.Location = new System.Drawing.Point(247, 4);
            this.pnleavemanagement.Name = "pnleavemanagement";
            this.pnleavemanagement.Size = new System.Drawing.Size(1113, 614);
            this.pnleavemanagement.TabIndex = 2;
            // 
            // frmleavemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.Controls.Add(this.pnleavemanagement);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmleavemanagement";
            this.Text = "frmleavemanagement";
            this.Load += new System.EventHandler(this.frmleavemanagement_Load);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel9;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_leavestatus;
        private Button btn_requestleave;
        private Button btn_authorize;
        private Panel pnleavemanagement;
    }
}