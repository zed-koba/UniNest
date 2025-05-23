using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class ForgotPassword : UserControl
    {
        string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;MultipleActiveResultSets=True";
        string emailAdd;
        int studentID;
        bool studentExist = true;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtStudentID.Text))
            {
                DateTime? lastResetFromDb = GetlastPasswordReset();
                DateTime now = DateTime.Now;
                
                if(lastResetFromDb.HasValue)
                {
                    TimeSpan timeSinceLastReset = now - lastResetFromDb.Value;
       
                    if(timeSinceLastReset.TotalDays < 7)
                    {
                        GlobalMethod.PopAMessage("error", $"Invalid request, you cannot reset password for {7 - timeSinceLastReset.TotalDays:F0} days.", this.Parent.Parent.Size, this.Parent.Parent.Location);
                        return;
                    }
                }
                if (studentExist)
                {
                    updateNewPassword();
                    GlobalMethod.PopAMessage("success", "Password reset successfully, details is sent to your registered email.", this.Parent.Parent.Size, this.Parent.Parent.Location);
                    
                }
            }
            else
            {
                GlobalMethod.PopAMessage("error", "Invalid request, make sure to provide a student ID.", this.Parent.Parent.Size, this.Parent.Parent.Location);
            }
        }
        private string getEmaillAddress()
        {
            
            string query = "SELECT emailAdd FROM Students WHERE student_ID = @studentID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        return (string)command.ExecuteScalar();
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        private DateTime? GetlastPasswordReset()
        {
            studentID = Convert.ToInt32(txtStudentID.Text);
            string query = "SELECT lastReset FROM Students_Accounts WHERE studentId = @studentID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        object result = command.ExecuteScalar();
                        if(result == null)
                        {
                            GlobalMethod.PopAMessage("error", "Invalid request, student ID doesn't exist.", this.Parent.Parent.Size, this.Parent.Parent.Location);
                            txtStudentID.Clear();
                            studentExist = false;
                            return null;
                        }
                        else
                        {
                            studentExist = true;
                        }
                       
                        if(result != DBNull.Value)
                        {
                            return Convert.ToDateTime(result);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        private string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            return password.ToString();
        }

        private void updateNewPassword()
        {
            
            string newPassword = GenerateRandomPassword(10);
            string query = "UPDATE Students_Accounts SET student_Password = @newPass, lastReset = @lastReset WHERE studentId = @studentID";
            emailAdd = getEmaillAddress();
            MailMessage gmailSend = new MailMessage("uninest.uni@gmail.com", emailAdd);
            gmailSend.Subject = "UniNest Reset Password";
            gmailSend.Body = "Your new account password is " + newPassword;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            NetworkCredential nc = new NetworkCredential("uninest.uni@gmail.com", "jaur mjgm kwcb wyeq");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(gmailSend);


            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@newPass", newPassword);
                        command.Parameters.AddWithValue("@lastReset", DateTime.Now);
                        command.ExecuteNonQuery();
                        txtStudentID.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblGoback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the input
            }
        }
    }
}
