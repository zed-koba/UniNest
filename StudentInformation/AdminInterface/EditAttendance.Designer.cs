namespace StudentInformation.AdminInterface
{
    partial class EditAttendance
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
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPeriod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.modalTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnUpdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::StudentInformation.Properties.Resources.si__arrow_right_line__1_;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnUpdate.ImageSize = new System.Drawing.Size(24, 24);
            this.btnUpdate.Location = new System.Drawing.Point(502, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 42);
            this.btnUpdate.TabIndex = 95;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator4.FillThickness = 2;
            this.guna2Separator4.Location = new System.Drawing.Point(23, 268);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(659, 14);
            this.guna2Separator4.TabIndex = 85;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(23, 99);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(659, 14);
            this.guna2Separator1.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 80;
            this.label3.Text = "Details";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblBack.Image = global::StudentInformation.Properties.Resources.lsicon__arrow_left_filled__24_;
            this.lblBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBack.Location = new System.Drawing.Point(13, 15);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(107, 23);
            this.lblBack.TabIndex = 82;
            this.lblBack.Text = "       Cancel Edit";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 22);
            this.label4.TabIndex = 74;
            this.label4.Text = "Update student attendance right here";
            // 
            // txtStudentID
            // 
            this.txtStudentID.AutoSize = true;
            this.txtStudentID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtStudentID.Location = new System.Drawing.Point(18, 50);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(102, 28);
            this.txtStudentID.TabIndex = 73;
            this.txtStudentID.Text = "Student ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(110, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 22);
            this.label8.TabIndex = 76;
            this.label8.Text = "Period";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoRoundedCorners = true;
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 17;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbStatus.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.cmbStatus.Location = new System.Drawing.Point(303, 138);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(185, 36);
            this.cmbStatus.TabIndex = 99;
            // 
            // txtDate
            // 
            this.txtDate.Animated = true;
            this.txtDate.AutoRoundedCorners = true;
            this.txtDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDate.BorderRadius = 17;
            this.txtDate.BorderThickness = 1;
            this.txtDate.Checked = true;
            this.txtDate.FillColor = System.Drawing.Color.White;
            this.txtDate.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(102, 138);
            this.txtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(185, 36);
            this.txtDate.TabIndex = 98;
            this.txtDate.UseTransparentBackground = true;
            this.txtDate.Value = new System.DateTime(2024, 11, 23, 9, 5, 8, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(112, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 22);
            this.label6.TabIndex = 97;
            this.label6.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(321, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 96;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(514, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 96;
            this.label2.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.AutoRoundedCorners = true;
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BorderRadius = 17;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbType.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbType.ItemHeight = 30;
            this.cmbType.Items.AddRange(new object[] {
            "LEC",
            "LAB"});
            this.cmbType.Location = new System.Drawing.Point(496, 138);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(185, 36);
            this.cmbType.TabIndex = 99;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.AutoRoundedCorners = true;
            this.cmbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriod.BorderRadius = 17;
            this.cmbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbPeriod.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbPeriod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbPeriod.ItemHeight = 30;
            this.cmbPeriod.Items.AddRange(new object[] {
            "Prelim",
            "Midterm",
            "Final"});
            this.cmbPeriod.Location = new System.Drawing.Point(102, 222);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(185, 36);
            this.cmbPeriod.TabIndex = 99;
            // 
            // modalTimer
            // 
            this.modalTimer.Enabled = true;
            this.modalTimer.Interval = 10;
            this.modalTimer.Tick += new System.EventHandler(this.modalTimer_Tick);
            // 
            // EditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(699, 363);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.guna2Separator4);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAttendance";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditAttendance";
            this.Load += new System.EventHandler(this.EditAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtStudentID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer modalTimer;
    }
}