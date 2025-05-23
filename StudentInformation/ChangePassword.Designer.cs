namespace StudentInformation
{
    partial class ChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblWarn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.modalTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create New Password";
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(13, 86);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(349, 58);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Your new Password must be different from your previous password";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblPass.Location = new System.Drawing.Point(13, 163);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(88, 28);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.AutoRoundedCorners = true;
            this.txtPass.BorderColor = System.Drawing.Color.DimGray;
            this.txtPass.BorderRadius = 18;
            this.txtPass.BorderThickness = 2;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.txtPass.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtPass.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.txtPass.Location = new System.Drawing.Point(17, 189);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(345, 39);
            this.txtPass.TabIndex = 0;
            this.txtPass.TextOffset = new System.Drawing.Point(5, 0);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfirmPass.Location = new System.Drawing.Point(14, 272);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(155, 28);
            this.lblConfirmPass.TabIndex = 2;
            this.lblConfirmPass.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Animated = true;
            this.txtConfirmPass.AutoRoundedCorners = true;
            this.txtConfirmPass.BorderColor = System.Drawing.Color.DimGray;
            this.txtConfirmPass.BorderRadius = 18;
            this.txtConfirmPass.BorderThickness = 2;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.DefaultText = "";
            this.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.txtConfirmPass.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtConfirmPass.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(18, 298);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPass.PlaceholderText = "";
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.Size = new System.Drawing.Size(344, 39);
            this.txtConfirmPass.TabIndex = 1;
            this.txtConfirmPass.TextOffset = new System.Drawing.Point(5, 0);
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarn.ForeColor = System.Drawing.Color.DimGray;
            this.lblWarn.Location = new System.Drawing.Point(14, 234);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(196, 23);
            this.lblWarn.TabIndex = 2;
            this.lblWarn.Text = "Must be atleast 8 characters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(17, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Both password must match";
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 21;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Enabled = false;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnReset.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(19, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(343, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseTransparentBackground = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // modalTimer
            // 
            this.modalTimer.Enabled = true;
            this.modalTimer.Interval = 1;
            this.modalTimer.Tick += new System.EventHandler(this.modalTimer_Tick);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblBack.Image = global::StudentInformation.Properties.Resources.lsicon__arrow_left_filled__24_;
            this.lblBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBack.Location = new System.Drawing.Point(12, 13);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(65, 23);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "       Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(392, 467);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblBack;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWarn;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Timer modalTimer;
    }
}