namespace VotingSystem
{
    partial class FRM_Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.BTN_Voters = new System.Windows.Forms.Button();
            this.BTN_Election = new System.Windows.Forms.Button();
            this.BTN_Candidate = new System.Windows.Forms.Button();
            this.BTN_Partylist = new System.Windows.Forms.Button();
            this.BTN_Home = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTN_Minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 122);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(645, 81);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(45, 20);
            this.Time.TabIndex = 12;
            this.Time.Text = "Time";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(644, 55);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(57, 26);
            this.Date.TabIndex = 11;
            this.Date.Text = "Date";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 122);
            this.label1.TabIndex = 10;
            this.label1.Text = "STI College Of Legazpi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Minimize
            // 
            this.BTN_Minimize.FlatAppearance.BorderSize = 0;
            this.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Minimize.Image")));
            this.BTN_Minimize.Location = new System.Drawing.Point(794, 0);
            this.BTN_Minimize.Name = "BTN_Minimize";
            this.BTN_Minimize.Size = new System.Drawing.Size(41, 36);
            this.BTN_Minimize.TabIndex = 8;
            this.BTN_Minimize.Text = " ";
            this.BTN_Minimize.UseVisualStyleBackColor = true;
            this.BTN_Minimize.Click += new System.EventHandler(this.BTN_Minimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.Sidepanel);
            this.panel2.Controls.Add(this.BTN_LogOut);
            this.panel2.Controls.Add(this.BTN_Voters);
            this.panel2.Controls.Add(this.BTN_Election);
            this.panel2.Controls.Add(this.BTN_Candidate);
            this.panel2.Controls.Add(this.BTN_Partylist);
            this.panel2.Controls.Add(this.BTN_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 388);
            this.panel2.TabIndex = 3;
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.FlatAppearance.BorderSize = 0;
            this.BTN_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LogOut.Image")));
            this.BTN_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_LogOut.Location = new System.Drawing.Point(12, 278);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(166, 40);
            this.BTN_LogOut.TabIndex = 9;
            this.BTN_LogOut.Text = "Log out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTN_Voters
            // 
            this.BTN_Voters.FlatAppearance.BorderSize = 0;
            this.BTN_Voters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Voters.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Voters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Voters.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Voters.Image")));
            this.BTN_Voters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Voters.Location = new System.Drawing.Point(12, 186);
            this.BTN_Voters.Name = "BTN_Voters";
            this.BTN_Voters.Size = new System.Drawing.Size(166, 40);
            this.BTN_Voters.TabIndex = 8;
            this.BTN_Voters.Text = "Voters";
            this.BTN_Voters.UseVisualStyleBackColor = true;
            this.BTN_Voters.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_Election
            // 
            this.BTN_Election.FlatAppearance.BorderSize = 0;
            this.BTN_Election.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Election.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Election.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Election.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Election.Image")));
            this.BTN_Election.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Election.Location = new System.Drawing.Point(12, 232);
            this.BTN_Election.Name = "BTN_Election";
            this.BTN_Election.Size = new System.Drawing.Size(166, 40);
            this.BTN_Election.TabIndex = 7;
            this.BTN_Election.Text = "Elections";
            this.BTN_Election.UseVisualStyleBackColor = true;
            this.BTN_Election.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_Candidate
            // 
            this.BTN_Candidate.FlatAppearance.BorderSize = 0;
            this.BTN_Candidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Candidate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Candidate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Candidate.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Candidate.Image")));
            this.BTN_Candidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Candidate.Location = new System.Drawing.Point(12, 94);
            this.BTN_Candidate.Name = "BTN_Candidate";
            this.BTN_Candidate.Size = new System.Drawing.Size(166, 40);
            this.BTN_Candidate.TabIndex = 6;
            this.BTN_Candidate.Text = "Candidate";
            this.BTN_Candidate.UseVisualStyleBackColor = true;
            this.BTN_Candidate.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_Partylist
            // 
            this.BTN_Partylist.FlatAppearance.BorderSize = 0;
            this.BTN_Partylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Partylist.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Partylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Partylist.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Partylist.Image")));
            this.BTN_Partylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Partylist.Location = new System.Drawing.Point(12, 140);
            this.BTN_Partylist.Name = "BTN_Partylist";
            this.BTN_Partylist.Size = new System.Drawing.Size(166, 40);
            this.BTN_Partylist.TabIndex = 5;
            this.BTN_Partylist.Text = "Partylist";
            this.BTN_Partylist.UseVisualStyleBackColor = true;
            this.BTN_Partylist.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.FlatAppearance.BorderSize = 0;
            this.BTN_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Home.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Home.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Home.Image")));
            this.BTN_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Home.Location = new System.Drawing.Point(12, 45);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(166, 40);
            this.BTN_Home.TabIndex = 4;
            this.BTN_Home.Text = "Home";
            this.BTN_Home.UseVisualStyleBackColor = true;
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(649, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 174);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.label4.Location = new System.Drawing.Point(0, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 135);
            this.label4.TabIndex = 14;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 42);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registered Voters";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(649, 324);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 174);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.label5.Location = new System.Drawing.Point(0, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 129);
            this.label5.TabIndex = 15;
            this.label5.Text = "VOTERS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 42);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Voters Voted";
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.Sidepanel.Location = new System.Drawing.Point(0, 45);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 40);
            this.Sidepanel.TabIndex = 10;
            // 
            // FRM_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Home";
            this.Load += new System.EventHandler(this.FRM_Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Home;
        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Button BTN_Voters;
        private System.Windows.Forms.Button BTN_Election;
        private System.Windows.Forms.Button BTN_Candidate;
        private System.Windows.Forms.Button BTN_Partylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Sidepanel;
    }
}