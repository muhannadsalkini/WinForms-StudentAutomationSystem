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
    public partial class SemesterAverages : Form
    {
        private string studentId;
        public SemesterAverages(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void SemesterAverages_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string sqlstatment = "SELECT * FROM SemesterAvrg, Semesters WHERE student_id = '" + studentId +
                "' AND Semesters.Id = SemesterAvrg.semester_id ORDER BY Semesters.start_date";

            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            chart1.Series["Average"].Color = Color.FromArgb(128, 128, 255);
            chart1.Series["Average"].IsValueShownAsLabel = true;

            while (dr.Read())
            {
                chart1.Series["Average"].Points.AddXY(dr["academic_year"].ToString() + " " + 
                    dr["type"].ToString(), dr["avrg"]);
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
