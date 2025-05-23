using Guna.UI2.WinForms;
using StudentInformation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.StudentInterface
{
    public partial class MajorExam : UserControl
    {
        private int student_ID, getCurrentSem, getYrLevel;
        private string status;
        private string[] levelString = { "", "st", "nd", "rd", "th" };
        Color newColor;
        Control getPanel;
        UserControl currentUserControl;
        public MajorExam(int studentid)
        {
            InitializeComponent();
            student_ID = studentid;
            newColor = Color.FromArgb(10, 169, 110);
           
        }
        private void MajorExam_Load(object sender, EventArgs e)
        {
            string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connect;
                        command.CommandText = $"SELECT * FROM Students WHERE student_ID = {student_ID}";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            getYrLevel = (int)char.GetNumericValue(reader["yearLevel"].ToString()[0]);
                            getCurrentSem = (int)reader["currentSem"];
                            for (int i = 1; i <= getYrLevel; i++)
                            {
                                for (int j = 1; j <= getCurrentSem; j++)
                                {
                                    if (i == getYrLevel && j == getCurrentSem)
                                        status = "Ongoing";
                                    else
                                        status = "Finished";
                                    createSemesterCard(i, j, status);
                                }
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panelSemester_MouseEnter(object sender, EventArgs e)
        {
            getPanel = sender as Control;
            if (getPanel is Guna2Panel pane)
            {
                pane.FillColor = newColor;
                foreach (Control ctrl in pane.Controls)
                {
                    if (ctrl is Guna2Panel icon)
                    {
                        icon.FillColor = Color.FromArgb(13, 217, 141);
                    }
                    else if (ctrl is Label lbl && lbl.Name != "lblFinished")
                    {
                        ctrl.ForeColor = Color.White;
                    }
                    else if (ctrl is Label finished && finished.Name == "lblFinished")
                    {
                        finished.ForeColor = Color.FromArgb(42, 243, 169);
                    }
                }
            }
        }

        private void panelSemester_MouseLeave(object sender, EventArgs e)
        {
            
            if (getPanel is Guna2Panel pane)
            {
                pane.FillColor = Color.FromArgb(251, 252, 248);
                foreach (Control ctrl in getPanel.Controls)
                {
                    if (ctrl is Guna2Panel icon)
                    {
                        icon.FillColor = newColor;
                    }
                    else if (ctrl is Label lbl && lbl.Name != "lblFinished")
                    {
                        lbl.ForeColor = Color.FromArgb(51, 52, 55);
                    }
                    else if (ctrl is Label finished && finished.Name == "lblFinished")
                    {
                        finished.ForeColor = newColor;
                    }
                }
            }
        }
        private void seeDetails_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Panel;
            currentUserControl = new MajorExamScores(student_ID, Convert.ToInt32(btn.Name), Convert.ToInt32(btn.Tag));
            currentUserControl.Dock = DockStyle.Fill;
            panelSemesters.Controls.Add(currentUserControl);
            currentUserControl.BringToFront();

        }
        private void createSemesterCard(int yrLevel, int currentSem, string status)
        {
            string semesterString = string.Empty, yrLevelString;

            if (currentSem == 1)
                semesterString = "First Semester";
            else
                semesterString = "Second Semester";

            if (yrLevel < 4)
                yrLevelString = $"{yrLevel}{levelString[yrLevel]} Year";
            else
                yrLevelString = $"{yrLevel}{levelString[4]} Year";

            Guna2Panel semesterPanel = new Guna2Panel();
            semesterPanel.Name = yrLevel.ToString();
            semesterPanel.Tag = currentSem.ToString();
            semesterPanel.FillColor = Color.FromArgb(251, 252, 248);
            semesterPanel.BackColor = Color.Transparent;
            semesterPanel.BorderRadius = 10;
            semesterPanel.Size = new Size(165, 153);
            semesterPanel.Margin = new Padding(0, 0, 15, 0);
            
            semesterPanel.Cursor = Cursors.Hand;

            Guna2Panel iconPanel = new Guna2Panel();
            iconPanel.FillColor = newColor;
            iconPanel.BorderRadius = 5;
            iconPanel.Size = new Size(48, 44);
            iconPanel.Location = new Point(13, 22);

            Guna2PictureBox icon = new Guna2PictureBox();
            icon.Size = new Size(42, 37);
            icon.Location = new Point(3, 3);
            icon.Image = Resources.clarity__note_solid;
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.UseTransparentBackground = true;

            iconPanel.Controls.Add(icon);

            Guna2PictureBox seeDetails = new Guna2PictureBox();
            seeDetails.Size = new Size(42, 37);
            seeDetails.Location = new Point(120, 115);
            seeDetails.Image = Resources.si__arrow_right_line;
            seeDetails.SizeMode = PictureBoxSizeMode.Zoom;
            seeDetails.UseTransparentBackground = true;

            Label lblYearLevel = new Label();
            lblYearLevel.Text = yrLevelString;
            lblYearLevel.Font = new Font("Poppins", 12, FontStyle.Bold);
            lblYearLevel.BackColor = Color.Transparent;
            lblYearLevel.ForeColor = Color.FromArgb(51, 52, 55);
            lblYearLevel.Location = new Point(8, 69);
            lblYearLevel.AutoSize = true;

            Label lblSemester = new Label();
            lblSemester.Text = semesterString;
            lblSemester.Font = new Font("Poppins", 12, FontStyle.Regular);
            lblSemester.Location = new Point(8, 90);
            lblSemester.ForeColor = Color.FromArgb(51, 52, 55);
            lblSemester.AutoSize = true;

            Label lblStatus = new Label();
            lblStatus.Text = status;
            lblStatus.Name = "lblFinished";
            lblStatus.Font = new Font("Poppins", 8, FontStyle.Regular);
            lblStatus.Location = new Point(9, 112);
            lblStatus.ForeColor = Color.FromArgb(10,169,110);
            lblStatus.AutoSize = true;
            lblStatus.BringToFront();

            semesterPanel.Controls.Add(iconPanel);
            semesterPanel.Controls.Add(lblYearLevel);
            semesterPanel.Controls.Add(lblStatus);
            semesterPanel.Controls.Add(lblSemester);
            semesterPanel.Controls.Add(seeDetails);


            semesterPanel.MouseEnter += panelSemester_MouseEnter;
            semesterPanel.MouseLeave += panelSemester_MouseLeave;
            semesterPanel.Click += seeDetails_Clicked;

            flowSemester.Controls.Add(semesterPanel);

        }

        
    }
}
