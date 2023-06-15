namespace VotingSystem.ADMIN_AddUpdateElection
{
    partial class UC_ElectionMembers
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
            this.LBL_PLID = new System.Windows.Forms.Label();
            this.LBL_PLName = new System.Windows.Forms.Label();
            this.PB_Partylist = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Partylist)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_PLID
            // 
            this.LBL_PLID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PLID.Location = new System.Drawing.Point(39, 141);
            this.LBL_PLID.Name = "LBL_PLID";
            this.LBL_PLID.Size = new System.Drawing.Size(97, 23);
            this.LBL_PLID.TabIndex = 7;
            this.LBL_PLID.Text = "Partylist ID";
            this.LBL_PLID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_PLName
            // 
            this.LBL_PLName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PLName.Location = new System.Drawing.Point(40, 191);
            this.LBL_PLName.Name = "LBL_PLName";
            this.LBL_PLName.Size = new System.Drawing.Size(97, 23);
            this.LBL_PLName.TabIndex = 5;
            this.LBL_PLName.Text = "PartylistName";
            this.LBL_PLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Partylist
            // 
            this.PB_Partylist.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.PB_Partylist.Location = new System.Drawing.Point(40, 29);
            this.PB_Partylist.Name = "PB_Partylist";
            this.PB_Partylist.Size = new System.Drawing.Size(97, 96);
            this.PB_Partylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Partylist.TabIndex = 4;
            this.PB_Partylist.TabStop = false;
            // 
            // UC_ElectionMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_PLID);
            this.Controls.Add(this.LBL_PLName);
            this.Controls.Add(this.PB_Partylist);
            this.Name = "UC_ElectionMembers";
            this.Size = new System.Drawing.Size(177, 289);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Partylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_PLID;
        private System.Windows.Forms.Label LBL_PLName;
        private System.Windows.Forms.PictureBox PB_Partylist;
    }
}
