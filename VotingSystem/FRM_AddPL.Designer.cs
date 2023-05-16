namespace VotingSystem
{
    partial class AddingPartyList_FRM
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddPartylist_txtbx = new System.Windows.Forms.TextBox();
            this.addPL_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_logo = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add your Partylist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partylist Name:";
            // 
            // AddPartylist_txtbx
            // 
            this.AddPartylist_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPartylist_txtbx.Location = new System.Drawing.Point(74, 235);
            this.AddPartylist_txtbx.Name = "AddPartylist_txtbx";
            this.AddPartylist_txtbx.Size = new System.Drawing.Size(235, 20);
            this.AddPartylist_txtbx.TabIndex = 2;
            this.AddPartylist_txtbx.TextChanged += new System.EventHandler(this.Partylist_txtbx_TextChanged);
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
            this.addPL_btn.Location = new System.Drawing.Point(231, 278);
            this.addPL_btn.Name = "addPL_btn";
            this.addPL_btn.Size = new System.Drawing.Size(75, 29);
            this.addPL_btn.TabIndex = 3;
            this.addPL_btn.Text = "Add Partylist";
            this.addPL_btn.UseVisualStyleBackColor = false;
            this.addPL_btn.Click += new System.EventHandler(this.addPL_btn_Click);
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
            this.button2.Location = new System.Drawing.Point(312, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.ForeColor = System.Drawing.Color.White;
            this.btn_logo.Location = new System.Drawing.Point(150, 177);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(100, 23);
            this.btn_logo.TabIndex = 6;
            this.btn_logo.Text = "Insert Logo";
            this.btn_logo.UseVisualStyleBackColor = false;
            this.btn_logo.Click += new System.EventHandler(this.btn_logo_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.pb_logo.Location = new System.Drawing.Point(150, 76);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(100, 95);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 5;
            this.pb_logo.TabStop = false;
            // 
            // AddingPartyList_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 319);
            this.Controls.Add(this.btn_logo);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPL_btn);
            this.Controls.Add(this.AddPartylist_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddingPartyList_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STI Voting System";
            this.Load += new System.EventHandler(this.AddingPartyList_FRM_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddPartylist_txtbx;
        private System.Windows.Forms.Button addPL_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_logo;
    }
}