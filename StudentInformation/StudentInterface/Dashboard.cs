using Guna.UI2.WinForms;
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
    public partial class Dashboard : UserControl
    {
        string subject_Ids = string.Empty;
        int student_Id = 0;
        int countRow = 0;
        int student_yearLevel = 0;
        int student_currentSemNum = 0;
        string student_currentSemString = string.Empty;
        string student_course = string.Empty;
        string dayOftheWeek = string.Empty;
        public Dashboard(int student_id)
        {
            InitializeComponent();
            student_Id = student_id;
            getDayOfTheWeek();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var con = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            #region personalDetails
                            command.CommandText = $"SELECT * FROM Students WHERE student_ID = {student_Id}";
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    student_yearLevel = (int)char.GetNumericValue(reader["yearLevel"].ToString()[0]);
                                    student_currentSemNum = (int)reader["currentSem"];
                                    student_course = reader["course"].ToString();
                                    lblSection.Text = reader["section"].ToString();
                                    lblYearLevel.Text = reader["yearLevel"].ToString();
                                    lblSemesterName.Text = GlobalMethod.semesterToString((int)reader["currentSem"]);
                                    lblCourse.Text = student_course;
                                    txtFullName.Text = $"Hii, {reader["fName"]} {reader["lName"]}";

                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }
                            }
                            #endregion
                            switch (student_currentSemNum)
                            {
                                case 1:
                                    student_currentSemString = "First Semester";
                                    break;
                                case 2:
                                    student_currentSemString = "Second Semester";
                                    break;
                            }
                            #region schedule
                            command.CommandText = $"SELECT TOP 4 * FROM Students_Schedule WHERE student_id = @stud_id AND subject_day IN ({dayOftheWeek}) AND subject_year = @sub_yr AND subject_semester = @sub_sem ORDER BY TRY_CAST(LEFT(subject_timeSched, CHARINDEX('-', subject_timeSched) - 1) AS TIME);";
                            command.Parameters.AddWithValue("@stud_id", student_Id);
                            command.Parameters.AddWithValue("@sub_yr", student_yearLevel);
                            command.Parameters.AddWithValue("@sub_sem", student_currentSemNum);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                
                                if (reader.HasRows)
                                {
                                    
                                    while (reader.Read())
                                    {
                                        using (SqlCommand command1 = new SqlCommand())
                                        {
                                            command1.Connection = connection;
                                            command1.CommandText = $"SELECT subject_name FROM Students_Subjects WHERE subject_id = {Convert.ToInt32(reader["subject_id"])}";
                                            using (SqlDataReader reader2 = command1.ExecuteReader())
                                            {
                                                if (reader2.HasRows)
                                                {
                                                    reader2.Read();
                                                    
                                                    createScheduleCard(reader2[0].ToString(), reader["subject_timeSched"].ToString(), reader["subject_type"].ToString());
                                                }
                                            }
                                        }

                                    }
                                }
                                else
                                {
                                    Label nosched = new Label();
                                    nosched.Font = new Font("Poppins", 9, FontStyle.Regular);
                                    nosched.ForeColor = Color.FromArgb(51, 52, 55);
                                    nosched.Dock = DockStyle.Left;
                                    nosched.Text = "You dont have a schedule for the day";
                                    nosched.AutoSize = true;
                                    nosched.BackColor = Color.FromArgb(235, 237, 237);
                                    tblTodaySchedule.Controls.Add(nosched, 0, 0);
                                }
                            }
                            #endregion
                            #region offeredSubjects
                            command.CommandText = $"SELECT course_subjects FROM course_SubjectsOffered WHERE course_name = '{student_course}' AND course_yearLevel = {student_yearLevel} AND course_term = '{student_currentSemString}';";
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    subject_Ids = reader[0].ToString();

                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }
                            }
                            command.CommandText = $"SELECT subject_name, subject_description, subject_unit FROM Students_Subjects WHERE subject_id IN ({subject_Ids});";
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                
                                while (reader.Read())
                                {
                                    dataGridSubjects.Rows.Add(
                                        reader["subject_name"],
                                        reader["subject_description"],
                                        reader["subject_unit"]
                                        );
                                }
                            }
                            #endregion

                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            dataGridSubjects.Rows[0].Selected = false;
            dataGridSubjects.Height = dataGridSubjects.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + dataGridSubjects.ColumnHeadersHeight;

        }
       
        private void createScheduleCard(string subjectName, string schedule, string type)
        {
            Guna2Panel schedPanel = new Guna2Panel();
            schedPanel.Size = new Size(250, 55);
            schedPanel.Dock = DockStyle.Top;
            schedPanel.BackColor = Color.FromArgb(235, 237, 237);
            schedPanel.FillColor = Color.FromArgb(251, 252, 248);
            schedPanel.BorderRadius = 10;

            System.Windows.Forms.Label schedSubject = new System.Windows.Forms.Label();
            schedSubject.Font = new Font("Poppins", 10, FontStyle.Bold);
            schedSubject.ForeColor = Color.FromArgb(51, 52, 55);
            schedSubject.Location = new Point(24, 9);
            schedSubject.Text = subjectName;
            schedSubject.BackColor = Color.FromArgb(251, 252, 248);

            System.Windows.Forms.Label sched = new System.Windows.Forms.Label();
            sched.Font = new Font("Poppins", 9, FontStyle.Regular);
            sched.ForeColor = Color.FromArgb(51, 52, 55);
            sched.Location = new Point(24, 28);
            sched.Text = schedule;
            sched.AutoSize = true;
            sched.BackColor = Color.FromArgb(251, 252, 248);

            System.Windows.Forms.Label sub_type = new System.Windows.Forms.Label();
            sub_type.Font = new Font("Poppins", 10, FontStyle.Bold);
            sub_type.ForeColor = Color.FromArgb(110, 113, 119);
            sub_type.Location = new Point(201, 19);
            sub_type.Text = type;
            sub_type.AutoSize = true;
            sub_type.BackColor = Color.FromArgb(251, 252, 248);

            Guna2VSeparator schedSeparator = new Guna2VSeparator();
            schedSeparator.FillColor = Color.FromArgb(10, 169, 110);
            schedSeparator.Location = new Point(7, 11);
            schedSeparator.Size = new Size(16, 33);
            schedSeparator.FillThickness = 3;
            schedSeparator.UseTransparentBackground = true;

            schedPanel.Controls.Add(schedSeparator);
            schedPanel.Controls.Add(schedSubject);
            schedPanel.Controls.Add(sched);
            schedPanel.Controls.Add(sub_type);

            tblTodaySchedule.Controls.Add(schedPanel, 0, countRow);
            countRow++;
        }
        private void getDayOfTheWeek()
        {
            var todayDay = DateTime.Today.DayOfWeek.ToString();
            //var todayDay = "Tuesday";

            if (todayDay == "Monday")
            {
                dayOftheWeek = "'MT'";
            }
            else if (todayDay == "Tuesday")
            {
                dayOftheWeek = "'MT', 'T'";
            }
            else if (todayDay == "Wednesday")
            {
                dayOftheWeek = "'WTH'";
            }
            else if (todayDay == "Thursday")
            {
                dayOftheWeek = "'TH'";
            }
            else if (todayDay == "Friday")
            {
                dayOftheWeek = "'F'";
            }
            else if (todayDay == "Saturday")
            {
                dayOftheWeek = "'S'";
            }
            else
            {
                dayOftheWeek = "'No Class'";
            }

            lblTodayDate.Text = todayDay + " - " + DateTime.Today.Date.ToString("MM/dd/yyyy");

        }
    }
}
