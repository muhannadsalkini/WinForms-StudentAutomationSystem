namespace WindowsFormsApp_StudentAutomayionSystem.Student
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelname = new System.Windows.Forms.Label();
            this.labelstudentnumber = new System.Windows.Forms.Label();
            this.takenCourses = new System.Windows.Forms.Button();
            this.courseSchedule = new System.Windows.Forms.Button();
            this.exmResults = new System.Windows.Forms.Button();
            this.examCalendar = new System.Windows.Forms.Button();
            this.semesterAverages = new System.Windows.Forms.Button();
            this.academicStatus = new System.Windows.Forms.Button();
            this.notifacations = new System.Windows.Forms.Button();
            this.academicCalender = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.cousrcescedule1 = new WindowsFormsApp_StudentAutomayionSystem.Student.cousrcescedule();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelname.Location = new System.Drawing.Point(212, 66);
            this.labelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(70, 24);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Name";
            // 
            // labelstudentnumber
            // 
            this.labelstudentnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelstudentnumber.AutoSize = true;
            this.labelstudentnumber.BackColor = System.Drawing.Color.White;
            this.labelstudentnumber.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.labelstudentnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelstudentnumber.Location = new System.Drawing.Point(212, 99);
            this.labelstudentnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstudentnumber.Name = "labelstudentnumber";
            this.labelstudentnumber.Size = new System.Drawing.Size(39, 24);
            this.labelstudentnumber.TabIndex = 2;
            this.labelstudentnumber.Text = "No";
            // 
            // takenCourses
            // 
            this.takenCourses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takenCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.takenCourses.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takenCourses.ForeColor = System.Drawing.Color.White;
            this.takenCourses.Location = new System.Drawing.Point(85, 239);
            this.takenCourses.Margin = new System.Windows.Forms.Padding(4);
            this.takenCourses.Name = "takenCourses";
            this.takenCourses.Size = new System.Drawing.Size(187, 80);
            this.takenCourses.TabIndex = 3;
            this.takenCourses.Text = "Taken Courses";
            this.takenCourses.UseVisualStyleBackColor = false;
            // 
            // courseSchedule
            // 
            this.courseSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.courseSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.courseSchedule.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSchedule.ForeColor = System.Drawing.Color.White;
            this.courseSchedule.Location = new System.Drawing.Point(322, 239);
            this.courseSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.courseSchedule.Name = "courseSchedule";
            this.courseSchedule.Size = new System.Drawing.Size(187, 80);
            this.courseSchedule.TabIndex = 4;
            this.courseSchedule.Text = "Course Schedule";
            this.courseSchedule.UseVisualStyleBackColor = false;
            this.courseSchedule.Click += new System.EventHandler(this.courseSchedule_Click);
            // 
            // exmResults
            // 
            this.exmResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exmResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exmResults.FlatAppearance.BorderSize = 0;
            this.exmResults.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.exmResults.ForeColor = System.Drawing.Color.White;
            this.exmResults.Location = new System.Drawing.Point(556, 239);
            this.exmResults.Margin = new System.Windows.Forms.Padding(4);
            this.exmResults.Name = "exmResults";
            this.exmResults.Size = new System.Drawing.Size(187, 80);
            this.exmResults.TabIndex = 5;
            this.exmResults.Text = "Exam Results";
            this.exmResults.UseVisualStyleBackColor = false;
            // 
            // examCalendar
            // 
            this.examCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.examCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.examCalendar.FlatAppearance.BorderSize = 0;
            this.examCalendar.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.examCalendar.ForeColor = System.Drawing.Color.White;
            this.examCalendar.Location = new System.Drawing.Point(789, 239);
            this.examCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.examCalendar.Name = "examCalendar";
            this.examCalendar.Size = new System.Drawing.Size(187, 80);
            this.examCalendar.TabIndex = 6;
            this.examCalendar.Text = "Exam Calendar";
            this.examCalendar.UseVisualStyleBackColor = false;
            // 
            // semesterAverages
            // 
            this.semesterAverages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.semesterAverages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.semesterAverages.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterAverages.ForeColor = System.Drawing.Color.White;
            this.semesterAverages.Location = new System.Drawing.Point(322, 380);
            this.semesterAverages.Margin = new System.Windows.Forms.Padding(4);
            this.semesterAverages.Name = "semesterAverages";
            this.semesterAverages.Size = new System.Drawing.Size(187, 80);
            this.semesterAverages.TabIndex = 7;
            this.semesterAverages.Text = "Semester Averages";
            this.semesterAverages.UseVisualStyleBackColor = false;
            // 
            // academicStatus
            // 
            this.academicStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.academicStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.academicStatus.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicStatus.ForeColor = System.Drawing.Color.White;
            this.academicStatus.Location = new System.Drawing.Point(556, 380);
            this.academicStatus.Margin = new System.Windows.Forms.Padding(4);
            this.academicStatus.Name = "academicStatus";
            this.academicStatus.Size = new System.Drawing.Size(187, 80);
            this.academicStatus.TabIndex = 8;
            this.academicStatus.Text = "Academic Status";
            this.academicStatus.UseVisualStyleBackColor = false;
            // 
            // notifacations
            // 
            this.notifacations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notifacations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.notifacations.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.notifacations.ForeColor = System.Drawing.Color.White;
            this.notifacations.Location = new System.Drawing.Point(789, 380);
            this.notifacations.Margin = new System.Windows.Forms.Padding(4);
            this.notifacations.Name = "notifacations";
            this.notifacations.Size = new System.Drawing.Size(187, 80);
            this.notifacations.TabIndex = 9;
            this.notifacations.Text = "Notifacations";
            this.notifacations.UseVisualStyleBackColor = false;
            // 
            // academicCalender
            // 
            this.academicCalender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.academicCalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.academicCalender.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicCalender.ForeColor = System.Drawing.Color.White;
            this.academicCalender.Location = new System.Drawing.Point(85, 380);
            this.academicCalender.Margin = new System.Windows.Forms.Padding(4);
            this.academicCalender.Name = "academicCalender";
            this.academicCalender.Size = new System.Drawing.Size(187, 80);
            this.academicCalender.TabIndex = 10;
            this.academicCalender.Text = "Academic Calendar";
            this.academicCalender.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(85, 160);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 10);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp_StudentAutomayionSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(926, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // userPicture
            // 
            this.userPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPicture.Image = global::WindowsFormsApp_StudentAutomayionSystem.Properties.Resources.blank_profile_picture;
            this.userPicture.Location = new System.Drawing.Point(100, 57);
            this.userPicture.Margin = new System.Windows.Forms.Padding(4);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(75, 75);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // cousrcescedule1
            // 
            this.cousrcescedule1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cousrcescedule1.Location = new System.Drawing.Point(65, 176);
            this.cousrcescedule1.Name = "cousrcescedule1";
            this.cousrcescedule1.Size = new System.Drawing.Size(927, 371);
            this.cousrcescedule1.TabIndex = 14;
            this.cousrcescedule1.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.academicCalender);
            this.Controls.Add(this.notifacations);
            this.Controls.Add(this.academicStatus);
            this.Controls.Add(this.semesterAverages);
            this.Controls.Add(this.examCalendar);
            this.Controls.Add(this.exmResults);
            this.Controls.Add(this.courseSchedule);
            this.Controls.Add(this.takenCourses);
            this.Controls.Add(this.labelstudentnumber);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.userPicture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelstudentnumber;
        private System.Windows.Forms.Button takenCourses;
        private System.Windows.Forms.Button courseSchedule;
        private System.Windows.Forms.Button exmResults;
        private System.Windows.Forms.Button examCalendar;
        private System.Windows.Forms.Button semesterAverages;
        private System.Windows.Forms.Button academicStatus;
        private System.Windows.Forms.Button notifacations;
        private System.Windows.Forms.Button academicCalender;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private cousrcescedule cousrcescedule1;
    }
}