namespace VotingSystem
{
    partial class UC_Candidate
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
            this.PB_Clogo = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.LBL_Candidate_ID = new System.Windows.Forms.Label();
            this.LBL_Firstname = new System.Windows.Forms.Label();
            this.lbl_PartylistName = new System.Windows.Forms.Label();
            this.lbl_partylistID = new System.Windows.Forms.Label();
            this.LBL_Middlename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_Lastname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_Position = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Partylist = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_Course = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Clogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Clogo
            // 
            this.PB_Clogo.BackColor = System.Drawing.Color.Transparent;
            this.PB_Clogo.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.PB_Clogo.Location = new System.Drawing.Point(21, 7);
            this.PB_Clogo.Name = "PB_Clogo";
            this.PB_Clogo.Size = new System.Drawing.Size(104, 112);
            this.PB_Clogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Clogo.TabIndex = 13;
            this.PB_Clogo.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::VotingSystem.Properties.Resources.icons8_trash_can_64;
            this.btn_delete.Location = new System.Drawing.Point(694, 35);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 62);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = global::VotingSystem.Properties.Resources.icons8_pencil_64__1_;
            this.btn_edit.Location = new System.Drawing.Point(620, 35);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(68, 62);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // LBL_Candidate_ID
            // 
            this.LBL_Candidate_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Candidate_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Candidate_ID.Location = new System.Drawing.Point(154, 54);
            this.LBL_Candidate_ID.Name = "LBL_Candidate_ID";
            this.LBL_Candidate_ID.Size = new System.Drawing.Size(79, 31);
            this.LBL_Candidate_ID.TabIndex = 23;
            // 
            // LBL_Firstname
            // 
            this.LBL_Firstname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Firstname.Location = new System.Drawing.Point(261, 26);
            this.LBL_Firstname.Name = "LBL_Firstname";
            this.LBL_Firstname.Size = new System.Drawing.Size(141, 19);
            this.LBL_Firstname.TabIndex = 22;
            // 
            // lbl_PartylistName
            // 
            this.lbl_PartylistName.AutoSize = true;
            this.lbl_PartylistName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PartylistName.Location = new System.Drawing.Point(262, 7);
            this.lbl_PartylistName.Name = "lbl_PartylistName";
            this.lbl_PartylistName.Size = new System.Drawing.Size(74, 17);
            this.lbl_PartylistName.TabIndex = 21;
            this.lbl_PartylistName.Text = "First Name:";
            // 
            // lbl_partylistID
            // 
            this.lbl_partylistID.AutoSize = true;
            this.lbl_partylistID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partylistID.Location = new System.Drawing.Point(146, 28);
            this.lbl_partylistID.Name = "lbl_partylistID";
            this.lbl_partylistID.Size = new System.Drawing.Size(87, 17);
            this.lbl_partylistID.TabIndex = 20;
            this.lbl_partylistID.Text = "Candidate ID:";
            // 
            // LBL_Middlename
            // 
            this.LBL_Middlename.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Middlename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Middlename.Location = new System.Drawing.Point(261, 66);
            this.LBL_Middlename.Name = "LBL_Middlename";
            this.LBL_Middlename.Size = new System.Drawing.Size(141, 19);
            this.LBL_Middlename.TabIndex = 27;
            this.LBL_Middlename.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Middle Name:";
            // 
            // LBL_Lastname
            // 
            this.LBL_Lastname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Lastname.Location = new System.Drawing.Point(261, 111);
            this.LBL_Lastname.Name = "LBL_Lastname";
            this.LBL_Lastname.Size = new System.Drawing.Size(141, 19);
            this.LBL_Lastname.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Name:";
            // 
            // LBL_Position
            // 
            this.LBL_Position.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Position.Location = new System.Drawing.Point(433, 111);
            this.LBL_Position.Name = "LBL_Position";
            this.LBL_Position.Size = new System.Drawing.Size(141, 19);
            this.LBL_Position.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Position:";
            // 
            // LBL_Partylist
            // 
            this.LBL_Partylist.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Partylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Partylist.Location = new System.Drawing.Point(433, 66);
            this.LBL_Partylist.Name = "LBL_Partylist";
            this.LBL_Partylist.Size = new System.Drawing.Size(141, 19);
            this.LBL_Partylist.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Partylist:";
            // 
            // LBL_Course
            // 
            this.LBL_Course.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Course.Location = new System.Drawing.Point(433, 26);
            this.LBL_Course.Name = "LBL_Course";
            this.LBL_Course.Size = new System.Drawing.Size(141, 19);
            this.LBL_Course.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Course:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 3);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(778, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 138);
            this.panel1.TabIndex = 23;
            // 
            // UC_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LBL_Position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_Partylist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBL_Course);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBL_Lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_Middlename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.LBL_Candidate_ID);
            this.Controls.Add(this.LBL_Firstname);
            this.Controls.Add(this.lbl_PartylistName);
            this.Controls.Add(this.lbl_partylistID);
            this.Controls.Add(this.PB_Clogo);
            this.Name = "UC_Candidate";
            this.Size = new System.Drawing.Size(781, 141);
            this.Load += new System.EventHandler(this.UC_Candidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Clogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Clogo;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label LBL_Candidate_ID;
        private System.Windows.Forms.Label LBL_Firstname;
        private System.Windows.Forms.Label lbl_PartylistName;
        private System.Windows.Forms.Label lbl_partylistID;
        private System.Windows.Forms.Label LBL_Middlename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_Lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_Position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Partylist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_Course;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
