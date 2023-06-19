namespace VotingSystem
{
    partial class UC_VotingBtn
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
            this.PB_PartylistLogo = new System.Windows.Forms.PictureBox();
            this.PB_CandidatePic = new System.Windows.Forms.PictureBox();
            this.BTN_Vote = new System.Windows.Forms.Button();
            this.LBL_PartylistName = new System.Windows.Forms.Label();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_Position = new System.Windows.Forms.Label();
            this.LBL_EletionTitle = new System.Windows.Forms.Label();
            this.LBL_Voter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PartylistLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CandidatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_PartylistLogo
            // 
            this.PB_PartylistLogo.Image = global::VotingSystem.Properties.Resources.icons8_picture_32;
            this.PB_PartylistLogo.Location = new System.Drawing.Point(3, 3);
            this.PB_PartylistLogo.Name = "PB_PartylistLogo";
            this.PB_PartylistLogo.Size = new System.Drawing.Size(40, 35);
            this.PB_PartylistLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_PartylistLogo.TabIndex = 11;
            this.PB_PartylistLogo.TabStop = false;
            // 
            // PB_CandidatePic
            // 
            this.PB_CandidatePic.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.PB_CandidatePic.Location = new System.Drawing.Point(60, 90);
            this.PB_CandidatePic.Name = "PB_CandidatePic";
            this.PB_CandidatePic.Size = new System.Drawing.Size(109, 101);
            this.PB_CandidatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_CandidatePic.TabIndex = 10;
            this.PB_CandidatePic.TabStop = false;
            // 
            // BTN_Vote
            // 
            this.BTN_Vote.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_Vote.FlatAppearance.BorderSize = 0;
            this.BTN_Vote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Vote.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Vote.ForeColor = System.Drawing.Color.White;
            this.BTN_Vote.Location = new System.Drawing.Point(60, 296);
            this.BTN_Vote.Name = "BTN_Vote";
            this.BTN_Vote.Size = new System.Drawing.Size(109, 43);
            this.BTN_Vote.TabIndex = 12;
            this.BTN_Vote.Text = "Vote";
            this.BTN_Vote.UseVisualStyleBackColor = false;
            this.BTN_Vote.Click += new System.EventHandler(this.BTN_Vote_Click);
            // 
            // LBL_PartylistName
            // 
            this.LBL_PartylistName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_PartylistName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PartylistName.Location = new System.Drawing.Point(60, 239);
            this.LBL_PartylistName.Name = "LBL_PartylistName";
            this.LBL_PartylistName.Size = new System.Drawing.Size(109, 21);
            this.LBL_PartylistName.TabIndex = 13;
            this.LBL_PartylistName.Text = "Partylist Name";
            this.LBL_PartylistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Name
            // 
            this.LBL_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Name.Location = new System.Drawing.Point(61, 207);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(109, 21);
            this.LBL_Name.TabIndex = 14;
            this.LBL_Name.Text = "Name\r\n";
            this.LBL_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Position
            // 
            this.LBL_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Position.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Position.Location = new System.Drawing.Point(60, 272);
            this.LBL_Position.Name = "LBL_Position";
            this.LBL_Position.Size = new System.Drawing.Size(109, 21);
            this.LBL_Position.TabIndex = 15;
            this.LBL_Position.Text = "Position";
            this.LBL_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_EletionTitle
            // 
            this.LBL_EletionTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_EletionTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EletionTitle.Location = new System.Drawing.Point(61, 3);
            this.LBL_EletionTitle.Name = "LBL_EletionTitle";
            this.LBL_EletionTitle.Size = new System.Drawing.Size(109, 71);
            this.LBL_EletionTitle.TabIndex = 16;
            this.LBL_EletionTitle.Text = "Election Title";
            this.LBL_EletionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Voter
            // 
            this.LBL_Voter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Voter.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Voter.Location = new System.Drawing.Point(60, 347);
            this.LBL_Voter.Name = "LBL_Voter";
            this.LBL_Voter.Size = new System.Drawing.Size(109, 21);
            this.LBL_Voter.TabIndex = 17;
            this.LBL_Voter.Text = "Timestamp";
            this.LBL_Voter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Voter.Click += new System.EventHandler(this.label1_Click);
            // 
            // UC_VotingBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LBL_Voter);
            this.Controls.Add(this.LBL_EletionTitle);
            this.Controls.Add(this.LBL_Position);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.LBL_PartylistName);
            this.Controls.Add(this.BTN_Vote);
            this.Controls.Add(this.PB_PartylistLogo);
            this.Controls.Add(this.PB_CandidatePic);
            this.Name = "UC_VotingBtn";
            this.Size = new System.Drawing.Size(210, 381);
            this.Load += new System.EventHandler(this.UC_VotingBtn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PartylistLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CandidatePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_PartylistLogo;
        private System.Windows.Forms.PictureBox PB_CandidatePic;
        private System.Windows.Forms.Button BTN_Vote;
        private System.Windows.Forms.Label LBL_PartylistName;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_Position;
        private System.Windows.Forms.Label LBL_EletionTitle;
        private System.Windows.Forms.Label LBL_Voter;
    }
}
