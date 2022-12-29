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
using WindowsFormsApp_StudentAutomayionSystem.Teacher;

namespace WindowsFormsApp_StudentAutomayionSystem.Student
{
    public partial class HomePage : Form
    {
        private string studentId;
        public HomePage(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        

        private void HomePage_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string sqlstatment = "SELECT Students.name, surname, student_number, regester_date, Departments.name AS department FROM Students, Departments WHERE Students.Id='" + studentId + "' AND Students.department_id= Departments.Id";
            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                labelname.Text = dr["name"].ToString() +" "+ dr["surname"].ToString();
                labelstudentnumber.Text = dr["student_number"].ToString();
                labelregesterdate.Text = dr["regester_date"].ToString().Substring(0,10);
                labelprogram.Text = dr["department"].ToString();
            }
            else
            {
                MessageBox.Show("Database error!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            con.Close();

            sqlstatment = "SELECT * FROM Students, Departments WHERE Students.Id='" + studentId + "' AND Students.department_id= Departments.Id";
        }

        private void courseSchedule_Click(object sender, EventArgs e)
        {
            var Course_Schedule = new CourseSchedule(studentId);
            Course_Schedule.Location = this.Location;
            Course_Schedule.StartPosition= FormStartPosition.Manual;
            Course_Schedule.Size = this.Size;
            Course_Schedule.Show();
            this.Close();
        }

        private void academicCalender_Click(object sender, EventArgs e)
        {
            var Academic_Calender = new AcademicCalender(studentId);
            Academic_Calender.Location = this.Location;
            Academic_Calender.StartPosition = FormStartPosition.Manual;
            Academic_Calender.Size = this.Size;
            Academic_Calender.Show();
            this.Close();
        }

        private void semesterAverages_Click(object sender, EventArgs e)
        {
            var Semester_Averages = new SemesterAverages(studentId);
            Semester_Averages.Location = this.Location;
            Semester_Averages.StartPosition = FormStartPosition.Manual;
            Semester_Averages.Size = this.Size;
            Semester_Averages.Show();
            this.Close();
        }

        private void academicStatus_Click(object sender, EventArgs e)
        {
            var Academic_Status = new AcademicStatus(studentId);
            Academic_Status.Location = this.Location;
            Academic_Status.StartPosition = FormStartPosition.Manual;
            Academic_Status.Size = this.Size;
            Academic_Status.Show();
            this.Close();
        }

        private void exmResults_Click(object sender, EventArgs e)
        {
            var Exam_Results = new ExamResults(studentId);
            Exam_Results.Location = this.Location;
            Exam_Results.StartPosition = FormStartPosition.Manual;
            Exam_Results.Size = this.Size;
            Exam_Results.Show();
            this.Close();
        }

        private void examCalendar_Click(object sender, EventArgs e)
        {
            var Exam_Calendar = new ExamCalendar(studentId);
            Exam_Calendar.Location = this.Location;
            Exam_Calendar.StartPosition = FormStartPosition.Manual;
            Exam_Calendar.Size = this.Size;
            Exam_Calendar.Show();
            this.Close();
        }

        private void notifacations_Click(object sender, EventArgs e)
        {
            var Notifications_ = new Notifications(studentId);
            Notifications_.Location = this.Location;
            Notifications_.StartPosition = FormStartPosition.Manual;
            Notifications_.Size = this.Size;
            Notifications_.Show();
            this.Close();
        }
    }
}
