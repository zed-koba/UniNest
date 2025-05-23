namespace StudentInformation.EnrollUserControls
{
    partial class EnrollmentLanding
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.panelCollege = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblCollege = new System.Windows.Forms.Label();
            this.lblCollegeDesc = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblEnrolling = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panelCollege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.MainPanel.Controls.Add(this.btnStart);
            this.MainPanel.Controls.Add(this.panelCollege);
            this.MainPanel.Controls.Add(this.guna2PictureBox2);
            this.MainPanel.Controls.Add(this.lblEnrolling);
            this.MainPanel.Controls.Add(this.lblDescript);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1157, 588);
            this.MainPanel.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.AutoRoundedCorners = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 21;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.Enabled = false;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnStart.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.IndicateFocus = true;
            this.btnStart.Location = new System.Drawing.Point(488, 469);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 45);
            this.btnStart.TabIndex = 27;
            this.btnStart.Text = "START";
            this.btnStart.UseTransparentBackground = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelCollege
            // 
            this.panelCollege.BackColor = System.Drawing.Color.Transparent;
            this.panelCollege.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.panelCollege.BorderRadius = 5;
            this.panelCollege.BorderThickness = 2;
            this.panelCollege.Controls.Add(this.guna2PictureBox3);
            this.panelCollege.Controls.Add(this.lblCollege);
            this.panelCollege.Controls.Add(this.lblCollegeDesc);
            this.panelCollege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCollege.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.panelCollege.Location = new System.Drawing.Point(478, 245);
            this.panelCollege.Name = "panelCollege";
            this.panelCollege.Size = new System.Drawing.Size(200, 198);
            this.panelCollege.TabIndex = 26;
            this.panelCollege.Click += new System.EventHandler(this.panelCollege_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::StudentInformation.Properties.Resources.mdi__college_outline__1_;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(82, 23);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 0;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            this.guna2PictureBox3.Click += new System.EventHandler(this.panelCollege_Click);
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblCollege.Location = new System.Drawing.Point(49, 59);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(98, 37);
            this.lblCollege.TabIndex = 25;
            this.lblCollege.Text = "College";
            this.lblCollege.Click += new System.EventHandler(this.panelCollege_Click);
            // 
            // lblCollegeDesc
            // 
            this.lblCollegeDesc.AutoSize = true;
            this.lblCollegeDesc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollegeDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblCollegeDesc.Location = new System.Drawing.Point(26, 102);
            this.lblCollegeDesc.Name = "lblCollegeDesc";
            this.lblCollegeDesc.Size = new System.Drawing.Size(145, 69);
            this.lblCollegeDesc.TabIndex = 25;
            this.lblCollegeDesc.Text = "offers specialized \r\neducation for career \r\nor further study";
            this.lblCollegeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCollegeDesc.Click += new System.EventHandler(this.panelCollege_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox2.Image = global::StudentInformation.Properties.Resources.output_onlinegiftools;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(506, 10);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(131, 112);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // lblEnrolling
            // 
            this.lblEnrolling.AutoSize = true;
            this.lblEnrolling.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblEnrolling.Location = new System.Drawing.Point(434, 121);
            this.lblEnrolling.Name = "lblEnrolling";
            this.lblEnrolling.Size = new System.Drawing.Size(274, 37);
            this.lblEnrolling.TabIndex = 25;
            this.lblEnrolling.Text = "Enrollment with UniNest";
            // 
            // lblDescript
            // 
            this.lblDescript.AutoSize = true;
            this.lblDescript.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblDescript.Location = new System.Drawing.Point(267, 163);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(608, 56);
            this.lblDescript.TabIndex = 25;
            this.lblDescript.Text = "As a new student at UniNest, there are a few important steps we need from \r\nyou t" +
    "o complete your enrollment and manage your registration.";
            this.lblDescript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnrollmentLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "EnrollmentLanding";
            this.Size = new System.Drawing.Size(1157, 588);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panelCollege.ResumeLayout(false);
            this.panelCollege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Panel panelCollege;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Label lblCollegeDesc;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lblEnrolling;
        private System.Windows.Forms.Label lblDescript;
    }
}
