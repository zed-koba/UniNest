using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class EnrollMainPage : Form
    {
        private static EnrollMainPage _instance;
        public static EnrollMainPage Instance { 
            get {
                return _instance;
            }
          } 
        
        public EnrollMainPage(Form form)
        {
            InitializeComponent();
            _instance = this;
            
            
            var enrollment = EnrollUserControls.EnrollmentLanding.Instance;         

            if (!MainPanel.Controls.Contains(enrollment))
            {
                MainPanel.Controls.Add(enrollment);
                enrollment.Dock = DockStyle.Fill;
                enrollment.BringToFront();
            }
            else
            {
                enrollment.BringToFront();
            }
            //connectToSql();
        }
        public Guna2ProgressBar enrollProgress
        {
            get { return progCompletion; }
        }
        public Label progressLabel
        {
            get { return lblCompletion; }
        }
     
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            string exePath = Application.ExecutablePath;
            #if DEBUG
            Process.Start(exePath);
            Environment.Exit(0);
            #endif
            //parentForm.Show();
        }
    }
}
