namespace EmployeeManagementSystem
{
    partial class frmSurvey
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgrid_survView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_survView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "SURVEY";
            // 
            // dgrid_survView
            // 
            this.dgrid_survView.AllowUserToAddRows = false;
            this.dgrid_survView.AllowUserToDeleteRows = false;
            this.dgrid_survView.AllowUserToOrderColumns = true;
            this.dgrid_survView.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgrid_survView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_survView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgrid_survView.Location = new System.Drawing.Point(87, 114);
            this.dgrid_survView.Name = "dgrid_survView";
            this.dgrid_survView.RowHeadersVisible = false;
            this.dgrid_survView.RowHeadersWidth = 51;
            this.dgrid_survView.RowTemplate.Height = 29;
            this.dgrid_survView.Size = new System.Drawing.Size(1178, 292);
            this.dgrid_survView.TabIndex = 44;
            this.dgrid_survView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Give Feedback";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 200;
            // 
            // frmSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1362, 619);
            this.ControlBox = false;
            this.Controls.Add(this.dgrid_survView);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSurvey";
            this.Text = "frmSurvey";
            this.Load += new System.EventHandler(this.frmSurvey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_survView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private DataGridView dgrid_survView;
        private DataGridViewButtonColumn Column1;
    }
}