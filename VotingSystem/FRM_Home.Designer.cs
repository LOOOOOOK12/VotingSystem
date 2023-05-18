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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Candidates = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Election_btn = new System.Windows.Forms.Button();
            this.Voters_btn = new System.Windows.Forms.Button();
            this.Partylist_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BTN_Candidates);
            this.panel1.Controls.Add(this.Home_btn);
            this.panel1.Controls.Add(this.Logout_btn);
            this.panel1.Controls.Add(this.Election_btn);
            this.panel1.Controls.Add(this.Voters_btn);
            this.panel1.Controls.Add(this.Partylist_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 510);
            this.panel1.TabIndex = 6;
            // 
            // BTN_Candidates
            // 
            this.BTN_Candidates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Candidates.FlatAppearance.BorderSize = 0;
            this.BTN_Candidates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Candidates.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Candidates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_Candidates.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Candidates.Image")));
            this.BTN_Candidates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Candidates.Location = new System.Drawing.Point(0, 167);
            this.BTN_Candidates.Name = "BTN_Candidates";
            this.BTN_Candidates.Size = new System.Drawing.Size(180, 38);
            this.BTN_Candidates.TabIndex = 9;
            this.BTN_Candidates.Text = " Candidates";
            this.BTN_Candidates.UseVisualStyleBackColor = true;
            this.BTN_Candidates.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_btn.FlatAppearance.BorderSize = 0;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.Home_btn.Image = ((System.Drawing.Image)(resources.GetObject("Home_btn.Image")));
            this.Home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_btn.Location = new System.Drawing.Point(0, 123);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(180, 38);
            this.Home_btn.TabIndex = 3;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.Logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("Logout_btn.Image")));
            this.Logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_btn.Location = new System.Drawing.Point(0, 343);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(180, 38);
            this.Logout_btn.TabIndex = 8;
            this.Logout_btn.Text = "Log Out";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Election_btn
            // 
            this.Election_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Election_btn.FlatAppearance.BorderSize = 0;
            this.Election_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Election_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Election_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.Election_btn.Image = ((System.Drawing.Image)(resources.GetObject("Election_btn.Image")));
            this.Election_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Election_btn.Location = new System.Drawing.Point(0, 299);
            this.Election_btn.Name = "Election_btn";
            this.Election_btn.Size = new System.Drawing.Size(180, 38);
            this.Election_btn.TabIndex = 7;
            this.Election_btn.Text = "Election";
            this.Election_btn.UseVisualStyleBackColor = true;
            // 
            // Voters_btn
            // 
            this.Voters_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voters_btn.FlatAppearance.BorderSize = 0;
            this.Voters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voters_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voters_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.Voters_btn.Image = ((System.Drawing.Image)(resources.GetObject("Voters_btn.Image")));
            this.Voters_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Voters_btn.Location = new System.Drawing.Point(0, 255);
            this.Voters_btn.Name = "Voters_btn";
            this.Voters_btn.Size = new System.Drawing.Size(180, 38);
            this.Voters_btn.TabIndex = 6;
            this.Voters_btn.Text = "Voters";
            this.Voters_btn.UseVisualStyleBackColor = true;
            this.Voters_btn.Click += new System.EventHandler(this.Voters_btn_Click);
            // 
            // Partylist_btn
            // 
            this.Partylist_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Partylist_btn.FlatAppearance.BorderSize = 0;
            this.Partylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Partylist_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partylist_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.Partylist_btn.Image = ((System.Drawing.Image)(resources.GetObject("Partylist_btn.Image")));
            this.Partylist_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Partylist_btn.Location = new System.Drawing.Point(0, 211);
            this.Partylist_btn.Name = "Partylist_btn";
            this.Partylist_btn.Size = new System.Drawing.Size(180, 38);
            this.Partylist_btn.TabIndex = 4;
            this.Partylist_btn.Text = "Partylist";
            this.Partylist_btn.UseVisualStyleBackColor = true;
            this.Partylist_btn.Click += new System.EventHandler(this.Partylist_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.Minimize_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 117);
            this.panel2.TabIndex = 7;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_btn.Image")));
            this.Minimize_btn.Location = new System.Drawing.Point(623, 0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(29, 27);
            this.Minimize_btn.TabIndex = 2;
            this.Minimize_btn.Text = " ";
            this.Minimize_btn.UseVisualStyleBackColor = true;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "STI College Of Legazpi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STI Voting System";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button Partylist_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Election_btn;
        private System.Windows.Forms.Button Voters_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button BTN_Candidates;
    }
}