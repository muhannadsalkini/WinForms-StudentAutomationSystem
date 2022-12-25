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
    public partial class CourseSchedule : Form
    {
        private string studentId;
        public CourseSchedule(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void Course_Schedule_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string sqlstatment = "SELECT day, hall_no, startTime, endTime, Lectures.name as lecture, Teachers.name as teacher, prefix FROM StudentLectures, Teachers, Lectures WHERE lecture_id = Lectures.Id AND Teachers.Id = Lectures.teacher_id AND student_id = '" + studentId + "'";
            
            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                switch (dr["day"])
                {
                    case "Sunday":
                        sunadydatagrid.Rows.Add("------------");
                        sunadydatagrid.Rows.Add(dr["lecture"].ToString());
                        sunadydatagrid.Rows.Add(dr["prefix"].ToString() + ". " + dr["teacher"].ToString());
                        sunadydatagrid.Rows.Add(dr["startTime"].ToString().Substring(0, 5) + "-" + dr["endTime"].ToString().Substring(0, 5));
                        sunadydatagrid.Rows.Add("Hall: " + dr["hall_no"].ToString());
                        break;
                    case "Monday":
                        mondaydatagrid.Rows.Add("------------");
                        mondaydatagrid.Rows.Add(dr["lecture"].ToString());
                        mondaydatagrid.Rows.Add(dr["prefix"].ToString() + ". " + dr["teacher"].ToString());
                        mondaydatagrid.Rows.Add(dr["startTime"].ToString().Substring(0, 5) + " - " + dr["endTime"].ToString().Substring(0, 5));
                        mondaydatagrid.Rows.Add("Hall: " + dr["hall_no"].ToString());
                        break;
                    case "Tuesday":
                        tuesdaydatagrid.Rows.Add("------------");
                        tuesdaydatagrid.Rows.Add(dr["lecture"].ToString());
                        tuesdaydatagrid.Rows.Add(dr["prefix"].ToString() + ". " + dr["teacher"].ToString());
                        tuesdaydatagrid.Rows.Add(dr["startTime"].ToString().Substring(0, 5) + " - " + dr["endTime"].ToString().Substring(0, 5));
                        tuesdaydatagrid.Rows.Add("Hall: " + dr["hall_no"].ToString());
                        break;
                    case "Wednesday":
                        wednesdaydatagrid.Rows.Add("------------");
                        wednesdaydatagrid.Rows.Add(dr["lecture"].ToString());
                        wednesdaydatagrid.Rows.Add(dr["prefix"].ToString() + ". " + dr["teacher"].ToString());
                        wednesdaydatagrid.Rows.Add(dr["startTime"].ToString().Substring(0, 5) + " - " + dr["endTime"].ToString().Substring(0, 5));
                        wednesdaydatagrid.Rows.Add("Hall: " + dr["hall_no"].ToString());
                        break;
                    case "Thursday":
                        thursdaydatagrid.Rows.Add("------------");
                        thursdaydatagrid.Rows.Add(dr["lecture"].ToString());
                        thursdaydatagrid.Rows.Add(dr["prefix"].ToString() + ". " + dr["teacher"].ToString());
                        thursdaydatagrid.Rows.Add(dr["startTime"].ToString().Substring(0, 5) + " - " + dr["endTime"].ToString().Substring(0, 5));
                        thursdaydatagrid.Rows.Add("Hall: " + dr["hall_no"].ToString());
                        break;
                    case "Friday":
                        fridaydatagrid.Rows.Add("------------");
                        fridaydatagrid.Rows.Add(dr["lecture"].ToString());
                        fridaydatagrid.Rows.Add(dr["prefix"].ToString() + ". " + dr["teacher"].ToString());
                        fridaydatagrid.Rows.Add(dr["startTime"].ToString().Substring(0, 5) + " - " + dr["endTime"].ToString().Substring(0, 5));
                        fridaydatagrid.Rows.Add("Hall: " + dr["hall_no"].ToString());
                        break;
                    case "Saturday":
                        saturdaydatagrid.Rows.Add("------------");
                        saturdaydatagrid.Rows.Add(dr["lecture"].ToString());
                        saturdaydatagrid.Rows.Add(dr["prefix"].ToString() + ". " + dr["teacher"].ToString());
                        saturdaydatagrid.Rows.Add(dr["startTime"].ToString().Substring(0, 5) + " - " + dr["endTime"].ToString().Substring(0, 5));
                        saturdaydatagrid.Rows.Add("Hall: " + dr["hall_no"].ToString());
                        break;
                    default:
                        MessageBox.Show("Database error!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
