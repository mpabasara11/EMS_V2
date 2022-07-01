namespace EmployeeManagementSystem
{
    partial class Login
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
            this.lgnUsername = new System.Windows.Forms.TextBox();
            this.lgnBtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lgnPswd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.telegramBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.resignationManageBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lgnUsername
            // 
            this.lgnUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lgnUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lgnUsername.ForeColor = System.Drawing.Color.White;
            this.lgnUsername.Location = new System.Drawing.Point(51, 307);
            this.lgnUsername.MaxLength = 255;
            this.lgnUsername.Name = "lgnUsername";
            this.lgnUsername.Size = new System.Drawing.Size(311, 20);
            this.lgnUsername.TabIndex = 1;
            this.lgnUsername.TabStop = false;
            this.lgnUsername.Text = "Username";
            this.lgnUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lgnUsername_MouseClick);
            this.lgnUsername.Leave += new System.EventHandler(this.lgnUsername_Leave);
            // 
            // lgnBtnLogin
            // 
            this.lgnBtnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lgnBtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lgnBtnLogin.ForeColor = System.Drawing.Color.White;
            this.lgnBtnLogin.Location = new System.Drawing.Point(107, 425);
            this.lgnBtnLogin.Name = "lgnBtnLogin";
            this.lgnBtnLogin.Size = new System.Drawing.Size(206, 49);
            this.lgnBtnLogin.TabIndex = 2;
            this.lgnBtnLogin.Text = "LOGIN";
            this.lgnBtnLogin.UseVisualStyleBackColor = false;
            this.lgnBtnLogin.Click += new System.EventHandler(this.lgnBtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.person_icon_blue_25;
            this.pictureBox1.Location = new System.Drawing.Point(67, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lgnPswd
            // 
            this.lgnPswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lgnPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lgnPswd.ForeColor = System.Drawing.Color.White;
            this.lgnPswd.Location = new System.Drawing.Point(51, 363);
            this.lgnPswd.MaxLength = 20;
            this.lgnPswd.Name = "lgnPswd";
            this.lgnPswd.Size = new System.Drawing.Size(311, 20);
            this.lgnPswd.TabIndex = 4;
            this.lgnPswd.Text = "Password";
            this.lgnPswd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lgnPswd_MouseClick);
            this.lgnPswd.Leave += new System.EventHandler(this.lgnPswd_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(51, 330);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 1);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(51, 386);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 1);
            this.panel2.TabIndex = 19;
            // 
            // telegramBackgroundWorker
            // 
            this.telegramBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // resignationManageBackgroundWorker
            // 
            this.resignationManageBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.resignationManageBackgroundWorker_DoWork);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(428, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lgnPswd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lgnBtnLogin);
            this.Controls.Add(this.lgnUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox lgnUsername;
        private Button lgnBtnLogin;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox lgnPswd;
        private Panel panel1;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker telegramBackgroundWorker;
        private System.ComponentModel.BackgroundWorker resignationManageBackgroundWorker;
    }
}