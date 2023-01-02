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
    public partial class ExamResults : Form
    {
        private string studentId;
        public ExamResults(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void ExamResults_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string sqlstatment = "SELECT Lectures.name, type, score, percentage,  announce_date FROM Examss, Lectures, " +
                "StudentLectures WHERE StudentLectures.student_id = '" + studentId+ "' AND announce_date IS NOT NULL " +
                "AND Examss.studentLecture_id = StudentLectures.lecture_id AND Lectures.Id = StudentLectures.lecture_id ORDER BY Lectures.name";

            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                datagrid.Rows.Add(dr["name"].ToString()+" | "+ dr["type"].ToString(), dr["score"].ToString(), 
                    dr["percentage"].ToString()+"%", dr["announce_date"].ToString().Substring(0, 10));
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
