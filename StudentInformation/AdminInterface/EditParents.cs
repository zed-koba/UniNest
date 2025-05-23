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
    public partial class EditParents : Form
    {
        int student_ID;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";

        public EditParents(int studentID, Point parentLocation)
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

            string query = "SELECT * FROM Students_fathers WHERE student_ID = @studentID";
            string query2 = "SELECT * FROM Students_mothers WHERE student_ID = @studentID";
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
                            txtFatherFname.Text = reader["fName"].ToString();
                            txtFatherMname.Text = reader["middleName"].ToString();
                            txtFatherLname.Text = reader["lName"].ToString();
                            cmbFatherPhType.SelectedItem = reader["phoneType"].ToString();
                            txtFatherNo.Text = reader["phoneNum"].ToString();
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query2, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", student_ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            txtStudentID.Text = $"Student ID: {student_ID}";
                            txtMotherFname.Text = reader["fName"].ToString();
                            txtMotherMname.Text = reader["middleName"].ToString();
                            txtMotherLname.Text = reader["lName"].ToString();
                            cmbMotherPhType.SelectedItem = reader["phoneType"].ToString();
                            txtMotherNo.Text = reader["phoneNum"].ToString();
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
            bool allInputsAreNotEmpty = true;
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is Guna2TextBox || ctrl is Guna2ComboBox)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        allInputsAreNotEmpty = false;
                    }
                }
            }
            if (allInputsAreNotEmpty)
            {
                string query = "UPDATE Students_fathers SET fName = @fName, middleName = @mName, lName = @lName, phoneType = @type, phoneNum = @number WHERE student_ID = @stud_id";
                string query2 = "UPDATE Students_mothers SET fName = @fName, middleName = @mName, lName = @lName, phoneType = @type, phoneNum = @number WHERE student_ID = @stud_id";
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
                                    command.Parameters.AddWithValue("@stud_id", student_ID);
                                    command.Parameters.AddWithValue("@fName", txtFatherFname.Text);
                                    command.Parameters.AddWithValue("@mName", txtFatherMname.Text);
                                    command.Parameters.AddWithValue("@lName", txtFatherLname.Text);
                                    command.Parameters.AddWithValue("@type", cmbFatherPhType.SelectedItem);
                                    command.Parameters.AddWithValue("@number", txtFatherNo.Text);
                                    command.ExecuteNonQuery();

                                    command.CommandText = query2;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@stud_id", student_ID);
                                    command.Parameters.AddWithValue("@fName", txtMotherFname.Text);
                                    command.Parameters.AddWithValue("@mName", txtMotherMname.Text);
                                    command.Parameters.AddWithValue("@lName", txtMotherLname.Text);
                                    command.Parameters.AddWithValue("@type", cmbMotherPhType.SelectedItem);
                                    command.Parameters.AddWithValue("@number", txtMotherNo.Text);
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
