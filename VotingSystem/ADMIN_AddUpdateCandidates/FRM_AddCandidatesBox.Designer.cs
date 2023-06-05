namespace VotingSystem
{
    partial class FRM_AddCandidatesBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AddCandidatesBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_InsertPhoto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_Partylist = new System.Windows.Forms.ComboBox();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.BTN_AddCandidate = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TXTBX_Name = new System.Windows.Forms.TextBox();
            this.CB_Course = new System.Windows.Forms.ComboBox();
            this.CB_Position = new System.Windows.Forms.ComboBox();
            this.PB_Candidate = new System.Windows.Forms.PictureBox();
            this.CB_Elections = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Candidate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Candidates";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_InsertPhoto
            // 
            this.BTN_InsertPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_InsertPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_InsertPhoto.ForeColor = System.Drawing.Color.White;
            this.BTN_InsertPhoto.Location = new System.Drawing.Point(46, 257);
            this.BTN_InsertPhoto.Name = "BTN_InsertPhoto";
            this.BTN_InsertPhoto.Size = new System.Drawing.Size(92, 32);
            this.BTN_InsertPhoto.TabIndex = 3;
            this.BTN_InsertPhoto.Text = "Insert Photo";
            this.BTN_InsertPhoto.UseVisualStyleBackColor = false;
            this.BTN_InsertPhoto.Click += new System.EventHandler(this.BTN_InsertPhoto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Course:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Position:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "PartyList:";
            // 
            // CB_Partylist
            // 
            this.CB_Partylist.FormattingEnabled = true;
            this.CB_Partylist.Location = new System.Drawing.Point(179, 230);
            this.CB_Partylist.Name = "CB_Partylist";
            this.CB_Partylist.Size = new System.Drawing.Size(175, 21);
            this.CB_Partylist.TabIndex = 11;
            this.CB_Partylist.SelectedIndexChanged += new System.EventHandler(this.CB_Partylist_SelectedIndexChanged);
            // 
            // CB_Year
            // 
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th"});
            this.CB_Year.Location = new System.Drawing.Point(360, 168);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(175, 21);
            this.CB_Year.TabIndex = 12;
            // 
            // BTN_AddCandidate
            // 
            this.BTN_AddCandidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_AddCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddCandidate.ForeColor = System.Drawing.Color.White;
            this.BTN_AddCandidate.Location = new System.Drawing.Point(360, 314);
            this.BTN_AddCandidate.Name = "BTN_AddCandidate";
            this.BTN_AddCandidate.Size = new System.Drawing.Size(93, 32);
            this.BTN_AddCandidate.TabIndex = 13;
            this.BTN_AddCandidate.Text = "Add Candidate";
            this.BTN_AddCandidate.UseVisualStyleBackColor = false;
            this.BTN_AddCandidate.Click += new System.EventHandler(this.BTN_AddCandidate_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancel.ForeColor = System.Drawing.Color.White;
            this.BTN_Cancel.Location = new System.Drawing.Point(459, 314);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(95, 32);
            this.BTN_Cancel.TabIndex = 14;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // TXTBX_Name
            // 
            this.TXTBX_Name.Location = new System.Drawing.Point(179, 104);
            this.TXTBX_Name.Name = "TXTBX_Name";
            this.TXTBX_Name.Size = new System.Drawing.Size(175, 20);
            this.TXTBX_Name.TabIndex = 16;
            // 
            // CB_Course
            // 
            this.CB_Course.FormattingEnabled = true;
            this.CB_Course.Items.AddRange(new object[] {
            "Bachelor of Science in Information Technology",
            "Bachelore of Science in Computer Engineering",
            "Bachelore of Science in Hospitality Management",
            "Bachelore of Science in Business Administration",
            "Bachelor of Science in Accounting Information Systems"});
            this.CB_Course.Location = new System.Drawing.Point(179, 168);
            this.CB_Course.Name = "CB_Course";
            this.CB_Course.Size = new System.Drawing.Size(175, 21);
            this.CB_Course.TabIndex = 18;
            // 
            // CB_Position
            // 
            this.CB_Position.FormattingEnabled = true;
            this.CB_Position.Items.AddRange(new object[] {
            "President",
            "Vice-President",
            "Secretary",
            "1st year representative",
            "2nd year representative",
            "3rd year representative",
            "4th year representative"});
            this.CB_Position.Location = new System.Drawing.Point(360, 230);
            this.CB_Position.Name = "CB_Position";
            this.CB_Position.Size = new System.Drawing.Size(175, 21);
            this.CB_Position.TabIndex = 19;
            // 
            // PB_Candidate
            // 
            this.PB_Candidate.Image = ((System.Drawing.Image)(resources.GetObject("PB_Candidate.Image")));
            this.PB_Candidate.Location = new System.Drawing.Point(12, 104);
            this.PB_Candidate.Name = "PB_Candidate";
            this.PB_Candidate.Size = new System.Drawing.Size(158, 147);
            this.PB_Candidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Candidate.TabIndex = 2;
            this.PB_Candidate.TabStop = false;
            // 
            // CB_Elections
            // 
            this.CB_Elections.FormattingEnabled = true;
            this.CB_Elections.Location = new System.Drawing.Point(360, 103);
            this.CB_Elections.Name = "CB_Elections";
            this.CB_Elections.Size = new System.Drawing.Size(175, 21);
            this.CB_Elections.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Election";
            // 
            // FRM_AddCandidatesBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 358);
            this.Controls.Add(this.CB_Elections);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Position);
            this.Controls.Add(this.CB_Course);
            this.Controls.Add(this.TXTBX_Name);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_AddCandidate);
            this.Controls.Add(this.CB_Year);
            this.Controls.Add(this.CB_Partylist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_InsertPhoto);
            this.Controls.Add(this.PB_Candidate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AddCandidatesBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AddCandidates";
            this.Load += new System.EventHandler(this.FRM_AddCandidates_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Candidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_Candidate;
        private System.Windows.Forms.Button BTN_InsertPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_Partylist;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.Button BTN_AddCandidate;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TXTBX_Name;
        private System.Windows.Forms.ComboBox CB_Course;
        private System.Windows.Forms.ComboBox CB_Position;
        private System.Windows.Forms.ComboBox CB_Elections;
        private System.Windows.Forms.Label label4;
    }
}