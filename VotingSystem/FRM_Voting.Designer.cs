namespace VotingSystem
{
    partial class FRM_Voting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Voting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.BTN_Vote = new System.Windows.Forms.Button();
            this.BTN_Election = new System.Windows.Forms.Button();
            this.BTN_Candidate = new System.Windows.Forms.Button();
            this.BTN_Home = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.uC_Home1 = new VotingSystem.UC_Home();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.ContainerPanel);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTN_Minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 122);
            this.panel1.TabIndex = 3;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Location = new System.Drawing.Point(178, 122);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(657, 388);
            this.ContainerPanel.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(178, 122);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(657, 388);
            this.panel9.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(181, 122);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 8;
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
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.Sidepanel);
            this.panel2.Controls.Add(this.BTN_LogOut);
            this.panel2.Controls.Add(this.BTN_Vote);
            this.panel2.Controls.Add(this.BTN_Election);
            this.panel2.Controls.Add(this.BTN_Candidate);
            this.panel2.Controls.Add(this.BTN_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 388);
            this.panel2.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(178, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(654, 388);
            this.panel8.TabIndex = 8;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.Sidepanel.Location = new System.Drawing.Point(0, 8);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 40);
            this.Sidepanel.TabIndex = 8;
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.FlatAppearance.BorderSize = 0;
            this.BTN_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LogOut.Image")));
            this.BTN_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_LogOut.Location = new System.Drawing.Point(10, 195);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(165, 40);
            this.BTN_LogOut.TabIndex = 9;
            this.BTN_LogOut.Text = "Log out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // BTN_Vote
            // 
            this.BTN_Vote.FlatAppearance.BorderSize = 0;
            this.BTN_Vote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Vote.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Vote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Vote.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Vote.Image")));
            this.BTN_Vote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Vote.Location = new System.Drawing.Point(10, 103);
            this.BTN_Vote.Name = "BTN_Vote";
            this.BTN_Vote.Size = new System.Drawing.Size(165, 40);
            this.BTN_Vote.TabIndex = 8;
            this.BTN_Vote.Text = "Vote";
            this.BTN_Vote.UseVisualStyleBackColor = true;
            this.BTN_Vote.Click += new System.EventHandler(this.BTN_Voters_Click);
            // 
            // BTN_Election
            // 
            this.BTN_Election.FlatAppearance.BorderSize = 0;
            this.BTN_Election.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Election.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Election.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Election.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Election.Image")));
            this.BTN_Election.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Election.Location = new System.Drawing.Point(10, 149);
            this.BTN_Election.Name = "BTN_Election";
            this.BTN_Election.Size = new System.Drawing.Size(165, 40);
            this.BTN_Election.TabIndex = 7;
            this.BTN_Election.Text = "Elections";
            this.BTN_Election.UseVisualStyleBackColor = true;
            this.BTN_Election.Click += new System.EventHandler(this.BTN_Election_Click);
            // 
            // BTN_Candidate
            // 
            this.BTN_Candidate.FlatAppearance.BorderSize = 0;
            this.BTN_Candidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Candidate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Candidate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Candidate.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Candidate.Image")));
            this.BTN_Candidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Candidate.Location = new System.Drawing.Point(10, 57);
            this.BTN_Candidate.Name = "BTN_Candidate";
            this.BTN_Candidate.Size = new System.Drawing.Size(165, 40);
            this.BTN_Candidate.TabIndex = 6;
            this.BTN_Candidate.Text = "Candidate";
            this.BTN_Candidate.UseVisualStyleBackColor = true;
            this.BTN_Candidate.Click += new System.EventHandler(this.BTN_Candidate_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.FlatAppearance.BorderSize = 0;
            this.BTN_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Home.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Home.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Home.Image")));
            this.BTN_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Home.Location = new System.Drawing.Point(10, 8);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(165, 40);
            this.BTN_Home.TabIndex = 4;
            this.BTN_Home.Text = "Home";
            this.BTN_Home.UseVisualStyleBackColor = true;
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // uC_Home1
            // 
            this.uC_Home1.Location = new System.Drawing.Point(178, 122);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(657, 388);
            this.uC_Home1.TabIndex = 5;
            // 
            // FRM_Voting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.uC_Home1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Voting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Voting";
            this.Load += new System.EventHandler(this.FRM_Voting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Button BTN_Vote;
        private System.Windows.Forms.Button BTN_Election;
        private System.Windows.Forms.Button BTN_Candidate;
        private System.Windows.Forms.Button BTN_Home;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private UC_Home uC_Home1;
    }
}