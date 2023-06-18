namespace VotingSystem.VOTERS_VotingForms
{
    partial class FRM_VotingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_VotingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BTN_Minimize = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.FL_Voting = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.ContainerPanel);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.BTN_Minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 96);
            this.panel1.TabIndex = 4;
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
            // 
            // Back_btn
            // 
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Image = global::VotingSystem.Properties.Resources.icons8_left_50;
            this.Back_btn.Location = new System.Drawing.Point(630, 60);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(46, 36);
            this.Back_btn.TabIndex = 11;
            this.Back_btn.Text = " ";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // FL_Voting
            // 
            this.FL_Voting.AutoScroll = true;
            this.FL_Voting.BackColor = System.Drawing.SystemColors.Control;
            this.FL_Voting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FL_Voting.Location = new System.Drawing.Point(0, 96);
            this.FL_Voting.Name = "FL_Voting";
            this.FL_Voting.Size = new System.Drawing.Size(679, 333);
            this.FL_Voting.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 84);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_VotingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 429);
            this.Controls.Add(this.FL_Voting);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_VotingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_VotingForm";
            this.Load += new System.EventHandler(this.FRM_VotingForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BTN_Minimize;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.FlowLayoutPanel FL_Voting;
        private System.Windows.Forms.Label label2;
    }
}