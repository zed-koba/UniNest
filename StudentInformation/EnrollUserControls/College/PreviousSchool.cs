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

namespace StudentInformation.EnrollUserControls.College
{
    public partial class PreviousSchool : UserControl
    {
        private static PreviousSchool _instance;
        private StudentDetails _studentDetails;
        private StudentParents _studentMother;
        private StudentParents _studentFather;
        private List<StudentsEducation> _studentsEducation;
        public static PreviousSchool Instance(StudentDetails stud, StudentParents mother, StudentParents father)
        {
            if (_instance == null)
            {
                _instance = new PreviousSchool(stud, mother, father);
            }
            return _instance;
        }
        public PreviousSchool(StudentDetails stud, StudentParents mother, StudentParents father)
        {
            InitializeComponent();
            _studentDetails = stud;
            _studentMother = mother;
            _studentFather = father;
        }
       

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (requirementCheck())
            {
                _studentsEducation = new List<StudentsEducation>()
                {
                    new StudentsEducation()
                    {
                        schoolName = txtElemName.Text,
                        dateGraduated = dtpElemGraduated.Value.ToString("yyyy-MM-dd")
                    },
                    new StudentsEducation()
                    {
                        schoolName = txtJuniorName.Text,
                        dateGraduated = dtpJuniorGraduated.Value.ToString("yyyy-MM-dd")
                    },
                    new StudentsEducation()
                    {
                        schoolName = txtSeniorName.Text,
                        dateGraduated = dtpSeniorGraduated.Value.ToString("yyyy-MM-dd")
                    }
                };
                var enrollmentDetails = College.EnrollmentDetails.Instance(_studentDetails, _studentMother, _studentFather, _studentsEducation);
                var panelContainer = this.Parent as Panel;
                var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
                var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);

                if (!addStatus.Controls.Contains(enrollmentDetails))
                {
                    addStatus.Controls.Add(enrollmentDetails);
                    enrollmentDetails.Dock = DockStyle.Fill;
                    enrollmentDetails.BringToFront();
                }
                else
                {
                    enrollmentDetails.BringToFront();
                }
                
            }
            else
            {
                btnNext.Enabled = false;
            }
            EnrollMainPage.Instance.enrollProgress.Value = 70;
            EnrollMainPage.Instance.progressLabel.Text = $"{EnrollMainPage.Instance.enrollProgress.Value}% Complete";
        }
        private bool requirementCheck()
        {
            bool completed = false;
            foreach (Control ctrl in panelElementary.Controls)
            {
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (string.IsNullOrEmpty(textBoxes.Text))
                    {
                        textBoxes.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
            }
            foreach (Control ctrl in panelJuniorH.Controls)
            {
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (string.IsNullOrEmpty(textBoxes.Text))
                    {
                        textBoxes.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
            }
            foreach (Control ctrl in panelSeniorH.Controls)
            {
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (string.IsNullOrEmpty(textBoxes.Text))
                    {
                        textBoxes.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
            }
            completed = checkIfAllInputsAreFilled();
            if (!completed)
            {
                GlobalMethod.PopAMessage("error", "Please fill in all required inputs with valid information", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
            }
            return completed;
        }
        private bool checkIfAllInputsAreFilled()
        {
            foreach (Control ctrl in panelElementary.Controls)
            {
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (textBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            foreach (Control ctrl in panelJuniorH.Controls)
            {
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (textBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            foreach (Control ctrl in panelSeniorH.Controls)
            {
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (textBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            return true;
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna2TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
                textBox.BorderColor = Color.FromArgb(51, 52, 55);
            btnNext.Enabled = true;
        }
    
        private void btnBack_Click(object sender, EventArgs e)
        {
            var educ = College.Education.Instance(_studentDetails, _studentMother, _studentFather);
            var panelContainer = this.Parent as Panel;
            var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
            var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);
            if (!addStatus.Controls.Contains(educ))
            {
                addStatus.Controls.Add(educ);
                educ.Dock = DockStyle.Fill;
                educ.BringToFront();
            }
            else
            {
                educ.BringToFront();
            }
            
        }
    }
}
