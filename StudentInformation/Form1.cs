using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        private static string connDbName;
        private static string connDbPcName;
       

        public static string getConnDbName
        {
            get => connDbName;
        }
        public static string getConnectionDbPcName
        {
            get => connDbPcName;
        }

        public Form1()
        {
            InitializeComponent();
            connDbName = "StudentInformation";
            connDbPcName = "localhost\\SQLEXPRESS";

           
        }

 
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollMainPage enroll = new EnrollMainPage(this);
            enroll.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "admin" && txtPassword.Text != "admin")
            {
                try
                {
                    string con = $"Server={connDbPcName};Database={connDbName};Trusted_Connection=True;";
                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        connection.Open();
                        try
                        {
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = connection;
                                command.CommandText = $"SELECT * FROM Students_Accounts WHERE student_Username = '{txtUsername.Text}' AND student_Password = '{txtPassword.Text}'";
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        this.Hide();
                                        StudentDashboard studentDashboard = new StudentDashboard(Convert.ToInt32(txtUsername.Text));
                                        studentDashboard.Show();
                                        txtUsername.Clear();
                                        txtPassword.Clear();
                                    }
                                    else
                                    {
                                        GlobalMethod.PopAMessage("error", "Incorrect credentials, please try again", this.Size, this.Location);
                                        txtUsername.Clear();
                                        txtPassword.Clear();
                                    }
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotpass = new ForgotPassword();
            panelForm.Controls.Add(forgotpass);
            forgotpass.Dock = DockStyle.Fill;
            forgotpass.BringToFront();

        }
    }
}
