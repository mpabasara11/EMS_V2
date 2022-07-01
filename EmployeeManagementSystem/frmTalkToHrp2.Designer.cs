namespace EmployeeManagementSystem
{
    partial class frmTalkToHrp2
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
            this.dgrid_tlkToH2SelHrs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_contHrSend = new System.Windows.Forms.Button();
            this.lbl_contHrTo = new System.Windows.Forms.Label();
            this.txt_contHrMes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_tlkToH2SelHrs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_tlkToH2SelHrs
            // 
            this.dgrid_tlkToH2SelHrs.AllowUserToAddRows = false;
            this.dgrid_tlkToH2SelHrs.AllowUserToDeleteRows = false;
            this.dgrid_tlkToH2SelHrs.AllowUserToOrderColumns = true;
            this.dgrid_tlkToH2SelHrs.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgrid_tlkToH2SelHrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_tlkToH2SelHrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgrid_tlkToH2SelHrs.Location = new System.Drawing.Point(87, 28);
            this.dgrid_tlkToH2SelHrs.Name = "dgrid_tlkToH2SelHrs";
            this.dgrid_tlkToH2SelHrs.RowHeadersVisible = false;
            this.dgrid_tlkToH2SelHrs.RowHeadersWidth = 51;
            this.dgrid_tlkToH2SelHrs.RowTemplate.Height = 29;
            this.dgrid_tlkToH2SelHrs.Size = new System.Drawing.Size(1161, 266);
            this.dgrid_tlkToH2SelHrs.TabIndex = 2;
            this.dgrid_tlkToH2SelHrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Contact";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reciever";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(406, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Problem";
            // 
            // btn_contHrSend
            // 
            this.btn_contHrSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_contHrSend.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_contHrSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_contHrSend.Location = new System.Drawing.Point(628, 488);
            this.btn_contHrSend.Name = "btn_contHrSend";
            this.btn_contHrSend.Size = new System.Drawing.Size(139, 45);
            this.btn_contHrSend.TabIndex = 5;
            this.btn_contHrSend.Text = "Send";
            this.btn_contHrSend.UseVisualStyleBackColor = false;
            this.btn_contHrSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_contHrTo
            // 
            this.lbl_contHrTo.AutoSize = true;
            this.lbl_contHrTo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_contHrTo.Location = new System.Drawing.Point(534, 325);
            this.lbl_contHrTo.Name = "lbl_contHrTo";
            this.lbl_contHrTo.Size = new System.Drawing.Size(0, 19);
            this.lbl_contHrTo.TabIndex = 7;
            // 
            // txt_contHrMes
            // 
            this.txt_contHrMes.Location = new System.Drawing.Point(534, 362);
            this.txt_contHrMes.Name = "txt_contHrMes";
            this.txt_contHrMes.Size = new System.Drawing.Size(327, 120);
            this.txt_contHrMes.TabIndex = 8;
            this.txt_contHrMes.Text = "";
            // 
            // frmTalkToHrp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.Controls.Add(this.txt_contHrMes);
            this.Controls.Add(this.lbl_contHrTo);
            this.Controls.Add(this.btn_contHrSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_tlkToH2SelHrs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTalkToHrp2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTalkToHrContactHr";
            this.Load += new System.EventHandler(this.frmTalkToHrContactHr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_tlkToH2SelHrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgrid_tlkToH2SelHrs;
        private Label label1;
        private Label label3;
        private Button btn_contHrSend;
        private DataGridViewButtonColumn Column1;
        private Label lbl_contHrTo;
        private RichTextBox txt_contHrMes;
    }
}