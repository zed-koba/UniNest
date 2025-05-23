using Guna.UI2.WinForms;
using StudentInformation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.StudentInterface
{
    public partial class Grades : UserControl
    {
        int student_Id, getYearLevel, getCurrentSem;
        List<double> prelimGrades = new List<double>();
        List<double> midTermGrades = new List<double>();
        List<double> finalGrades = new List<double>();
        

        UserControl currentUserControl;
        public Grades(int studentId)
        {
            InitializeComponent();
            student_Id = studentId;
            currentUserControl = this;
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            
            string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
            double prelimGpa = 0, midTermGpa = 0, finalGpa = 0;
            string prelimText = string.Empty, midText = string.Empty, finalText = string.Empty, semester = string.Empty, course = string.Empty, allUnavailable = string.Empty;
            try
            {
                using(SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = $"SELECT * FROM Students WHERE student_ID = {student_Id}";
                        using(SqlDataReader reader = command.ExecuteReader()) {
                            if(reader.HasRows)
                            {
                                reader.Read();
                                getYearLevel = (int)char.GetNumericValue(reader["yearLevel"].ToString()[0]);
                                getCurrentSem = (int)reader["currentSem"];
                                course = reader["course"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No Data Found");
                            }                       
                        }

                        
                        for(int i = 1; i <= getYearLevel; i++)
                        {
                            for(int j = 1;  j <= getCurrentSem; j++)
                            {
                                prelimGrades = new List<double>();
                                midTermGrades = new List<double>();
                                finalGrades = new List<double>();
                                command.CommandText = $"SELECT COUNT(*) FROM Students_SubjectsTaken WHERE student_id = {student_Id} AND student_subjectYrLevel = {i} AND student_subjectTerm = {j}";
                                int takenRowCount = (int)command.ExecuteScalar();
                                command.CommandText = $"SELECT COUNT(*) FROM Students_Grades WHERE student_id = {student_Id} AND student_yrLevel = {i} AND grade_sem = {j}";
                                int numOfGradeUpdated = (int)command.ExecuteScalar();

                                if (takenRowCount == numOfGradeUpdated || takenRowCount > 0)
                                {
                                    try
                                    {
                                        command.CommandText = $"SELECT * FROM Students_Grades WHERE student_id = {student_Id} AND student_yrLevel = {i} AND grade_sem = {j}";
                                        using (SqlDataReader reader = command.ExecuteReader())
                                        {
                                            if (reader.HasRows)
                                            {
                                                while (reader.Read())
                                                {
                                                    prelimGrades.Add(Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("student_PrelimGrade"))));
                                                    midTermGrades.Add(Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("student_MidtermGrade"))));
                                                    finalGrades.Add(Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("student_FinalGrade"))));
                                                }
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message + "THIS POPPED");
                                    }
                                    if (prelimGrades.Count == 0)
                                        prelimText = "Unavailable";
                                    if (midTermGrades.Count == 0)
                                        midText = "Unavailable";
                                    if (finalGrades.Count == 0)
                                        finalText = "Unavailable";

                                    foreach (double grade in prelimGrades)
                                    {
                                        if (grade != 0)
                                        {
                                            prelimGpa += grade;
                                        }
                                        else
                                        {
                                            prelimText = "Unavailable";
                                            break;
                                        }
                                    }
                                    foreach (double grade in midTermGrades)
                                    {
                                        if (grade != 0)
                                        {
                                            midTermGpa += grade;
                                        }
                                        else
                                        {
                                            midText = "Unavailable";
                                            break;
                                        }
                                    }
                                    foreach (double grade in finalGrades)
                                    {
                                        if (grade != 0)
                                        {
                                            finalGpa += grade;
                                        }
                                        else
                                        {
                                            finalText = "Unavailable";
                                            break;
                                        }
                                    }
                                    prelimGpa = prelimGpa / takenRowCount;
                                    midTermGpa = midTermGpa / takenRowCount;
                                    finalGpa = finalGpa / takenRowCount;

                                    
                                    if (prelimText != "Unavailable")
                                        prelimText = prelimGpa.ToString("0.00");
                                    if(midText != "Unavailable")
                                        midText = midTermGpa.ToString("0.00");
                                    if (finalText != "Unavailable")
                                        finalText = finalGpa.ToString("0.00");
                                    if (prelimText == "Unavailable" && midText == "Unavailable" && finalText == "Unavailable")
                                    {
                                        allUnavailable = "unavailable";
                                    }
                                    else
                                    {
                                        allUnavailable = j.ToString();
                                    }
                                    
                                    if (i == getYearLevel && j == getCurrentSem)
                                    {
                                        createSemesterCard(j, course, i, prelimText, midText, finalText, true, allUnavailable);
                                    }
                                    else
                                    {
                                        createSemesterCard(j, course, i, prelimText, midText, finalText, false, allUnavailable);
                                    }
                                }    
                            }
                            
                        }
                        
                    }
                }

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void seeDetails_Click(object sender, EventArgs e)
        {
            var btn = sender as Label;
            if ((string)btn.Tag != "unavailable")
            {
                //flowGradePerSemester.Visible = false;
                currentUserControl = new GradesPerSem(student_Id, Convert.ToInt32(btn.Name), Convert.ToInt32(btn.Tag));
                currentUserControl.Dock = DockStyle.Fill;
                panelSemesters.Controls.Add(currentUserControl);
                currentUserControl.BringToFront();
            }
            else
            {
                GlobalMethod.PopAMessage("error", "No grades are posted yet", this.Parent.Parent.Size, this.Parent.Parent.Location);
               
            }

        }
        private void createSemesterCard(int sem, string course, int yearLevel, string prelimGrade, string midtermGrade, string finalGrade, bool currentSem, string unavailable)
        {
            var currentSemester = currentSem;
            string status = "passed";
            string statusOfSem = string.Empty;
            List<int> foreColor = new List<int>();
            List<int> backColor = new List<int>();
            List<int> fillColorGreen = new List<int>();
            List<int> fillColorGreen2 = new List<int>();
            Image seeDetailsIcon;
            

            if (currentSemester)
            {
                if (status == "passed")
                {
                    foreColor = new List<int> { 251, 252, 248 };
                }
                else
                {
                    foreColor = new List<int> { 215, 215, 215 };
                }
                backColor = new List<int> { 10, 169, 110 };
                fillColorGreen = new List<int> { 13, 217, 141 };
                fillColorGreen2 = new List<int> { 42, 243, 169 };
                statusOfSem = "On going";
                seeDetailsIcon = Resources.si__arrow_right_line__1_;
            }
            else
            {
                seeDetailsIcon = Resources.si__arrow_right_line__2_;
                foreColor = new List<int> { 51, 52, 55 };
                backColor = new List<int> { 251, 252, 248 };
                fillColorGreen = new List<int> { 10, 169, 110 };
                fillColorGreen2 = new List<int> { 10, 169, 110 };
                statusOfSem = "Finished";
            }
            string yearLevelWord = string.Empty;
            string semester = string.Empty;
            switch (yearLevel)
            {
                case 1:
                    yearLevelWord = "1st Year";
                    break;
                case 2:
                    yearLevelWord = "2nd Year";
                    break;
                case 3:
                    yearLevelWord = "3rd Year";
                    break;
                case 4:
                    yearLevelWord = "4th Year";
                    break;
            }
            switch (sem)
            {
                case 1:
                    semester = "First Semester";
                    break;
                case 2:
                    semester = "Second Semester";
                    break;
            }
            Guna2Panel panelSemester = new Guna2Panel();
            panelSemester.Size = new Size(290, 175);
            panelSemester.FillColor = Color.FromArgb(backColor[0], backColor[1], backColor[2]);
            panelSemester.BorderRadius = 10;
            panelSemester.BackColor = Color.Transparent;

            Guna2Panel panelIcon = new Guna2Panel();
            panelIcon.Size = new Size(56, 52);
            panelIcon.FillColor = Color.FromArgb(fillColorGreen[0], fillColorGreen[1], fillColorGreen[2]);
            panelIcon.Location = new Point(11, 14);
            panelIcon.BorderRadius = 8;
            panelIcon.BackColor = Color.Transparent;

            Guna2PictureBox pbIcon = new Guna2PictureBox();
            pbIcon.Size = new Size(38, 41);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.BackColor = Color.Transparent;
            pbIcon.Location = new Point(8, 6);
            pbIcon.Image = Resources.hugeicons__school_report_card;

            panelIcon.Controls.Add(pbIcon);

            Label lblSemTitle = new Label();
            lblSemTitle.Text = semester;
            lblSemTitle.Font = new Font("Poppins", 12, FontStyle.Bold);
            lblSemTitle.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblSemTitle.BackColor = Color.Transparent;
            lblSemTitle.AutoSize = true;
            lblSemTitle.Location = new Point(72, 16);

            Label lblyearLevel = new Label();
            lblyearLevel.Text = $"{course} - {yearLevelWord}";
            lblyearLevel.Font = new Font("Poppins", 10, FontStyle.Regular);
            lblyearLevel.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblyearLevel.BackColor = Color.Transparent;
            lblyearLevel.AutoSize = true;
            lblyearLevel.Location = new Point(72, 37);

            TableLayoutPanel tblPeriods = new TableLayoutPanel();
            tblPeriods.AutoSize = false;
            tblPeriods.ColumnCount = 3;
            tblPeriods.BackColor = Color.Transparent;
            tblPeriods.Location = new Point(0, 75);
            tblPeriods.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tblPeriods.Size = new Size(292, 56);
            //tblPeriods.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblPeriods.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tblPeriods.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tblPeriods.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            FlowLayoutPanel flowPrelim = new FlowLayoutPanel();
            flowPrelim.FlowDirection = FlowDirection.TopDown;
            flowPrelim.AutoSize = true;
            flowPrelim.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPrelim.BackColor = Color.Transparent;

            FlowLayoutPanel flowMidterm = new FlowLayoutPanel();
            flowMidterm.FlowDirection = FlowDirection.TopDown;
          
            flowMidterm.AutoSize = true;
            flowPrelim.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowMidterm.BackColor = Color.Transparent;

            FlowLayoutPanel flowFinal = new FlowLayoutPanel();
            flowFinal.FlowDirection = FlowDirection.TopDown;
            flowFinal.AutoSize = true;
            flowPrelim.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowFinal.BackColor = Color.Transparent;

            Label lblPrelim = new Label();
            lblPrelim.Text = "Prelim";
            lblPrelim.Font = new Font("Poppins", 9, FontStyle.Regular);
            lblPrelim.AutoSize = false;
            lblPrelim.Size = new Size(83, 23);
            lblPrelim.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblPrelim.BackColor = Color.FromArgb(backColor[0], backColor[1], backColor[2]);
            lblPrelim.TextAlign = ContentAlignment.TopCenter;

            Label lblPrelimGrade = new Label();
            lblPrelimGrade.Name = "getPrelimGrade";
            lblPrelimGrade.Text = prelimGrade;
            lblPrelimGrade.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblPrelimGrade.BackColor = Color.FromArgb(backColor[0], backColor[1], backColor[2]);
            lblPrelimGrade.AutoSize = false;
            lblPrelimGrade.Size = new Size(83, 23);
            lblPrelimGrade.Font = new Font("Poppins", 9, FontStyle.Regular);
            lblPrelimGrade.TextAlign = ContentAlignment.TopCenter;

            Label lblMidterm = new Label();
            lblMidterm.Text = "Midterm";
            lblMidterm.Font = new Font("Poppins", 9, FontStyle.Regular);
            lblMidterm.AutoSize = false;
            lblMidterm.Size = new Size(83, 23);
            lblMidterm.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblMidterm.BackColor = Color.FromArgb(backColor[0], backColor[1], backColor[2]);
            lblMidterm.TextAlign = ContentAlignment.TopCenter;

            Label lblMidtermGrade = new Label();
            lblMidtermGrade.Name = "getMidtermGrade"; 
            lblMidtermGrade.Text = midtermGrade;
            lblMidtermGrade.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblMidtermGrade.BackColor = Color.FromArgb(backColor[0], backColor[1], backColor[2]);
            lblMidtermGrade.AutoSize = false;
            lblMidtermGrade.Size = new Size(83, 23);
            lblMidtermGrade.Font = new Font("Poppins", 9, FontStyle.Regular);
            lblMidtermGrade.TextAlign = ContentAlignment.TopCenter;


            Label lblFinal = new Label();
            lblFinal.Name = "getFinalGrade";
            lblFinal.Text = "Final";
            lblFinal.Font = new Font("Poppins", 9, FontStyle.Regular);
            lblFinal.AutoSize = false;
            lblFinal.Size = new Size(83, 23);
            lblFinal.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblFinal.BackColor = Color.FromArgb(backColor[0], backColor[1], backColor[2]);
            lblFinal.TextAlign = ContentAlignment.TopCenter;

            Label lblFinalGrade = new Label();
            lblFinalGrade.Text = finalGrade;
            lblFinalGrade.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            lblFinalGrade.BackColor = Color.FromArgb(backColor[0], backColor[1], backColor[2]);
            lblFinalGrade.AutoSize = false;
            lblFinalGrade.Size = new Size(83, 23);
            lblFinalGrade.Font = new Font("Poppins", 9, FontStyle.Regular);
            lblFinalGrade.TextAlign = ContentAlignment.TopCenter;

            Guna2Separator separator = new Guna2Separator();
            separator.Size = new Size(290, 10);
            separator.Location = new Point(2, 134);
            separator.FillColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);

            Label lblStatus = new Label();
            lblStatus.Text = statusOfSem;
            lblStatus.ForeColor = Color.FromArgb(fillColorGreen2[0], fillColorGreen2[1], fillColorGreen2[2]);
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Poppins", 10, FontStyle.Bold);
            lblStatus.Location = new Point(15, 144);
            lblStatus.AutoSize = true;

            Label seeDetails = new Label();
            seeDetails.Text = "See Details       ";
            seeDetails.ForeColor = Color.FromArgb(foreColor[0], foreColor[1], foreColor[2]);
            seeDetails.BackColor = Color.Transparent;
            seeDetails.Font = new Font("Poppins", 10, FontStyle.Bold);
            seeDetails.Location = new Point(170, 144);
            seeDetails.AutoSize = true;
            seeDetails.Image = seeDetailsIcon;
            seeDetails.ImageAlign = ContentAlignment.MiddleRight;
            seeDetails.Cursor = Cursors.Hand;
            seeDetails.Name = sem.ToString();
            seeDetails.Tag = unavailable;
            seeDetails.Click += seeDetails_Click;

            flowPrelim.Controls.Add(lblPrelim);
            flowPrelim.Controls.Add(lblPrelimGrade);

            flowMidterm.Controls.Add(lblMidterm);
            flowMidterm.Controls.Add(lblMidtermGrade);

            flowFinal.Controls.Add(lblFinal);
            flowFinal.Controls.Add(lblFinalGrade);

           
            tblPeriods.Controls.Add(flowPrelim, 0, 0);
            tblPeriods.Controls.Add(flowMidterm, 1, 0);
            tblPeriods.Controls.Add(flowFinal, 2, 0);

            panelSemester.Controls.Add(panelIcon);
            panelSemester.Controls.Add(lblyearLevel);
            panelSemester.Controls.Add(lblSemTitle);
            panelSemester.Controls.Add(tblPeriods);
            panelSemester.Controls.Add(separator);
            panelSemester.Controls.Add(lblStatus);
            panelSemester.Controls.Add(seeDetails);

            flowGradePerSemester.Controls.Add(panelSemester);
        }
    }
}
