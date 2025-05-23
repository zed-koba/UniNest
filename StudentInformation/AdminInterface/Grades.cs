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
    public partial class Grades : UserControl
    {
        int count = 1;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        public Grades()
        {
            InitializeComponent();

        }

        private void Grades_Load(object sender, EventArgs e)
        {
            loadStudents("SELECT * FROM Students WHERE currentSemEnrolled = 1");
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
                                dataGridStudents.Rows.Add(reader["student_ID"], $"{reader["fName"]} {reader["lName"]}", reader["Sex"], reader["course"], reader["yearLevel"], reader["section"]);
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
        private void ViewProfile_Clicked(int rowNum)
        {
            DataGridViewRow selectedRow = dataGridStudents.Rows[rowNum];
            try
            {
                using (EditGrades resetForm = new EditGrades(Convert.ToInt32(selectedRow.Cells["studentID"].Value), this.Parent.Parent.Location))
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
                cmbSort.SelectedIndex = -1;
            }
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
                        dataGridStudents.Sort(dataGridStudents.Columns[2], ListSortDirection.Ascending);
                        break;
                    case 2:
                        dataGridStudents.Sort(dataGridStudents.Columns[3], ListSortDirection.Ascending);
                        break;
                    case 3:
                        dataGridStudents.Sort(dataGridStudents.Columns[4], ListSortDirection.Ascending);
                        break;
                }
            }
        }
    }
}
