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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PB_PartylistLogo = new System.Windows.Forms.PictureBox();
            this.PB_CandidatePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PartylistLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CandidatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_CandidateName
            // 
            this.LBL_CandidateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CandidateName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CandidateName.Location = new System.Drawing.Point(56, 170);
            this.LBL_CandidateName.Name = "LBL_CandidateName";
            this.LBL_CandidateName.Size = new System.Drawing.Size(100, 21);
            this.LBL_CandidateName.TabIndex = 1;
            this.LBL_CandidateName.Text = "Name";
            this.LBL_CandidateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Partylist
            // 
            this.LBL_Partylist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Partylist.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Partylist.Location = new System.Drawing.Point(56, 217);
            this.LBL_Partylist.Name = "LBL_Partylist";
            this.LBL_Partylist.Size = new System.Drawing.Size(100, 21);
            this.LBL_Partylist.TabIndex = 2;
            this.LBL_Partylist.Text = "Partylist Name";
            this.LBL_Partylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Position
            // 
            this.LBL_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Position.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Position.Location = new System.Drawing.Point(56, 260);
            this.LBL_Position.Name = "LBL_Position";
            this.LBL_Position.Size = new System.Drawing.Size(100, 21);
            this.LBL_Position.TabIndex = 3;
            this.LBL_Position.Text = "Position";
            this.LBL_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 330);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 4);
            this.panel2.TabIndex = 7;
            // 
            // PB_PartylistLogo
            // 
            this.PB_PartylistLogo.Image = global::VotingSystem.Properties.Resources.icons8_picture_32;
            this.PB_PartylistLogo.Location = new System.Drawing.Point(3, 3);
            this.PB_PartylistLogo.Name = "PB_PartylistLogo";
            this.PB_PartylistLogo.Size = new System.Drawing.Size(40, 35);
            this.PB_PartylistLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_PartylistLogo.TabIndex = 5;
            this.PB_PartylistLogo.TabStop = false;
            // 
            // PB_CandidatePic
            // 
            this.PB_CandidatePic.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.PB_CandidatePic.Location = new System.Drawing.Point(56, 47);
            this.PB_CandidatePic.Name = "PB_CandidatePic";
            this.PB_CandidatePic.Size = new System.Drawing.Size(100, 97);
            this.PB_CandidatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_CandidatePic.TabIndex = 0;
            this.PB_CandidatePic.TabStop = false;
            // 
            // UC_Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_PartylistLogo);
            this.Controls.Add(this.LBL_Position);
            this.Controls.Add(this.LBL_Partylist);
            this.Controls.Add(this.LBL_CandidateName);
            this.Controls.Add(this.PB_CandidatePic);
            this.Name = "UC_Participants";
            this.Size = new System.Drawing.Size(210, 330);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PartylistLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CandidatePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_CandidatePic;
        private System.Windows.Forms.Label LBL_CandidateName;
        private System.Windows.Forms.Label LBL_Partylist;
        private System.Windows.Forms.Label LBL_Position;
        private System.Windows.Forms.PictureBox PB_PartylistLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
