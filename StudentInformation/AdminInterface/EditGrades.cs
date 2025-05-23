using Guna.UI2.WinForms;
using StudentInformation.StudentInterface;
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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInformation.AdminInterface
{
    public partial class EditGrades : Form
    {
        int student_ID;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        int subject_Id;
        public EditGrades(int studentID, Point parentLocation)
        {
            InitializeComponent();
            student_ID = studentID;
            this.parentLocation = parentLocation;
            txtStudentID.Text = $"Student ID: {student_ID}";
        }
        int i;
        private void EditGrades_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 50;
            this.Location = new Point(parentLocation.X + 330, parentLocation.Y);
            string query = "SELECT * FROM Students WHERE student_id = @studentID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", student_ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            int yearLevel = (int)char.GetNumericValue(reader["yearLevel"].ToString()[0]);

                            for(int i = 1; i <= yearLevel; i++)
                            {
                                cmbYearLevel.Items.Add(GlobalMethod.yearLevelConverter(i));
                                for (int j = 1; j <= (int)reader["currentSem"]; j++)
                                {
                                    cmbSemester.Items.Add(GlobalMethod.semesterToString(j));
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

                      
        private void loadScores()
        {
            string query = "SELECT ss.*, name.subject_id, name.subject_name FROM Students_Scores ss LEFT JOIN Students_SubjectsTaken subj ON ss.student_subject = subj.student_subject " +
                "LEFT JOIN Students_Subjects name ON ss.student_subject = name.subject_id " +
                "WHERE ss.student_id = @studentID AND name.subject_name = @subject AND subj.student_subjectTerm = @term AND subj.student_subjectYrLevel = @yrLevel";
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", student_ID);
                        command.Parameters.AddWithValue("@subject", cmbSubject.SelectedItem);
                        command.Parameters.AddWithValue("@term", cmbSemester.SelectedIndex);
                        command.Parameters.AddWithValue("@yrLevel", cmbYearLevel.SelectedIndex);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string subjectPeriod = reader["subject_Period"].ToString();
                                subject_Id = (int)reader["subject_id"];
                                switch (subjectPeriod)
                                {
                                    case "Prelim":
                                        txtQuizPrelim.Text = reader["student_Quiz"].ToString();
                                        txtSeatPrelim.Text = reader["student_SeatWork"].ToString();
                                        txtLabPrelim.Text = reader["student_Labratory"].ToString();
                                        txtProjectPrelim.Text = reader["student_Project"].ToString();
                                        txtMajorPrelim.Text = reader["student_MajorExam"].ToString();

                                        txtQuizPrelimMax.Text = reader["quiz_MaxScore"].ToString();
                                        txtSeatPrelimMax.Text = reader["seatwork_MaxScore"].ToString();
                                        txtLabPrelimMax.Text = reader["labratory_MaxScore"].ToString();
                                        txtProjectPrelimMax.Text = reader["project_MaxScore"].ToString();
                                        txtMajorPrelimMax.Text = reader["majorExam_MaxScore"].ToString();

                                        txtQuizPrelim.Enabled = true;
                                        txtSeatPrelim.Enabled = true;
                                        txtLabPrelim.Enabled = true;
                                        txtProjectPrelim.Enabled = true;
                                        txtMajorPrelim.Enabled = true;

                                        txtQuizPrelimMax.Enabled = true;
                                        txtSeatPrelimMax.Enabled = true;
                                        txtLabPrelimMax.Enabled = true;
                                        txtProjectPrelimMax.Enabled = true;
                                        txtMajorPrelimMax.Enabled = true;

                                        break;
                                    case "Midterm":
                                        txtQuizMidterm.Text = reader["student_Quiz"].ToString();
                                        txtSeatMidterm.Text = reader["student_SeatWork"].ToString();
                                        txtLabMidterm.Text = reader["student_Labratory"].ToString();
                                        txtProjectMidterm.Text = reader["student_Project"].ToString();
                                        txtMajorMidterm.Text = reader["student_MajorExam"].ToString();

                                        txtQuizMidtermMax.Text = reader["quiz_MaxScore"].ToString();
                                        txtSeatMidtermMax.Text = reader["seatwork_MaxScore"].ToString();
                                        txtLabMidtermMax.Text = reader["labratory_MaxScore"].ToString();
                                        txtProjectMidtermMax.Text = reader["project_MaxScore"].ToString();
                                        txtMajorMidtermMax.Text = reader["majorExam_MaxScore"].ToString();

                                        txtQuizMidterm.Enabled = true;
                                        txtSeatMidterm.Enabled = true;
                                        txtLabMidterm.Enabled = true;
                                        txtProjectMidterm.Enabled = true;
                                        txtMajorMidterm.Enabled = true;

                                        txtQuizMidtermMax.Enabled = true;
                                        txtSeatMidtermMax.Enabled = true;
                                        txtLabMidtermMax.Enabled = true;
                                        txtProjectMidtermMax.Enabled = true;
                                        txtMajorMidtermMax.Enabled = true;
                                        break;

                                    case "Final":
                                        txtQuizFinal.Text = reader["student_Quiz"].ToString();
                                        txtSeatFinal.Text = reader["student_SeatWork"].ToString();
                                        txtLabFinal.Text = reader["student_Labratory"].ToString();
                                        txtProjectFinal.Text = reader["student_Project"].ToString();
                                        txtMajorFinal.Text = reader["student_MajorExam"].ToString();

                                        txtQuizFinalMax.Text = reader["quiz_MaxScore"].ToString();
                                        txtSeatFinalMax.Text = reader["seatwork_MaxScore"].ToString();
                                        txtLabFinalMax.Text = reader["labratory_MaxScore"].ToString();
                                        txtProjectFinalMax.Text = reader["project_MaxScore"].ToString();
                                        txtMajorFinalMax.Text = reader["majorExam_MaxScore"].ToString();

                                        txtQuizFinal.Enabled = true;
                                        txtSeatFinal.Enabled = true;
                                        txtLabFinal.Enabled = true;
                                        txtProjectFinal.Enabled = true;
                                        txtMajorFinal.Enabled = true;

                                        txtQuizFinalMax.Enabled = true;
                                        txtSeatFinalMax.Enabled = true;
                                        txtLabFinalMax.Enabled = true;
                                        txtProjectFinalMax.Enabled = true;
                                        txtMajorFinalMax.Enabled = true;

                                        break;
                                }
                                
                            }

                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearTextBoxes()
        {
            txtQuizPrelim.Text = "0";
            txtSeatPrelim.Text = "0";
            txtLabPrelim.Text = "0";
            txtProjectPrelim.Text = "0";
            txtMajorPrelim.Text = "0";

            txtQuizPrelimMax.Text = "0";
            txtSeatPrelimMax.Text = "0";
            txtLabPrelimMax.Text = "0";
            txtProjectPrelimMax.Text = "0";
            txtMajorPrelimMax.Text = "0";

            txtQuizPrelim.Enabled = false;
            txtSeatPrelim.Enabled = false;
            txtLabPrelim.Enabled = false;
            txtProjectPrelim.Enabled = false;
            txtMajorPrelim.Enabled = false;

            txtQuizPrelimMax.Enabled = false;
            txtSeatPrelimMax.Enabled = false;
            txtLabPrelimMax.Enabled = false;
            txtProjectPrelimMax.Enabled = false;
            txtMajorPrelimMax.Enabled = false;

            txtQuizMidterm.Text = "0";
            txtSeatMidterm.Text = "0";
            txtLabMidterm.Text = "0";
            txtProjectMidterm.Text = "0";
            txtMajorMidterm.Text = "0";

            txtQuizMidterm.Enabled = false;
            txtSeatMidterm.Enabled = false;
            txtLabMidterm.Enabled = false;
            txtProjectMidterm.Enabled = false;
            txtMajorMidterm.Enabled = false;

            txtQuizMidtermMax.Text = "0";
            txtSeatMidtermMax.Text = "0";
            txtLabMidtermMax.Text = "0";
            txtProjectMidtermMax.Text = "0";
            txtMajorMidtermMax.Text = "0";

            txtQuizMidtermMax.Enabled = false;
            txtSeatMidtermMax.Enabled = false;
            txtLabMidtermMax.Enabled = false;
            txtProjectMidtermMax.Enabled = false;
            txtMajorMidtermMax.Enabled = false;

            txtQuizFinal.Text = "0";
            txtSeatFinal.Text = "0";
            txtLabFinal.Text = "0";
            txtProjectFinal.Text = "0";
            txtMajorFinal.Text = "0";

            txtQuizFinal.Enabled = false;
            txtSeatFinal.Enabled = false;
            txtLabFinal.Enabled = false;
            txtProjectFinal.Enabled = false;
            txtMajorFinal.Enabled = false;

            txtQuizFinalMax.Text = "0";
            txtSeatFinalMax.Text = "0";
            txtLabFinalMax.Text = "0";
            txtProjectFinalMax.Text = "0";
            txtMajorFinalMax.Text = "0";

            txtQuizFinalMax.Enabled = false;
            txtSeatFinalMax.Enabled = false;
            txtLabFinalMax.Enabled = false;
            txtProjectFinalMax.Enabled = false;
            txtMajorFinalMax.Enabled = false;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modalTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalTimer.Stop();
            }
            else
            {
                Opacity += 0.07;
            }
            int y = parentLocation.Y += 3;
            this.Location = new Point(parentLocation.X + 330, y);
            if (y >= i)
            {
                modalTimer.Stop();
            }
        }

        private void cmbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemester.SelectedIndex != 0)
                generateSubjects(cmbYearLevel.SelectedIndex, cmbSemester.SelectedIndex);
            clearTextBoxes();
            subject_Id = 0;

            
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYearLevel.SelectedIndex != 0)
                generateSubjects(cmbYearLevel.SelectedIndex, cmbSemester.SelectedIndex);
            clearTextBoxes();
            subject_Id = 0;



        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearTextBoxes();

            if (cmbSemester.SelectedIndex != 0 && cmbYearLevel.SelectedIndex != 0 && cmbSubject.SelectedIndex != -1)
            {
                loadScores();
                btnUpdate.Enabled = true;
            }
           
           
        }

        private void generateSubjects(int yrLevel, int semester)
        {
            string query = "SELECT ss.*, subj.subject_name FROM Students_SubjectsTaken ss LEFT JOIN Students_Subjects subj ON ss.student_subject = subj.subject_id " +
                "WHERE ss.student_id = @studentID AND ss.student_subjectTerm = @semester AND ss.student_subjectYrLevel = @yrLevel";
            cmbSubject.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", student_ID);
                        command.Parameters.AddWithValue("@semester", semester);
                        command.Parameters.AddWithValue("@yrLevel", yrLevel);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                cmbSubject.Items.Add(reader["subject_name"].ToString());
                            }  
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cmbSemester.SelectedIndex != 0 && cmbYearLevel.SelectedIndex != 0 && cmbSubject.SelectedIndex != -1 && subject_Id != 0)
            {
                updateScores(subject_Id);
            }
            else
            {
                GlobalMethod.PopAMessage("error", "Invalid update occurred, please recheck your work", this.Size, this.Location);
            }
        }
        private void updateScores(int subject)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = conn;
                                command.Transaction = transaction;
                                command.CommandText = "UPDATE Students_Scores SET student_Quiz = @quiz, quiz_MaxScore = @quiz_Max, student_SeatWork = @seatwork, seatwork_MaxScore = @seat_max," +
                                    "student_Labratory = @lab, labratory_MaxScore = @lab_max, student_Project = @project, project_MaxScore = @proj_max, student_MajorExam = @exam, majorExam_MaxScore = @major_max " +
                                    "WHERE student_id = @studentID AND subject_period = @period AND student_subject = @subject";
                                command.Parameters.AddWithValue("@quiz", txtQuizPrelim.Text);
                                command.Parameters.AddWithValue("@quiz_Max", txtQuizPrelimMax.Text);
                                command.Parameters.AddWithValue("@seatwork", txtSeatPrelim.Text);
                                command.Parameters.AddWithValue("@seat_max", txtSeatPrelimMax.Text);
                                command.Parameters.AddWithValue("@lab", txtLabPrelim.Text);
                                command.Parameters.AddWithValue("@lab_max", txtLabPrelimMax.Text);
                                command.Parameters.AddWithValue("@project", txtProjectPrelim.Text);
                                command.Parameters.AddWithValue("@proj_max", txtProjectPrelimMax.Text);
                                command.Parameters.AddWithValue("@exam", txtMajorPrelim.Text);
                                command.Parameters.AddWithValue("@major_max", txtMajorPrelimMax.Text);
                                command.Parameters.AddWithValue("@studentID", student_ID);
                                command.Parameters.AddWithValue("@period", "Prelim");
                                command.Parameters.AddWithValue("@subject", subject);
                                command.ExecuteNonQuery();

                                double psQuiz = Math.Round((Convert.ToDouble(txtQuizPrelim.Text) / Convert.ToDouble(txtQuizPrelimMax.Text)) * 100);
                                double psLab = Math.Round(((Convert.ToDouble(txtLabPrelim.Text) / Convert.ToDouble(txtLabPrelimMax.Text)) * 100));
                                double psProject = Math.Round(((Convert.ToDouble(txtProjectPrelim.Text) / Convert.ToDouble(txtProjectPrelimMax.Text)) * 100));
                                double psSeatwork = Math.Round((Convert.ToDouble(txtSeatPrelim.Text) / Convert.ToDouble(txtSeatPrelimMax.Text)) * 100);
                                double weightedQuiz, weightedLab, weightedProject, weightedSeatwork;
                                double weightMajorExam;
                                double prelimTermGrade, midtermTermGrade, finalTermGrade;

                                weightedQuiz = psQuiz * 0.2;
                                weightedLab = psLab * 0.2;
                                weightedProject = psProject * 0.1;
                                weightedSeatwork = psSeatwork * 0.1;
                                weightMajorExam = ((Convert.ToDouble(txtMajorPrelim.Text) / Convert.ToDouble(txtMajorPrelimMax.Text)) * 100) * 0.4;

                                //Class Standing Percentage
                                double classStandingPercentage = weightedQuiz + weightedLab + weightedProject + weightedSeatwork;
                                prelimTermGrade = weightMajorExam + classStandingPercentage;

                                command.CommandText = "UPDATE Students_Scores SET student_Quiz = @quiz, quiz_MaxScore = @quiz_Max, student_SeatWork = @seatwork, seatwork_MaxScore = @seat_max," +
                                    "student_Labratory = @lab, labratory_MaxScore = @lab_max, student_Project = @project, project_MaxScore = @proj_max, student_MajorExam = @exam, majorExam_MaxScore = @major_max " +
                                    "WHERE student_id = @studentID AND subject_period = @period AND student_subject = @subject";

                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@quiz", txtQuizMidterm.Text);
                                command.Parameters.AddWithValue("@quiz_Max", txtQuizMidtermMax.Text);
                                command.Parameters.AddWithValue("@seatwork", txtSeatMidterm.Text);
                                command.Parameters.AddWithValue("@seat_max", txtSeatMidtermMax.Text);
                                command.Parameters.AddWithValue("@lab", txtLabMidterm.Text);
                                command.Parameters.AddWithValue("@lab_max", txtLabMidtermMax.Text);
                                command.Parameters.AddWithValue("@project", txtProjectMidterm.Text);
                                command.Parameters.AddWithValue("@proj_max", txtProjectMidtermMax.Text);
                                command.Parameters.AddWithValue("@exam", txtMajorMidterm.Text);
                                command.Parameters.AddWithValue("@major_max", txtMajorMidtermMax.Text);
                                command.Parameters.AddWithValue("@studentID", student_ID);
                                command.Parameters.AddWithValue("@period", "Midterm");
                                command.Parameters.AddWithValue("@subject", subject);
                                command.ExecuteNonQuery();

                                psQuiz = Math.Round((Convert.ToDouble(txtQuizMidterm.Text) / Convert.ToDouble(txtQuizMidtermMax.Text)) * 100);
                                psLab = Math.Round(((Convert.ToDouble(txtLabMidterm.Text) / Convert.ToDouble(txtLabMidtermMax.Text)) * 100));
                                psProject = Math.Round(((Convert.ToDouble(txtProjectMidterm.Text) / Convert.ToDouble(txtProjectMidtermMax.Text)) * 100));
                                psSeatwork = Math.Round((Convert.ToDouble(txtSeatMidterm.Text) / Convert.ToDouble(txtSeatMidtermMax.Text)) * 100);

                                weightedQuiz = psQuiz * 0.2;
                                weightedLab = psLab * 0.2;
                                weightedProject = psProject * 0.1;
                                weightedSeatwork = psSeatwork * 0.1;
                                weightMajorExam = ((Convert.ToDouble(txtMajorMidterm.Text) / Convert.ToDouble(txtMajorMidtermMax.Text)) * 100) * 0.4;

                                //Class Standing Percentage
                                classStandingPercentage = weightedQuiz + weightedLab + weightedProject + weightedSeatwork;
                                midtermTermGrade = weightMajorExam + classStandingPercentage;

                                command.CommandText = "UPDATE Students_Scores SET student_Quiz = @quiz, quiz_MaxScore = @quiz_Max, student_SeatWork = @seatwork, seatwork_MaxScore = @seat_max," +
                                    "student_Labratory = @lab, labratory_MaxScore = @lab_max, student_Project = @project, project_MaxScore = @proj_max, student_MajorExam = @exam, majorExam_MaxScore = @major_max " +
                                    "WHERE student_id = @studentID AND subject_period = @period AND student_subject = @subject";

                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@quiz", txtQuizFinal.Text);
                                command.Parameters.AddWithValue("@quiz_Max", txtQuizFinalMax.Text);
                                command.Parameters.AddWithValue("@seatwork", txtSeatFinal.Text);
                                command.Parameters.AddWithValue("@seat_max", txtSeatFinalMax.Text);
                                command.Parameters.AddWithValue("@lab", txtLabFinal.Text);
                                command.Parameters.AddWithValue("@lab_max", txtLabFinalMax.Text);
                                command.Parameters.AddWithValue("@project", txtProjectFinal.Text);
                                command.Parameters.AddWithValue("@proj_max", txtProjectFinalMax.Text);
                                command.Parameters.AddWithValue("@exam", txtMajorFinal.Text);
                                command.Parameters.AddWithValue("@major_max", txtMajorFinalMax.Text);
                                command.Parameters.AddWithValue("@studentID", student_ID);
                                command.Parameters.AddWithValue("@period", "Final");
                                command.Parameters.AddWithValue("@subject", subject);
                                command.ExecuteNonQuery();

                                command.CommandText = "UPDATE Students_MajorExams SET prelim_score = @prelim, prelim_maxScore = @prelim_max, " +
                                    "midterm_score = @midterm, midterm_maxScore = @midterm_max, final_score = @final, final_maxScore = @final_max " +
                                    "WHERE student_id = @studentID AND subject_id = @subject";
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@prelim", txtMajorPrelim.Text);
                                command.Parameters.AddWithValue("@prelim_max", txtMajorPrelimMax.Text);
                                command.Parameters.AddWithValue("@midterm", txtMajorMidterm.Text);
                                command.Parameters.AddWithValue("@midterm_max", txtMajorMidtermMax.Text);
                                command.Parameters.AddWithValue("@final", txtMajorFinal.Text);
                                command.Parameters.AddWithValue("@final_max", txtMajorFinalMax.Text);
                                command.Parameters.AddWithValue("@studentID", student_ID);
                                command.Parameters.AddWithValue("@subject", subject);
                                command.ExecuteNonQuery();

                                psQuiz = Math.Round((Convert.ToDouble(txtQuizFinal.Text) / Convert.ToDouble(txtQuizFinalMax.Text)) * 100);
                                psLab = Math.Round(((Convert.ToDouble(txtLabFinal.Text) / Convert.ToDouble(txtLabFinalMax.Text)) * 100));
                                psProject = Math.Round(((Convert.ToDouble(txtProjectFinal.Text) / Convert.ToDouble(txtProjectFinalMax.Text)) * 100));
                                psSeatwork = Math.Round((Convert.ToDouble(txtSeatFinal.Text) / Convert.ToDouble(txtSeatFinalMax.Text)) * 100);

                                weightedQuiz = psQuiz * 0.2;
                                weightedLab = psLab * 0.2;
                                weightedProject = psProject * 0.1;
                                weightedSeatwork = psSeatwork * 0.1;
                                weightMajorExam = ((Convert.ToDouble(txtMajorFinal.Text) / Convert.ToDouble(txtMajorFinalMax.Text)) * 100) * 0.4;

                                //Class Standing Percentage
                                classStandingPercentage = weightedQuiz + weightedLab + weightedProject + weightedSeatwork;
                                finalTermGrade = weightMajorExam + classStandingPercentage;

                                prelimTermGrade = (Double.IsNaN(prelimTermGrade) || Double.IsInfinity(prelimTermGrade)) ? 0 : prelimTermGrade;
                                midtermTermGrade = (Double.IsNaN(midtermTermGrade) || Double.IsInfinity(midtermTermGrade)) ? 0 : midtermTermGrade;
                                finalTermGrade = (Double.IsNaN(finalTermGrade) || Double.IsInfinity(finalTermGrade)) ? 0 : finalTermGrade;

                                updateGrades(prelimTermGrade, midtermTermGrade, finalTermGrade, command);

                               
                                transaction.Commit();
                                GlobalMethod.PopAMessage("success", "Sucessfully update student scores.", this.Size, this.Location);
                                subject_Id = 0;
                                cmbSubject.SelectedIndex = -1;

                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateGrades(double prelimWeight, double midtermWeight, double finalWeight, SqlCommand command)
        {
            
            double prelimGrade = computeWeightedGToUnitG(prelimWeight);
            double midtermGrade = computeWeightedGToUnitG(midtermWeight);
            double finalGrade = computeWeightedGToUnitG(finalWeight);
            double finalGPA = (prelimGrade * 0.2) + (midtermGrade * 0.4) + (finalGrade * 0.4);

            command.CommandText = "UPDATE Students_Grades SET student_PrelimGrade = @prelimGrade, student_MidtermGrade = @midtermGrade, student_FinalGrade = @finalGrade, grade_finalGPA = @finalGPA WHERE " +
                "grade_subject = @subject AND student_id = @studentID";

            command.Parameters.AddWithValue("@prelimGrade", prelimGrade);
            command.Parameters.AddWithValue("@midtermGrade", midtermGrade);
            command.Parameters.AddWithValue("@finalGrade", finalGrade);
            command.Parameters.AddWithValue("@finalGPA", finalGPA);
            command.ExecuteNonQuery();
        }

        private double computeWeightedGToUnitG(double weightedGToUnitG)
        {
            var gradingScale = new List<GradeRange>
            {
                new GradeRange { MinScore = 95, Grade = 1.0, Remarks = "Excellent" },
                new GradeRange { MinScore = 94, Grade = 1.1, Remarks = "Superior" },
                new GradeRange { MinScore = 93, Grade = 1.2, Remarks = "Superior" },
                new GradeRange { MinScore = 92, Grade = 1.3, Remarks = "Superior" },
                new GradeRange { MinScore = 91, Grade = 1.4, Remarks = "Superior" },
                new GradeRange { MinScore = 90, Grade = 1.5, Remarks = "Superior" },
                new GradeRange { MinScore = 89, Grade = 1.6, Remarks = "Very Good" },
                new GradeRange { MinScore = 88, Grade = 1.7, Remarks = "Very Good" },
                new GradeRange { MinScore = 87, Grade = 1.8, Remarks = "Very Good" },
                new GradeRange { MinScore = 86, Grade = 1.9, Remarks = "Very Good" },
                new GradeRange { MinScore = 85, Grade = 2.0, Remarks = "Very Good" },
                new GradeRange { MinScore = 84, Grade = 2.1, Remarks = "Good" },
                new GradeRange { MinScore = 83, Grade = 2.2, Remarks = "Good" },
                new GradeRange { MinScore = 82, Grade = 2.3, Remarks = "Good" },
                new GradeRange { MinScore = 81, Grade = 2.4, Remarks = "Good" },
                new GradeRange { MinScore = 80, Grade = 2.5, Remarks = "Good" },
                new GradeRange { MinScore = 79, Grade = 2.6, Remarks = "Fair" },
                new GradeRange { MinScore = 78, Grade = 2.7, Remarks = "Fair" },
                new GradeRange { MinScore = 77, Grade = 2.8, Remarks = "Fair" },
                new GradeRange { MinScore = 76, Grade = 2.9, Remarks = "Fair" },
                new GradeRange { MinScore = 75, Grade = 3.0, Remarks = "Passing" },
                new GradeRange { MinScore = 0, Grade = 5.0, Remarks = "Failure" }
            };
            if (weightedGToUnitG <= 0)
                return 0.00;

            if (weightedGToUnitG >= 95)
                return gradingScale[0].Grade;

            for(int i = 0; i < gradingScale.Count; i++)
            {
                if (weightedGToUnitG >= gradingScale[i].MinScore)
                {
                    var gradeStep = (gradingScale[i].Grade - gradingScale[i - 1].Grade);
                    var rangeWidth = (gradingScale[i].MinScore - gradingScale[i - 1].MinScore);

                    var unitGrade = gradingScale[i].Grade + (((weightedGToUnitG - gradingScale[i].MinScore)/rangeWidth) * gradeStep);
                    return unitGrade;
                }
            }

            return 5.00;
        }
    }
}
