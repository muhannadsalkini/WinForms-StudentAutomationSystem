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
    public partial class AcademicStatus : Form
    {
        private string studentId;
        public AcademicStatus(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void AcademicStatus_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string sqlstatment = "SELECT * FROM AcademicStatus WHERE student_id = '" + studentId + "'";

            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {
                labelcreditrcvd.Text = dr["credit_rcvd"].ToString();
                labelcredittake.Text = dr["credit_take"].ToString();
                labelectsrcvd.Text = dr["ects_rcvd"].ToString();
                labelectstake.Text = dr["ects_take"].ToString();
                labelcompulsoryrcvd.Text = dr["comulusory_rcvd"].ToString();
                labelcompulsorytake.Text = dr["comulusory_take"].ToString();
                labelelectivercvd.Text = dr["elective_rcvd"].ToString();
                labelelectivertake.Text = dr["elective_take"].ToString();
                labelcoursercvd.Text = dr["course_rcvd"].ToString();
                labelcoursetake.Text = dr["course_take"].ToString();
            }
            else
            {
                MessageBox.Show("Database error!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
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
