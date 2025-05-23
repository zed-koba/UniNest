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
    public partial class Subjects : UserControl
    {
        private int student_Id;
        private int getYearLevel;
        private int getCurrentSem;
        private int subject_id;
        private int total_Attendance;
        private int total_Present;
        private static Guna2Panel showPanelFilter;
        public static Guna2Panel ShowPanelFilter { get => showPanelFilter; }
        private string[] levelString = { "", "st", "nd", "rd", "th" };
        private string semesterString, instuctorName;
        private string subject_Name;
        private string subject_schedule;
        private string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";

        public Subjects(int studentID)
        {
            InitializeComponent();
            student_Id = studentID;
            showPanelFilter = panelFilter;
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            using(SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connect;
                        command.CommandText = $"SELECT * FROM Students WHERE student_ID = {student_Id}";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            cmbSemester.Items.Clear();
                            getYearLevel = (int)char.GetNumericValue(reader["yearLevel"].ToString()[0]);
                            getCurrentSem = (int)reader["currentSem"];
                            for (int i = 1; i <= getYearLevel; i++)
                            {
                                if (i > 1)
                                {
                                    if (i < 4)
                                        cmbYearLevel.Items.Add($"{i}{levelString[i]} Year");
                                    else
                                        cmbYearLevel.Items.Add($"{i}{levelString[4]} Year");
                                }
                                for (int j = 1; j <= getCurrentSem; j++)
                                {
                                    if (j == 1)
                                        semesterString = "First";
                                    else if (j == 2)
                                        semesterString = "Second";
                                    cmbSemester.Items.Add($"{semesterString} Semester");
                                }
                            }
                        }
                    }
                    connect.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox comboBox = sender as Guna2ComboBox;
            getYearLevel = cmbYearLevel.SelectedIndex + 1;
            getCurrentSem = cmbSemester.SelectedIndex + 1;
            string query = @"SELECT student_subject FROM Students_SubjectsTaken WHERE student_subjectTerm = @subjectTerm AND student_subjectYrLevel = @subject_yrLevel";
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@subjectTerm", getCurrentSem);
                        command.Parameters.AddWithValue("@subject_yrLevel", getYearLevel);
                        flowSubjects.Controls.Clear();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                using (SqlCommand command1 = new SqlCommand())
                                {
                                    command1.Connection = conn;
                                    command1.CommandText = "SELECT ss.subject_name, ins.teachersName, ins.subject_timeSched FROM Students_Subjects ss INNER JOIN Students_Schedule ins " +
                                        $"ON ss.subject_id = ins.subject_id WHERE ss.subject_id = @subject_id;";
                                    command1.Parameters.AddWithValue("@subject_id", reader["student_subject"]);
                                    subject_id = Convert.ToInt32(reader["student_subject"]);
                                    using (SqlDataReader reader2 = command1.ExecuteReader())
                                    { 
                                        reader2.Read();
                                        subject_Name = reader2["subject_name"].ToString();
                                        subject_schedule = reader2["subject_timeSched"].ToString();
                                        if (string.IsNullOrEmpty(reader2["teachersName"].ToString()))
                                            instuctorName = "TBA";
                                        else
                                            instuctorName = reader2["teachersName"].ToString();
 
                                    }
                                    command1.CommandText = "SELECT COUNT(*) FROM Students_Attendance WHERE student_ID = @student_id AND subject_ID = @subject_id";
                                    command1.Parameters.AddWithValue("@student_id", student_Id);
                                    total_Attendance = (int)command1.ExecuteScalar();
                                    command1.CommandText = "SELECT COUNT(*) FROM Students_Attendance WHERE student_ID = @student_id AND subject_ID = @subject_id AND attendance_Status = 1";
                                   
                                    total_Present = (int)command1.ExecuteScalar();

                                    createSubjectCard(subject_Name, instuctorName, subject_schedule, subject_id, total_Present, total_Attendance);
                                }
                            }
                        }
                        
                    }
                }catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void seeDetails_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Guna2Button;
            UserControl attendanceControl;
            attendanceControl = new Attendance(btn.TabIndex, student_Id, (string)btn.Tag, btn.Name);
            attendanceControl.Dock = DockStyle.Fill;
            panelSubjects.Controls.Add(attendanceControl);
            attendanceControl.BringToFront();
            showPanelFilter.Visible = false;
        }
        private void createSubjectCard(string nameOfSubject, string instructorName, string sub_sched, int sub_id, int totalPresent, int total_Attend)
        {
            var panelFilColor = Color.FromArgb(251, 252, 248);
            Guna2Panel panelSubjectCard = new Guna2Panel();
            panelSubjectCard.FillColor = panelFilColor;
            panelSubjectCard.BorderRadius = 10;
            panelSubjectCard.Size = new Size(240, 116);

            Label subjectName = new Label();
            subjectName.Text = nameOfSubject;
            subjectName.Font = new Font("Poppins", 12, FontStyle.Bold);
            subjectName.Location = new Point(0, 3);
            subjectName.AutoSize = false;
            subjectName.ForeColor = Color.FromArgb(51, 52, 55);
            subjectName.BackColor = Color.Transparent;
            subjectName.Size = new Size(242, 28);
            subjectName.TextAlign = ContentAlignment.MiddleCenter;

            Label subjectInstructor = new Label();
            subjectInstructor.Text = instructorName;
            subjectInstructor.Font = new Font("Poppins", 10, FontStyle.Regular);
            subjectInstructor.Location = new Point(0, 24);
            subjectInstructor.AutoSize = false;
            subjectInstructor.ForeColor = Color.FromArgb(51, 52, 55);
            subjectInstructor.BackColor = Color.Transparent;
            subjectInstructor.Size = new Size(242, 23);
            subjectInstructor.TextAlign = ContentAlignment.MiddleCenter;

            Guna2Separator separate = new Guna2Separator();
            separate.Location = new Point(0, 46);
            separate.Size = new Size(243, 10);
            separate.FillColor = Color.FromArgb(51, 52, 55);

            Label totalAttendance = new Label();
            totalAttendance.Text = $"Total Attendance: {totalPresent}/{total_Attend}";
            totalAttendance.Font = new Font("Poppins", 10, FontStyle.Regular);
            totalAttendance.Location = new Point(0, 58);
            totalAttendance.AutoSize = false;
            totalAttendance.ForeColor = Color.FromArgb(10,169,110);
            totalAttendance.BackColor = Color.Transparent;
            totalAttendance.Size = new Size(242, 23);
            totalAttendance.TextAlign = ContentAlignment.MiddleCenter;

            Guna2Button seeDetails = new Guna2Button();
            seeDetails.Name = nameOfSubject;
            seeDetails.Tag = sub_sched;
            seeDetails.TabIndex = sub_id;
            seeDetails.Text = "See Details";
            seeDetails.Size = new Size(123, 29);
            seeDetails.FillColor = panelFilColor;
            seeDetails.BorderRadius = 13;
            seeDetails.Font = new Font("Poppins", 10, FontStyle.Regular);
            seeDetails.ForeColor = Color.FromArgb(51,52,55);
            seeDetails.Location = new Point(116, 88);
            seeDetails.TextAlign = HorizontalAlignment.Left;
            seeDetails.Image = Resources.si__arrow_right_line__2_;
            seeDetails.ImageAlign = HorizontalAlignment.Right;
            seeDetails.Cursor = Cursors.Hand;
            seeDetails.HoverState.FillColor = panelFilColor;
            seeDetails.PressedDepth = 0;
            seeDetails.ShadowDecoration.Depth = 0;
            seeDetails.Click += seeDetails_Clicked;

            panelSubjectCard.Controls.Add(subjectName);
            panelSubjectCard.Controls.Add(subjectInstructor);
            panelSubjectCard.Controls.Add(separate);
            panelSubjectCard.Controls.Add(totalAttendance);
            panelSubjectCard.Controls.Add(seeDetails);
            subjectInstructor.BringToFront();

            flowSubjects.Controls.Add(panelSubjectCard);

        }
    }
}
