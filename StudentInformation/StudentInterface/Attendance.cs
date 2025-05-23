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
    public partial class Attendance : UserControl
    {
        private int subject_ID;
        private string subject_Status;
        private int student_id;
        private Color foreColor;
       
        public Attendance(int subject, int studentID, string schedule, string subjectName)
        {
            InitializeComponent();
            subject_ID = subject;
            student_id = studentID;
            lblSubjectName.Text = subjectName + " - " + schedule;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
            string query = "SELECT * FROM Students_Attendance WHERE student_ID = @student_id AND subject_id = @subject_Id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                   
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@student_id", student_id);
                        command.Parameters.AddWithValue("@subject_Id", subject_ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime dateValue = (DateTime)reader["attendance_Date"];
                                if (reader["attendance_Status"].ToString() == "True" || reader["attendance_Status"].ToString() == "1")
                                {
                                    subject_Status = "Present";
                                    foreColor = Color.FromArgb(10, 169, 110);
                                }
                                else
                                {
                                    subject_Status = "Absent";
                                    foreColor = Color.FromArgb(251, 75, 52);
                                }
                                dataGridAttendance.Rows.Add(dateValue.ToString("dddd, MMMM dd, yyyy"), subject_Status, reader["attendance_period"], reader["attendance_type"]);
                                dataGridAttendance.Rows[dataGridAttendance.RowCount-1].Cells[1].Style.ForeColor = foreColor;
                            }
                        }
                    }
                    dataGridAttendance.ClearSelection();
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Subjects.ShowPanelFilter.Visible = true;
            if (this.Parent is Guna2Panel parentPanel)
            {
                // Remove this UserControl from the parent panel
                parentPanel.Controls.Remove(this);

                // Dispose of this control
                this.Dispose();
            }
        }
    }
}
