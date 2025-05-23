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
using Guna.UI2;
using Guna.UI2.WinForms;
using StudentInformation.EnrollUserControls.College;


namespace StudentInformation.EnrollUserControls
{
    public partial class PersonalDetails : UserControl
    {
        private static PersonalDetails _instance;
       
        private static StudentDetails _studentDetails;
        public static PersonalDetails Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonalDetails();    
                }
                return _instance;
            }
        }
        public PersonalDetails()
        {
            InitializeComponent();
            guna2HtmlToolTip1.SetToolTip(pbEmailTipTool,
                "<b>Valid Email Domains</b><br>• <i>@gmail.com</i><br>• <i>@yahoo.com</i><br>• <i>@hotmail.com</i><br>• <i>@outlook.com</i>");
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (requirementCheck())
            {
                _studentDetails = new StudentDetails()
                {
                    fName = txtFirst.Text,
                    middleName = txtMiddle.Text,
                    lastName = txtLast.Text,
                    Sex = cmbSex.SelectedItem.ToString(),
                    BOD = dtpBirthDate.Value.ToString("yyyy-MM-dd"),
                    phoneType = cmbPhoneType.SelectedItem.ToString(),
                    phoneNum = txtPhoneNo.Text,
                    emailAdd = txtEmail.Text,
                    fbName = txtFacebook.Text
                };

                var statusInformation = College.StatusInformation.Instance(_studentDetails);
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
                EnrollMainPage.Instance.enrollProgress.Value = 20;
                EnrollMainPage.Instance.progressLabel.Text = $"{EnrollMainPage.Instance.enrollProgress.Value}% Complete";
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private bool requirementCheck()
        {
            bool completed = false, messageBoxShown = false;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com|hotmail\.com|outlook\.com)$";
           foreach (Control ctrl in panelPersonal.Controls)
            {
                if(ctrl is Guna2TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);                      
                    }
                }
                else if(ctrl is Guna2ComboBox comboBox)
                {
                    if(comboBox.SelectedIndex == 0)
                    {
                        comboBox.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
                else if(ctrl is Guna2DateTimePicker dateTimePicker)
                {
                    if(dateTimePicker.Value.Date.Year == 2024)
                    {
                        dateTimePicker.BorderColor = Color.FromArgb(251, 75, 52);
                    }
                }
            }
            foreach (Control ctrl in panelContacts.Controls)
            {
                if (ctrl is Guna2TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);
                        
                    }else if (textBox.Name == "txtPhoneNo" && textBox.Text.Length != 11)
                    {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);
                        if(!messageBoxShown)
                        {
                            GlobalMethod.PopAMessage("error", "Phone number must be exactly 11 digits", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
                            messageBoxShown = true;
                        }
                        
                    }else if(textBox.Name == "txtEmail" && !Regex.IsMatch(textBox.Text, emailPattern)) {
                        textBox.BorderColor = Color.FromArgb(251, 75, 52);
                        if(!messageBoxShown)
                        {
                            GlobalMethod.PopAMessage("error", "Please enter a valid email", this.Parent.Parent.Parent.Parent.Size, this.Parent.Parent.Parent.Parent.Location);
                            messageBoxShown= true;
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
            foreach (Control ctrl in panelPersonal.Controls)
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
                if (ctrl is Guna2DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }
            foreach (Control ctrl in panelContacts.Controls)
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
                if (ctrl is Guna2DateTimePicker dateTimePicker)
                {
                    if (dateTimePicker.BorderColor == Color.FromArgb(251, 75, 52))
                        return false;
                }
            }

            return true;
        }
        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
           
            if(sender is Guna2TextBox txtBoxes && !string.IsNullOrEmpty(txtBoxes.Text))
            {
                txtBoxes.BorderColor = Color.FromArgb(51,52,55);
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
    }
}
