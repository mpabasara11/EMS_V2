namespace EmployeeManagementSystem
{
    partial class FrmLeavestatus
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
            this.lstview_LeaveStatusPending = new System.Windows.Forms.ListView();
            this.lstview_LeaveStatusFeedback = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstview_LeaveStatusPending
            // 
            this.lstview_LeaveStatusPending.Location = new System.Drawing.Point(29, 83);
            this.lstview_LeaveStatusPending.Name = "lstview_LeaveStatusPending";
            this.lstview_LeaveStatusPending.Size = new System.Drawing.Size(1047, 172);
            this.lstview_LeaveStatusPending.TabIndex = 0;
            this.lstview_LeaveStatusPending.UseCompatibleStateImageBehavior = false;
            // 
            // lstview_LeaveStatusFeedback
            // 
            this.lstview_LeaveStatusFeedback.Location = new System.Drawing.Point(29, 334);
            this.lstview_LeaveStatusFeedback.Name = "lstview_LeaveStatusFeedback";
            this.lstview_LeaveStatusFeedback.Size = new System.Drawing.Size(1047, 172);
            this.lstview_LeaveStatusFeedback.TabIndex = 1;
            this.lstview_LeaveStatusFeedback.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pending";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feedback";
            // 
            // FrmLeavestatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstview_LeaveStatusFeedback);
            this.Controls.Add(this.lstview_LeaveStatusPending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLeavestatus";
            this.Text = "FrmLeavestatus";
            this.Load += new System.EventHandler(this.FrmLeavestatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstview_LeaveStatusPending;
        private ListView lstview_LeaveStatusFeedback;
        private Label label1;
        private Label label2;
    }
}