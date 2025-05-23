using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.StudentInterface
{
    public partial class CustomPopWindow : Form
    {
        int location_Y;
        public CustomPopWindow(Color kindColor, Image kindImage, string type, string message)
        {
            InitializeComponent();
            panelColor.FillColor = kindColor;
            pbIcon.Image = kindImage;
            lblType.Text = type;
            lblMessage.Text = message;
            location_Y = 100;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomPopWindow_Load(object sender, EventArgs e)
        {
            i = this.Location.Y + 100;
            this.Location = new Point(this.Location.X, i);
        }
        int i;
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
            int y = location_Y += 3;
            this.Location = new Point(this.Location.X, y);
            if (y >= i)
            {
                Transition.Stop();
            }
        }
    }
}
