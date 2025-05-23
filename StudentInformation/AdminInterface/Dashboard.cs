using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.AdminInterface
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            panelName.Parent = pbPicture1;
            panelDepartment.Parent = pbPicture2;
            toolTip1.SetToolTip(btnOfficialEnrollees, "Official Enrollees");
            toolTip1.SetToolTip(btnNotOfficialEnrolled, "Not Official Enrollees");
            toolTip1.SetToolTip(guna2Button5, "Pending Enrollees");
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartments.SelectedIndex != 0)
            {
                switch (cmbDepartments.SelectedIndex)
                {
                    case 1:
                        chartTotalStudents.Datasets.Add(createDataSet(220, "BSCS", Color.LightCoral));
                        chartTotalStudents.Datasets.Add(createDataSet(300, "BSIT", Color.ForestGreen));
                        chartTotalStudents.Datasets.Add(createDataSet(158, "BSIS", Color.Orange));
                        chartTotalStudents.Datasets.Add(createDataSet(216, "BSCpE", Color.MediumAquamarine));
                        break;
                }
            }
        }
        private GunaBarDataset createDataSet(int dataSetValue, string dataSetLabel, Color dataSetColor)
        {
            GunaBarDataset dataSet = new GunaBarDataset();
            dataSet.FillColors.Add(dataSetColor);
            dataSet.DataPoints.Add("", dataSetValue);
            dataSet.BarPercentage = .5;
            dataSet.IndexLabel = dataSetLabel;
            dataSet.Label = dataSetLabel;
            dataSet.TargetChart = chartTotalStudents;

            return dataSet;

        }
    }
}
