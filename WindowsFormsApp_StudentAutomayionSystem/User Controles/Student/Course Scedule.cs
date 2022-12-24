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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_StudentAutomayionSystem.Student
{
    public partial class cousrcescedule : UserControl
    {
        private string studentId;
        public cousrcescedule()
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string student = "SELECT * FROM Lectures WHERE Id= (SELECT lecture_id FROM StudentLectures WHERE student_id='" + studentId + "')";
            cmd = new SqlCommand(student, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                while (dr.Read())
                {
                    listView1.Items.Add("");
                    listView1.Items.Add(dr["Id"].ToString());
                    listView1.Items.Add(dr["name"].ToString());
                    listView1.Items.Add(dr["teacher_id"].ToString());
                    listView1.Items.Add(dr["startTime"].ToString() + "-" + dr["endTime"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Database error!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
