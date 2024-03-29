﻿using System;
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
    public partial class AcademicCalender : Form
    {
        private string studentId;
        public AcademicCalender(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        SqlConnection con = new SqlConnection("Data Source=MUHOHAN;Initial Catalog=studentautomayionsystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void AcademicCalender_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();

            string sqlstatment = "SELECT * FROM AcademicCalendars ORDER BY startDate";

            cmd = new SqlCommand(sqlstatment, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                datagrid.Rows.Add(dr["academic_pro"].ToString(), dr["startDate"].ToString().Substring(0, 10), 
                    dr["EndDate"].ToString().Substring(0, 10));
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
            //new HomePage(studentId).Show();
            this.Close();
        }
    }
}
