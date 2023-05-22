namespace VotingSystem
{
    partial class FRM_EditPartylist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Updatelogo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addPL_btn = new System.Windows.Forms.Button();
            this.TXTBX_UpdatePL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTBX_PartylistID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update your Partylist";
            // 
            // btn_Updatelogo
            // 
            this.btn_Updatelogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_Updatelogo.FlatAppearance.BorderSize = 0;
            this.btn_Updatelogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Updatelogo.ForeColor = System.Drawing.Color.White;
            this.btn_Updatelogo.Location = new System.Drawing.Point(149, 177);
            this.btn_Updatelogo.Name = "btn_Updatelogo";
            this.btn_Updatelogo.Size = new System.Drawing.Size(100, 23);
            this.btn_Updatelogo.TabIndex = 12;
            this.btn_Updatelogo.Text = "Insert Logo";
            this.btn_Updatelogo.UseVisualStyleBackColor = false;
            this.btn_Updatelogo.Click += new System.EventHandler(this.btn_Updatelogo_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(311, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPL_btn
            // 
            this.addPL_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPL_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.addPL_btn.FlatAppearance.BorderSize = 0;
            this.addPL_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPL_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPL_btn.ForeColor = System.Drawing.Color.White;
            this.addPL_btn.Location = new System.Drawing.Point(230, 330);
            this.addPL_btn.Name = "addPL_btn";
            this.addPL_btn.Size = new System.Drawing.Size(75, 28);
            this.addPL_btn.TabIndex = 9;
            this.addPL_btn.Text = "Update Partylist";
            this.addPL_btn.UseVisualStyleBackColor = false;
            this.addPL_btn.Click += new System.EventHandler(this.addPL_btn_Click);
            // 
            // TXTBX_UpdatePL
            // 
            this.TXTBX_UpdatePL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_UpdatePL.Location = new System.Drawing.Point(70, 281);
            this.TXTBX_UpdatePL.Name = "TXTBX_UpdatePL";
            this.TXTBX_UpdatePL.Size = new System.Drawing.Size(235, 20);
            this.TXTBX_UpdatePL.TabIndex = 8;
            this.TXTBX_UpdatePL.TextChanged += new System.EventHandler(this.TXTBX_UpdatePL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Partylist Name:";
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.pb_logo.Location = new System.Drawing.Point(149, 76);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(100, 95);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 11;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.pb_logo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Partylist ID:";
            // 
            // TXTBX_PartylistID
            // 
            this.TXTBX_PartylistID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBX_PartylistID.Location = new System.Drawing.Point(70, 228);
            this.TXTBX_PartylistID.Name = "TXTBX_PartylistID";
            this.TXTBX_PartylistID.Size = new System.Drawing.Size(235, 20);
            this.TXTBX_PartylistID.TabIndex = 14;
            this.TXTBX_PartylistID.TextChanged += new System.EventHandler(this.TXTBX_PartylistID_TextChanged);
            // 
            // FRM_EditPartylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTBX_PartylistID);
            this.Controls.Add(this.btn_Updatelogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPL_btn);
            this.Controls.Add(this.TXTBX_UpdatePL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_EditPartylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EditPartylist";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Updatelogo;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addPL_btn;
        private System.Windows.Forms.TextBox TXTBX_UpdatePL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTBX_PartylistID;
    }
}