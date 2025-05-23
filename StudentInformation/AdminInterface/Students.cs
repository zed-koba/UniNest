using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInformation.AdminInterface
{
    public partial class Students : UserControl
    {
        int count = 1;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        public Students()
        {
            InitializeComponent();
            
        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridStudents.Columns["Select"].Index && e.RowIndex >= 0)
            {
                bool isChecked = Convert.ToBoolean(dataGridStudents.Rows[e.RowIndex].Cells["Select"].Value);
                string getStatus = dataGridStudents.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (getStatus != "Withdrawn")
                {
                    if (isChecked)
                    {
                        dataGridStudents.Rows[e.RowIndex].Cells["Select"].Value = false;
                        dataGridStudents.Rows[e.RowIndex].Selected = false;
                    }
                    else
                    {
                        dataGridStudents.Rows[e.RowIndex].Cells["Select"].Value = true;
                        dataGridStudents.Rows[e.RowIndex].Selected = true;
                        Color statusColor = Color.FromArgb(51, 52, 55);
                        switch (dataGridStudents.Rows[e.RowIndex].Cells["Status"].Value.ToString())
                        {
                            case "Pre-Enrolled":
                                statusColor = Color.FromArgb(255, 197, 36);
                                break;
                            case "Officially Enrolled":
                                statusColor = Color.FromArgb(10, 169, 110);
                                break;
                            case "Withdrawn":
                                statusColor = Color.FromArgb(251, 75, 52);
                                break;
                        }
                        dataGridStudents.Rows[e.RowIndex].Cells["Status"].Style.SelectionForeColor = statusColor;
                    }
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dataGridStudents.Columns[e.ColumnIndex];
                if (column is DataGridViewImageColumn)
                {
                    ViewProfile_Clicked(e.RowIndex);
                }
            }


        }

        private void dataGridStudents_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridStudents.IsCurrentCellDirty)
            {
                // Commit the value change immediately
                dataGridStudents.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {


            loadStudents("SELECT * FROM Students");
            
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
                                string status = string.Empty;
                                Color statusColor = Color.FromArgb(51, 52, 55);
                                switch ((int)reader["currentStatus"])
                                {
                                    case 0:
                                        status = "Pre-Enrolled";
                                        statusColor = Color.FromArgb(255, 197, 36);
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
                                dataGridStudents.Rows.Add(false, reader["student_ID"], $"{reader["fName"]} {reader["lName"]}", reader["Sex"], reader["course"], reader["yearLevel"], status);
                                dataGridStudents.Rows[dataGridStudents.Rows.Count - 1].Cells[6].Style.ForeColor = statusColor;
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
                
                dataGridStudents.Rows[count - 1].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() == "Withdrawn")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(243,222,223);
                    row.Selected = false;
                    row.ReadOnly = true;

                    var checkBoxcell = row.Cells[0] as DataGridViewCheckBoxCell;
                    checkBoxcell.ReadOnly = true;
                }
                count++;
            }
            count = 1;
         
            dataGridStudents.ClearSelection();
        }
        private void ViewProfile_Clicked(int rowNum)
        {
           
            
            DataGridViewRow selectedRow = dataGridStudents.Rows[rowNum];
            try
            {
                using (EditStudent resetForm = new EditStudent(Convert.ToInt32(selectedRow.Cells["studentID"].Value), selectedRow.Cells["Status"].Value.ToString(), this.Parent.Parent.Location))
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
                            loadStudents("SELECT * FROM Students");
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
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilter.SelectedIndex != -1)
            {
                dataGridStudents.Rows.Clear();
                switch (cmbFilter.SelectedIndex)
                {
                    case 0:
                        loadStudents("SELECT * FROM Students");
                        break;
                    case 1:
                        loadStudents("SELECT * FROM Students WHERE currentStatus = 1");
                        break;
                    case 2:
                        loadStudents("SELECT * FROM Students WHERE currentStatus = 0");
                        break;
                    case 3:
                        loadStudents("SELECT * FROM Students WHERE currentStatus = 3");
                        break;
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

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedIndex != -1)
            {
                switch (cmbSort.SelectedIndex)
                {
                    case 0:
                        dataGridStudents.Sort(dataGridStudents.Columns[2], ListSortDirection.Ascending);
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
                    case 4:
                        dataGridStudents.Sort(dataGridStudents.Columns[6], ListSortDirection.Ascending);
                        break;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridStudents.SelectedRows.Count > 0)
            {
                try
                {   
                    foreach(DataGridViewRow row in dataGridStudents.SelectedRows) { 
                        int studentID = Convert.ToInt32(row.Cells["studentID"].Value);
                        if (GlobalMethod.PopAYesNoMessage(this.Parent.Parent.Size, this.Parent.Parent.Location))
                        {
                            string query = "UPDATE Students SET currentStatus = 3 WHERE student_ID = @studentID";
                            try
                            {
                                using (SqlConnection conn = new SqlConnection(connection))
                                {
                                    conn.Open();
                                    using (SqlTransaction transaction = conn.BeginTransaction())
                                    {
                                        try
                                        {
                                            using (SqlCommand command = new SqlCommand(query, conn))
                                            {
                                                command.Transaction = transaction;
                                                command.Parameters.AddWithValue("@studentID", studentID);
                                                command.ExecuteNonQuery();
                                                transaction.Commit();
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
                finally
                {
                    dataGridStudents.Rows.Clear();
                    loadStudents("SELECT * FROM Students");
                    txtSearch.Text = string.Empty;
                    cmbSort.SelectedIndex = -1;
                }
            }
            else
            {
                GlobalMethod.PopAMessage("error", "There's no selected rows.", this.Parent.Parent.Size, this.Parent.Parent.Location);
            }
        }

        private void dataGridStudents_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridStudents.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.FromArgb(243, 222, 223)) 
                {
                    row.Selected = false; 
                }
            }
        }

        
    }
}
