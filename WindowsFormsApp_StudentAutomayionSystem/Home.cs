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

namespace WindowsFormsApp_StudentAutomayionSystem
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        //private const int cGrip = 16;
        //private const int cCaption = 32;
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }

        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}


        private void buttonteacherlogin_Click(object sender, EventArgs e)
        {
            new Teacher.Login().Show();
            this.Hide();
        }

        private void buttonstudentlogin_Click(object sender, EventArgs e)
        {
            new Student.Login().Show();
            this.Hide();
        }
    }
}
