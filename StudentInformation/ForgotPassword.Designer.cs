namespace StudentInformation
{
    partial class ForgotPassword
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
            this.btnForgot = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtStudentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblGoback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForgot
            // 
            this.btnForgot.AutoRoundedCorners = true;
            this.btnForgot.BorderRadius = 22;
            this.btnForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnForgot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnForgot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForgot.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForgot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnForgot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(210)))), ((int)(((byte)(189)))));
            this.btnForgot.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(243)))), ((int)(((byte)(169)))));
            this.btnForgot.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnForgot.ForeColor = System.Drawing.Color.White;
            this.btnForgot.Location = new System.Drawing.Point(19, 201);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(316, 46);
            this.btnForgot.TabIndex = 28;
            this.btnForgot.Text = "Reset Password";
            this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Animated = true;
            this.txtStudentID.AutoRoundedCorners = true;
            this.txtStudentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtStudentID.BorderRadius = 23;
            this.txtStudentID.BorderThickness = 2;
            this.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentID.DefaultText = "";
            this.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(217)))), ((int)(((byte)(185)))));
            this.txtStudentID.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtStudentID.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txtStudentID.IconLeft = global::StudentInformation.Properties.Resources.user1;
            this.txtStudentID.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtStudentID.IconLeftSize = new System.Drawing.Size(24, 24);
            this.txtStudentID.Location = new System.Drawing.Point(15, 135);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtStudentID.PlaceholderText = "Student ID";
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.Size = new System.Drawing.Size(323, 48);
            this.txtStudentID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtStudentID.TabIndex = 25;
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Poppins", 12F);
            this.lblAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblAccount.Location = new System.Drawing.Point(14, 68);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(282, 56);
            this.lblAccount.TabIndex = 30;
            this.lblAccount.Text = "Enter your student ID to reset your \r\npassword";
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold);
            this.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblSignIn.Location = new System.Drawing.Point(3, 12);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(300, 56);
            this.lblSignIn.TabIndex = 31;
            this.lblSignIn.Text = "Forgot Password";
            // 
            // lblGoback
            // 
            this.lblGoback.AutoSize = true;
            this.lblGoback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoback.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Underline);
            this.lblGoback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblGoback.Location = new System.Drawing.Point(85, 324);
            this.lblGoback.Name = "lblGoback";
            this.lblGoback.Size = new System.Drawing.Size(161, 28);
            this.lblGoback.TabIndex = 32;
            this.lblGoback.Text = "GO BACK TO LOGIN";
            this.lblGoback.Click += new System.EventHandler(this.lblGoback_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.lblGoback);
            this.Controls.Add(this.btnForgot);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblSignIn);
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(350, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnForgot;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentID;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblGoback;
    }
}
