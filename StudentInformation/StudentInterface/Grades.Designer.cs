namespace StudentInformation.StudentInterface
{
    partial class Grades
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
            this.panelGradeTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSemesters = new Guna.UI2.WinForms.Guna2Panel();
            this.flowGradePerSemester = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGradeTitle.SuspendLayout();
            this.panelSemesters.SuspendLayout();
            this.SuspendLayout();
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
            this.panelGradeTitle.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(2, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Student Grades";
            // 
            // panelSemesters
            // 
            this.panelSemesters.BorderRadius = 10;
            this.panelSemesters.Controls.Add(this.flowGradePerSemester);
            this.panelSemesters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSemesters.Location = new System.Drawing.Point(20, 41);
            this.panelSemesters.Name = "panelSemesters";
            this.panelSemesters.Padding = new System.Windows.Forms.Padding(5);
            this.panelSemesters.Size = new System.Drawing.Size(1010, 636);
            this.panelSemesters.TabIndex = 31;
            // 
            // flowGradePerSemester
            // 
            this.flowGradePerSemester.AutoSize = true;
            this.flowGradePerSemester.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowGradePerSemester.BackColor = System.Drawing.Color.Transparent;
            this.flowGradePerSemester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowGradePerSemester.Location = new System.Drawing.Point(5, 5);
            this.flowGradePerSemester.Name = "flowGradePerSemester";
            this.flowGradePerSemester.Size = new System.Drawing.Size(1000, 626);
            this.flowGradePerSemester.TabIndex = 0;
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelSemesters);
            this.Controls.Add(this.panelGradeTitle);
            this.Name = "Grades";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Size = new System.Drawing.Size(1050, 680);
            this.Load += new System.EventHandler(this.Grades_Load);
            this.panelGradeTitle.ResumeLayout(false);
            this.panelGradeTitle.PerformLayout();
            this.panelSemesters.ResumeLayout(false);
            this.panelSemesters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelGradeTitle;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel panelSemesters;
        private System.Windows.Forms.FlowLayoutPanel flowGradePerSemester;
    }
}
