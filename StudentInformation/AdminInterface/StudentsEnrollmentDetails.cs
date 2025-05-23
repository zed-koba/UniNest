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
    public partial class StudentsEnrollmentDetails : UserControl
    {
        int count = 1;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        string course;
        public StudentsEnrollmentDetails()
        {
            InitializeComponent();
        }
        private void StudentsEnrollmentDetails_Load(object sender, EventArgs e)
        {
            loadStudents("SELECT ss.*, enrl.documentsConfirmed, enrl.documentsHanded, enrl.classification, enrl.study_load FROM Students ss LEFT JOIN Students_EnrollMent enrl ON ss.student_ID = enrl.student_ID");
        }
        private void loadStudents(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                bool documentsHanded = reader["documentsHanded"] != DBNull.Value && Convert.ToBoolean(reader["documentsHanded"]);
                                bool documentsConfirmed = reader["documentsConfirmed"] != DBNull.Value && Convert.ToBoolean(reader["documentsConfirmed"]);
                                string status = string.Empty;
                                Color statusColor = Color.FromArgb(51,52,55);
                                switch ((int)reader["currentStatus"])
                                {
                                    case 0:
                                        status = "Pre-Enrolled";
                                        statusColor = Color.FromArgb(251, 191, 52);
                                        break;
                                    case 1:
                                        status = "Officially Enrolled";
                                        statusColor = Color.FromArgb(10, 169, 110);
                                        break;
                                    case 3:
                                        status = "Withdrawn";
                                        statusColor = Color.FromArgb(251, 75, 52);
                                        break;
                                }
                                if ((int)reader["currentStatus"] != 3)
                                {
                                    course = reader["course"].ToString();
                                    dataGridStudents.Rows.Add(reader["student_ID"], $"{reader["fName"]} {reader["lName"]}", reader["Sex"], reader["course"], reader["classification"], status);
                                    dataGridStudents.Rows[dataGridStudents.Rows.Count - 1].Cells[5].Style.ForeColor = statusColor;
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
          

            foreach (DataGridViewRow row in dataGridStudents.Rows)
            {
                
                dataGridStudents.Rows[count - 1].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
               
                count++;
            }
            count = 1;

            dataGridStudents.ClearSelection();
        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dataGridStudents.Columns[e.ColumnIndex];
                if (column is DataGridViewImageColumn)
                {
                    ViewProfile_Clicked(e.RowIndex, dataGridStudents.Rows[e.RowIndex].Cells[4].Value.ToString());
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
                    // Set cursor to hand
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
        private void ViewProfile_Clicked(int rowNum, string classfication)
        {
            if (classfication == "Freshmen")
            {
                FreshmenEdit(rowNum);
            }
            else
            {
                ContinuingStudent(rowNum);
            }
        }
        private void FreshmenEdit(int rowNum)
        {
            DataGridViewRow selectedRow = dataGridStudents.Rows[rowNum];
            try
            {
                using (EditEnrollMentDetails resetForm = new EditEnrollMentDetails(Convert.ToInt32(selectedRow.Cells["studentID"].Value), this.Parent.Parent.Location, course))
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
                            loadStudents("SELECT ss.*, enrl.documentsConfirmed, enrl.documentsHanded, enrl.classification, enrl.study_load FROM Students ss LEFT JOIN Students_EnrollMent enrl ON ss.student_ID = enrl.student_ID");
                            txtSearch.Text = string.Empty;
                            cmbSort.SelectedIndex = -1;


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
        private void ContinuingStudent(int rowNum)
        {
            DataGridViewRow selectedRow = dataGridStudents.Rows[rowNum];
            try
            {
                using (EditEnrollMent resetForm = new EditEnrollMent(Convert.ToInt32(selectedRow.Cells["studentID"].Value), this.Parent.Parent.Location))
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
                            loadStudents("SELECT ss.*, enrl.documentsConfirmed, enrl.documentsHanded, enrl.classification, enrl.study_load FROM Students ss LEFT JOIN Students_EnrollMent enrl ON ss.student_ID = enrl.student_ID");
                            txtSearch.Text = string.Empty;
                            cmbSort.SelectedIndex = -1;


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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            foreach (DataGridViewRow row in dataGridStudents.Rows)
            {
                if (row.Cells["StudentName"].Value != null)
                {

                    string studentName = row.Cells["StudentName"].Value.ToString();
                    row.Visible = studentName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0;
                }
                else
                {
                    row.Visible = false;
                }
            }
            cmbSort.SelectedIndex = -1;
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedIndex != -1)
            {
                
                switch (cmbSort.SelectedIndex)
                {
                    case 0:
                        dataGridStudents.Sort(dataGridStudents.Columns[1], ListSortDirection.Ascending);
                        break;
                    case 1:
                        dataGridStudents.Sort(dataGridStudents.Columns[3], ListSortDirection.Ascending);
                        break;
                    case 2:
                        dataGridStudents.Sort(dataGridStudents.Columns[4], ListSortDirection.Ascending);
                        break;
                    case 3:
                        dataGridStudents.Sort(dataGridStudents.Columns[5], ListSortDirection.Ascending);
                        break;
                }
            }
        }
    }
}
