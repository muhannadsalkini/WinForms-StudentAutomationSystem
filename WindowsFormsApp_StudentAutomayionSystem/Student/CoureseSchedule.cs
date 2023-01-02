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
    public partial class CoureseSchedule : Form
    {
        private string studentId;
        public CoureseSchedule(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void CoureseSchedule_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string student = "SELECT * FROM Students WHERE Id='" + studentId + "'";
            cmd = new SqlCommand(student, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                labelname.Text = dr["name"].ToString() + " " + dr["surname"].ToString();
                labelstudentnumber.Text = dr["student_number"].ToString();
            }
            else
            {
                MessageBox.Show("Database error!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void labelback_Click(object sender, EventArgs e)
        {
            new HomePage(studentId).Show();
            this.Close();
        }
    
    }
}
