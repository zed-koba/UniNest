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
    public partial class EditEducation : Form
    {
        int student_ID;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";

        public EditEducation(int studentID, Point parentLocation)
        {
            InitializeComponent();
            student_ID = studentID;
            this.parentLocation = parentLocation;
        }
        int i;
        private void EditEducation_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 120;
            this.Location = new Point(parentLocation.X + 330, parentLocation.Y);

            string query = "SELECT * FROM Students_Education WHERE student_ID = @studentID";
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
                            txtStudentID.Text = $"Student ID: {student_ID}";
                            txtElem.Text = reader["elementary_schoolName"].ToString();
                            txtElemGraduated.Text = reader["elementary_dateGraduated"].ToString();
                            txtElemGraduated.Value = Convert.ToDateTime(reader["elementary_dateGraduated"]);
                            txtHS.Text = reader["juniorH_schoolName"].ToString();
                            txtHSGraduated.Text = reader["juniorH_dateGraduated"].ToString();
                            txtHSGraduated.Value = Convert.ToDateTime(reader["juniorH_dateGraduated"]);
                            txtSH.Text = reader["seniorH_schoolName"].ToString();
                            txtSHGraduated.Text = reader["seniorH_dateGraduated"].ToString();
                            txtSHGraduated.Value = Convert.ToDateTime(reader["seniorH_dateGraduated"]);
                            txtLRN.Text = reader["student_LRN"].ToString();


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
            if (!string.IsNullOrEmpty(txtElem.Text) && !string.IsNullOrEmpty(txtHS.Text) && !string.IsNullOrEmpty(txtSH.Text) && !string.IsNullOrEmpty(txtLRN.Text))
            {
                string query = "UPDATE Students_Education SET student_LRN = @lrn, elementary_schoolName = @elem, elementary_dateGraduated = @elemGrad, " +
                    "juniorH_schoolName = @junior, juniorH_dateGraduated = @juniorGrad, seniorH_schoolName = @senior, seniorH_dateGraduated = @seniorGrad WHERE student_ID = @stud_id";
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

                                    command.CommandText = query;
                                    command.Parameters.AddWithValue("@lrn", txtLRN.Text);
                                    command.Parameters.AddWithValue("@elem", txtElem.Text);
                                    command.Parameters.AddWithValue("@elemGrad", txtElemGraduated.Value.ToString("yyyy-MM-dd"));
                                    command.Parameters.AddWithValue("@junior", txtHS.Text);
                                    command.Parameters.AddWithValue("@juniorGrad", txtHSGraduated.Value.ToString("yyyy-MM-dd"));
                                    command.Parameters.AddWithValue("@senior", txtSH.Text);
                                    command.Parameters.AddWithValue("@seniorGrad", txtSHGraduated.Value.ToString("yyyy-MM-dd"));
                                    command.Parameters.AddWithValue("@stud_id", student_ID);

                                    command.ExecuteNonQuery();
                                    transaction.Commit();
                                    GlobalMethod.PopAMessage("success", "Successfully updated the information", this.Size, this.Location);
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
            else
            {
                GlobalMethod.PopAMessage("error", "Invalid update, fill out the details", this.Size, this.Location);
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
            this.Location = new Point(parentLocation.X + 330, y);
            if (y >= i)
            {
                modalTimer.Stop();
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
