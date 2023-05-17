namespace VotingSystem
{
    partial class UC_Partylist
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.PartylistID_lbl = new System.Windows.Forms.Label();
            this.PartylistName_lbl = new System.Windows.Forms.Label();
            this.lbl_PartylistName = new System.Windows.Forms.Label();
            this.lbl_partylistID = new System.Windows.Forms.Label();
            this.PB_PLlogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PLlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::VotingSystem.Properties.Resources.icons8_trash_can_64;
            this.btn_delete.Location = new System.Drawing.Point(689, 35);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 62);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = global::VotingSystem.Properties.Resources.icons8_pencil_64__1_;
            this.btn_edit.Location = new System.Drawing.Point(615, 35);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(68, 62);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // PartylistID_lbl
            // 
            this.PartylistID_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartylistID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.PartylistID_lbl.Location = new System.Drawing.Point(252, 56);
            this.PartylistID_lbl.Name = "PartylistID_lbl";
            this.PartylistID_lbl.Size = new System.Drawing.Size(79, 19);
            this.PartylistID_lbl.TabIndex = 17;
            // 
            // PartylistName_lbl
            // 
            this.PartylistName_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartylistName_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.PartylistName_lbl.Location = new System.Drawing.Point(375, 56);
            this.PartylistName_lbl.Name = "PartylistName_lbl";
            this.PartylistName_lbl.Size = new System.Drawing.Size(154, 19);
            this.PartylistName_lbl.TabIndex = 16;
            // 
            // lbl_PartylistName
            // 
            this.lbl_PartylistName.AutoSize = true;
            this.lbl_PartylistName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PartylistName.Location = new System.Drawing.Point(375, 18);
            this.lbl_PartylistName.Name = "lbl_PartylistName";
            this.lbl_PartylistName.Size = new System.Drawing.Size(102, 19);
            this.lbl_PartylistName.TabIndex = 14;
            this.lbl_PartylistName.Text = "Partylist Name:";
            // 
            // lbl_partylistID
            // 
            this.lbl_partylistID.AutoSize = true;
            this.lbl_partylistID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partylistID.Location = new System.Drawing.Point(252, 18);
            this.lbl_partylistID.Name = "lbl_partylistID";
            this.lbl_partylistID.Size = new System.Drawing.Size(79, 19);
            this.lbl_partylistID.TabIndex = 13;
            this.lbl_partylistID.Text = "Partylist ID:";
            // 
            // PB_PLlogo
            // 
            this.PB_PLlogo.BackColor = System.Drawing.Color.Transparent;
            this.PB_PLlogo.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.PB_PLlogo.Location = new System.Drawing.Point(36, 18);
            this.PB_PLlogo.Name = "PB_PLlogo";
            this.PB_PLlogo.Size = new System.Drawing.Size(92, 94);
            this.PB_PLlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_PLlogo.TabIndex = 12;
            this.PB_PLlogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 3);
            this.panel2.TabIndex = 21;
            // 
            // UC_Partylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PB_PLlogo);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.PartylistID_lbl);
            this.Controls.Add(this.PartylistName_lbl);
            this.Controls.Add(this.lbl_PartylistName);
            this.Controls.Add(this.lbl_partylistID);
            this.Name = "UC_Partylist";
            this.Size = new System.Drawing.Size(781, 131);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PLlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label PartylistID_lbl;
        private System.Windows.Forms.Label PartylistName_lbl;
        private System.Windows.Forms.Label lbl_PartylistName;
        private System.Windows.Forms.Label lbl_partylistID;
        private System.Windows.Forms.PictureBox PB_PLlogo;
        private System.Windows.Forms.Panel panel2;
    }
}
