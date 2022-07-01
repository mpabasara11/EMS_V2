namespace EmployeeManagementSystem
{
    partial class frmempleavemanagement
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_requestleave = new System.Windows.Forms.Button();
            this.btn_authorize = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnemlvmanagement = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Controls.Add(this.tableLayoutPanel2);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 619);
            this.panel9.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_requestleave, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_authorize, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4127F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5873F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 806);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.btn_requestleave.Size = new System.Drawing.Size(241, 55);
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
            this.btn_authorize.Location = new System.Drawing.Point(3, 69);
            this.btn_authorize.Name = "btn_authorize";
            this.btn_authorize.Size = new System.Drawing.Size(241, 55);
            this.btn_authorize.TabIndex = 0;
            this.btn_authorize.Text = "My Leave Status";
            this.btn_authorize.UseVisualStyleBackColor = false;
            this.btn_authorize.Click += new System.EventHandler(this.btn_authorize_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel8.Location = new System.Drawing.Point(3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(208, 444);
            this.panel8.TabIndex = 0;
            // 
            // pnemlvmanagement
            // 
            this.pnemlvmanagement.Location = new System.Drawing.Point(248, 3);
            this.pnemlvmanagement.Name = "pnemlvmanagement";
            this.pnemlvmanagement.Size = new System.Drawing.Size(1113, 613);
            this.pnemlvmanagement.TabIndex = 3;
            // 
            // frmempleavemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.Controls.Add(this.pnemlvmanagement);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmempleavemanagement";
            this.Text = "frmempleavemanagement";
            this.Load += new System.EventHandler(this.frmempleavemanagement_Load);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_requestleave;
        private Button btn_authorize;
        private Panel pnemlvmanagement;
        private Panel panel8;
    }
}