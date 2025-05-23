namespace StudentInformation.GlobalForms
{
    partial class CustomDecisionPopWindow
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
            this.lblType = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnNo = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
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
            this.Transition.Enabled = true;
            this.Transition.Interval = 10;
            this.Transition.Tick += new System.EventHandler(this.Transition_Tick);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(90, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(118, 28);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Are you sure?";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::StudentInformation.Properties.Resources.icons8_warning_48;
            this.pbIcon.Location = new System.Drawing.Point(113, 9);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(72, 52);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 8;
            this.pbIcon.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblMessage.Location = new System.Drawing.Point(0, 92);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMessage.Size = new System.Drawing.Size(298, 51);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Are you sure with your decision? This action cannot be undone";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnDelete.Location = new System.Drawing.Point(161, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Yes";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnNo.Location = new System.Drawing.Point(20, 145);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(112, 33);
            this.btnNo.TabIndex = 12;
            this.btnNo.Text = "No";
            this.btnNo.UseTransparentBackground = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
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
            this.btnClose.Location = new System.Drawing.Point(261, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedDepth = 0;
            this.btnClose.Size = new System.Drawing.Size(37, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustomDecisionPopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 186);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDecisionPopWindow";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomDecisionPopWindow";
            this.Load += new System.EventHandler(this.CustomYesNoPopWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Timer Transition;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnNo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}