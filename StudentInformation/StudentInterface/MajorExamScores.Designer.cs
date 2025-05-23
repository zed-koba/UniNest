namespace StudentInformation.StudentInterface
{
    partial class MajorExamScores
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
            this.dataGridScores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prelim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Midterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridScores
            // 
            this.dataGridScores.AllowUserToAddRows = false;
            this.dataGridScores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridScores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridScores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridScores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGridScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridScores.ColumnHeadersHeight = 35;
            this.dataGridScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Prelim,
            this.Midterm,
            this.Final});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridScores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridScores.Enabled = false;
            this.dataGridScores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridScores.Location = new System.Drawing.Point(40, 40);
            this.dataGridScores.Name = "dataGridScores";
            this.dataGridScores.ReadOnly = true;
            this.dataGridScores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridScores.RowHeadersVisible = false;
            this.dataGridScores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridScores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridScores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridScores.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScores.RowTemplate.DividerHeight = 1;
            this.dataGridScores.RowTemplate.Height = 30;
            this.dataGridScores.RowTemplate.ReadOnly = true;
            this.dataGridScores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridScores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridScores.Size = new System.Drawing.Size(930, 400);
            this.dataGridScores.TabIndex = 0;
            this.dataGridScores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridScores.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridScores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridScores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridScores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridScores.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dataGridScores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridScores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridScores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridScores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridScores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridScores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridScores.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridScores.ThemeStyle.ReadOnly = true;
            this.dataGridScores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.dataGridScores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGridScores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridScores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.dataGridScores.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridScores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridScores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            // 
            // Subject
            // 
            this.Subject.DividerWidth = 1;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Prelim
            // 
            this.Prelim.DividerWidth = 1;
            this.Prelim.HeaderText = "Prelim";
            this.Prelim.Name = "Prelim";
            this.Prelim.ReadOnly = true;
            // 
            // Midterm
            // 
            this.Midterm.DividerWidth = 1;
            this.Midterm.HeaderText = "Midterm";
            this.Midterm.Name = "Midterm";
            this.Midterm.ReadOnly = true;
            // 
            // Final
            // 
            this.Final.DividerWidth = 1;
            this.Final.HeaderText = "Final";
            this.Final.Name = "Final";
            this.Final.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Animated = true;
            this.btnReturn.AutoRoundedCorners = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BorderRadius = 21;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnReturn.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = global::StudentInformation.Properties.Resources.si__arrow_left_fill;
            this.btnReturn.Location = new System.Drawing.Point(40, 456);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(208, 44);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return to Semesters";
            this.btnReturn.UseTransparentBackground = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // MajorExamScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridScores);
            this.Name = "MajorExamScores";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(1010, 622);
            this.Load += new System.EventHandler(this.MajorExamScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prelim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Midterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
    }
}
