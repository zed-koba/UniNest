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

namespace StudentInformation.AdminInterface
{
    public partial class EditEnrollMentDetails : Form
    {
        int student_ID;
        Point parentLocation;
        string course;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        public EditEnrollMentDetails(int student_ID, Point parentLocation, string course)
        {
            InitializeComponent();
            this.student_ID = student_ID;
            this.parentLocation = parentLocation;
            this.course = course;
        }
        int i;

        private void EditEnrollMentDetails_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 120;
            this.Location = new Point(parentLocation.X + 330, parentLocation.Y);

            string query = "SELECT * FROM Students_EnrollMent WHERE student_ID = @studentID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        //MessageBox.Show(student_ID.ToString());
                        command.Parameters.AddWithValue("@studentID", student_ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            txtStudentID.Text = $"Student ID: {student_ID}";
                            txtTermEnrolled.Text = reader["schoolTermEnrolled"].ToString();
                            txtDateEnrolled.Text = reader["dateEnrolled"].ToString();
                            txtDateEnrolled.Value = Convert.ToDateTime(reader["dateEnrolled"]);
                            cmbProgram.SelectedIndex = cmbProgram.Items.IndexOf(reader["studentProgram"].ToString());
                            cmbSession.SelectedIndex = cmbSession.Items.IndexOf(reader["studentSession"].ToString());
                            pbBirth.Image = Image.FromFile(reader["PSA_document"].ToString());
                            pbGoodMoral.Image = Image.FromFile(reader["goodMoral_document"].ToString());
                            pbReportCard.Image = Image.FromFile(reader["reportCard_document"].ToString());
                            cbDocumentsConfirmed.Checked = (bool)reader["documentsConfirmed"];
                            cbDocumentsHanded.Checked = (bool)reader["documentsHanded"];
                            if(cbDocumentsConfirmed.Checked && cbDocumentsHanded.Checked)
                            {
                                cbDocumentsHanded.Enabled = false;
                                cbDocumentsConfirmed.Enabled = false;
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
                Opacity += 0.03;
            }
            int y = parentLocation.Y += 3;
            this.Location = new Point(parentLocation.X + 330, y);
            if (y >= i)
            {
                modalTimer.Stop();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using(SqlCommand command = new SqlCommand())
                        {
                            command.Connection = conn;
                            command.Transaction = transaction;

                            command.CommandText = "UPDATE Students_EnrollMent SET studentProgram = @program, studentSession = @session, " +
                                "documentsConfirmed = @confirmed, documentsHanded = @handed, study_load = @study_load WHERE student_ID = @student_ID";
                            command.Parameters.AddWithValue("@session", cmbSession.SelectedItem);
                            command.Parameters.AddWithValue("@program", cmbProgram.SelectedItem);
                            command.Parameters.AddWithValue("@confirmed", cbDocumentsConfirmed.Checked);
                            command.Parameters.AddWithValue("@handed", cbDocumentsHanded.Checked);
                            bool study_load = cbDocumentsConfirmed.Checked && cbDocumentsHanded.Checked ? true : false;
                            command.Parameters.AddWithValue("@study_load", study_load);
                            command.Parameters.AddWithValue("@student_ID", student_ID);
                            command.ExecuteNonQuery();

                            command.CommandText = "UPDATE Students SET currentSemEnrolled = @study_load, currentStatus = @study_load WHERE student_ID = @student_ID";
                            command.ExecuteNonQuery();
                            if (cbDocumentsConfirmed.Checked && cbDocumentsConfirmed.Checked && cbDocumentsConfirmed.Enabled == true && cbDocumentsHanded.Enabled == true)
                            {
                                command.CommandText = "SELECT * FROM course_SubjectsOffered WHERE course_name = @course AND course_term = 'First Semester' AND course_yearLevel = 1";
                                command.Parameters.AddWithValue("@course", course);
                                string[] subject_IDS;
                                string[] subject_periods = { "Prelim", "Midterm", "Final" };
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    reader.Read();
                                    subject_IDS = reader["course_subjects"].ToString().Split(',');
                                }

                                for (int i = 0; i < subject_IDS.Length; i++)
                                {
                                    int subject_id = Convert.ToInt32(subject_IDS[i]);
                                    command.CommandText = "INSERT INTO Students_SubjectsTaken(student_id, student_subject, student_subjectTerm, student_subjectYrLevel, student_subjectRemarks, student_dateEnrolled) VALUES " +
                                        $"(@student_ID, {subject_id}, 1, 1, 'Ongoing', '{DateTime.Now.ToString("yyyy-MM-dd")}')";
                                    command.ExecuteNonQuery();
                                    command.CommandText = "INSERT INTO Students_Grades(student_id, grade_sem, student_yrLevel, grade_subject) VALUES " +
                                        $"(@student_ID, 1, 1, {subject_id})";
                                    command.ExecuteNonQuery();
                                    foreach(string period in subject_periods)
                                    {
                                        command.CommandText = "INSERT INTO Students_Scores(student_id, student_subject, subject_period) VALUES " +
                                            $"(@student_ID, {subject_id}, '{period}')";
                                        command.ExecuteNonQuery();
                                    }
                                    command.CommandText = "INSERT INTO Students_MajorExams(student_id, subject_id, subject_semester, subject_yrLevel) VALUES " +
                                        $"(@student_ID, {subject_id}, 1, 1";
                                    
                                }
                            }
                            transaction.Commit();
                            GlobalMethod.PopAMessage("success", "Successfully updated student enrollment status.", this.Size, this.Location);
                            this.Close();
                         
                        }
                    }catch(SqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
