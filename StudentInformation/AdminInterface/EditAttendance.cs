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
    public partial class EditAttendance : Form
    {
        int student_ID, subject_ID;
        string attend_Type;
        DateTime date;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";

        public EditAttendance(int student_ID, int sub_ID, DateTime date, string attendance_type, Point parentLocation)
        {
            InitializeComponent();
            this.date = date;
            attend_Type = attendance_type;
            this.student_ID = student_ID;
            this.parentLocation = parentLocation;
            subject_ID = sub_ID;  
        }
        int i;

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

        private void EditAttendance_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 130;
            this.Location = new Point(parentLocation.X + 330, parentLocation.Y);

            string query = "SELECT * FROM Students_Attendance WHERE student_ID = @student_ID AND attendance_Date = @date AND attendance_type = @type";
            try
            {
                using(SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@student_ID", student_ID);
                        command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@type", attend_Type);
                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            reader.Read();
                            txtStudentID.Text = $"Student ID: {student_ID}";
                            txtDate.Text = reader["attendance_Date"].ToString();
                            txtDate.Value = Convert.ToDateTime(reader["attendance_Date"]);
                            cmbType.SelectedItem = reader["attendance_type"].ToString();
                            string status = (bool)reader["attendance_Status"] ? "Present" : "Absent";
                            cmbStatus.SelectedItem = status;
                            cmbPeriod.SelectedItem = reader["attendance_period"].ToString();
                        }
                    }
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                            using(SqlCommand command = new SqlCommand())
                            {
                                command.Connection = conn;
                                command.Transaction = transaction;

                                command.CommandText = "UPDATE students_Attendance SET attendance_Date = @date, attendance_Status = @status, " +
                                    "attendance_Type = @type, attendance_Period = @period WHERE subject_ID = @id AND attendance_Date = @date2 AND attendance_type = @type2";
                                command.Parameters.AddWithValue("@date", txtDate.Value.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@status", cmbStatus.SelectedIndex);
                                command.Parameters.AddWithValue("@type", cmbType.SelectedItem);
                                command.Parameters.AddWithValue("@period", cmbPeriod.SelectedItem);
                                command.Parameters.AddWithValue("@id", subject_ID);
                                command.Parameters.AddWithValue("@date2", date);
                                command.Parameters.AddWithValue("@type2", attend_Type);
                                command.ExecuteNonQuery();
                                transaction.Commit();

                                GlobalMethod.PopAMessage("success", "Successfully updated the attendance", this.Size, this.Location);
                                this.Close();
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                            transaction.Rollback();
                        }
                    }
                }

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
