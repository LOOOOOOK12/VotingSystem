namespace VotingSystem
{
    partial class FRM_Election
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Election));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTBX_SearchElection = new System.Windows.Forms.TextBox();
            this.BTN_SearchCandidates = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_AddElection = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.TXTBX_SearchElection);
            this.panel1.Controls.Add(this.BTN_SearchCandidates);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.BTN_Refresh);
            this.panel1.Controls.Add(this.BTN_AddElection);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 95);
            this.panel1.TabIndex = 2;
            // 
            // TXTBX_SearchElection
            // 
            this.TXTBX_SearchElection.Location = new System.Drawing.Point(419, 60);
            this.TXTBX_SearchElection.Name = "TXTBX_SearchElection";
            this.TXTBX_SearchElection.Size = new System.Drawing.Size(165, 20);
            this.TXTBX_SearchElection.TabIndex = 12;
            this.TXTBX_SearchElection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_SearchCandidates
            // 
            this.BTN_SearchCandidates.BackColor = System.Drawing.Color.Yellow;
            this.BTN_SearchCandidates.FlatAppearance.BorderSize = 0;
            this.BTN_SearchCandidates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SearchCandidates.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SearchCandidates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_SearchCandidates.Location = new System.Drawing.Point(295, 50);
            this.BTN_SearchCandidates.Name = "BTN_SearchCandidates";
            this.BTN_SearchCandidates.Size = new System.Drawing.Size(118, 36);
            this.BTN_SearchCandidates.TabIndex = 11;
            this.BTN_SearchCandidates.Text = "Search\r\n";
            this.BTN_SearchCandidates.UseVisualStyleBackColor = false;
            this.BTN_SearchCandidates.Click += new System.EventHandler(this.BTN_SearchCandidates_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Image = ((System.Drawing.Image)(resources.GetObject("Back_btn.Image")));
            this.Back_btn.Location = new System.Drawing.Point(777, 50);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(46, 36);
            this.Back_btn.TabIndex = 8;
            this.Back_btn.Text = " ";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.FlatAppearance.BorderSize = 0;
            this.BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Refresh.Image")));
            this.BTN_Refresh.Location = new System.Drawing.Point(734, 50);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(37, 36);
            this.BTN_Refresh.TabIndex = 7;
            this.BTN_Refresh.Text = " ";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_AddElection
            // 
            this.BTN_AddElection.BackColor = System.Drawing.Color.Yellow;
            this.BTN_AddElection.FlatAppearance.BorderSize = 0;
            this.BTN_AddElection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddElection.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddElection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_AddElection.Location = new System.Drawing.Point(123, 50);
            this.BTN_AddElection.Name = "BTN_AddElection";
            this.BTN_AddElection.Size = new System.Drawing.Size(166, 36);
            this.BTN_AddElection.TabIndex = 6;
            this.BTN_AddElection.Text = "Add Election Title";
            this.BTN_AddElection.UseVisualStyleBackColor = false;
            this.BTN_AddElection.Click += new System.EventHandler(this.BTN_AddElection_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.icons8_election_70;
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
            this.label1.Size = new System.Drawing.Size(172, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Election";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Menu;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 101);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(811, 397);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // FRM_Election
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Election";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Election";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTBX_SearchElection;
        private System.Windows.Forms.Button BTN_SearchCandidates;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_AddElection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}