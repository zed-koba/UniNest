using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.GlobalForms
{
    public partial class CustomYesNoPopWindow : Form
    {
        Point parentLocation;
        public CustomYesNoPopWindow(Point parentLocation)
        {
            InitializeComponent();
            this.parentLocation = parentLocation;
        }
        int i;
        private void CustomYesNoPopWindow_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 120;
            this.Location = new Point(parentLocation.X + 530, parentLocation.Y);
        }

        private void Transition_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Transition.Stop();
            }
            else
            {
                Opacity += 0.03;
            }
            int y = parentLocation.Y += 3;
            this.Location = new Point(parentLocation.X + 530, y);
            if (y >= i)
            {
                Transition.Stop();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalMethod.PopAMessage("success", "Sucessfully updated the students status", this.Size, this.Location);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
