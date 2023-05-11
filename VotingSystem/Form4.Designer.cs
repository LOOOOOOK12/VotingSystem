namespace VotingSystem
{
    partial class FRM_Partylist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.AddPartylist_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.Refresh_btn);
            this.panel1.Controls.Add(this.AddPartylist_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 95);
            this.panel1.TabIndex = 0;
            // 
            // Back_btn
            // 
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Image = global::VotingSystem.Properties.Resources.icons8_left_50;
            this.Back_btn.Location = new System.Drawing.Point(777, 50);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(46, 36);
            this.Back_btn.TabIndex = 8;
            this.Back_btn.Text = " ";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.FlatAppearance.BorderSize = 0;
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_btn.Image = global::VotingSystem.Properties.Resources.icons8_refresh_24;
            this.Refresh_btn.Location = new System.Drawing.Point(734, 50);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(37, 36);
            this.Refresh_btn.TabIndex = 7;
            this.Refresh_btn.Text = " ";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            // 
            // AddPartylist_btn
            // 
            this.AddPartylist_btn.BackColor = System.Drawing.Color.Yellow;
            this.AddPartylist_btn.FlatAppearance.BorderSize = 0;
            this.AddPartylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPartylist_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartylist_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.AddPartylist_btn.Location = new System.Drawing.Point(123, 50);
            this.AddPartylist_btn.Name = "AddPartylist_btn";
            this.AddPartylist_btn.Size = new System.Drawing.Size(118, 36);
            this.AddPartylist_btn.TabIndex = 6;
            this.AddPartylist_btn.Text = "Add Partylist";
            this.AddPartylist_btn.UseVisualStyleBackColor = false;
            this.AddPartylist_btn.Click += new System.EventHandler(this.AddPartylist_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.icons8_user_account_96;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Partylist Information";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 397);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FRM_Partylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Partylist";
            this.Text = "STI Voting System";
            this.Load += new System.EventHandler(this.FRM_Partylist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddPartylist_btn;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}