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
    public partial class Agreement : UserControl
    {
        private static Agreement _instance;
        private StudentDetails _studentDetails;
        private StudentParents _studentMother;
        private StudentParents _studentFather;
        private List<StudentsEducation> _studentEducation;
        private StudentEnrollmentInfo _studentEnrollmentInfo;
        public static Agreement Instance(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ, StudentEnrollmentInfo enroll)
        {
            if (_instance == null)
            {
                _instance = new Agreement(stud, mother, father, educ, enroll);
            }

            return _instance;
        }
        public Agreement(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ, StudentEnrollmentInfo enroll)
        {
            InitializeComponent();
            _studentDetails = stud;
            _studentMother = mother;
            _studentFather = father;
            _studentEducation = educ;
            _studentEnrollmentInfo = enroll;
        }
      

        private void btnBack_Click(object sender, EventArgs e)
        {
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
            EnrollMainPage.Instance.enrollProgress.Value = 100;
            EnrollMainPage.Instance.progressLabel.Text = $"{EnrollMainPage.Instance.enrollProgress.Value}% Complete";
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (cbxAgreement.Checked)
            {
                var officialEnrolled = College.OfficiallyEnrolled.Instance(_studentDetails, _studentMother, _studentFather, _studentEducation, _studentEnrollmentInfo);
                var panelContainer = this.Parent as Panel;
                var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
                var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);

                
                if (!addStatus.Controls.Contains(officialEnrolled))
                {
                    addStatus.Controls.Add(officialEnrolled);
                    officialEnrolled.Dock = DockStyle.Fill;
                    officialEnrolled.BringToFront();
                }
                else
                {
                    officialEnrolled.BringToFront();
                }

                EnrollMainPage.Instance.enrollProgress.Value = 100;
                EnrollMainPage.Instance.progressLabel.Text = $"{EnrollMainPage.Instance.enrollProgress.Value}% Complete";
            }
            else
            {
                GlobalMethod.PopAMessage("error", "You must check the box to agree with the Terms and Conditions to submit", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);             
            }
            
        }
    }
}
