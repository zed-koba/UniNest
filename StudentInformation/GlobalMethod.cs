using StudentInformation.GlobalForms;
using StudentInformation.Properties;
using StudentInformation.StudentInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public static class GlobalMethod
    {
        public static bool PopAYesNoMessage(Size clientSize, Point clientLoc)
        {
            Form shadowBG = new Form();
            using (CustomYesNoPopWindow sucess = new CustomYesNoPopWindow(clientLoc))
            {
                shadowBG.StartPosition = FormStartPosition.Manual;
                shadowBG.FormBorderStyle = FormBorderStyle.None;
                shadowBG.Opacity = .50d;
                shadowBG.BackColor = Color.Black;
                shadowBG.Size = clientSize;
                shadowBG.Location = clientLoc;
                shadowBG.ShowInTaskbar = false;
                shadowBG.Show();
                sucess.Owner = shadowBG;

                var confirmation = sucess.ShowDialog();
                sucess.BringToFront();
                shadowBG.BringToFront();
                shadowBG.Dispose();

                bool isConfirmed = confirmation == DialogResult.OK;

                return isConfirmed;
            }
        }
        public static bool PopADecisionWindow(Size clientSize, Point clientLoc)
        {
            Form shadowBG = new Form();
            using (CustomDecisionPopWindow sucess = new CustomDecisionPopWindow(clientLoc))
            {
                shadowBG.StartPosition = FormStartPosition.Manual;
                shadowBG.FormBorderStyle = FormBorderStyle.None;
                shadowBG.Opacity = .50d;
                shadowBG.BackColor = Color.Black;
                shadowBG.Size = clientSize;
                shadowBG.Location = clientLoc;
                shadowBG.ShowInTaskbar = false;
                shadowBG.Show();
                sucess.Owner = shadowBG;

                var confirmation = sucess.ShowDialog();
                sucess.BringToFront();
                shadowBG.BringToFront();
                shadowBG.Dispose();

                bool isConfirmed = confirmation == DialogResult.OK;

                return isConfirmed;
            }
        }
        public static bool PopALogout(Size clientSize, Point clientLoc)
        {
            Form shadowBG = new Form();
            using (CustomLogoutPopup sucess = new CustomLogoutPopup(clientLoc))
            {
                shadowBG.StartPosition = FormStartPosition.Manual;
                shadowBG.FormBorderStyle = FormBorderStyle.None;
                shadowBG.Opacity = .50d;
                shadowBG.BackColor = Color.Black;
                shadowBG.Size = clientSize;
                shadowBG.Location = clientLoc;
                shadowBG.ShowInTaskbar = false;
                shadowBG.Show();
                sucess.Owner = shadowBG;

                var confirmation = sucess.ShowDialog();
                sucess.BringToFront();
                shadowBG.BringToFront();
                shadowBG.Dispose();

                bool isConfirmed = confirmation == DialogResult.OK;

                return isConfirmed;
            }
        }
        public static void PopAMessage(string typeOfMessage, string Message, Size clientSize, Point loc)
        {

            Image kindImage = null;
            Color kindColor = Color.Empty;
            string type = string.Empty;
            switch (typeOfMessage)
            {
                case "success":
                    kindImage = Resources.icon_park__check_one;
                    kindColor = Color.FromArgb(10, 169, 110);
                    type = "Success";
                    break;
                case "error":
                    kindImage = Resources.icons8_error_48;
                    kindColor = Color.FromArgb(251, 75, 52);
                    type = "Error";
                    break;
            }
            Form shadowBG = new Form();
            using (CustomPopWindow sucess = new CustomPopWindow(kindColor, kindImage, type, Message))
            {
                shadowBG.StartPosition = FormStartPosition.Manual;
                shadowBG.FormBorderStyle = FormBorderStyle.None;
                shadowBG.Opacity = .50d;
                shadowBG.BackColor = Color.Black;
                shadowBG.Size = clientSize;
                shadowBG.Location = loc;
                shadowBG.ShowInTaskbar = false;
                shadowBG.Show();
                sucess.Owner = shadowBG;


                sucess.ShowDialog();
                sucess.BringToFront();
                shadowBG.BringToFront();
                shadowBG.Dispose();
            }
        }

        public static string semesterToString(int sem)
        {
            if (sem == 1)
                return "First Semester";
            else if (sem == 2)
                return "Second Semester";

            return string.Empty;
        }
        public static string yearLevelConverter(int yr)
        {
            if (yr == 1)
                return "1st Year";
            else if (yr == 2)
                return "2nd Year";
            else if (yr == 3)
                return "3rd Year";
            else if (yr >= 4)
                return $"{yr}th Year";

            return string.Empty;
        }

    }
}
