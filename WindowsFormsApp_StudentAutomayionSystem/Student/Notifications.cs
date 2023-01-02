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
    public partial class Notifications : Form
    {
        private string studentId;
        public Notifications(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void Notifications_Load(object sender, EventArgs e)
        {
            int Rowcount = 0;

            con.Close();
            con.Open();

            string sqlstatment = "SELECT * FROM Notifacations WHERE student_id= '" + studentId+"' ORDER BY date";

            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                datagrid.Rows.Add(dr["header"].ToString(), dr["type"].ToString(), dr["date"].ToString().Substring(0, 10),
                    dr["status"].ToString(), dr["Id"].ToString());
                
                if (dr["status"].ToString() == "True")
                    datagrid.Rows[Rowcount].DefaultCellStyle.BackColor = Color.PaleGreen;

                Rowcount++;
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
