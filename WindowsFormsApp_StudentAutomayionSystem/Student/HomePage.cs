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

            string student = "SELECT Students.name, surname, student_number, regester_date, Departments.name AS department FROM Students, Departments WHERE Students.Id='" + studentId + "' AND Students.department_id= Departments.Id";
            cmd = new SqlCommand(student, con);
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
        }

        private void courseSchedule_Click(object sender, EventArgs e)
        {
            new Course_Schedule(studentId).Show();
            this.Close();
        }


        private void cousrcescedule2_Load(object sender, EventArgs e)
        {

        }
    }
}
