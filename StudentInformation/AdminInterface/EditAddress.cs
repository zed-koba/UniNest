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
    public partial class EditAddress : Form
    {
        int student_ID;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";

        public EditAddress(int studentID, Point parentLocation)
        {
            InitializeComponent();
            student_ID = studentID;
            this.parentLocation = parentLocation;
        }
        int i;
        private void EditAddress_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 160;
            this.Location = new Point(parentLocation.X + 330, parentLocation.Y);

            string query = "SELECT * FROM student_Address WHERE student_ID = @studentID";
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
                            txtBarangay.Text = reader["Barangay"].ToString();
                            txtSitio.Text = reader["Sitio"].ToString();
                            txtStreet.Text = reader["Street"].ToString();
                            txtProvince.SelectedItem = reader["Province"];
                            txtMunicipalCity.SelectedItem = reader["MunicipalCity"];
                            
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
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Guna2TextBox || ctrl is Guna2ComboBox)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        allInputsAreNotEmpty = false;
                    }
                }
            }
            if (allInputsAreNotEmpty)
            {
                string query = "UPDATE student_Address SET Province = @prov, MunicipalCity = @municipal, Barangay = @barangay, Sitio = @sitio, " +
                    "Street = @street WHERE student_ID = @stud_id";
               
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
                                    command.Parameters.AddWithValue("@prov", txtProvince.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@municipal", txtMunicipalCity.SelectedItem.ToString());
                                    command.Parameters.AddWithValue("@barangay", txtBarangay.Text);
                                    command.Parameters.AddWithValue("@sitio", txtSitio.Text);
                                    command.Parameters.AddWithValue("@street", txtStreet.Text);
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
