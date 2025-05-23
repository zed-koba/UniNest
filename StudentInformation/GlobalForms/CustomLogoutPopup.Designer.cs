namespace StudentInformation.GlobalForms
{
    partial class CustomLogoutPopup
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
            this.Transition = new System.Windows.Forms.Timer(this.components);
            this.btnNo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblType = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Transition
            // 
            this.Transition.Interval = 10;
            this.Transition.Tick += new System.EventHandler(this.Transition_Tick);
            // 
            // btnNo
            // 
            this.btnNo.Animated = true;
            this.btnNo.AutoRoundedCorners = true;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnNo.BorderRadius = 15;
            this.btnNo.BorderThickness = 1;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.btnNo.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btnNo.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnNo.Location = new System.Drawing.Point(20, 132);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(112, 33);
            this.btnNo.TabIndex = 10;
            this.btnNo.Text = "No";
            this.btnNo.UseTransparentBackground = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 129);
            this.panel1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::StudentInformation.Properties.Resources.material_symbols__close__1_;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(261, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedDepth = 0;
            this.btnClose.Size = new System.Drawing.Size(37, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(78, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(143, 28);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Are you leaving?";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::StudentInformation.Properties.Resources.icons8_warning_48;
            this.pbIcon.Location = new System.Drawing.Point(113, 7);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(72, 52);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblMessage.Location = new System.Drawing.Point(0, 90);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMessage.Size = new System.Drawing.Size(298, 39);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Are you sure you want to logout?";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.AutoRoundedCorners = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::StudentInformation.Properties.Resources.basil__logout_solid__2_;
            this.btnLogout.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnLogout.Location = new System.Drawing.Point(161, 132);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 33);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CustomLogoutPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 186);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomLogoutPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomLogoutPopup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer Transition;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnNo;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblMessage;
    }
}