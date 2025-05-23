using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation.EnrollUserControls.College
{
    public partial class OfficiallyEnrolled : UserControl
    {
      
        private static OfficiallyEnrolled _instance;
        private StudentDetails _studentDetails;
        private List<StudentParents> _studentParents;
        private List<StudentsEducation> _studentEducation;
        private StudentEnrollmentInfo _studentEnrollmentsInfo;
        public static OfficiallyEnrolled Instance(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ, StudentEnrollmentInfo enroll)
        {
            if (_instance == null)
            {
                _instance = new OfficiallyEnrolled(stud, mother, father, educ, enroll);
            }
            return _instance;
        }
        public OfficiallyEnrolled(StudentDetails stud, StudentParents mother, StudentParents father, List<StudentsEducation> educ, StudentEnrollmentInfo enroll)
        {
            InitializeComponent();
            _studentDetails = stud;
            _studentParents = new List<StudentParents>()
            {
                mother,
                father
            };
            _studentEducation = educ;
            _studentEnrollmentsInfo = enroll;
           
        }
     
        private void connectToSql()
        {
            try
            {
                string connection = $"Server={Form1.getConnectionDbPcName};Database={Form1.getConnDbName};Trusted_Connection=True;";

                string insertStudent = "INSERT INTO Students(" +
                    "fName, middleName, lName, Sex, BOD, phoneType, phoneNum, emailAdd, fbName, civilStatus, citizenShip, religion, addInfo, yearLevel, currentSem, course, currentSemEnrolled, currentStatus) VALUES (" +
                    $"'{_studentDetails.fName}', '{_studentDetails.middleName}', '{_studentDetails.lastName}', '{_studentDetails.Sex}', '{_studentDetails.BOD}', " +
                    $"'{_studentDetails.phoneType}', {_studentDetails.phoneNum}, '{_studentDetails.emailAdd}', '{_studentDetails.fbName}', '{_studentDetails.civilStatus}', '{_studentDetails.citizenShip}'," +
                    $"'{_studentDetails.religion}', '{_studentDetails.addInfo}', '1st Year', 1, 'BSCS', 0, 0)";
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    using (SqlTransaction transaction = connect.BeginTransaction())
                    {
                        try 
                        { 
                            using(SqlCommand command = new SqlCommand())
                            {
                                int getStudentId = 0;
                                command.Connection = connect;
                                command.Transaction = transaction;
                                 
                                command.CommandText = insertStudent;
                                command.ExecuteNonQuery();

                                command.CommandText = $"SELECT student_ID FROM Students WHERE fName = '{_studentDetails.fName}' AND lName = '{_studentDetails.lastName}'";
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        reader.Read();
                                        getStudentId = reader.GetInt32(0);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No Data Found");
                                    }
                                }
                                command.CommandText = "INSERT INTO Students_mothers(student_ID, fName, middleName, lName, phoneType, phoneNum) VALUES" +
                                            $"({getStudentId}, '{_studentParents[0].fName}', '{_studentParents[0].middleName}', '{_studentParents[0].lastName}'," +
                                            $"'{_studentParents[0].phoneType}', {_studentParents[0].phoneNum})";
                                command.ExecuteNonQuery();

                                command.CommandText = "INSERT INTO Students_fathers(student_ID, fName, middleName, lName, phoneType, phoneNum) VALUES" +
                                    $"({getStudentId}, '{_studentParents[1].fName}', '{_studentParents[1].middleName}', '{_studentParents[1].lastName}'," +
                                    $"'{_studentParents[1].phoneType}', {_studentParents[1].phoneNum})";
                                command.ExecuteNonQuery();

                                command.CommandText = "INSERT INTO student_Address(student_ID, Province, MunicipalCity, Barangay, Sitio, Street) VALUES (" +
                                    $"{getStudentId}, '{_studentDetails.province}', '{_studentDetails.municipal}', '{_studentDetails.barangay}', '{_studentDetails.sitio}', '{_studentDetails.street}')";
                                command.ExecuteNonQuery();

                                command.CommandText = "INSERT INTO students_Education(student_ID, student_LRN, elementary_schoolName, elementary_dateGraduated, juniorH_schoolName, " +
                                    "juniorH_dateGraduated, seniorH_schoolName, seniorH_dateGraduated) VALUES (" +
                                    $"{getStudentId}, '{_studentDetails.student_LRN}', '{_studentEducation[0].schoolName}', '{_studentEducation[0].dateGraduated}', '{_studentEducation[1].schoolName}', " +
                                    $"'{_studentEducation[1].dateGraduated}', '{_studentEducation[2].schoolName}', '{_studentEducation[2].dateGraduated}')";
                                command.ExecuteNonQuery();

                                command.CommandText = "INSERT INTO Students_EnrollMent(student_ID, schoolTermEnrolled, dateEnrolled, studentProgram, studentSession, Referral, PSA_document, " +
                                    "goodMoral_document, reportCard_document, documentsConfirmed, documentsHanded, classification, study_load) VALUES (" +
                                    $"{getStudentId}, 'First Term A.Y 2024-2025', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{_studentEnrollmentsInfo.studentProgram}', '{_studentEnrollmentsInfo.studentSession}'," +
                                    $"'{_studentEnrollmentsInfo.referral}', 'Images/EnrollmentDetails/{_studentEnrollmentsInfo.PSA}', 'Images/EnrollmentDetails/{_studentEnrollmentsInfo.goodMoral}', 'Images/EnrollmentDetails/{_studentEnrollmentsInfo.reportCard}', 0, 0," +
                                    $"'Freshmen', 0)";

                                command.ExecuteNonQuery();

                                command.CommandText = $"INSERT INTO Students_Accounts(studentId, student_Username, student_Password) VALUES ({getStudentId}, {getStudentId}, {getStudentId})";
                                command.ExecuteNonQuery();
                                lblUsername.Text = $"<b>{getStudentId}</b>";
                                lblPassword.Text = $"<b>{getStudentId}</b>";
                                transaction.Commit();
                            }
                        }catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR FIRST");
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            string exePath = Application.ExecutablePath;
            #if DEBUG
            Process.Start(exePath);
            Environment.Exit(0);
            #endif

        }
        
        private void OfficiallyEnrolled_Load(object sender, EventArgs e)
        {
            connectToSql();
          

        }
    }
}
