using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.GlobalForms
{
    public partial class CustomDecisionPopWindow : Form
    {

        Point parentLocation;
        public CustomDecisionPopWindow(Point parentLocation)
        {
            InitializeComponent();
            this.parentLocation = parentLocation;
        }
        int i;
        private void CustomYesNoPopWindow_Load(object sender, EventArgs e)
        {
            i = parentLocation.Y + 120;
            this.Location = new Point(parentLocation.X + 200, parentLocation.Y);
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
            this.Location = new Point(parentLocation.X + 200, y);
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
