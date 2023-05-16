namespace VotingSystem
{
    partial class FRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.userNametxtbx = new System.Windows.Forms.TextBox();
            this.logInbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Password_txtbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNametxtbx
            // 
            this.userNametxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNametxtbx.Location = new System.Drawing.Point(437, 159);
            this.userNametxtbx.Name = "userNametxtbx";
            this.userNametxtbx.Size = new System.Drawing.Size(162, 20);
            this.userNametxtbx.TabIndex = 2;
            this.userNametxtbx.TextChanged += new System.EventHandler(this.userNametxtbx_TextChanged);
            // 
            // logInbtn
            // 
            this.logInbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.logInbtn.FlatAppearance.BorderSize = 0;
            this.logInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInbtn.ForeColor = System.Drawing.Color.White;
            this.logInbtn.Location = new System.Drawing.Point(437, 230);
            this.logInbtn.Name = "logInbtn";
            this.logInbtn.Size = new System.Drawing.Size(162, 45);
            this.logInbtn.TabIndex = 3;
            this.logInbtn.Text = "Log-in";
            this.logInbtn.UseVisualStyleBackColor = false;
            this.logInbtn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "or Sign up?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Password_txtbx
            // 
            this.Password_txtbx.Location = new System.Drawing.Point(437, 204);
            this.Password_txtbx.Name = "Password_txtbx";
            this.Password_txtbx.PasswordChar = '*';
            this.Password_txtbx.Size = new System.Drawing.Size(162, 20);
            this.Password_txtbx.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 418);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(82, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 96);
            this.label6.TabIndex = 3;
            this.label6.Text = "Voting System";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(-1, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "692 Rizal St, Old Albay District, Legazpi City, 4500 Albay";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "STI College of Legazpi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(71, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Image = global::VotingSystem.Properties.Resources.icons8_subtract_32__1_;
            this.Minimize.Location = new System.Drawing.Point(607, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 23);
            this.Minimize.TabIndex = 11;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = global::VotingSystem.Properties.Resources.icons8_close_32__1_;
            this.Exit.Location = new System.Drawing.Point(641, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Click += new System.EventHandler(this.label5_Click);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Password_txtbx);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logInbtn);
            this.Controls.Add(this.userNametxtbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STI Voting System";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userNametxtbx;
        private System.Windows.Forms.Button logInbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password_txtbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}

