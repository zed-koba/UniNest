namespace StudentInformation.StudentInterface
{
    partial class MajorExam
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
            this.panelSemesters = new Guna.UI2.WinForms.Guna2Panel();
            this.flowSemester = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGradeTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSemesters.SuspendLayout();
            this.panelGradeTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSemesters
            // 
            this.panelSemesters.BorderRadius = 10;
            this.panelSemesters.Controls.Add(this.flowSemester);
            this.panelSemesters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSemesters.Location = new System.Drawing.Point(20, 41);
            this.panelSemesters.Name = "panelSemesters";
            this.panelSemesters.Padding = new System.Windows.Forms.Padding(5);
            this.panelSemesters.Size = new System.Drawing.Size(1010, 622);
            this.panelSemesters.TabIndex = 33;
            // 
            // flowSemester
            // 
            this.flowSemester.AutoSize = true;
            this.flowSemester.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowSemester.BackColor = System.Drawing.Color.Transparent;
            this.flowSemester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSemester.Location = new System.Drawing.Point(5, 5);
            this.flowSemester.Name = "flowSemester";
            this.flowSemester.Size = new System.Drawing.Size(1000, 612);
            this.flowSemester.TabIndex = 0;
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
            this.panelGradeTitle.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(2, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Major Exam";
            // 
            // MajorExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelSemesters);
            this.Controls.Add(this.panelGradeTitle);
            this.Name = "MajorExam";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Size = new System.Drawing.Size(1050, 680);
            this.Load += new System.EventHandler(this.MajorExam_Load);
            this.panelSemesters.ResumeLayout(false);
            this.panelSemesters.PerformLayout();
            this.panelGradeTitle.ResumeLayout(false);
            this.panelGradeTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSemesters;
        private System.Windows.Forms.FlowLayoutPanel flowSemester;
        private Guna.UI2.WinForms.Guna2Panel panelGradeTitle;
        private System.Windows.Forms.Label label5;
    }
}
