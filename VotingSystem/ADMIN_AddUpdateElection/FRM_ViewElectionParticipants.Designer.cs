namespace VotingSystem.ADMIN_AddUpdateElection
{
    partial class FRM_ViewElectionParticipants
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
            this.label2 = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FL_Elections = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 90);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Election ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_btn
            // 
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Image = global::VotingSystem.Properties.Resources.icons8_left_50;
            this.Back_btn.Location = new System.Drawing.Point(353, 44);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(46, 36);
            this.Back_btn.TabIndex = 9;
            this.Back_btn.Text = " ";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members";
            // 
            // FL_Elections
            // 
            this.FL_Elections.AutoScroll = true;
            this.FL_Elections.BackColor = System.Drawing.SystemColors.Menu;
            this.FL_Elections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FL_Elections.Location = new System.Drawing.Point(0, 90);
            this.FL_Elections.Name = "FL_Elections";
            this.FL_Elections.Size = new System.Drawing.Size(399, 270);
            this.FL_Elections.TabIndex = 3;
            this.FL_Elections.Paint += new System.Windows.Forms.PaintEventHandler(this.FL_Elections_Paint);
            // 
            // FRM_ViewElectionParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 360);
            this.Controls.Add(this.FL_Elections);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ViewElectionParticipants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ViewElectionParticipants";
            this.Load += new System.EventHandler(this.FRM_ViewElectionParticipants_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FL_Elections;
    }
}