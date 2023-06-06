namespace VotingSystem
{
    partial class UC_Vote
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
            this.FL_Vote = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FL_Vote
            // 
            this.FL_Vote.AutoScroll = true;
            this.FL_Vote.Location = new System.Drawing.Point(0, 0);
            this.FL_Vote.Name = "FL_Vote";
            this.FL_Vote.Size = new System.Drawing.Size(650, 385);
            this.FL_Vote.TabIndex = 0;
            // 
            // UC_Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FL_Vote);
            this.Name = "UC_Vote";
            this.Size = new System.Drawing.Size(650, 388);
            this.Load += new System.EventHandler(this.UC_Vote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FL_Vote;
    }
}
