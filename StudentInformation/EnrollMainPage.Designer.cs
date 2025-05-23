namespace StudentInformation
{
    partial class EnrollMainPage
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
            this.panelNav = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.progCompletion = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblCompletion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.Transparent;
            this.panelNav.Controls.Add(this.progCompletion);
            this.panelNav.Controls.Add(this.btnClose);
            this.panelNav.Controls.Add(this.guna2PictureBox1);
            this.panelNav.Controls.Add(this.lblCompletion);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Controls.Add(this.lblAppName);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panelNav.ShadowShift = 3;
            this.panelNav.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.panelNav.Size = new System.Drawing.Size(1157, 66);
            this.panelNav.TabIndex = 0;
            // 
            // progCompletion
            // 
            this.progCompletion.BorderRadius = 5;
            this.progCompletion.Location = new System.Drawing.Point(795, 28);
            this.progCompletion.Name = "progCompletion";
            this.progCompletion.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(243)))), ((int)(((byte)(169)))));
            this.progCompletion.Size = new System.Drawing.Size(182, 10);
            this.progCompletion.TabIndex = 27;
            this.progCompletion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomIconSize = 15F;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnClose.Location = new System.Drawing.Point(1109, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 33);
            this.btnClose.TabIndex = 26;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::StudentInformation.Properties.Resources.logo2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(39, 42);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // lblCompletion
            // 
            this.lblCompletion.AutoSize = true;
            this.lblCompletion.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblCompletion.Location = new System.Drawing.Point(986, 22);
            this.lblCompletion.Name = "lblCompletion";
            this.lblCompletion.Size = new System.Drawing.Size(95, 23);
            this.lblCompletion.TabIndex = 25;
            this.lblCompletion.Text = "0% Complete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(185, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enrollment";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblAppName.Location = new System.Drawing.Point(79, 15);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(117, 37);
            this.lblAppName.TabIndex = 25;
            this.lblAppName.Text = "UniNest >";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 66);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1157, 588);
            this.MainPanel.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelNav;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // EnrollMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 654);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnrollMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrollMainPage";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelNav;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ProgressBar progCompletion;
        private System.Windows.Forms.Label lblCompletion;
    }
}