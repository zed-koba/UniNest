using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.EnrollUserControls.College
{
    public partial class Education : UserControl
    {
        private static Education _instance;
        
        private StudentDetails _studentDetails;
        private StudentParents _studentMother;
        private StudentParents _studentFather;
       
     
        public static Education Instance(StudentDetails stud, StudentParents studentMother, StudentParents studentFather)
        {
            if (_instance == null)
            {
                _instance = new Education(stud, studentMother, studentFather);
            }
            return _instance;
        }
        public Education(StudentDetails stud, StudentParents studentMother, StudentParents studentFather)
        {
            InitializeComponent();
            _studentDetails = stud;
            _studentMother = studentMother;
            _studentFather = studentFather;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (requirementCheck())
            {
                _studentDetails.student_LRN = txtLRN.Text;
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
                
            }else
            {
                btnNext.Enabled = false;
            }
            EnrollMainPage.Instance.enrollProgress.Value = 60;
            EnrollMainPage.Instance.progressLabel.Text = $"{EnrollMainPage.Instance.enrollProgress.Value}% Complete";
        }

        private bool requirementCheck()
        {
            bool completed = false;
            foreach(Control ctrl in panelBackground.Controls)
            {
                if(ctrl is Guna2TextBox textBoxes)
                {
                    if(string.IsNullOrEmpty(textBoxes.Text))
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
            foreach (Control ctrl in panelBackground.Controls)
            {
                if (ctrl is Guna2TextBox textBoxes)
                {
                    if (textBoxes.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            return true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var adresss = College.Address.Instance(_studentDetails, _studentMother, _studentFather);
            var panelContainer = this.Parent as Panel;
            var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
            var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);
            if (!addStatus.Controls.Contains(adresss))
            {
                addStatus.Controls.Add(adresss);
                adresss.Dock = DockStyle.Fill;
                adresss.BringToFront();
            }
            else
            {
                adresss.BringToFront();
            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna2TextBox;
            if(!string.IsNullOrEmpty(textBox.Text))
                textBox.BorderColor = Color.FromArgb(51, 52, 55);
            btnNext.Enabled = true;
        }

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == '-') return;
            e.Handled = !(char.IsDigit(e.KeyChar));
        }
    }
}
