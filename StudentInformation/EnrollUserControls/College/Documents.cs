using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.EnrollUserControls.College
{
    public partial class Documents : UserControl
    {
        private static Documents _instance;
        private StudentDetails _studentDetails;
        private StudentParents _studentMother;
        private StudentParents _studentFather;
        private List<StudentsEducation> _studentEducation;
        private StudentEnrollmentInfo _studentEnrollmentInfo;
        private string getPSAFilePath;
        private string getGoodMoralFilePath;
        private string getReportCardFilePath;
        private string destinationPSASaveFilePath;
        private string destinationGMSaveFilePath;
        private string destinationRCSaveFilePath;
        private string targetSaveFilePath;
        
        public static Documents Instance(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ, StudentEnrollmentInfo enroll)
        {
            if (_instance == null)
            {
                _instance = new Documents(stud, mother, father, educ, enroll);
            }
            return _instance;
        }
        public Documents(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ, StudentEnrollmentInfo enroll)
        {
            InitializeComponent();
            _studentDetails = stud;
            _studentMother = mother;
            _studentFather = father;
            _studentEducation = educ;
            _studentEnrollmentInfo = enroll;

            var getBinDirectory = AppDomain.CurrentDomain.BaseDirectory;
            targetSaveFilePath = Path.Combine(getBinDirectory, "Images", "EnrollmentDetails");
            Directory.CreateDirectory(targetSaveFilePath);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (requirementCheck())
            {
                _studentEnrollmentInfo.referral = cmbReferral.Text;
                var agreement = College.Agreement.Instance(_studentDetails, _studentMother, _studentFather, _studentEducation, _studentEnrollmentInfo);
                var panelContainer = this.Parent as Panel;
                var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
                var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);

                if (!addStatus.Controls.Contains(agreement))
                {
                    addStatus.Controls.Add(agreement);
                    agreement.Dock = DockStyle.Fill;
                    agreement.BringToFront();
                }
                else
                {
                    agreement.BringToFront();
                }
                try
                {
                    File.Copy(getPSAFilePath, destinationPSASaveFilePath, true);
                    File.Copy(getGoodMoralFilePath, destinationGMSaveFilePath, true);
                    File.Copy(getReportCardFilePath, destinationRCSaveFilePath, true);

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                EnrollMainPage.Instance.enrollProgress.Value = 90;
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
            if(cmbReferral.SelectedIndex == 0)
            {
                cmbReferral.BorderColor = Color.FromArgb(251, 75, 52);
            }
            foreach (Control panel in panelUpload.Controls)
            {
                if (panel is Guna2Panel gunaPanel)
                {
                    foreach (Control label in gunaPanel.Controls)
                    {
                        if (label is Label && label.Text == "No File Chosen")
                        {
                            gunaPanel.BorderColor = Color.FromArgb(251, 75, 52);
                        }
                    }
                }
            }
            completed = checkIfAllInputsAreFilled();
            if (!completed)
            {
                MessageBox.Show("Please fill in all required inputs with valid information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return completed;
        }
        private bool checkIfAllInputsAreFilled()
        {
            if (cmbReferral.BorderColor == Color.FromArgb(251, 75, 52))
                return false;

            foreach (Control panel in panelUpload.Controls)
            {
                if (panel is Guna2Panel gunaPanel && gunaPanel.BorderColor == Color.FromArgb(251, 75, 52))
                    return false;
            }
            return true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var enrollmentDetails = College.EnrollmentDetails.Instance(_studentDetails, _studentMother, _studentFather, _studentEducation);
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

        private void cmbReferral_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbReferral.SelectedIndex != 0)
            {
                cmbReferral.BorderColor = Color.FromArgb(51, 52, 55);
                btnNext.Enabled = true;
            }
        }

        private void btnPSA_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadImage = new OpenFileDialog();
            uploadImage.Title = "Upload your birth certificate image";
            uploadImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            uploadImage.Multiselect = false;
            uploadImage.FilterIndex = 1;
            uploadImage.RestoreDirectory = true;

            if(uploadImage.ShowDialog() == DialogResult.OK)
            {
                var fileName = Path.GetFileName(uploadImage.FileName);
                lblPSAimage.Text = fileName;
                panelPSA.BorderColor = Color.FromArgb(51, 52, 55);
                btnNext.Enabled = true;
                _studentEnrollmentInfo.PSA = fileName;

                getPSAFilePath = uploadImage.FileName;
                destinationPSASaveFilePath = Path.Combine(targetSaveFilePath, fileName);
            }
        }

        private void btnGoodMoral_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadImage = new OpenFileDialog();
            uploadImage.Title = "Upload your good moral image";
            uploadImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            uploadImage.Multiselect = false;
            uploadImage.FilterIndex = 1;
            uploadImage.RestoreDirectory = true;

            if (uploadImage.ShowDialog() == DialogResult.OK)
            {
                var fileName = Path.GetFileName(uploadImage.FileName);
                lblGMimage.Text = fileName;
                panelGoodMoral.BorderColor = Color.FromArgb(51, 52, 55);
                btnNext.Enabled = true;
                _studentEnrollmentInfo.goodMoral = fileName;

                getGoodMoralFilePath = uploadImage.FileName;
                destinationGMSaveFilePath = Path.Combine(targetSaveFilePath, fileName);
            }
        }

        private void btnReportCard_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadImage = new OpenFileDialog();
            uploadImage.Title = "Upload your report card image";
            uploadImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            uploadImage.Multiselect = false;
            uploadImage.FilterIndex = 1;
            uploadImage.RestoreDirectory = true;

            if (uploadImage.ShowDialog() == DialogResult.OK)
            {
                var fileName = Path.GetFileName(uploadImage.FileName);
                lblRCimage.Text = fileName;
                panelReportCard.BorderColor = Color.FromArgb(51, 52, 55);
                btnNext.Enabled = true;
                _studentEnrollmentInfo.reportCard = fileName;

                getPSAFilePath = uploadImage.FileName;
                destinationRCSaveFilePath = Path.Combine(targetSaveFilePath, fileName);
            }
        }
    }
}
