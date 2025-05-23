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
    public partial class GradesPerSem : UserControl
    {
        int student_Id, studentGradeSem, studentYrLevel;
        List<double> prelimGrades = new List<double>();
        List<double> midTermGrades = new List<double>();
        List<double> finalGrades = new List<double>();
        double prelimText, midText, finalText, periodGpa;
        public GradesPerSem(int studentId, int gradeSem, int yrLevel)
        {
            InitializeComponent();
            student_Id = studentId;
            studentGradeSem = gradeSem;
            studentYrLevel = yrLevel;
          
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            if (this.Parent is Guna2Panel parentPanel)
            {
                // Remove this UserControl from the parent panel
                parentPanel.Controls.Remove(this);

                // Dispose of this control
                this.Dispose();
            }
        }

        private void GradesPerSem_Load(object sender, EventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
            gridGrades.Rows.Clear();
            gridGrades.Columns.Clear();
            if(cmbFilter.SelectedIndex != cmbFilter.Items.Count-1)
            {
                periodGrading(connection);
            }else
            {
                viewAllGrades(connection);
            }
            gridGrades.Rows[0].Selected = false;
        }
        private string getRemark(double grade)
        {
            if(grade >= 1.00 && grade <= 1.59)
            {
                return "Excellent";
            }else if(grade >= 1.60 && grade <= 2.09)
            {
                return "Very Good";
            }else if(grade >= 2.10 && grade <= 2.59)
            {
                return "Good";
            }else if(grade >= 2.60 && grade <= 2.99)
            {
                return "Fair";
            }else if(grade == 3.0)
            {
                return "Passing";
            }


            return "Failed";
        }
        private void periodGrading(string connection)
        {
            DataGridViewTextBoxColumn customColumn1 = new DataGridViewTextBoxColumn
            {
                Name = "subjectColumn",
                HeaderText = "Subject",
                Width = 150,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,


            };
            DataGridViewTextBoxColumn customColumn2 = new DataGridViewTextBoxColumn
            {
                Name = "periodGrade",
                HeaderText = "Period Grade",
                Width = 150,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,

            };
            DataGridViewTextBoxColumn customColumn3 = new DataGridViewTextBoxColumn
            {
                Name = "remarksColumn",
                HeaderText = "Remarks",
                Width = 150,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,

            };
            gridGrades.Columns.Add(customColumn1);
            gridGrades.Columns.Add(customColumn2);
            gridGrades.Columns.Add(customColumn3);


            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = $"SELECT * FROM Students_Grades WHERE student_id = {student_Id} AND grade_sem = {studentGradeSem} AND student_yrLevel = {studentYrLevel};";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                using (SqlCommand command1 = new SqlCommand())
                                {
                                    command1.Connection = conn;
                                    command1.CommandText = $"SELECT subject_name FROM Students_Subjects WHERE subject_id = {Convert.ToInt32(reader["grade_subject"])}";
                                    using (SqlDataReader reader1 = command1.ExecuteReader())
                                    {
                                        reader1.Read();
                                        string gradeScore = Convert.ToDouble(reader[$"student_{cmbFilter.SelectedItem}Grade"]) <= 0.00 ? string.Empty : reader[$"student_{cmbFilter.SelectedItem}Grade"].ToString();
                                        string remark = string.IsNullOrEmpty(gradeScore) ? string.Empty : getRemark(Convert.ToDouble(reader[$"student_{cmbFilter.SelectedItem}Grade"]));
                                        gridGrades.Rows.Add(reader1[0], gradeScore, remark);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Period Grade");
            }
        }
        private void viewAllGrades(string connection)
        {
            DataGridViewTextBoxColumn customColumn1 = new DataGridViewTextBoxColumn
            {
                Name = "subjectColumn",
                HeaderText = "Subject",
                Width = 100,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,


            };
            DataGridViewTextBoxColumn customColumn2 = new DataGridViewTextBoxColumn
            {
                Name = "periodPrelim",
                HeaderText = "Prelim",
                Width = 70,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            DataGridViewTextBoxColumn customColumn3 = new DataGridViewTextBoxColumn
            {
                Name = "periodMidterm",
                HeaderText = "Midterm",
                Width = 70,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            DataGridViewTextBoxColumn customColumn4 = new DataGridViewTextBoxColumn
            {
                Name = "periodFinal",
                HeaderText = "Final",
                Width = 70,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            DataGridViewTextBoxColumn customColumn5 = new DataGridViewTextBoxColumn
            {
                Name = "periodFinalGpa",
                HeaderText = "Period GPA",
                Width = 70,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            DataGridViewTextBoxColumn customColumn6 = new DataGridViewTextBoxColumn
            {
                Name = "remarksColumn",
                HeaderText = "Remarks",
                Width = 100,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,

            };
            gridGrades.Columns.Add(customColumn1);
            gridGrades.Columns.Add(customColumn2);
            gridGrades.Columns.Add(customColumn3);
            gridGrades.Columns.Add(customColumn4);
            gridGrades.Columns.Add(customColumn5);
            gridGrades.Columns.Add(customColumn6);



            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandText = $"SELECT * FROM Students_Grades WHERE student_id = {student_Id} AND grade_sem = {studentGradeSem} AND student_yrLevel = {studentYrLevel};";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                using (SqlCommand command1 = new SqlCommand())
                                {
                                    command1.Connection = conn;
                                    command1.CommandText = $"SELECT subject_name FROM Students_Subjects WHERE subject_id = {Convert.ToInt32(reader["grade_subject"])}";
                                    using (SqlDataReader reader1 = command1.ExecuteReader())
                                    {
                                        reader1.Read();
                                        string prelimGrade = Convert.ToDouble(reader["student_PrelimGrade"]) <= 0.00 ? string.Empty : reader["student_PrelimGrade"].ToString();
                                        string midtermGrade = Convert.ToDouble(reader["student_MidtermGrade"]) <= 0.00 ? string.Empty : reader["student_MidtermGrade"].ToString();
                                        string finalGrade = Convert.ToDouble(reader["student_FinalGrade"]) <= 0.00 ? string.Empty : reader["student_FinalGrade"].ToString();
                                        string finalGPA = !string.IsNullOrEmpty(prelimGrade) && !string.IsNullOrEmpty(midtermGrade) && !string.IsNullOrEmpty(finalGrade)? reader["grade_finalGPA"].ToString() : string.Empty;
                                        string remarks = string.IsNullOrEmpty(finalGPA) ? string.Empty : getRemark(Convert.ToDouble(reader["grade_finalGPA"]));
                                        gridGrades.Rows.Add(reader1[0], prelimGrade, midtermGrade, finalGrade, finalGPA, remarks);
                                    }
                                }
                                prelimGrades.Add(Convert.ToDouble(reader["student_PrelimGrade"]));
                                midTermGrades.Add(Convert.ToDouble(reader["student_MidtermGrade"]));
                                finalGrades.Add(Convert.ToDouble(reader["student_FinalGrade"]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "viewAll");
            }
            foreach(double grade in prelimGrades)
            {
                prelimText += grade;
            }
            foreach (double grade in midTermGrades)
            {
                midText += grade;
            }
            foreach (double grade in finalGrades)
            {
                finalText += grade;
            }
            prelimText = prelimText / prelimGrades.Count;
            midText = midText / midTermGrades.Count;
            finalText = finalText / finalGrades.Count;

            periodGpa = (prelimText + midText + finalText) / 3.0;
            gridGrades.Rows.Add("Period GPA", prelimText.ToString("0.00"), midText.ToString("0.00"), finalText.ToString("0.00"), 
            periodGpa.ToString("0.00"), getRemark(periodGpa));
        }
    }
}
