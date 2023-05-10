namespace VotingSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_IDnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_Firstname = new System.Windows.Forms.TextBox();
            this.txtb_Lastname = new System.Windows.Forms.TextBox();
            this.txtb_MiddleName = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cyear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.txtb_Cpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID number:";
            // 
            // txtb_IDnumber
            // 
            this.txtb_IDnumber.Location = new System.Drawing.Point(402, 191);
            this.txtb_IDnumber.Name = "txtb_IDnumber";
            this.txtb_IDnumber.Size = new System.Drawing.Size(171, 20);
            this.txtb_IDnumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(402, 245);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.PasswordChar = '*';
            this.txtb_Password.Size = new System.Drawing.Size(171, 20);
            this.txtb_Password.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(241, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = global::VotingSystem.Properties.Resources.icons8_close_32__1_;
            this.Exit.Location = new System.Drawing.Point(642, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Click += new System.EventHandler(this.label5_Click);
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Image = global::VotingSystem.Properties.Resources.icons8_subtract_32__1_;
            this.Minimize.Location = new System.Drawing.Point(612, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 23);
            this.Minimize.TabIndex = 10;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Already have an acconut?";
            // 
            // txtb_Firstname
            // 
            this.txtb_Firstname.Location = new System.Drawing.Point(92, 78);
            this.txtb_Firstname.Name = "txtb_Firstname";
            this.txtb_Firstname.Size = new System.Drawing.Size(171, 20);
            this.txtb_Firstname.TabIndex = 12;
            // 
            // txtb_Lastname
            // 
            this.txtb_Lastname.Location = new System.Drawing.Point(92, 132);
            this.txtb_Lastname.Name = "txtb_Lastname";
            this.txtb_Lastname.Size = new System.Drawing.Size(171, 20);
            this.txtb_Lastname.TabIndex = 13;
            // 
            // txtb_MiddleName
            // 
            this.txtb_MiddleName.Location = new System.Drawing.Point(92, 191);
            this.txtb_MiddleName.Name = "txtb_MiddleName";
            this.txtb_MiddleName.Size = new System.Drawing.Size(171, 20);
            this.txtb_MiddleName.TabIndex = 14;
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Computer Engineering"});
            this.Course.Location = new System.Drawing.Point(402, 78);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(171, 21);
            this.Course.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Last name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Middle name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Course:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Year";
            // 
            // Cyear
            // 
            this.Cyear.FormattingEnabled = true;
            this.Cyear.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th"});
            this.Cyear.Location = new System.Drawing.Point(402, 132);
            this.Cyear.Name = "Cyear";
            this.Cyear.Size = new System.Drawing.Size(71, 21);
            this.Cyear.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(498, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Age";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(502, 133);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(71, 20);
            this.Age.TabIndex = 24;
            // 
            // txtb_Cpassword
            // 
            this.txtb_Cpassword.Location = new System.Drawing.Point(402, 304);
            this.txtb_Cpassword.Name = "txtb_Cpassword";
            this.txtb_Cpassword.PasswordChar = '*';
            this.txtb_Cpassword.Size = new System.Drawing.Size(171, 20);
            this.txtb_Cpassword.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(398, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Confirm Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Birth Date:";
            // 
            // Date
            // 
            this.Date.FormattingEnabled = true;
            this.Date.Location = new System.Drawing.Point(92, 245);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 21);
            this.Date.TabIndex = 29;
            this.Date.Text = "DD";
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.Month.Location = new System.Drawing.Point(146, 245);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(63, 21);
            this.Month.TabIndex = 30;
            this.Month.Text = "MM";
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(215, 245);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(48, 21);
            this.Year.TabIndex = 31;
            this.Year.Text = "YY";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtb_Cpassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cyear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.txtb_MiddleName);
            this.Controls.Add(this.txtb_Lastname);
            this.Controls.Add(this.txtb_Firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtb_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_IDnumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "STI Voting System";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_IDnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_Firstname;
        private System.Windows.Forms.TextBox txtb_Lastname;
        private System.Windows.Forms.TextBox txtb_MiddleName;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cyear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox txtb_Cpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Date;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Year;
    }
}