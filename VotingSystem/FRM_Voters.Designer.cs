namespace VotingSystem
{
    partial class FRM_Voters
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.TXTBX_SearchCandidates = new System.Windows.Forms.TextBox();
            this.BTN_SearchCandidates = new System.Windows.Forms.Button();
            this.AddPartylist_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.TXTBX_SearchCandidates);
            this.panel1.Controls.Add(this.BTN_SearchCandidates);
            this.panel1.Controls.Add(this.AddPartylist_btn);
            this.panel1.Controls.Add(this.Refresh_btn);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voters History\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 381);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Back_btn
            // 
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Image = global::VotingSystem.Properties.Resources.icons8_left_50;
            this.Back_btn.Location = new System.Drawing.Point(777, 61);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(46, 36);
            this.Back_btn.TabIndex = 9;
            this.Back_btn.Text = " ";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.FlatAppearance.BorderSize = 0;
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_btn.Image = global::VotingSystem.Properties.Resources.icons8_refresh_24;
            this.Refresh_btn.Location = new System.Drawing.Point(734, 61);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(37, 36);
            this.Refresh_btn.TabIndex = 10;
            this.Refresh_btn.Text = " ";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            // 
            // TXTBX_SearchCandidates
            // 
            this.TXTBX_SearchCandidates.Location = new System.Drawing.Point(484, 70);
            this.TXTBX_SearchCandidates.Name = "TXTBX_SearchCandidates";
            this.TXTBX_SearchCandidates.Size = new System.Drawing.Size(165, 20);
            this.TXTBX_SearchCandidates.TabIndex = 15;
            this.TXTBX_SearchCandidates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_SearchCandidates
            // 
            this.BTN_SearchCandidates.BackColor = System.Drawing.Color.Yellow;
            this.BTN_SearchCandidates.FlatAppearance.BorderSize = 0;
            this.BTN_SearchCandidates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SearchCandidates.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SearchCandidates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BTN_SearchCandidates.Location = new System.Drawing.Point(161, 60);
            this.BTN_SearchCandidates.Name = "BTN_SearchCandidates";
            this.BTN_SearchCandidates.Size = new System.Drawing.Size(118, 36);
            this.BTN_SearchCandidates.TabIndex = 14;
            this.BTN_SearchCandidates.Text = "Search\r\n";
            this.BTN_SearchCandidates.UseVisualStyleBackColor = false;
            // 
            // AddPartylist_btn
            // 
            this.AddPartylist_btn.BackColor = System.Drawing.Color.Yellow;
            this.AddPartylist_btn.FlatAppearance.BorderSize = 0;
            this.AddPartylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPartylist_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartylist_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.AddPartylist_btn.Location = new System.Drawing.Point(12, 60);
            this.AddPartylist_btn.Name = "AddPartylist_btn";
            this.AddPartylist_btn.Size = new System.Drawing.Size(143, 36);
            this.AddPartylist_btn.TabIndex = 13;
            this.AddPartylist_btn.Text = "Add Candidates";
            this.AddPartylist_btn.UseVisualStyleBackColor = false;
            // 
            // FRM_Voters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Voters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Voters";
            this.Load += new System.EventHandler(this.FRM_Voters_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.TextBox TXTBX_SearchCandidates;
        private System.Windows.Forms.Button BTN_SearchCandidates;
        private System.Windows.Forms.Button AddPartylist_btn;
    }
}