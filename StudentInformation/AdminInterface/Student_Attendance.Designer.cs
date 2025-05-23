namespace StudentInformation.StudentInterface
{
    partial class Student_Attendance
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.cmbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbYearLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.tableContainer = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtPage = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTop.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.tableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.guna2Panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(20, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelTop.Size = new System.Drawing.Size(1010, 71);
            this.panelTop.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.lblBack);
            this.guna2Panel1.Controls.Add(this.cmbSubject);
            this.guna2Panel1.Controls.Add(this.cmbSemester);
            this.guna2Panel1.Controls.Add(this.cmbYearLevel);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1010, 66);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblBack.Image = global::StudentInformation.Properties.Resources.lsicon__arrow_left_filled__24_;
            this.lblBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBack.Location = new System.Drawing.Point(17, 15);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(107, 23);
            this.lblBack.TabIndex = 49;
            this.lblBack.Text = "       Cancel Edit";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.AutoRoundedCorners = true;
            this.cmbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cmbSubject.BorderRadius = 17;
            this.cmbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSubject.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSubject.ItemHeight = 30;
            this.cmbSubject.Items.AddRange(new object[] {
            "--Subject--"});
            this.cmbSubject.Location = new System.Drawing.Point(806, 15);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(184, 36);
            this.cmbSubject.StartIndex = 0;
            this.cmbSubject.TabIndex = 46;
            this.cmbSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.AutoRoundedCorners = true;
            this.cmbSemester.BackColor = System.Drawing.Color.Transparent;
            this.cmbSemester.BorderRadius = 17;
            this.cmbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSemester.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbSemester.ItemHeight = 30;
            this.cmbSemester.Items.AddRange(new object[] {
            "--Semester--"});
            this.cmbSemester.Location = new System.Drawing.Point(593, 15);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(196, 36);
            this.cmbSemester.StartIndex = 0;
            this.cmbSemester.TabIndex = 47;
            this.cmbSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // cmbYearLevel
            // 
            this.cmbYearLevel.AutoRoundedCorners = true;
            this.cmbYearLevel.BackColor = System.Drawing.Color.Transparent;
            this.cmbYearLevel.BorderRadius = 17;
            this.cmbYearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbYearLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbYearLevel.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cmbYearLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.cmbYearLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.cmbYearLevel.ItemHeight = 30;
            this.cmbYearLevel.Items.AddRange(new object[] {
            "--Year Level--"});
            this.cmbYearLevel.Location = new System.Drawing.Point(410, 15);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(169, 36);
            this.cmbYearLevel.StartIndex = 0;
            this.cmbYearLevel.TabIndex = 48;
            this.cmbYearLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbYearLevel.SelectedIndexChanged += new System.EventHandler(this.cmbYearLevel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(354, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Filter";
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.tableContainer);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainContent.Location = new System.Drawing.Point(20, 71);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1010, 593);
            this.panelMainContent.TabIndex = 6;
            // 
            // tableContainer
            // 
            this.tableContainer.BorderRadius = 15;
            this.tableContainer.Controls.Add(this.btnAdd);
            this.tableContainer.Controls.Add(this.btnNext);
            this.tableContainer.Controls.Add(this.btnPrev);
            this.tableContainer.Controls.Add(this.txtPage);
            this.tableContainer.Controls.Add(this.dataGridStudents);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableContainer.Size = new System.Drawing.Size(1010, 593);
            this.tableContainer.TabIndex = 0;
            this.tableContainer.Text = "guna2ContainerControl1";
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnAdd.Font = new System.Drawing.Font("Poppins", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::StudentInformation.Properties.Resources.mdi__plus_circle_outline;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnAdd.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAdd.Location = new System.Drawing.Point(827, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 42);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnNext.Image = global::StudentInformation.Properties.Resources.si__arrow_right_line__2_;
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(24, 24);
            this.btnNext.Location = new System.Drawing.Point(88, 554);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnNext.Size = new System.Drawing.Size(22, 21);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseTransparentBackground = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnPrev.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrev.Image = global::StudentInformation.Properties.Resources.si__arrow_right_line__2_;
            this.btnPrev.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnPrev.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPrev.ImageRotate = 0F;
            this.btnPrev.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrev.Location = new System.Drawing.Point(21, 554);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnPrev.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrev.Size = new System.Drawing.Size(22, 21);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.UseTransparentBackground = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtPage
            // 
            this.txtPage.Animated = true;
            this.txtPage.BorderRadius = 5;
            this.txtPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPage.DefaultText = "1";
            this.txtPage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.txtPage.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtPage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.txtPage.Location = new System.Drawing.Point(47, 548);
            this.txtPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPage.Name = "txtPage";
            this.txtPage.PasswordChar = '\0';
            this.txtPage.PlaceholderText = "";
            this.txtPage.ReadOnly = true;
            this.txtPage.SelectedText = "";
            this.txtPage.Size = new System.Drawing.Size(34, 32);
            this.txtPage.TabIndex = 3;
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToAddRows = false;
            this.dataGridStudents.AllowUserToDeleteRows = false;
            this.dataGridStudents.AllowUserToResizeColumns = false;
            this.dataGridStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridStudents.ColumnHeadersHeight = 35;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.StudentName,
            this.Type,
            this.Period,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dataGridStudents.Location = new System.Drawing.Point(0, 10);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.ReadOnly = true;
            this.dataGridStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridStudents.RowHeadersVisible = false;
            this.dataGridStudents.RowTemplate.Height = 48;
            this.dataGridStudents.RowTemplate.ReadOnly = true;
            this.dataGridStudents.Size = new System.Drawing.Size(1010, 531);
            this.dataGridStudents.StandardTab = true;
            this.dataGridStudents.TabIndex = 1;
            this.dataGridStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.dataGridStudents.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridStudents.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.dataGridStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridStudents.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridStudents.ThemeStyle.ReadOnly = true;
            this.dataGridStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridStudents.ThemeStyle.RowsStyle.Height = 48;
            this.dataGridStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellClick);
            this.dataGridStudents.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellMouseEnter);
            this.dataGridStudents.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellMouseLeave);
            this.dataGridStudents.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridStudents_CurrentCellDirtyStateChanged);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.FillWeight = 120F;
            this.StudentName.HeaderText = "Status";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Period
            // 
            this.Period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Period.FillWeight = 120F;
            this.Period.HeaderText = "Period";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            this.Period.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.FillWeight = 60.79124F;
            this.Action.HeaderText = "Action";
            this.Action.Image = global::StudentInformation.Properties.Resources.edit__1_;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.FillWeight = 60.79124F;
            this.dataGridViewImageColumn1.HeaderText = "Action";
            this.dataGridViewImageColumn1.Image = global::StudentInformation.Properties.Resources.edit__1_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Student_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelTop);
            this.Name = "Student_Attendance";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.Size = new System.Drawing.Size(1035, 680);
            this.Load += new System.EventHandler(this.Student_Attendance_Load);
            this.panelTop.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel panelMainContent;
        private Guna.UI2.WinForms.Guna2ContainerControl tableContainer;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrev;
        private Guna.UI2.WinForms.Guna2TextBox txtPage;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridStudents;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubject;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemester;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYearLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewImageColumn Action;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
