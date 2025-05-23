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
    public partial class MajorExamScores : UserControl
    {
        int student_ID, getYrLevel, getSemester;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (this.Parent is Guna2Panel parentPanel)
            {
                // Remove this UserControl from the parent panel
                parentPanel.Controls.Remove(this);

                // Dispose of this control
                this.Dispose();
            }
        }

        public MajorExamScores(int studentId, int yrlevel, int semester)
        {
            InitializeComponent();
            student_ID = studentId;
            getYrLevel = yrlevel;
            getSemester = semester;
        }
        private void MajorExamScores_Load(object sender, EventArgs e)
        {
            string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
            string query = @"
                            SELECT ss.prelim_score, ss.prelim_maxScore, ss.midterm_score, ss.midterm_maxScore, ss.final_score, 
                                   ss.final_maxScore, subj.subject_name
                            FROM Students_MajorExams ss
                            INNER JOIN Students_Subjects subj ON subj.subject_id = ss.subject_id
                            WHERE ss.student_id = @studentID 
                            AND ss.subject_semester = @semester 
                            AND ss.subject_yrLevel = @yearLevel";
            using(SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                using(SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@studentID", student_ID);
                    command.Parameters.AddWithValue("@semester", getSemester);
                    command.Parameters.AddWithValue("@yearLevel", getYrLevel);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            dataGridScores.Rows.Add(reader["subject_name"],
                                $"{reader["prelim_score"]}/{reader["prelim_maxScore"]}",
                                $"{reader["midterm_score"]}/{reader["midterm_maxScore"]}",
                                $"{reader["final_score"]}/{reader["final_maxScore"]}");
                        }
                    }
                }
                dataGridScores.ClearSelection();
            }
        }
       
    }
}
