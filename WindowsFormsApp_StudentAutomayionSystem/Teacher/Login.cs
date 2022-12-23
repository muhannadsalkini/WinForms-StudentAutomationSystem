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
using WindowsFormsApp_StudentAutomayionSystem;
using WindowsFormsApp_StudentAutomayionSystem.Teacher;

namespace WindowsFormsApp_StudentAutomayionSystem.Teacher
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string login = "SELECT  FROM Teachers WHERE e_mail='" + textboxemail.Text + "' and password='" + textboxpassword.Text + "'";
            cmd = new SqlCommand(login, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new HomePage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Student number or password!", "Login faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxemail.Text = string.Empty;
                textboxpassword.Text = string.Empty;
                textboxemail.Focus();
            }
            con.Close();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textboxemail.Text = string.Empty;
            textboxpassword.Text = string.Empty;
            textboxemail.Focus();
        }

        private void checkboxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxshowpassword.Checked)
            {
                textboxpassword.PasswordChar = '\0';
            }
            else
            {
                textboxpassword.PasswordChar = '*';
            }
        }

        private void labelbackhome_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }
    }
}
