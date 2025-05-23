using StudentInformation.Properties;
using StudentInformation.StudentInterface;
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

namespace StudentInformation
{
    public partial class ChangePassword : Form
    {
        private int student_ID;
        public ChangePassword(int studId)
        {
            InitializeComponent();
            student_ID = studId;
        }
        int i;
        private void modalTimer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                modalTimer.Stop();
            }
            else
            {
                Opacity += 0.03;
            }
            int y = StudentDashboard.parentY += 3;
            this.Location = new Point(StudentDashboard.parentX + 520, y);
            if(y >= i)
            {
                modalTimer.Stop();
            }

        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            i = StudentDashboard.parentY + 150;
            this.Location = new Point(StudentDashboard.parentX + 520, i);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
            string query = "UPDATE Students_Accounts SET student_Password = @password WHERE studentId = @student_ID";
            if(txtPass.Text == txtConfirmPass.Text) {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@student_ID", student_ID);
                        command.Parameters.AddWithValue("@password", txtConfirmPass.Text);
                        command.ExecuteNonQuery();
                    }
                }
                this.Close();
                GlobalMethod.PopAMessage("success", "Sucessfully updated the password", this.Size, this.Location);
            }
            else
            {
                GlobalMethod.PopAMessage("error", "Passwords do not match. Please try again.", this.Size, this.Location);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(txtPass.Text.Length < 8)
            {
                txtPass.BorderColor = Color.FromArgb(251, 75, 52);
                btnReset.Enabled = false;
            }
            else
            {
                txtPass.BorderColor = Color.FromArgb(10,169,110);
                if(txtConfirmPass.Text.Length >= 8)
                    btnReset.Enabled = true;
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text.Length < 8)
            {
                txtConfirmPass.BorderColor = Color.FromArgb(251, 75, 52);
                btnReset.Enabled = false;
            }
            else
            {
                txtConfirmPass.BorderColor = Color.FromArgb(10, 169, 110);
                if (txtPass.Text.Length >= 8)
                    btnReset.Enabled = true;
            }
        }
     
        
    }
}
