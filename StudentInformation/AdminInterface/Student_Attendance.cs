using StudentInformation.AdminInterface;
using System;
using System.Collections;
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
    public partial class Student_Attendance : UserControl
    {
        int student_ID;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        int page = 1, pageSize = 10;
        public Student_Attendance(int studentID)
        {
            InitializeComponent();
            student_ID = studentID;
        }
        private void Student_Attendance_Load(object sender, EventArgs e)
        {
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

                            for (int i = 1; i <= yearLevel; i++)
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemester.SelectedIndex != 0)
                generateSubjects(cmbYearLevel.SelectedIndex, cmbSemester.SelectedIndex);
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYearLevel.SelectedIndex != 0)
                generateSubjects(cmbYearLevel.SelectedIndex, cmbSemester.SelectedIndex);
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemester.SelectedIndex != 0 && cmbYearLevel.SelectedIndex != 0)
            {
                loadAttendance("SELECT TOP 10 ss.*, subj.subject_name FROM Students_Attendance ss LEFT JOIN Students_Subjects subj ON ss.subject_ID = subj.subject_id " +
                "WHERE ss.student_ID = @studentID AND subj.subject_name = @subj_name");
                btnAdd.Enabled = true;
            }
        }

        private void generateSubjects(int yrLevel, int semester)
        {
            string query = "SELECT ss.*, subj.subject_name FROM Students_SubjectsTaken ss LEFT JOIN Students_Subjects subj ON ss.student_subject = subj.subject_id " +
                "WHERE ss.student_id = @studentID AND ss.student_subjectTerm = @semester AND ss.student_subjectYrLevel = @yrLevel";
            cmbSubject.Items.Clear();
            btnAdd.Enabled = false;
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
                            while (reader.Read())
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
        private void loadAttendance(string query)
        {
            

            try
            {
                using(SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using(SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", student_ID);
                        command.Parameters.AddWithValue("@subj_name", cmbSubject.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@offset", (page - 1) * pageSize);
                        command.Parameters.AddWithValue("@PageSize", pageSize);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string status = (bool)reader["attendance_Status"] ? "Present" : "Absent";
                                Color statusColor = (bool)reader["attendance_Status"] ? Color.FromArgb(10, 169, 110) : Color.FromArgb(251, 75, 52);
                                dataGridStudents.Rows.Add(Convert.ToDateTime(reader["attendance_Date"]).ToString("yyyy-MM-dd"), status, reader["attendance_type"], reader["attendance_period"]);
                                dataGridStudents.Rows[dataGridStudents.Rows.Count - 1].Cells[1].Style.ForeColor = statusColor;
                                
                            }
                        }
                    }
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridStudents.ClearSelection();
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dataGridStudents.Columns[e.ColumnIndex];
                if (column is DataGridViewImageColumn)
                {

                    ViewProfile_Clicked(e.RowIndex);
                }
            }
        }

        private void dataGridStudents_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var column = dataGridStudents.Columns[e.ColumnIndex];
                if (column is DataGridViewImageColumn)
                {
                    dataGridStudents.Cursor = Cursors.Hand;
                }
            }
        }
        private void dataGridStudents_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridStudents.Cursor = Cursors.Default;
        }
        private void dataGridStudents_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridStudents.IsCurrentCellDirty)
            {
                // Commit the value change immediately
                dataGridStudents.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void ViewProfile_Clicked(int rowNum)
        {
            DataGridViewRow selectedRow = dataGridStudents.Rows[rowNum];
            DateTime attendanceDate = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
            string attendanceType = (string)selectedRow.Cells["Type"].Value;
            try
            {
                using (EditAttendance resetForm = new EditAttendance(student_ID, getSubjectID(), attendanceDate, attendanceType, this.Parent.Parent.Location))
                {
                    using (Form resetBackground = new Form())
                    {
                        resetBackground.StartPosition = FormStartPosition.Manual;
                        resetBackground.FormBorderStyle = FormBorderStyle.None;
                        resetBackground.Opacity = .50d;
                        resetBackground.BackColor = Color.Black;
                        resetBackground.Size = this.Parent.Parent.Size;
                        resetBackground.Location = this.Parent.Parent.Location;
                        resetBackground.ShowInTaskbar = false;
                        resetBackground.Show();
                        resetForm.Owner = resetBackground;

                        resetForm.FormClosed += (s, args) =>
                        {
                            dataGridStudents.Rows.Clear();
                            loadAttendance("SELECT TOP 10 ss.*, subj.subject_name FROM Students_Attendance ss LEFT JOIN Students_Subjects subj ON ss.subject_ID = subj.subject_id " +
                "WHERE ss.student_ID = @studentID AND subj.subject_name = @subj_name");
                            
                        };

                        resetForm.ShowDialog();
                        resetBackground.BringToFront();
                        resetForm.BringToFront();
                    }
                }
            }
            finally
            {

                this.Parent.Parent.FindForm().WindowState = FormWindowState.Normal;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (AddAttendance resetForm = new AddAttendance(student_ID, getSubjectID(), this.Parent.Parent.Location))
                {
                    using (Form resetBackground = new Form())
                    {
                        resetBackground.StartPosition = FormStartPosition.Manual;
                        resetBackground.FormBorderStyle = FormBorderStyle.None;
                        resetBackground.Opacity = .50d;
                        resetBackground.BackColor = Color.Black;
                        resetBackground.Size = this.Parent.Parent.Size;
                        resetBackground.Location = this.Parent.Parent.Location;
                        resetBackground.ShowInTaskbar = false;
                        resetBackground.Show();
                        resetForm.Owner = resetBackground;

                        resetForm.FormClosed += (s, args) =>
                        {
                            dataGridStudents.Rows.Clear();
                            loadAttendance("SELECT TOP 10 ss.*, subj.subject_name FROM Students_Attendance ss LEFT JOIN Students_Subjects subj ON ss.subject_ID = subj.subject_id " +
                "WHERE ss.student_ID = @studentID AND subj.subject_name = @subj_name ORDER BY ss.attendance_Date");

                        };

                        resetForm.ShowDialog();
                        resetBackground.BringToFront();
                        resetForm.BringToFront();
                    }
                }
            }
            finally
            {

                this.Parent.Parent.FindForm().WindowState = FormWindowState.Normal;
            }
        }
        private int getSubjectID()
        {
            string query = "SELECT subject_id FROM Students_Subjects WHERE subject_name = @name";
            try
            {
                using(SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using(SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", cmbSubject.SelectedItem.ToString());
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            return (int)reader["subject_id"];
                        }
                    }
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dataGridStudents.Rows.Clear();
            page++;
            loadAttendance("SELECT ss.*, subj.subject_name FROM Students_Attendance ss LEFT JOIN Students_Subjects subj ON ss.subject_ID = subj.subject_id " +
              "WHERE ss.student_ID = @studentID AND subj.subject_name = @subj_name ORDER BY ss.attendance_Date OFFSET @offset ROWS FETCH NEXT @PageSize ROWS ONLY");
            txtPage.Text = page.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(page !=  1)
            {
                dataGridStudents.Rows.Clear();
                page--;
                loadAttendance("SELECT ss.*, subj.subject_name FROM Students_Attendance ss LEFT JOIN Students_Subjects subj ON ss.subject_ID = subj.subject_id " +
              "WHERE ss.student_ID = @studentID AND subj.subject_name = @subj_name ORDER BY ss.attendance_Date OFFSET @offset ROWS FETCH NEXT @PageSize ROWS ONLY");
                txtPage.Text = page.ToString();
                
            }
        }
    }
}
