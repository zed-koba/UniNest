namespace StudentInformation.StudentInterface
{
    partial class Subjects
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
            this.panelSubjects = new Guna.UI2.WinForms.Guna2Panel();
            this.flowSubjects = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGradeTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSemester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbYearLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSubjects.SuspendLayout();
            this.panelGradeTitle.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubjects
            // 
            this.panelSubjects.BorderRadius = 10;
            this.panelSubjects.Controls.Add(this.flowSubjects);
            this.panelSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjects.Location = new System.Drawing.Point(20, 95);
            this.panelSubjects.Name = "panelSubjects";
            this.panelSubjects.Padding = new System.Windows.Forms.Padding(5);
            this.panelSubjects.Size = new System.Drawing.Size(1010, 585);
            this.panelSubjects.TabIndex = 35;
            // 
            // flowSubjects
            // 
            this.flowSubjects.AutoSize = true;
            this.flowSubjects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowSubjects.BackColor = System.Drawing.Color.Transparent;
            this.flowSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSubjects.Location = new System.Drawing.Point(5, 5);
            this.flowSubjects.Name = "flowSubjects";
            this.flowSubjects.Size = new System.Drawing.Size(1000, 575);
            this.flowSubjects.TabIndex = 0;
            // 
            // panelGradeTitle
            // 
            this.panelGradeTitle.AutoSize = true;
            this.panelGradeTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGradeTitle.Controls.Add(this.label5);
            this.panelGradeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGradeTitle.Location = new System.Drawing.Point(20, 0);
            this.panelGradeTitle.Name = "panelGradeTitle";
            this.panelGradeTitle.Padding = new System.Windows.Forms.Padding(0, 0, 31, 0);
            this.panelGradeTitle.Size = new System.Drawing.Size(1010, 41);
            this.panelGradeTitle.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(2, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Subjects";
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
            "First Semester"});
            this.cmbSemester.Location = new System.Drawing.Point(290, 8);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(253, 36);
            this.cmbSemester.StartIndex = 0;
            this.cmbSemester.TabIndex = 0;
            this.cmbSemester.TextOffset = new System.Drawing.Point(5, 0);
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbYearLevel_SelectedIndexChanged);
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
            this.cmbYearLevel.Location = new System.Drawing.Point(59, 8);
            this.cmbYearLevel.Name = "cmbYearLevel";
            this.cmbYearLevel.Size = new System.Drawing.Size(159, 36);
            this.cmbYearLevel.StartIndex = 0;
            this.cmbYearLevel.TabIndex = 0;
            this.cmbYearLevel.TextOffset = new System.Drawing.Point(5, 0);
            this.cmbYearLevel.SelectedIndexChanged += new System.EventHandler(this.cmbYearLevel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(231, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Term";
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.cmbYearLevel);
            this.panelFilter.Controls.Add(this.cmbSemester);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(20, 41);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1010, 54);
            this.panelFilter.TabIndex = 36;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelSubjects);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelGradeTitle);
            this.Name = "Subjects";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Size = new System.Drawing.Size(1050, 680);
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.panelSubjects.ResumeLayout(false);
            this.panelSubjects.PerformLayout();
            this.panelGradeTitle.ResumeLayout(false);
            this.panelGradeTitle.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSubjects;
        private System.Windows.Forms.FlowLayoutPanel flowSubjects;
        private Guna.UI2.WinForms.Guna2Panel panelGradeTitle;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSemester;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYearLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelFilter;
    }
}
