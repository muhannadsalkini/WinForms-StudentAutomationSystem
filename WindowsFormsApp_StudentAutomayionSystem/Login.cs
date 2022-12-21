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

namespace WindowsFormsApp_StudentAutomayionSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True";
        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {
            teacherLogin1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherLogin1.Hide();
            studnetLogin1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studnetLogin1.Hide();
            teacherLogin1.Show();
        }
    }
}
