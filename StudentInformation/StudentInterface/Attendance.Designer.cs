namespace StudentInformation.StudentInterface
{
    partial class Attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAttendance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendancePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSubjectDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttendance)).BeginInit();
            this.panelSubjectDetails.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAttendance
            // 
            this.dataGridAttendance.AllowUserToAddRows = false;
            this.dataGridAttendance.AllowUserToDeleteRows = false;
            this.dataGridAttendance.AllowUserToResizeColumns = false;
            this.dataGridAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGridAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridAttendance.ColumnHeadersHeight = 32;
            this.dataGridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceDate,
            this.AttendanceStatus,
            this.AttendancePeriod,
            this.AttendanceType});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAttendance.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridAttendance.Enabled = false;
            this.dataGridAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridAttendance.Location = new System.Drawing.Point(15, 58);
            this.dataGridAttendance.Name = "dataGridAttendance";
            this.dataGridAttendance.ReadOnly = true;
            this.dataGridAttendance.RowHeadersVisible = false;
            this.dataGridAttendance.Size = new System.Drawing.Size(980, 466);
            this.dataGridAttendance.TabIndex = 0;
            this.dataGridAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridAttendance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridAttendance.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGridAttendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAttendance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridAttendance.ThemeStyle.HeaderStyle.Height = 32;
            this.dataGridAttendance.ThemeStyle.ReadOnly = true;
            this.dataGridAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridAttendance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridAttendance.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AttendanceDate
            // 
            this.AttendanceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AttendanceDate.HeaderText = "Date";
            this.AttendanceDate.Name = "AttendanceDate";
            this.AttendanceDate.ReadOnly = true;
            // 
            // AttendanceStatus
            // 
            this.AttendanceStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AttendanceStatus.HeaderText = "Status";
            this.AttendanceStatus.Name = "AttendanceStatus";
            this.AttendanceStatus.ReadOnly = true;
            // 
            // AttendancePeriod
            // 
            this.AttendancePeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AttendancePeriod.HeaderText = "Period";
            this.AttendancePeriod.Name = "AttendancePeriod";
            this.AttendancePeriod.ReadOnly = true;
            // 
            // AttendanceType
            // 
            this.AttendanceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AttendanceType.HeaderText = "Type";
            this.AttendanceType.Name = "AttendanceType";
            this.AttendanceType.ReadOnly = true;
            // 
            // panelSubjectDetails
            // 
            this.panelSubjectDetails.Controls.Add(this.guna2Panel1);
            this.panelSubjectDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjectDetails.Location = new System.Drawing.Point(15, 0);
            this.panelSubjectDetails.Name = "panelSubjectDetails";
            this.panelSubjectDetails.Size = new System.Drawing.Size(980, 58);
            this.panelSubjectDetails.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.lblSubjectName);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(304, 48);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubjectName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblSubjectName.Location = new System.Drawing.Point(10, 10);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(284, 28);
            this.lblSubjectName.TabIndex = 0;
            this.lblSubjectName.Text = "Subject Name - 3:00 PM - 6:00 PM";
            // 
            // btnReturn
            // 
            this.btnReturn.Animated = true;
            this.btnReturn.AutoRoundedCorners = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BorderRadius = 19;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnReturn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = global::StudentInformation.Properties.Resources.si__arrow_left_fill;
            this.btnReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReturn.Location = new System.Drawing.Point(15, 532);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(243, 40);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to Subjects";
            this.btnReturn.UseTransparentBackground = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridAttendance);
            this.Controls.Add(this.panelSubjectDetails);
            this.Name = "Attendance";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Size = new System.Drawing.Size(1010, 585);
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAttendance)).EndInit();
            this.panelSubjectDetails.ResumeLayout(false);
            this.panelSubjectDetails.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridAttendance;
        private Guna.UI2.WinForms.Guna2Panel panelSubjectDetails;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendancePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceType;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
    }
}
