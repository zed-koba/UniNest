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
using System.Web.UI.WebControls;
using System.Xml.Linq;
using StudentInformation.Properties;


namespace StudentInformation
{
    public partial class StudentDashboard : Form
    {
        bool navBarCompress = false;
        int student_Id = 0;
        string currentControlName = string.Empty;
        UserControl currentControl;
        public static int parentX, parentY;
        public StudentDashboard(int student_id)
        {
            InitializeComponent();
            student_Id = student_id;
           
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
             if(currentControlName != "Dashboard")
            {
                if(currentControl != null) { 
                    panelMain.Controls.Remove(currentControl);
                    currentControl.Dispose();
                
                }

                currentControl = new StudentInterface.Dashboard(student_Id);
                panelMain.Controls.Add(currentControl);
                currentControl.Dock = DockStyle.Fill;
                currentControlName = "Dashboard";
                currentActiveNav();
            }
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            
            try
            {
                var con = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            #region personalDetails
                            command.CommandText = $"SELECT * FROM Students WHERE student_ID = {student_Id}";
                            using(SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    lblStudentID.Text = reader["student_ID"].ToString();
                                    lblStudentName.Text = reader["fName"].ToString();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }
                            }
                            #endregion          

                        }

                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            currentControl = new StudentInterface.Dashboard(student_Id);
            panelMain.Controls.Add(currentControl);
            currentControl.Dock = DockStyle.Fill;
            currentControlName = "Dashboard";
            
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if(!navBarCompress)
            {
                sidePanelNav.Size = new Size(76, 665);
                panelLogo.MaximumSize = new Size(71, 78);
                pbLogo.Location = new Point(18, 16);
                foreach(Control ctrl in panelSideNav.Controls)
                {
                    if(ctrl is Guna2Button gunaBtn)
                    {
                        gunaBtn.ImageOffset = new Point(-1, -1);
                        gunaBtn.BorderRadius = 10;
                    }
                }
                navBarCompress = true;
            }else
            {
                sidePanelNav.Size = new Size(278, 775);
                panelLogo.MaximumSize = new Size(273, 78);
                pbLogo.Location = new Point(56, 18);
                foreach (Control ctrl in panelSideNav.Controls)
                {
                    if (ctrl is Guna2Button gunaBtn)
                    {
                        gunaBtn.ImageOffset = new Point(3, -1);
                        gunaBtn.BorderRadius = 18;
                    }
                }
                navBarCompress = false;
            }
        }

        private void btnAcademics_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Grades")
            {
                if (currentControl != null)
                {
                    panelMain.Controls.Remove(currentControl);
                    currentControl.Dispose();

                }
                currentControl = new StudentInterface.Grades(student_Id);
                panelMain.Controls.Add(currentControl);
                btnAcademics.FillColor = Color.FromArgb(10, 169, 110);
                btnAcademics.Image = Resources.streamline__graduation_cap_white;
                btnAcademics.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentControlName = "Grades";
                currentActiveNav();
            }
        }

        private void currentActiveNav()
        {
            foreach(Control ctrl in panelSideNav.Controls)
            {
                if(ctrl is Guna2Button gunaBtn) { 
                
                    if(gunaBtn.Text == currentControlName)
                    {
                        gunaBtn.FillColor = Color.FromArgb(10, 169, 110);
                        gunaBtn.ForeColor = Color.White;
                        gunaBtn.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                        lblTitleName.Text = gunaBtn.Text;
                    }
                    else
                    {
                        gunaBtn.FillColor = Color.FromArgb(251, 252, 248);
                        gunaBtn.ForeColor = Color.FromArgb(110, 113, 119);
                        gunaBtn.Image = System.Drawing.Image.FromFile($"Images/Icons/{gunaBtn.Text}-grey.png");
                    }
                }
            }
            
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Schedule")
            {
                if (currentControl != null)
                {
                    panelMain.Controls.Remove(currentControl);
                    currentControl.Dispose();

                }
                currentControl = new StudentInterface.Schedule(student_Id);
                panelMain.Controls.Add(currentControl);
                currentControlName = "Schedule";
                btnAcademics.FillColor = Color.FromArgb(10, 169, 110);
                btnAcademics.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnAcademics.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }

        private void btnMajorExamScores_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Major Exam Scores")
            {
                if (currentControl != null)
                {
                    panelMain.Controls.Remove(currentControl);
                    currentControl.Dispose();

                }
                currentControl = new StudentInterface.MajorExam(student_Id);
                panelMain.Controls.Add(currentControl);
                currentControlName = "Major Exam Scores";
                btnAcademics.FillColor = Color.FromArgb(10, 169, 110);
                btnAcademics.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnAcademics.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Subjects")
            {
                if (currentControl != null)
                {
                    panelMain.Controls.Remove(currentControl);
                    currentControl.Dispose();

                }
                currentControl = new StudentInterface.Subjects(student_Id);
                panelMain.Controls.Add(currentControl);
                currentControlName = "Subjects";
                btnAcademics.FillColor = Color.FromArgb(10, 169, 110);
                btnAcademics.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnAcademics.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(GlobalMethod.PopALogout(this.Size, this.Location))
            {
                this.Close();
                Application.OpenForms["Form1"].Show();
            }
        }

        private void panelAccount_Click(object sender, EventArgs e)
        {
            Form resetBackground = new Form();
            using (ChangePassword resetForm = new ChangePassword(student_Id))
            {
                resetBackground.StartPosition = FormStartPosition.Manual;
                resetBackground.FormBorderStyle = FormBorderStyle.None;
                resetBackground.Opacity = .50d;
                resetBackground.BackColor = Color.Black;
                resetBackground.Size = this.Size;
                resetBackground.Location = this.Location;
                resetBackground.ShowInTaskbar = false;
                resetBackground.Show();
                resetForm.Owner = resetBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                resetForm.ShowDialog();
                resetBackground.BringToFront();
                resetForm.BringToFront();
                resetBackground.Dispose();
                
            }

        }
    }
}
