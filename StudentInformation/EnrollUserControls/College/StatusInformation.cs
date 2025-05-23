using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInformation.EnrollUserControls.College
{

    public partial class StatusInformation : UserControl
    {
        private static StatusInformation _instance;
        private StudentDetails _studentDetails;
        private string addInfo = string.Empty;
        public static StatusInformation Instance(StudentDetails stud)
        {

            if (_instance == null)
            {
                _instance = new StatusInformation(stud);
            }
            return _instance;

        }
        public StatusInformation(StudentDetails stud)
        {
            InitializeComponent();
            _studentDetails = stud;
         

        }
     

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            var personalDetails = PersonalDetails.Instance;
            var panelContainer = this.Parent as Panel;
            var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
            var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);
            if (!addStatus.Controls.Contains(personalDetails))
            {
                addStatus.Controls.Add(personalDetails);
                personalDetails.Dock = DockStyle.Fill;
                personalDetails.BringToFront();
            }
            else
            {
                personalDetails.BringToFront();
            }
            
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (requirementCheck())
            {
                foreach (Control ctrl in panelAddInfo.Controls)
                {
                    if (ctrl is Guna2CheckBox infoChecked && infoChecked.Checked)
                    {
                        addInfo += infoChecked.Text + ",";
                    }
                }
                _studentDetails.civilStatus = cmbCivilStatus.SelectedItem.ToString();
                _studentDetails.citizenShip = cmbCitizenShip.SelectedItem.ToString();
                _studentDetails.religion = cmbReligion.SelectedItem.ToString();
                _studentDetails.addInfo = addInfo;
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
                EnrollMainPage.Instance.enrollProgress.Value = 30;
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
            foreach (Control ctrl in panelStatus.Controls)
            {
                if (ctrl is Guna2ComboBox comboBoxes)
                {
                    if (comboBoxes.SelectedIndex == 0)
                    {
                        comboBoxes.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
            }
            completed = checkIfAllInputsAreFilled();
            if (!completed)
            {
                GlobalMethod.PopAMessage("error", "Please fill in all required inputs with valid information.", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
            }
            return completed;
        }
        private bool checkIfAllInputsAreFilled()
        {
            foreach (Control ctrl in panelStatus.Controls)
            {
                
               if (ctrl is Guna2ComboBox comboBoxes)
                {
                    if (comboBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            return true;
        }

        private void selectedChanged(object sender, EventArgs e)
        {
            if(sender is  Guna2ComboBox comboBoxes && comboBoxes.SelectedIndex != 0)
            {
                comboBoxes.BorderColor = Color.FromArgb(51, 52, 55);
            }
            btnNext.Enabled = true;
        }
    }
}
