namespace StudentInformation.StudentInterface
{
    partial class Schedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSubjects = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSchedule = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridSchedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.teachersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSeparator = new Guna.UI2.WinForms.Guna2Panel();
            this.panelFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnViewSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.cmbYearLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelScheduleTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.panelSubjects.SuspendLayout();
            this.panelSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelScheduleTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubjects
            // 
            this.panelSubjects.BorderRadius = 10;
            this.panelSubjects.Controls.Add(this.panelSchedule);
            this.panelSubjects.Controls.Add(this.panelSeparator);
            this.panelSubjects.Controls.Add(this.panelFilter);
            this.panelSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjects.Location = new System.Drawing.Point(20, 41);
            this.panelSubjects.Name = "panelSubjects";
            this.panelSubjects.Padding = new System.Windows.Forms.Padding(5);
            this.panelSubjects.Size = new System.Drawing.Size(1010, 625);
            this.panelSubjects.TabIndex = 33;
            // 
            // panelSchedule
            // 
            this.panelSchedule.BorderRadius = 10;
            this.panelSchedule.Controls.Add(this.dataGridSchedule);
            this.panelSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSchedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.panelSchedule.Location = new System.Drawing.Point(5, 76);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.Padding = new System.Windows.Forms.Padding(10);
            this.panelSchedule.Size = new System.Drawing.Size(1000, 542);
            this.panelSchedule.TabIndex = 2;
            // 
            // dataGridSchedule
            // 
            this.dataGridSchedule.AllowUserToAddRows = false;
            this.dataGridSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSchedule.ColumnHeadersHeight = 30;
            this.dataGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teachersName,
            this.Subject,
            this.Units,
            this.Type,
            this.Section,
            this.Room,
            this.Time,
            this.Day});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridSchedule.Enabled = false;
            this.dataGridSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridSchedule.Location = new System.Drawing.Point(10, 10);
            this.dataGridSchedule.Name = "dataGridSchedule";
            this.dataGridSchedule.ReadOnly = true;
            this.dataGridSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSchedule.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSchedule.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridSchedule.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridSchedule.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridSchedule.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridSchedule.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridSchedule.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSchedule.RowTemplate.Height = 20;
            this.dataGridSchedule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridSchedule.Size = new System.Drawing.Size(980, 531);
            this.dataGridSchedule.TabIndex = 0;
            this.dataGridSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridSchedule.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridSchedule.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridSchedule.ThemeStyle.ReadOnly = true;
            this.dataGridSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridSchedule.ThemeStyle.RowsStyle.Height = 20;
            this.dataGridSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridSchedule.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridSchedule_SortCompare);
            // 
            // teachersName
            // 
            this.teachersName.DividerWidth = 1;
            this.teachersName.FillWeight = 163.4321F;
            this.teachersName.HeaderText = "Teacher\'s Name";
            this.teachersName.Name = "teachersName";
            this.teachersName.ReadOnly = true;
            this.teachersName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Subject
            // 
            this.Subject.DividerWidth = 1;
            this.Subject.FillWeight = 129.4878F;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Units
            // 
            this.Units.DividerWidth = 1;
            this.Units.FillWeight = 84.53161F;
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DividerWidth = 1;
            this.Type.FillWeight = 104.6142F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.DividerWidth = 1;
            this.Section.FillWeight = 92.68314F;
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.DividerWidth = 1;
            this.Room.FillWeight = 82.51904F;
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DividerWidth = 1;
            this.Time.FillWeight = 96.90156F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.DividerWidth = 1;
            this.Day.FillWeight = 45.83061F;
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // panelSeparator
            // 
            this.panelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparator.Location = new System.Drawing.Point(5, 59);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(1000, 17);
            this.panelSeparator.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.BorderRadius = 10;
            this.panelFilter.Controls.Add(this.btnViewSchedule);
            this.panelFilter.Controls.Add(this.cmbYearLevel);
            this.panelFilter.Controls.Add(this.cmbSort);
            this.panelFilter.Controls.Add(this.cmbSemester);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.panelFilter.Location = new System.Drawing.Point(5, 5);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1000, 54);
            this.panelFilter.TabIndex = 0;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Animated = true;
            this.btnViewSchedule.AutoRoundedCorners = true;
            this.btnViewSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnViewSchedule.BorderRadius = 17;
            this.btnViewSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewSchedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnViewSchedule.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(682, 8);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(210, 36);
            this.btnViewSchedule.TabIndex = 1;
            this.btnViewSchedule.Text = "View Schedule Detail";
            this.btnViewSchedule.UseTransparentBackground = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.AutoRoundedCorners = true;
            this.cmbYearLevel.BackColor = System.Drawing.Color.Transparent;
            this.cmbYearLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbYearLevel.BorderRadius = 17;
            this.cmbYearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbYearLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbYearLevel.Font = new System.Drawing.Font("Poppins", 12F);
            this.cmbYearLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbYearLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbYearLevel.ItemHeight = 30;
            this.cmbYearLevel.Items.AddRange(new object[] {
            "1st Year"});
            this.cmbYearLevel.Location = new System.Drawing.Point(14, 8);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(188, 36);
            this.cmbYearLevel.StartIndex = 0;
            this.cmbYearLevel.TabIndex = 0;
            this.cmbYearLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSort
            // 
            this.cmbSort.AutoRoundedCorners = true;
            this.cmbSort.BackColor = System.Drawing.Color.Transparent;
            this.cmbSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbSort.BorderRadius = 17;
            this.cmbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSort.Font = new System.Drawing.Font("Poppins", 12F);
            this.cmbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbSort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSort.ItemHeight = 30;
            this.cmbSort.Items.AddRange(new object[] {
            "--SORT BY--",
            "Teacher\'s Name",
            "Subject",
            "Units",
            "Type",
            "Section",
            "Room",
            "Time",
            "Day"});
            this.cmbSort.Location = new System.Drawing.Point(483, 8);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(188, 36);
            this.cmbSort.StartIndex = 0;
            this.cmbSort.TabIndex = 0;
            this.cmbSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSemester
            // 
            this.cmbSemester.AutoRoundedCorners = true;
            this.cmbSemester.BackColor = System.Drawing.Color.Transparent;
            this.cmbSemester.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbSemester.BorderRadius = 17;
            this.cmbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSemester.Font = new System.Drawing.Font("Poppins", 12F);
            this.cmbSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSemester.ItemHeight = 30;
            this.cmbSemester.Items.AddRange(new object[] {
            "--Select A Semester--"});
            this.cmbSemester.Location = new System.Drawing.Point(212, 8);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(262, 36);
            this.cmbSemester.StartIndex = 0;
            this.cmbSemester.TabIndex = 0;
            this.cmbSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelScheduleTitle
            // 
            this.panelScheduleTitle.AutoSize = true;
            this.panelScheduleTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelScheduleTitle.Controls.Add(this.lblSchedule);
            this.panelScheduleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScheduleTitle.Location = new System.Drawing.Point(20, 0);
            this.panelScheduleTitle.Name = "panelScheduleTitle";
            this.panelScheduleTitle.Padding = new System.Windows.Forms.Padding(0, 0, 31, 0);
            this.panelScheduleTitle.Size = new System.Drawing.Size(1010, 41);
            this.panelScheduleTitle.TabIndex = 32;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblSchedule.Location = new System.Drawing.Point(2, 13);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(86, 28);
            this.lblSchedule.TabIndex = 27;
            this.lblSchedule.Text = "Schedule";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelSubjects);
            this.Controls.Add(this.panelScheduleTitle);
            this.Name = "Schedule";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Size = new System.Drawing.Size(1050, 680);
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.panelSubjects.ResumeLayout(false);
            this.panelSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelScheduleTitle.ResumeLayout(false);
            this.panelScheduleTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSubjects;
        private Guna.UI2.WinForms.Guna2Panel panelScheduleTitle;
        private System.Windows.Forms.Label lblSchedule;
        private Guna.UI2.WinForms.Guna2Panel panelFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemester;
        private Guna.UI2.WinForms.Guna2Button btnViewSchedule;
        private Guna.UI2.WinForms.Guna2Panel panelSchedule;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridSchedule;
        private Guna.UI2.WinForms.Guna2Panel panelSeparator;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYearLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
    }
}
