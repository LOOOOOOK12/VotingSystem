namespace VotingSystem.ADMIN_AddUpdateElection
{
    partial class UC_PartylistMembers
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
            this.PB_Member = new System.Windows.Forms.PictureBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_Position = new System.Windows.Forms.Label();
            this.LBL_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Member
            // 
            this.PB_Member.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.PB_Member.Location = new System.Drawing.Point(39, 21);
            this.PB_Member.Name = "PB_Member";
            this.PB_Member.Size = new System.Drawing.Size(97, 96);
            this.PB_Member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Member.TabIndex = 0;
            this.PB_Member.TabStop = false;
            this.PB_Member.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LBL_Name
            // 
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Name.Location = new System.Drawing.Point(39, 183);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(97, 23);
            this.LBL_Name.TabIndex = 1;
            this.LBL_Name.Text = "Name";
            this.LBL_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Position
            // 
            this.LBL_Position.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Position.Location = new System.Drawing.Point(39, 229);
            this.LBL_Position.Name = "LBL_Position";
            this.LBL_Position.Size = new System.Drawing.Size(97, 23);
            this.LBL_Position.TabIndex = 2;
            this.LBL_Position.Text = "Position";
            this.LBL_Position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_ID
            // 
            this.LBL_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ID.Location = new System.Drawing.Point(38, 133);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(97, 23);
            this.LBL_ID.TabIndex = 3;
            this.LBL_ID.Text = "Partylist ID";
            this.LBL_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_PartylistMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.LBL_Position);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.PB_Member);
            this.Name = "UC_PartylistMembers";
            this.Size = new System.Drawing.Size(174, 289);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Member)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Member;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_Position;
        private System.Windows.Forms.Label LBL_ID;
    }
}
