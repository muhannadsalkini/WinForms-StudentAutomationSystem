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

namespace WindowsFormsApp_StudentAutomayionSystem.Student
{
    public partial class ExamCalendar : Form
    {
        private string studentId;
        public ExamCalendar(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void ExamCalendar_Load(object sender, EventArgs e)
        {
            string day;
            DateTime date = new DateTime();
            int Rowcount = 0;

            con.Close();
            con.Open();

            string sqlstatment = "SELECT Lectures.name, type, percentage,  date, Teachers.prefix, Teachers.name AS Teacher, announce_date FROM Examss, Lectures, StudentLectures, Teachers WHERE StudentLectures.student_id = '"
                + studentId + "' AND Examss.studentLecture_id = StudentLectures.lecture_id AND Lectures.Id = StudentLectures.lecture_id AND Lectures.teacher_id = Teachers.Id ORDER BY Lectures.name, date";

            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader(); 

            while (dr.Read())
            {
                
                date = (DateTime)dr["date"];
                day = date.DayOfWeek.ToString();

                datagrid.Rows.Add(dr["name"].ToString() + " | " + dr["type"].ToString(), dr["date"].ToString().Substring(0, 10), day, dr["percentage"].ToString() + "%", dr["prefix"].ToString()+". "+ dr["Teacher"].ToString());

                
                if (dr["announce_date"].ToString().Length > 1)
                {
                    datagrid.Rows[Rowcount].DefaultCellStyle.BackColor = Color.PaleGreen;
                }
                Rowcount++;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            var Home_Page = new HomePage(studentId);
            Home_Page.Location = this.Location;
            Home_Page.StartPosition = FormStartPosition.Manual;
            Home_Page.Size = this.Size;
            Home_Page.Show();
            this.Close();
        }

        
    }
}
