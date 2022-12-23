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
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.studentNumber = new System.Windows.Forms.Label();
            this.takenCourses = new System.Windows.Forms.Button();
            this.courseSchedule = new System.Windows.Forms.Button();
            this.exmResults = new System.Windows.Forms.Button();
            this.examCalendar = new System.Windows.Forms.Button();
            this.semesterAverages = new System.Windows.Forms.Button();
            this.academicStatus = new System.Windows.Forms.Button();
            this.notifacations = new System.Windows.Forms.Button();
            this.academicCalender = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userPicture
            // 
            this.userPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPicture.Image = global::WindowsFormsApp_StudentAutomayionSystem.Properties.Resources.blank_profile_picture;
            this.userPicture.Location = new System.Drawing.Point(64, 48);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(77, 77);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(185, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "label1";
            // 
            // studentNumber
            // 
            this.studentNumber.AutoSize = true;
            this.studentNumber.Location = new System.Drawing.Point(185, 102);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(35, 13);
            this.studentNumber.TabIndex = 2;
            this.studentNumber.Text = "label2";
            // 
            // takenCourses
            // 
            this.takenCourses.Location = new System.Drawing.Point(112, 194);
            this.takenCourses.Name = "takenCourses";
            this.takenCourses.Size = new System.Drawing.Size(140, 65);
            this.takenCourses.TabIndex = 3;
            this.takenCourses.Text = "Taken Courses";
            this.takenCourses.UseVisualStyleBackColor = true;
            // 
            // courseSchedule
            // 
            this.courseSchedule.Location = new System.Drawing.Point(258, 194);
            this.courseSchedule.Name = "courseSchedule";
            this.courseSchedule.Size = new System.Drawing.Size(140, 65);
            this.courseSchedule.TabIndex = 4;
            this.courseSchedule.Text = "Course Schedule";
            this.courseSchedule.UseVisualStyleBackColor = true;
            // 
            // exmResults
            // 
            this.exmResults.Location = new System.Drawing.Point(404, 194);
            this.exmResults.Name = "exmResults";
            this.exmResults.Size = new System.Drawing.Size(140, 65);
            this.exmResults.TabIndex = 5;
            this.exmResults.Text = "Exam Results";
            this.exmResults.UseVisualStyleBackColor = true;
            this.exmResults.Click += new System.EventHandler(this.button3_Click);
            // 
            // examCalendar
            // 
            this.examCalendar.Location = new System.Drawing.Point(550, 194);
            this.examCalendar.Name = "examCalendar";
            this.examCalendar.Size = new System.Drawing.Size(140, 65);
            this.examCalendar.TabIndex = 6;
            this.examCalendar.Text = "Exam Calendar";
            this.examCalendar.UseVisualStyleBackColor = true;
            // 
            // semesterAverages
            // 
            this.semesterAverages.Location = new System.Drawing.Point(258, 309);
            this.semesterAverages.Name = "semesterAverages";
            this.semesterAverages.Size = new System.Drawing.Size(140, 65);
            this.semesterAverages.TabIndex = 7;
            this.semesterAverages.Text = "Semester Averages";
            this.semesterAverages.UseVisualStyleBackColor = true;
            // 
            // academicStatus
            // 
            this.academicStatus.Location = new System.Drawing.Point(404, 309);
            this.academicStatus.Name = "academicStatus";
            this.academicStatus.Size = new System.Drawing.Size(140, 65);
            this.academicStatus.TabIndex = 8;
            this.academicStatus.Text = "Academic Status";
            this.academicStatus.UseVisualStyleBackColor = true;
            // 
            // notifacations
            // 
            this.notifacations.Location = new System.Drawing.Point(550, 309);
            this.notifacations.Name = "notifacations";
            this.notifacations.Size = new System.Drawing.Size(140, 65);
            this.notifacations.TabIndex = 9;
            this.notifacations.Text = "Notifacations";
            this.notifacations.UseVisualStyleBackColor = true;
            // 
            // academicCalender
            // 
            this.academicCalender.Location = new System.Drawing.Point(112, 309);
            this.academicCalender.Name = "academicCalender";
            this.academicCalender.Size = new System.Drawing.Size(140, 65);
            this.academicCalender.TabIndex = 10;
            this.academicCalender.Text = "Academic Calendar";
            this.academicCalender.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp_StudentAutomayionSystem.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(724, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.academicCalender);
            this.Controls.Add(this.notifacations);
            this.Controls.Add(this.academicStatus);
            this.Controls.Add(this.semesterAverages);
            this.Controls.Add(this.examCalendar);
            this.Controls.Add(this.exmResults);
            this.Controls.Add(this.courseSchedule);
            this.Controls.Add(this.takenCourses);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.userPicture);
            this.Name = "HomePage";
            this.Text = "homePage";
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label studentNumber;
        private System.Windows.Forms.Button takenCourses;
        private System.Windows.Forms.Button courseSchedule;
        private System.Windows.Forms.Button exmResults;
        private System.Windows.Forms.Button examCalendar;
        private System.Windows.Forms.Button semesterAverages;
        private System.Windows.Forms.Button academicStatus;
        private System.Windows.Forms.Button notifacations;
        private System.Windows.Forms.Button academicCalender;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}