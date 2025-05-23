namespace StudentInformation.AdminInterface
{
    partial class StudentsEnrollmentDetails
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPage = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableContainer = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.tableContainer.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(946, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(828, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(478, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(361, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblID.Location = new System.Drawing.Point(31, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 26);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.label5);
            this.panelHeader.Controls.Add(this.label6);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblID);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1010, 54);
            this.panelHeader.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(629, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Classification";
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
            this.dataGridStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridStudents.ColumnHeadersHeight = 35;
            this.dataGridStudents.ColumnHeadersVisible = false;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.StudentName,
            this.Gender,
            this.Course,
            this.studentType,
            this.Status,
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
            this.dataGridStudents.Location = new System.Drawing.Point(0, 54);
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
            this.dataGridStudents.Size = new System.Drawing.Size(1010, 493);
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
            this.dataGridStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            // studentID
            // 
            this.studentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentID.FillWeight = 76.14214F;
            this.studentID.HeaderText = "ID";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            this.studentID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.FillWeight = 200F;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.FillWeight = 99.79124F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Course
            // 
            this.Course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course.FillWeight = 99.79124F;
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // studentType
            // 
            this.studentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentType.FillWeight = 180F;
            this.studentType.HeaderText = "Classification";
            this.studentType.Name = "studentType";
            this.studentType.ReadOnly = true;
            this.studentType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.FillWeight = 120F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // tableContainer
            // 
            this.tableContainer.BorderRadius = 15;
            this.tableContainer.Controls.Add(this.btnNext);
            this.tableContainer.Controls.Add(this.btnPrev);
            this.tableContainer.Controls.Add(this.txtPage);
            this.tableContainer.Controls.Add(this.dataGridStudents);
            this.tableContainer.Controls.Add(this.panelHeader);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.tableContainer.Location = new System.Drawing.Point(0, 0);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.Size = new System.Drawing.Size(1010, 593);
            this.tableContainer.TabIndex = 0;
            this.tableContainer.Text = "guna2ContainerControl1";
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
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.tableContainer);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainContent.Location = new System.Drawing.Point(20, 71);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1010, 593);
            this.panelMainContent.TabIndex = 3;
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
            "Student Name",
            "Course",
            "Classification",
            "Status"});
            this.cmbSort.Location = new System.Drawing.Point(746, 16);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(247, 36);
            this.cmbSort.TabIndex = 2;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lblFilter.Location = new System.Drawing.Point(671, 20);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(69, 28);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Sort By:";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cmbSort);
            this.panelTop.Controls.Add(this.lblFilter);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(20, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1010, 71);
            this.panelTop.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 17;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::StudentInformation.Properties.Resources.material_symbols__search;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txtSearch.Location = new System.Drawing.Point(3, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Student";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(276, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.FillWeight = 99.79124F;
            this.dataGridViewImageColumn1.HeaderText = "Action";
            this.dataGridViewImageColumn1.Image = global::StudentInformation.Properties.Resources.wired_lineal_35_edit_hover_line;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // StudentsEnrollmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelTop);
            this.Name = "StudentsEnrollmentDetails";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.Size = new System.Drawing.Size(1035, 680);
            this.Load += new System.EventHandler(this.StudentsEnrollmentDetails_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.tableContainer.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrev;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtPage;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridStudents;
        private Guna.UI2.WinForms.Guna2ContainerControl tableContainer;
        private Guna.UI2.WinForms.Guna2Panel panelMainContent;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Action;
    }
}
