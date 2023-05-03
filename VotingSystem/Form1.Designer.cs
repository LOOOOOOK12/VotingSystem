namespace VotingSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Passwordtxtbx = new System.Windows.Forms.TextBox();
            this.userNametxtbx = new System.Windows.Forms.TextBox();
            this.logInbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "STI VOTING SYSTEM";
            // 
            // Passwordtxtbx
            // 
            this.Passwordtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passwordtxtbx.Enabled = false;
            this.Passwordtxtbx.Location = new System.Drawing.Point(250, 264);
            this.Passwordtxtbx.Name = "Passwordtxtbx";
            this.Passwordtxtbx.PasswordChar = '*';
            this.Passwordtxtbx.Size = new System.Drawing.Size(162, 20);
            this.Passwordtxtbx.TabIndex = 1;
            // 
            // userNametxtbx
            // 
            this.userNametxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNametxtbx.Location = new System.Drawing.Point(250, 219);
            this.userNametxtbx.Name = "userNametxtbx";
            this.userNametxtbx.Size = new System.Drawing.Size(162, 20);
            this.userNametxtbx.TabIndex = 2;
            // 
            // logInbtn
            // 
            this.logInbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.logInbtn.FlatAppearance.BorderSize = 0;
            this.logInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInbtn.ForeColor = System.Drawing.Color.White;
            this.logInbtn.Location = new System.Drawing.Point(250, 290);
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
            this.label2.Location = new System.Drawing.Point(246, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "or Sign up?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(641, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.label5_Click);
            // 
            // Minimize
            // 
            this.Minimize.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(611, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 27);
            this.Minimize.TabIndex = 11;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logInbtn);
            this.Controls.Add(this.userNametxtbx);
            this.Controls.Add(this.Passwordtxtbx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passwordtxtbx;
        private System.Windows.Forms.TextBox userNametxtbx;
        private System.Windows.Forms.Button logInbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Minimize;
    }
}

