namespace EmployeeManagementSystem
{
    partial class frmInstructionManagement
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_instructionMngIDes = new System.Windows.Forms.TextBox();
            this.picker_instructionMngIType = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrid_instrDelInstr = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_instrDelInstr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 48);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upload Instructions";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_instructionMngIDes);
            this.panel6.Controls.Add(this.picker_instructionMngIType);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1362, 259);
            this.panel6.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(347, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Description";
            // 
            // txt_instructionMngIDes
            // 
            this.txt_instructionMngIDes.Location = new System.Drawing.Point(500, 110);
            this.txt_instructionMngIDes.MaxLength = 255;
            this.txt_instructionMngIDes.Name = "txt_instructionMngIDes";
            this.txt_instructionMngIDes.Size = new System.Drawing.Size(306, 27);
            this.txt_instructionMngIDes.TabIndex = 39;
            // 
            // picker_instructionMngIType
            // 
            this.picker_instructionMngIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.picker_instructionMngIType.FormattingEnabled = true;
            this.picker_instructionMngIType.Items.AddRange(new object[] {
            "Device",
            "Salary",
            "Transport",
            "Ems",
            "Leave"});
            this.picker_instructionMngIType.Location = new System.Drawing.Point(500, 41);
            this.picker_instructionMngIType.Name = "picker_instructionMngIType";
            this.picker_instructionMngIType.Size = new System.Drawing.Size(306, 28);
            this.picker_instructionMngIType.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(591, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 25;
            this.button3.Text = "Upload";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(347, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Issue Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 48);
            this.panel2.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Instructions";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrid_instrDelInstr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1362, 259);
            this.panel3.TabIndex = 40;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgrid_instrDelInstr
            // 
            this.dgrid_instrDelInstr.AllowUserToAddRows = false;
            this.dgrid_instrDelInstr.AllowUserToDeleteRows = false;
            this.dgrid_instrDelInstr.AllowUserToOrderColumns = true;
            this.dgrid_instrDelInstr.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgrid_instrDelInstr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_instrDelInstr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgrid_instrDelInstr.Location = new System.Drawing.Point(48, 37);
            this.dgrid_instrDelInstr.Name = "dgrid_instrDelInstr";
            this.dgrid_instrDelInstr.RowHeadersVisible = false;
            this.dgrid_instrDelInstr.RowHeadersWidth = 51;
            this.dgrid_instrDelInstr.RowTemplate.Height = 29;
            this.dgrid_instrDelInstr.Size = new System.Drawing.Size(1245, 188);
            this.dgrid_instrDelInstr.TabIndex = 0;
            this.dgrid_instrDelInstr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 125;
            // 
            // frmInstructionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInstructionManagement";
            this.Text = "frmInstructionManagement";
            this.Load += new System.EventHandler(this.frmInstructionManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_instrDelInstr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel6;
        private Button button3;
        private Label label9;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private TextBox txt_instructionMngIDes;
        private ComboBox picker_instructionMngIType;
        private DataGridView dgrid_instrDelInstr;
        private DataGridViewButtonColumn Column1;
    }
}