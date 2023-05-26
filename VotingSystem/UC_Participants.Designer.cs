namespace VotingSystem
{
    partial class UC_Participants
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
            this.LBL_CandidateName = new System.Windows.Forms.Label();
            this.LBL_Partylist = new System.Windows.Forms.Label();
            this.LBL_Position = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB_PartylistLogo = new System.Windows.Forms.PictureBox();
            this.PB_CandidatePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PartylistLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CandidatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_CandidateName
            // 
            this.LBL_CandidateName.AutoSize = true;
            this.LBL_CandidateName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CandidateName.Location = new System.Drawing.Point(77, 162);
            this.LBL_CandidateName.Name = "LBL_CandidateName";
            this.LBL_CandidateName.Size = new System.Drawing.Size(46, 19);
            this.LBL_CandidateName.TabIndex = 1;
            this.LBL_CandidateName.Text = "Name";
            this.LBL_CandidateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Partylist
            // 
            this.LBL_Partylist.AutoSize = true;
            this.LBL_Partylist.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Partylist.Location = new System.Drawing.Point(52, 197);
            this.LBL_Partylist.Name = "LBL_Partylist";
            this.LBL_Partylist.Size = new System.Drawing.Size(99, 19);
            this.LBL_Partylist.TabIndex = 2;
            this.LBL_Partylist.Text = "Partylist Name";
            this.LBL_Partylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Position
            // 
            this.LBL_Position.AutoSize = true;
            this.LBL_Position.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Position.Location = new System.Drawing.Point(76, 237);
            this.LBL_Position.Name = "LBL_Position";
            this.LBL_Position.Size = new System.Drawing.Size(58, 19);
            this.LBL_Position.TabIndex = 3;
            this.LBL_Position.Text = "Position";
            this.LBL_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_PartylistLogo
            // 
            this.PB_PartylistLogo.Image = global::VotingSystem.Properties.Resources.icons8_picture_32;
            this.PB_PartylistLogo.Location = new System.Drawing.Point(3, 3);
            this.PB_PartylistLogo.Name = "PB_PartylistLogo";
            this.PB_PartylistLogo.Size = new System.Drawing.Size(40, 35);
            this.PB_PartylistLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_PartylistLogo.TabIndex = 5;
            this.PB_PartylistLogo.TabStop = false;
            // 
            // PB_CandidatePic
            // 
            this.PB_CandidatePic.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.PB_CandidatePic.Location = new System.Drawing.Point(56, 43);
            this.PB_CandidatePic.Name = "PB_CandidatePic";
            this.PB_CandidatePic.Size = new System.Drawing.Size(100, 97);
            this.PB_CandidatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_CandidatePic.TabIndex = 0;
            this.PB_CandidatePic.TabStop = false;
            // 
            // UC_Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PB_PartylistLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_Position);
            this.Controls.Add(this.LBL_Partylist);
            this.Controls.Add(this.LBL_CandidateName);
            this.Controls.Add(this.PB_CandidatePic);
            this.Name = "UC_Participants";
            this.Size = new System.Drawing.Size(210, 330);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PartylistLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CandidatePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_CandidatePic;
        private System.Windows.Forms.Label LBL_CandidateName;
        private System.Windows.Forms.Label LBL_Partylist;
        private System.Windows.Forms.Label LBL_Position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PB_PartylistLogo;
    }
}
