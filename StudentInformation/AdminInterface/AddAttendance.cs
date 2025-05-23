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
    public partial class AddAttendance : Form
    {

        int student_ID, subject_ID;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";

        public AddAttendance(int student_ID, int sub_ID, Point parentLocation)
        {
            InitializeComponent();
            
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

        private void AddAttendance_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 130;
            this.Location = new Point(parentLocation.X + 330, parentLocation.Y);

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
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = conn;
                                command.Transaction = transaction;

                                command.CommandText = "INSERT INTO Students_Attendance(student_ID, subject_ID, attendance_Date, attendance_Status, attendance_type, attendance_period) VALUES " +
                                    "(@id, @sub_id, @date, @status, @type, @period)";                                
                                command.Parameters.AddWithValue("@date", txtDate.Value.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@status", cmbStatus.SelectedIndex);
                                command.Parameters.AddWithValue("@type", cmbType.SelectedItem);
                                command.Parameters.AddWithValue("@period", cmbPeriod.SelectedItem);
                                command.Parameters.AddWithValue("@id", student_ID);
                                command.Parameters.AddWithValue("@sub_id", subject_ID);
                                
                                command.ExecuteNonQuery();
                                transaction.Commit();

                                GlobalMethod.PopAMessage("success", "Successfully added the attendance", this.Size, this.Location);
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

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
