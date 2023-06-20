namespace VotingSystem
{
    partial class UC_CountVotes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel6 = new System.Windows.Forms.Panel();
            this.LBL_PartylistName = new System.Windows.Forms.Label();
            this.LBL_COUNT = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel6.Controls.Add(this.LBL_PartylistName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 42);
            this.panel6.TabIndex = 1;
            // 
            // LBL_PartylistName
            // 
            this.LBL_PartylistName.AutoSize = true;
            this.LBL_PartylistName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PartylistName.ForeColor = System.Drawing.Color.White;
            this.LBL_PartylistName.Location = new System.Drawing.Point(39, 11);
            this.LBL_PartylistName.Name = "LBL_PartylistName";
            this.LBL_PartylistName.Size = new System.Drawing.Size(114, 20);
            this.LBL_PartylistName.TabIndex = 13;
            this.LBL_PartylistName.Text = "Partylist Name";
            // 
            // LBL_COUNT
            // 
            this.LBL_COUNT.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_COUNT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_COUNT.Location = new System.Drawing.Point(0, 45);
            this.LBL_COUNT.Name = "LBL_COUNT";
            this.LBL_COUNT.Size = new System.Drawing.Size(186, 132);
            this.LBL_COUNT.TabIndex = 14;
            this.LBL_COUNT.Text = "NUM";
            this.LBL_COUNT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_CountVotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_COUNT);
            this.Controls.Add(this.panel6);
            this.Name = "UC_CountVotes";
            this.Size = new System.Drawing.Size(186, 177);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LBL_PartylistName;
        private System.Windows.Forms.Label LBL_COUNT;
    }
}
