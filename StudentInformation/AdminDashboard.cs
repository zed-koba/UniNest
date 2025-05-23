using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class AdminDashboard : Form
    {
        bool navBarCompress = false;
        UserControl currentControl;
        private string currentControlName = string.Empty;
        public AdminDashboard()
        {
            InitializeComponent();
            
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (!navBarCompress)
            {
                sidePanelNav.Size = new Size(76, 665);
                panelLogo.MaximumSize = new Size(71, 78);
                pbLogo.Location = new Point(18, 16);
                panelStudentsSub.Padding = new Padding(2, 0, 2, 0);
                btnEducation.Padding = new Padding(0, 0, 0, 0);
                btnParents.Padding = new Padding(0, 0, 0, 0);
                btnAddress.Padding = new Padding(0, 0, 0, 0);
                foreach (Control ctrl in panelSideNav.Controls)
                {
                    if (ctrl is Guna2Button gunaBtn)
                    {
                        gunaBtn.ImageOffset = new Point(-1, -1);
                        gunaBtn.BorderRadius = 10;
                    }
                }
                navBarCompress = true;
                
            }
            else
            {
                sidePanelNav.Size = new Size(278, 775);
                panelLogo.MaximumSize = new Size(273, 78);
                pbLogo.Location = new Point(56, 18);
                panelStudentsSub.Padding = new Padding(15, 0, 15, 0);
                btnEducation.Padding = new Padding(35, 0, 0, 0);
                btnParents.Padding = new Padding(35, 0, 0, 0);
                btnAddress.Padding = new Padding(35, 0, 0, 0);
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            currentControl = new AdminInterface.Dashboard();
            mainContainer.Controls.Add(currentControl);
            currentControl.Dock = DockStyle.Fill;
            currentControlName = "AdminDashboard";
        }


        private void btnStudents_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Students")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Students();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "Students";
                btnStudents.FillColor = Color.FromArgb(10, 169, 110);
                btnStudents.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnStudents.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }
        private void btnEducation_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Education")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Education();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "Education";
                currentControl.Dock = DockStyle.Fill;
                lblTitleName.Text = "Education";
            }
        }
        private void btnParents_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Parents")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Parents();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "Parents";
                currentControl.Dock = DockStyle.Fill;
                lblTitleName.Text = "Parents";
            }
        }
        private void btnAddress_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Address")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Address();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "Address";
                currentControl.Dock = DockStyle.Fill;
                lblTitleName.Text = "Address";
            }
        }
        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            if (currentControlName != "EnrollmentDetails")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.StudentsEnrollmentDetails();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "EnrollmentDetails";
                btnStudents.FillColor = Color.FromArgb(10, 169, 110);
                btnStudents.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnStudents.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }

        private void btnMajorExamScores_Click(object sender, EventArgs e)
        {
            if (currentControlName != "StudentGrade")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Grades();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "StudentGrade";
                btnStudents.FillColor = Color.FromArgb(10, 169, 110);
                btnStudents.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnStudents.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }
        

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Attendance")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Attendance();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "Attendance";
                btnStudents.FillColor = Color.FromArgb(10, 169, 110);
                btnStudents.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnStudents.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }
        

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (currentControlName != "Schedule")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Remove(currentControl);
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Schedule();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "Schedule";
                btnStudents.FillColor = Color.FromArgb(10, 169, 110);
                //btnStudents.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnStudents.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                //currentActiveNav();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (currentControlName != "AdminDashboard")
            {
                if (currentControl != null)
                {
                    mainContainer.Controls.Clear();
                    currentControl.Dispose();

                }
                currentControl = new AdminInterface.Dashboard();
                mainContainer.Controls.Add(currentControl);
                currentControlName = "AdminDashboard";
                btnStudents.FillColor = Color.FromArgb(10, 169, 110);
                btnStudents.Image = System.Drawing.Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                btnStudents.ForeColor = Color.White;
                currentControl.Dock = DockStyle.Fill;
                currentActiveNav();
            }
        }
        private void currentActiveNav()
        {
            foreach (Control ctrl in panelSideNav.Controls)
            {
                if (ctrl is Guna2Button gunaBtn)
                {

                    if ((string)gunaBtn.Tag == currentControlName)
                    {
                        gunaBtn.FillColor = Color.FromArgb(10, 169, 110);
                        gunaBtn.ForeColor = Color.White;
                        gunaBtn.Image = Image.FromFile($"Images/Icons/{currentControlName}-white.png");
                        lblTitleName.Text = gunaBtn.Text;
                        if (currentControlName == "Students")
                            panelStudentsSub.Visible = true;
                        else
                            panelStudentsSub.Visible = false;

                        if (currentControlName == "Grades")
                            panelStudentsSub.Visible = true;
                        else
                            panelStudentsSub.Visible = false;
                    }
                    else
                    {
                        gunaBtn.FillColor = Color.FromArgb(251, 252, 248);
                        gunaBtn.ForeColor = Color.FromArgb(110, 113, 119);
                        gunaBtn.Image = Image.FromFile($"Images/Icons/{gunaBtn.Tag}-grey.png");
                    }
                }
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
                Application.OpenForms["Form1"].Show();
                this.Close();
            }
        }

       
    }
}
