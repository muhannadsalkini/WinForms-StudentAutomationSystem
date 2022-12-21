namespace WindowsFormsApp_StudentAutomayionSystem
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teacherLogin1 = new WindowsFormsApp_StudentAutomayionSystem.TeacherLogin();
            this.studnetLogin1 = new WindowsFormsApp_StudentAutomayionSystem.StudnetLogin();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Teather";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacherLogin1
            // 
            this.teacherLogin1.Location = new System.Drawing.Point(323, 66);
            this.teacherLogin1.Name = "teacherLogin1";
            this.teacherLogin1.Size = new System.Drawing.Size(400, 300);
            this.teacherLogin1.TabIndex = 3;
            // 
            // studnetLogin1
            // 
            this.studnetLogin1.Location = new System.Drawing.Point(323, 66);
            this.studnetLogin1.Name = "studnetLogin1";
            this.studnetLogin1.Size = new System.Drawing.Size(400, 300);
            this.studnetLogin1.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teacherLogin1);
            this.Controls.Add(this.studnetLogin1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private StudnetLogin studnetLogin1;
        private TeacherLogin teacherLogin1;
    }
}

