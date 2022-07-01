namespace EmployeeManagementSystem
{
    partial class frmmanagesurvey
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picker_SurvayType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SurvaymngQ5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SurvaymngQ4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SurvaymngQ3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SurvaymngQ2 = new System.Windows.Forms.TextBox();
            this.btn_SurvaymngAddsur = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SurvaymngQ1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrid_mngSurvViewDel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ltsv_mngSurvVRes = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_mngSurvViewDel)).BeginInit();
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
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Survay";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.picker_SurvayType);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txt_SurvaymngQ5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txt_SurvaymngQ4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_SurvaymngQ3);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txt_SurvaymngQ2);
            this.panel6.Controls.Add(this.btn_SurvaymngAddsur);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txt_SurvaymngQ1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1362, 252);
            this.panel6.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(687, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 27);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(572, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Survey Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(572, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Survey Type";
            // 
            // picker_SurvayType
            // 
            this.picker_SurvayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.picker_SurvayType.FormattingEnabled = true;
            this.picker_SurvayType.Items.AddRange(new object[] {
            "Type 1",
            "Type 2"});
            this.picker_SurvayType.Location = new System.Drawing.Point(687, 75);
            this.picker_SurvayType.Name = "picker_SurvayType";
            this.picker_SurvayType.Size = new System.Drawing.Size(291, 28);
            this.picker_SurvayType.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(572, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Question 5";
            // 
            // txt_SurvaymngQ5
            // 
            this.txt_SurvaymngQ5.Location = new System.Drawing.Point(687, 27);
            this.txt_SurvaymngQ5.MaxLength = 255;
            this.txt_SurvaymngQ5.Name = "txt_SurvaymngQ5";
            this.txt_SurvaymngQ5.Size = new System.Drawing.Size(291, 27);
            this.txt_SurvaymngQ5.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Question 4";
            // 
            // txt_SurvaymngQ4
            // 
            this.txt_SurvaymngQ4.Location = new System.Drawing.Point(167, 175);
            this.txt_SurvaymngQ4.MaxLength = 255;
            this.txt_SurvaymngQ4.Name = "txt_SurvaymngQ4";
            this.txt_SurvaymngQ4.Size = new System.Drawing.Size(291, 27);
            this.txt_SurvaymngQ4.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Question 3";
            // 
            // txt_SurvaymngQ3
            // 
            this.txt_SurvaymngQ3.Location = new System.Drawing.Point(167, 126);
            this.txt_SurvaymngQ3.MaxLength = 255;
            this.txt_SurvaymngQ3.Name = "txt_SurvaymngQ3";
            this.txt_SurvaymngQ3.Size = new System.Drawing.Size(291, 27);
            this.txt_SurvaymngQ3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Question 2";
            // 
            // txt_SurvaymngQ2
            // 
            this.txt_SurvaymngQ2.Location = new System.Drawing.Point(167, 77);
            this.txt_SurvaymngQ2.MaxLength = 255;
            this.txt_SurvaymngQ2.Name = "txt_SurvaymngQ2";
            this.txt_SurvaymngQ2.Size = new System.Drawing.Size(291, 27);
            this.txt_SurvaymngQ2.TabIndex = 26;
            // 
            // btn_SurvaymngAddsur
            // 
            this.btn_SurvaymngAddsur.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SurvaymngAddsur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SurvaymngAddsur.ForeColor = System.Drawing.Color.White;
            this.btn_SurvaymngAddsur.Location = new System.Drawing.Point(718, 180);
            this.btn_SurvaymngAddsur.Name = "btn_SurvaymngAddsur";
            this.btn_SurvaymngAddsur.Size = new System.Drawing.Size(216, 35);
            this.btn_SurvaymngAddsur.TabIndex = 25;
            this.btn_SurvaymngAddsur.Text = "Create";
            this.btn_SurvaymngAddsur.UseVisualStyleBackColor = false;
            this.btn_SurvaymngAddsur.Click += new System.EventHandler(this.btn_SurvaymngAddsur_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(52, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Question 1";
            // 
            // txt_SurvaymngQ1
            // 
            this.txt_SurvaymngQ1.Location = new System.Drawing.Point(167, 28);
            this.txt_SurvaymngQ1.MaxLength = 255;
            this.txt_SurvaymngQ1.Name = "txt_SurvaymngQ1";
            this.txt_SurvaymngQ1.Size = new System.Drawing.Size(291, 27);
            this.txt_SurvaymngQ1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 48);
            this.panel2.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "View/Delete Survay";
            // 
            // dgrid_mngSurvViewDel
            // 
            this.dgrid_mngSurvViewDel.AllowUserToAddRows = false;
            this.dgrid_mngSurvViewDel.AllowUserToDeleteRows = false;
            this.dgrid_mngSurvViewDel.AllowUserToOrderColumns = true;
            this.dgrid_mngSurvViewDel.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgrid_mngSurvViewDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_mngSurvViewDel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgrid_mngSurvViewDel.Location = new System.Drawing.Point(24, 363);
            this.dgrid_mngSurvViewDel.Name = "dgrid_mngSurvViewDel";
            this.dgrid_mngSurvViewDel.RowHeadersVisible = false;
            this.dgrid_mngSurvViewDel.RowTemplate.Height = 29;
            this.dgrid_mngSurvViewDel.Size = new System.Drawing.Size(501, 229);
            this.dgrid_mngSurvViewDel.TabIndex = 40;
            this.dgrid_mngSurvViewDel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // ltsv_mngSurvVRes
            // 
            this.ltsv_mngSurvVRes.BackColor = System.Drawing.Color.Lavender;
            this.ltsv_mngSurvVRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltsv_mngSurvVRes.ForeColor = System.Drawing.Color.Black;
            this.ltsv_mngSurvVRes.Location = new System.Drawing.Point(547, 363);
            this.ltsv_mngSurvVRes.Name = "ltsv_mngSurvVRes";
            this.ltsv_mngSurvVRes.Size = new System.Drawing.Size(784, 229);
            this.ltsv_mngSurvVRes.TabIndex = 41;
            this.ltsv_mngSurvVRes.UseCompatibleStateImageBehavior = false;
            // 
            // frmmanagesurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.Controls.Add(this.ltsv_mngSurvVRes);
            this.Controls.Add(this.dgrid_mngSurvViewDel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmanagesurvey";
            this.Text = "frmmanagesurvey";
            this.Load += new System.EventHandler(this.frmmanagesurvey_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_mngSurvViewDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel6;
        private Button btn_SurvaymngAddsur;
        private Label label9;
        private TextBox txt_SurvaymngQ1;
        private Label label5;
        private TextBox txt_SurvaymngQ5;
        private Label label4;
        private TextBox txt_SurvaymngQ4;
        private Label label3;
        private TextBox txt_SurvaymngQ3;
        private Label label1;
        private TextBox txt_SurvaymngQ2;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private ComboBox picker_SurvayType;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private DataGridView dgrid_mngSurvViewDel;
        private ListView ltsv_mngSurvVRes;
        private DataGridViewButtonColumn Column1;
    }
}