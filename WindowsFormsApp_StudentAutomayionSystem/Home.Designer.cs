namespace WindowsFormsApp_StudentAutomayionSystem
{
    partial class home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonstudentlogin = new System.Windows.Forms.Button();
            this.buttonteacherlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp_StudentAutomayionSystem.Properties.Resources.logo;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(78, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonstudentlogin
            // 
            this.buttonstudentlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonstudentlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonstudentlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonstudentlogin.FlatAppearance.BorderSize = 0;
            this.buttonstudentlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstudentlogin.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonstudentlogin.ForeColor = System.Drawing.Color.White;
            this.buttonstudentlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonstudentlogin.Location = new System.Drawing.Point(34, 257);
            this.buttonstudentlogin.Name = "buttonstudentlogin";
            this.buttonstudentlogin.Size = new System.Drawing.Size(216, 35);
            this.buttonstudentlogin.TabIndex = 7;
            this.buttonstudentlogin.Text = "STUDENT LOGIN";
            this.buttonstudentlogin.UseVisualStyleBackColor = false;
            this.buttonstudentlogin.Click += new System.EventHandler(this.buttonstudentlogin_Click);
            // 
            // buttonteacherlogin
            // 
            this.buttonteacherlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonteacherlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonteacherlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonteacherlogin.FlatAppearance.BorderSize = 0;
            this.buttonteacherlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonteacherlogin.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonteacherlogin.ForeColor = System.Drawing.Color.White;
            this.buttonteacherlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonteacherlogin.Location = new System.Drawing.Point(34, 330);
            this.buttonteacherlogin.Name = "buttonteacherlogin";
            this.buttonteacherlogin.Size = new System.Drawing.Size(216, 35);
            this.buttonteacherlogin.TabIndex = 8;
            this.buttonteacherlogin.Text = "TEACHER LOGIN";
            this.buttonteacherlogin.UseVisualStyleBackColor = false;
            this.buttonteacherlogin.Click += new System.EventHandler(this.buttonteacherlogin_Click);
            // 
            // home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 492);
            this.Controls.Add(this.buttonteacherlogin);
            this.Controls.Add(this.buttonstudentlogin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Automation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonstudentlogin;
        private System.Windows.Forms.Button buttonteacherlogin;
    }
}

