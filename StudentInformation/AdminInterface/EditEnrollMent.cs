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
    public partial class EditEnrollMent : Form
    {
        int student_ID;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        public EditEnrollMent(int student_ID, Point parentLocation)
        {
            InitializeComponent();
            this.student_ID = student_ID;
            this.parentLocation = parentLocation;
        }
        int i;

        private void EditEnrollMent_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 150;
            this.Location = new Point(parentLocation.X + 500, parentLocation.Y);
            string query = "SELECT * FROM Students_EnrollMent WHERE student_ID = @studentID";
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
                            cbStudyLoadPrinted.Checked = (bool)reader["study_load"];
                            if (cbStudyLoadPrinted.Checked)
                                cbStudyLoadPrinted.Enabled = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            this.Location = new Point(parentLocation.X + 500, y);
            if (y >= i)
            {
                modalTimer.Stop();
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                            command.CommandText = "UPDATE Students_EnrollMent SET study_load = @study_load WHERE student_ID = @student_ID";
                            
                            command.Parameters.AddWithValue("@study_load", cbStudyLoadPrinted.Checked);
                            command.Parameters.AddWithValue("@student_ID", student_ID);
                            command.ExecuteNonQuery();

                            command.CommandText = "UPDATE Students SET currentSemEnrolled = @study_load WHERE student_ID = @student_ID";
                            command.ExecuteNonQuery();
                            transaction.Commit();
                            GlobalMethod.PopAMessage("success", "Successfully updated student enrollment status.", this.Size, this.Location);
                            this.Close();

                        }
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
