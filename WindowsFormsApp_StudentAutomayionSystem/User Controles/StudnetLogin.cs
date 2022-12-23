using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_StudentAutomayionSystem
{
    public partial class StudnetLogin : UserControl
    {
        public StudnetLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudnetLogin_Load(object sender, EventArgs e)
        {

        }

        private void StudentNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (StudentNumberTextBox.Text == "111" && PasswordTextBox.Text == "111")
            {
                new Student.HomePage().Show();
                this.Login.Hide();
            }

            else if (StudentNumberTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill the empy fealds!");
            }

            else
            {
                MessageBox.Show("Student number or password is incorrect!");
                StudentNumberTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }
    }
}
