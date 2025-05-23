using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.EnrollUserControls.College
{
    public partial class ParentInformation : UserControl
    {
        private static ParentInformation _instance;
        private StudentDetails _studentsDetails;
        private StudentParents _studentMother;
        private StudentParents _studentFather;
        public static ParentInformation Instance(StudentDetails stud)
        {
            if (_instance == null)
            {
                _instance = new ParentInformation(stud);
            }
            return _instance;
        }
        public ParentInformation(StudentDetails stud)
        {
            InitializeComponent();
            _studentsDetails = stud;
        }
      


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (requirementCheck())
            {
                var address = College.Address.Instance(_studentsDetails, _studentMother, _studentFather);
                var panelContainer = this.Parent as Panel;
                var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
                var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);

                _studentMother = new StudentParents()
                {
                    fName = txtMotherfName.Text,
                    middleName = txtMothermiddle.Text,
                    lastName = txtMotherlName.Text,
                    phoneType = cmbMotherPhoneType.SelectedItem.ToString(),
                    phoneNum = txtMotherPhoneNo.Text
                };
                _studentFather = new StudentParents()
                {
                    fName = txtFirst.Text,
                    middleName = txtMiddle.Text,
                    lastName = txtLast.Text,
                    phoneType = cmbPhoneType.SelectedItem.ToString(),
                    phoneNum = txtPhoneNo.Text
                };

                address = new Address(_studentsDetails, _studentMother, _studentFather);
                if (!addStatus.Controls.Contains(address))
                {
                    addStatus.Controls.Add(address);
                    address.Dock = DockStyle.Fill;
                    address.BringToFront();
                    
                }
                else
                {
                    address.BringToFront();
                }
                EnrollMainPage.Instance.enrollProgress.Value = 40;
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
            bool messageBoxShown = false;
            foreach (Control ctrl in panelFather.Controls)
            {
                if (ctrl is Guna2TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                    else if (textBox.Name == "txtPhoneNo" && textBox.Text.Length != 11)
                    {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);
                        if (!messageBoxShown)
                        {
                            GlobalMethod.PopAMessage("error", "Phone number must be exactly 11 digits", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
                            messageBoxShown = true;
                        }
                    }
                }
                else if (ctrl is Guna2ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == 0)
                    {
                        comboBox.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
                
            }
            foreach (Control ctrl in panelMother.Controls)
            {
                if (ctrl is Guna2TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);

                    }
                    else if ((string)textBox.Tag == "PhoneNo" && textBox.Text.Length != 11)
                    {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);

                        if (!messageBoxShown)
                        {
                            GlobalMethod.PopAMessage("error", "Phone number must be exactly 11 digits", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
                            messageBoxShown = true;
                        }
                        

                    }
                }
                else if (ctrl is Guna2ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == 0)
                    {
                        comboBox.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
                else if (ctrl is Guna2DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.Value.Date.Year == 2024)
                    {
                        dateTimePicker.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
            }

            completed = checkIfAllInputsAreFilled();
            if (completed == false)
            {
                if (!messageBoxShown)
                {
                    GlobalMethod.PopAMessage("error", "Please fill in all required inputs with valid information.", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
                    messageBoxShown = true;
                }
            }

                return completed;
        }

        private bool checkIfAllInputsAreFilled()
        {
            foreach (Control ctrl in panelFather.Controls)
            {
                if (ctrl is Guna2TextBox textBox)
                {
                    if (textBox.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
                else if (ctrl is Guna2ComboBox comboBox)
                {
                    if (comboBox.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
               
            }
            foreach (Control ctrl in panelMother.Controls)
            {
                if (ctrl is Guna2TextBox textBox)
                {
                    if (textBox.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
                else if (ctrl is Guna2ComboBox comboBox)
                {
                    if (comboBox.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
               
            }

            return true;
        }
        private void textBoxes_TextChanged(object sender, EventArgs e)
        {

            if (sender is Guna2TextBox txtBoxes && !string.IsNullOrEmpty(txtBoxes.Text))
            {
                txtBoxes.BorderColor = Color.FromArgb(51, 52, 55);
            }
            else if (sender is Guna2ComboBox comboBoxes && comboBoxes.SelectedIndex != 0)
            {
                comboBoxes.BorderColor = Color.FromArgb(51, 52, 55);
            }
            else if (sender is Guna2DateTimePicker dateBoxes && dateBoxes != null && dateBoxes.Value.Year != 2024)
            {
                dateBoxes.BorderColor = Color.FromArgb(51, 52, 55);
            }

            btnNext.Enabled = true;
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            e.Handled = !(char.IsDigit(e.KeyChar));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var statusInformation = College.StatusInformation.Instance(_studentsDetails);
            var panelContainer = this.Parent as Panel;
            var mainForm = panelContainer.TopLevelControl as EnrollMainPage;
            var addStatus = ((Panel)mainForm.Controls.Find("MainPanel", true)[0]);
            if (!addStatus.Controls.Contains(statusInformation))
            {
                addStatus.Controls.Add(statusInformation);
                statusInformation.Dock = DockStyle.Fill;
                statusInformation.BringToFront();
            }
            else
            {
                statusInformation.BringToFront();
            }
        }
    }
}
