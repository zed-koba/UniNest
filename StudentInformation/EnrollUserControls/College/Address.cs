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
    public partial class Address : UserControl
    {
        private static Address _instance;
       
        private StudentDetails _studentDetails;
        private StudentParents _studentMother;
        private StudentParents _studentFather;
        public static Address Instance(StudentDetails stud, StudentParents mother, StudentParents father)
        {
            if (_instance == null)
            {
                _instance = new Address(stud, mother, father);
            }
            return _instance;
        }
        public Address(StudentDetails stud, StudentParents mother, StudentParents father)
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
                _studentDetails.province = cmbProvince.SelectedItem.ToString();
                _studentDetails.municipal = cmbMunicipality.SelectedItem.ToString();
                _studentDetails.barangay = txtBarangay.Text;
                _studentDetails.sitio = txtSitio.Text;
                _studentDetails.street = txtStreet.Text;
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
                EnrollMainPage.Instance.enrollProgress.Value = 50;
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
            foreach (Control ctrl in panelAddress.Controls)
            {
                if (ctrl is Guna2ComboBox comboBoxes)
                {
                    if (comboBoxes.SelectedIndex == 0)
                    {
                        comboBoxes.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }else if(ctrl is Guna2TextBox textBoxes) 
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
            foreach (Control ctrl in panelAddress.Controls)
            {

                if (ctrl is Guna2ComboBox comboBoxes)
                {
                    if (comboBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (textBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            return true;
        }

        private void selectedChanged(object sender, EventArgs e)
        {
            if (sender is Guna2ComboBox comboBoxes && comboBoxes.SelectedIndex != 0)
            {
                comboBoxes.BorderColor = Color.FromArgb(51, 52, 55);
            }else if(sender is Guna2TextBox textBoxes && !string.IsNullOrEmpty(textBoxes.Text))
            {
                textBoxes.BorderColor = Color.FromArgb(51, 52, 55);
            } 
            btnNext.Enabled = true;
        }

    private void btnBack_Click(object sender, EventArgs e)
        {
            var parentInfo = College.ParentInformation.Instance(_studentDetails);
            var panelContainer = this.Parent as Panel;
            var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
            var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);
            if (!addStatus.Controls.Contains(parentInfo))
            {
                addStatus.Controls.Add(parentInfo);
                parentInfo.Dock = DockStyle.Fill;
                parentInfo.BringToFront();
            }
            else
            {
                parentInfo.BringToFront();
            }         
        }
    }
}
