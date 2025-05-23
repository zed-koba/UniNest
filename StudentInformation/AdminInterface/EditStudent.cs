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
    public partial class EditStudent : Form
    {
        int student_ID;
        string studentStatus;
        Point parentLocation;
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        public EditStudent(int studentID, string studentStatus, Point parentLocation)
        {
            InitializeComponent();
            student_ID = studentID;
            this.studentStatus = studentStatus;
            this.parentLocation = parentLocation;
        }
        int i;
        private void EditStudent_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 120;
            this.Location = new Point(parentLocation.X + 330, parentLocation.Y);
            if(studentStatus == "Withdrawn")
            {
                btnRemove.Text = "Re-Enroll";
            }
            string query = "SELECT * FROM Students WHERE student_ID = @studentID";
            try
            {
                using(SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using(SqlCommand command =  new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", student_ID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            txtStudentID.Text = $"Student ID: {student_ID} - {reader["course"]}";
                            txtFirstName.Text = reader["fName"].ToString();
                            txtMiddleName.Text = reader["middleName"].ToString();
                            txtLastName.Text = reader["lName"].ToString();
                            txtEmailAdd.Text = reader["emailAdd"].ToString();
                            txtBOD.Text = reader["BOD"].ToString();
                            txtBOD.Value = Convert.ToDateTime(reader["BOD"]);
                            txtSex.Text = reader["Sex"].ToString();
                            cmbPhoneType.Items.Add(reader["phoneType"]);
                            cmbPhoneType.SelectedIndex = 0;
                            txtPhoneNum.Text = reader["phoneNum"].ToString();
                            txtFbName.Text = reader["fbName"].ToString();
                            txtCivilStatus.Text = reader["civilStatus"].ToString();
                            txtReligion.Text = reader["religion"].ToString();
                            if (!string.IsNullOrEmpty(reader["addInfo"].ToString()))
                            {
                                string[] splitString = reader["addInfo"].ToString().Split(',');
                                List<string> list = new List<string>();
                                list = splitString.ToList();
                                foreach (string str in list)
                                {
                                    foreach(Control c in panelAddInfo.Controls)
                                    {
                                        if (c is Guna2CheckBox gune && gune.Text == str)
                                        {
                                            gune.Checked = true;  
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modalTimer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
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
                string query = "UPDATE Students SET fName = @fName, middleName = @middleName, lName = @lName, emailAdd = @emailAdd, BOD = @BOD, Sex = @Sex, " +
                    "phoneNum = @phoneNum, fbName = @fbName, civilStatus = @civil, religion = @religion, addInfo = @addInfo WHERE student_ID = @studentID";
                string addInfo = string.Empty;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@studentID", student_ID);
                            command.Parameters.AddWithValue("@fName", txtFirstName.Text);
                            command.Parameters.AddWithValue("@middleName", txtMiddleName.Text);
                            command.Parameters.AddWithValue("@lName", txtLastName.Text);
                            command.Parameters.AddWithValue("@emailAdd", txtEmailAdd.Text);
                            command.Parameters.AddWithValue("@BOD", txtBOD.Value.ToString("yyyy-MM-dd"));
                            command.Parameters.AddWithValue("@Sex", txtSex.Text);
                            command.Parameters.AddWithValue("@phoneNum", txtPhoneNum.Text);
                            command.Parameters.AddWithValue("@fbName", txtFbName.Text);
                            command.Parameters.AddWithValue("@civil", txtCivilStatus.Text);
                            command.Parameters.AddWithValue("@religion", txtReligion.Text);
                            foreach (Control c in panelAddInfo.Controls)
                            {
                                if (c is Guna2CheckBox gune && gune.Checked)
                                {
                                    addInfo += gune.Text + ",";
                                }
                            }
                            command.Parameters.AddWithValue("@addInfo", addInfo);
                            command.ExecuteNonQuery();
                            this.Close();
                            GlobalMethod.PopAMessage("success", "Sucessfully updated the student details", this.Size, this.Location);
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
                GlobalMethod.PopAMessage("error", "Invalid update, please recheck your inputs.", this.Size, this.Location);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (GlobalMethod.PopADecisionWindow(this.Size, this.Location))
            {
                if (btnRemove.Text == "Withdraw Student")
                {
                    string query = "UPDATE Students SET currentStatus = 3 WHERE student_ID = @studentID";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            conn.Open();
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@studentID", student_ID);
                                command.ExecuteNonQuery();
                                GlobalMethod.PopAMessage("success", "Sucessfully withdrawn the student.", this.Size, this.Location);
                                this.Close();
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
                    btnRemove.Text = "Re-Enroll";
                    string query = "UPDATE Students SET currentStatus = 0 WHERE student_ID = @studentID";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            conn.Open();
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@studentID", student_ID);
                                command.ExecuteNonQuery();
                                GlobalMethod.PopAMessage("success", "Sucessfully re-enrolled the student.", this.Size, this.Location);
                                this.Close();
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
    }
}
