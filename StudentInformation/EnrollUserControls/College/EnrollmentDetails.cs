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
    public partial class EnrollmentDetails : UserControl
    {
        private static EnrollmentDetails _instance;
        private StudentDetails _studentDetails;
        private StudentParents _studentMother;
        private StudentParents _studentFather;
        private List<StudentsEducation> _studentEducation;
        private StudentEnrollmentInfo _studentEnrollmentInfo;
        public static EnrollmentDetails Instance(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ)
        {
           
                if(_instance == null)
                {
                    _instance = new EnrollmentDetails(stud, mother, father, educ);
                }
                return _instance;           
        }
        public EnrollmentDetails(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ)
        {
            InitializeComponent();
            _studentDetails = stud;
            _studentMother = mother;
            _studentFather = father;
            _studentEducation = educ;
        }
      
        private void btnNext_Click(object sender, EventArgs e)
        {
            string program = string.Empty;
            if (requirementCheck())
            {
                if(cmbProgram.Text == "BSCS (BACHELOR OF SCIENCE IN COMPUTER SCIENCE)")
                {
                    program = "BSCS";
                }
                _studentEnrollmentInfo = new StudentEnrollmentInfo()
                {
                    dateEnrolled = DateTime.Now.ToString("yyyy-MM-dd"),
                    studentProgram = program,
                    studentSession = cmbSession.Text
                };  
                var documents = College.Documents.Instance(_studentDetails, _studentMother, _studentFather, _studentEducation, _studentEnrollmentInfo);
                var panelContainer = this.Parent as Panel;
                var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
                var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);

                if (!addStatus.Controls.Contains(documents))
                {
                    addStatus.Controls.Add(documents);
                    documents.Dock = DockStyle.Fill;
                    documents.BringToFront();
                }
                else
                {
                    documents.BringToFront();
                }
                EnrollMainPage.Instance.enrollProgress.Value = 80;
                EnrollMainPage.Instance.progressLabel.Text = $"{EnrollMainPage.Instance.enrollProgress.Value}% Complete";
            }
            else
            {
                btnNext.Enabled = false;
            }

        }
        private bool requirementCheck()
        {
            bool completed = false;
            foreach(Control ctrl in panelEnrollment.Controls)
            {
                if(ctrl is Guna2ComboBox comboBoxes)
                {
                    if(comboBoxes.SelectedIndex == 0 && (string)comboBoxes.Tag != "noCheck")
                    {
                        comboBoxes.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
            }
            completed = checkIfAllInputsAreFilled();
            if(!completed)
            {
                GlobalMethod.PopAMessage("error", "Please fill in all required inputs with valid information", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
            }
            return completed;
        }
        private bool checkIfAllInputsAreFilled() {
            foreach(Control ctrl in panelEnrollment.Controls)
            {
                if(ctrl is Guna2ComboBox comboBoxes)
                {
                    if (comboBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var previosSchool = College.PreviousSchool.Instance(_studentDetails, _studentMother, _studentFather);
            var panelContainer = this.Parent as Panel;
            var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
            var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);
            if (!addStatus.Controls.Contains(previosSchool))
            {
                addStatus.Controls.Add(previosSchool);
                previosSchool.Dock = DockStyle.Fill;
                previosSchool.BringToFront();
            }
            else
            {
                previosSchool.BringToFront();
            }
            
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is Guna2ComboBox comboBoxes && comboBoxes.SelectedIndex != 0 && (string)comboBoxes.Tag != "noCheck")
                comboBoxes.BorderColor = Color.FromArgb(51, 52, 55);
            btnNext.Enabled = true;
        }
    }
}
