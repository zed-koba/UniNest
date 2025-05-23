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
    public partial class Schedule : UserControl
    {
        private int student_Id;
        private int getYearLevel;
        private int getCurrentSem;
        private string[] levelString = { "", "st", "nd", "rd", "th"};
        private string teacherString = string.Empty;
        private string semesterString;
        private string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        public Schedule(int studentId)
        {
            InitializeComponent();
            student_Id = studentId;
        }
        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            if(cmbSemester.SelectedIndex != 0 && cmbSort.SelectedIndex != 0) 
            {
                dataGridSchedule.Rows.Clear();
                using(SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = @"
                                    SELECT 
                                        ss.subject_id,
                                        ss.teachersName,
                                        ss.subject_type,
                                        ss.subject_section,
                                        ss.subject_room,
                                        ss.subject_timeSched,
                                        ss.subject_day,
                                        subj.subject_name,
                                        subj.subject_unit
                                    FROM 
                                        Students_Schedule ss
                                    INNER JOIN 
                                        Students_Subjects subj ON ss.subject_id = subj.subject_id
                                    WHERE 
                                        ss.student_id = @studentId 
                                        AND ss.subject_year = @yearLevel 
                                        AND ss.subject_semester = @semester";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {                    
                        getYearLevel = (int)char.GetNumericValue(cmbYearLevel.SelectedItem.ToString()[0]);
                        if(cmbSemester.SelectedIndex % 2 == 0 && cmbSemester.SelectedIndex != 0)
                        {
                            getCurrentSem = 2;
                        }
                        else
                        {
                            getCurrentSem = 1;
                        }
                        DataTable table = new DataTable();
                        command.Parameters.AddWithValue("@studentId", student_Id);
                        command.Parameters.AddWithValue("@yearLevel", getYearLevel);
                        command.Parameters.AddWithValue("@semester", getCurrentSem);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);
                        foreach (DataRow row in table.Rows)
                        {
                            string teacherString = string.IsNullOrEmpty(row["teachersName"].ToString()) ? "TBA" : row["teachersName"].ToString();
                            dataGridSchedule.Rows.Add(
                                teacherString,
                                row["subject_name"],
                                row["subject_unit"],
                                row["subject_type"],
                                row["subject_section"],
                                row["subject_room"],
                                row["subject_timeSched"],
                                row["subject_day"]
                            );
                        }
                    }
                }
                string selectedSort = cmbSort.SelectedItem.ToString();
                if (selectedSort == "Teacher's Name")
                    selectedSort = "teachersName";
                
                dataGridSchedule.Sort(dataGridSchedule.Columns[selectedSort], ListSortDirection.Ascending);
                dataGridSchedule.ClearSelection();
            }
            else
            {
                GlobalMethod.PopAMessage("error", "You must select a filter to proceed.", this.Parent.Parent.Size, this.Parent.Parent.Location);
                
            }
        }
        private TimeSpan ParseTimeRange(string timeRange)
        {
            string startTime = timeRange.Split('-')[0].Trim();
            return DateTime.Parse(startTime).TimeOfDay;
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connect;
                        command.CommandText = $"SELECT * FROM Students WHERE student_ID = {student_Id}";
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            getYearLevel = (int)char.GetNumericValue(reader["yearLevel"].ToString()[0]);
                            getCurrentSem = (int)reader["currentSem"];
                            for (int i = 1; i <= getYearLevel; i++)
                            {
                                if (i > 1)
                                {
                                    if (i < 4)
                                        cmbYearLevel.Items.Add($"{i}{levelString[i]} Year");
                                    else
                                        cmbYearLevel.Items.Add($"{i}{levelString[4]} Year");
                                }
                                for(int j = 1; j <= getCurrentSem; j++)
                                {
                                    if (j == 1)
                                        semesterString = "First";
                                    else if (j == 2)
                                        semesterString = "Second";
                                    cmbSemester.Items.Add($"{semesterString} Semester");
                                }
                            }
                        }
                    }
                    connect.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridSchedule_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "Time")
            {
                TimeSpan time1 = ParseTimeRange(e.CellValue1.ToString());
                TimeSpan time2 = ParseTimeRange(e.CellValue2.ToString());
                e.SortResult = time1.CompareTo(time2);
                e.Handled = true;
            }
        }
    }
}
