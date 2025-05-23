using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.EnrollUserControls
{
    public partial class EnrollmentLanding : UserControl
    {
        public bool choosenCollege, choosenSenior;
      
        
        private static EnrollmentLanding _instance;
        public static EnrollmentLanding Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EnrollmentLanding();
                }
                return _instance;
            }
        }
        public EnrollmentLanding()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var personal = PersonalDetails.Instance;
            if (choosenCollege)
            {
                if (!MainPanel.Controls.Contains(personal))
                {
                    MainPanel.Controls.Add(personal);
                    personal.Dock = DockStyle.Fill;
                    personal.BringToFront();
                }
                else
                {
                    personal.BringToFront();
                }
               
            }else if (choosenSenior)
            {

            }
            EnrollMainPage.Instance.enrollProgress.Value = 10;
            EnrollMainPage.Instance.progressLabel.Text = $"{EnrollMainPage.Instance.enrollProgress.Value}% Complete";


        }
      
        private void panelCollege_Click(object sender, EventArgs e)
        {
            panelCollege.BorderColor = Color.FromArgb(10, 169, 110);
            choosenCollege = true;
            choosenSenior = false;
            btnStart.Enabled = true;
        }

    }
}
