namespace WindowsFormsApp_StudentAutomayionSystem.Student
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxnumber = new System.Windows.Forms.TextBox();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxshowpassword = new System.Windows.Forms.CheckBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backtohome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Studnet Number";
            // 
            // textboxnumber
            // 
            this.textboxnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textboxnumber.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxnumber.Location = new System.Drawing.Point(44, 130);
            this.textboxnumber.Name = "textboxnumber";
            this.textboxnumber.Size = new System.Drawing.Size(216, 34);
            this.textboxnumber.TabIndex = 2;
            // 
            // textboxpassword
            // 
            this.textboxpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textboxpassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxpassword.Location = new System.Drawing.Point(44, 212);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(216, 34);
            this.textboxpassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(41, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // checkboxshowpassword
            // 
            this.checkboxshowpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkboxshowpassword.AutoSize = true;
            this.checkboxshowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxshowpassword.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxshowpassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkboxshowpassword.Location = new System.Drawing.Point(120, 252);
            this.checkboxshowpassword.Name = "checkboxshowpassword";
            this.checkboxshowpassword.Size = new System.Drawing.Size(142, 19);
            this.checkboxshowpassword.TabIndex = 5;
            this.checkboxshowpassword.Text = "Show Password";
            this.checkboxshowpassword.UseVisualStyleBackColor = true;
            this.checkboxshowpassword.CheckedChanged += new System.EventHandler(this.checkboxshowpassword_CheckedChanged);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.FlatAppearance.BorderSize = 0;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(44, 299);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(216, 35);
            this.buttonlogin.TabIndex = 6;
            this.buttonlogin.Text = "LOGIN";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonclear.BackColor = System.Drawing.Color.White;
            this.buttonclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonclear.FlatAppearance.BorderSize = 0;
            this.buttonclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonclear.Location = new System.Drawing.Point(44, 351);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(216, 35);
            this.buttonclear.TabIndex = 7;
            this.buttonclear.Text = "CLEAR";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(61, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Login as a Teacher";
            // 
            // backtohome
            // 
            this.backtohome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backtohome.AutoSize = true;
            this.backtohome.BackColor = System.Drawing.Color.White;
            this.backtohome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtohome.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtohome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backtohome.Location = new System.Drawing.Point(61, 427);
            this.backtohome.Name = "backtohome";
            this.backtohome.Size = new System.Drawing.Size(127, 17);
            this.backtohome.TabIndex = 9;
            this.backtohome.Text = "Back to HOME";
            this.backtohome.Click += new System.EventHandler(this.backtohome_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 493);
            this.Controls.Add(this.backtohome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.checkboxshowpassword);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxnumber;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkboxshowpassword;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label backtohome;
    }
}