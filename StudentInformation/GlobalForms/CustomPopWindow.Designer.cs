namespace StudentInformation.StudentInterface
{
    partial class CustomPopWindow
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
            this.panelColor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.Transition = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panelColor
            // 
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.panelColor.Location = new System.Drawing.Point(0, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(12, 59);
            this.panelColor.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(49, 7);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(51, 28);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblMessage.Location = new System.Drawing.Point(51, 31);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(91, 22);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Error Message";
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
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::StudentInformation.Properties.Resources.material_symbols__close__1_;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(252, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedDepth = 0;
            this.btnClose.Size = new System.Drawing.Size(46, 59);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::StudentInformation.Properties.Resources.icons8_error_48;
            this.pbIcon.Location = new System.Drawing.Point(20, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(23, 23);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // Transition
            // 
            this.Transition.Enabled = true;
            this.Transition.Interval = 10;
            this.Transition.Tick += new System.EventHandler(this.Transition_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 59);
            this.panel1.TabIndex = 4;
            // 
            // CustomPopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 59);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomPopWindow";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomPopWindow";
            this.Load += new System.EventHandler(this.CustomPopWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pbIcon;
        private Guna.UI2.WinForms.Guna2Panel panelColor;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Timer Transition;
        private System.Windows.Forms.Panel panel1;
    }
}