namespace VotingSystem
{
    partial class UC_ElectionTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ElectionTitle));
            this.LBL_ElectionTitle = new System.Windows.Forms.Label();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_ElectionID = new System.Windows.Forms.Label();
            this.BTN_View = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_ElectionTitle
            // 
            this.LBL_ElectionTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ElectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_ElectionTitle.Location = new System.Drawing.Point(185, 13);
            this.LBL_ElectionTitle.Name = "LBL_ElectionTitle";
            this.LBL_ElectionTitle.Size = new System.Drawing.Size(406, 105);
            this.LBL_ElectionTitle.TabIndex = 0;
            this.LBL_ElectionTitle.Text = "Election Title";
            this.LBL_ElectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ElectionTitle.Click += new System.EventHandler(this.LBL_ElectionTitle_Click);
            // 
            // LBL_Description
            // 
            this.LBL_Description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_Description.Location = new System.Drawing.Point(266, 132);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(239, 76);
            this.LBL_Description.TabIndex = 1;
            this.LBL_Description.Text = "Election Description";
            this.LBL_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Election ID:";
            // 
            // LBL_ElectionID
            // 
            this.LBL_ElectionID.AutoSize = true;
            this.LBL_ElectionID.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ElectionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.LBL_ElectionID.Location = new System.Drawing.Point(97, 99);
            this.LBL_ElectionID.Name = "LBL_ElectionID";
            this.LBL_ElectionID.Size = new System.Drawing.Size(0, 19);
            this.LBL_ElectionID.TabIndex = 3;
            // 
            // BTN_View
            // 
            this.BTN_View.BackgroundImage = global::VotingSystem.Properties.Resources.icons8_eye_48;
            this.BTN_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_View.FlatAppearance.BorderSize = 0;
            this.BTN_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_View.Location = new System.Drawing.Point(636, 68);
            this.BTN_View.Name = "BTN_View";
            this.BTN_View.Size = new System.Drawing.Size(56, 60);
            this.BTN_View.TabIndex = 22;
            this.BTN_View.UseVisualStyleBackColor = true;
            this.BTN_View.Click += new System.EventHandler(this.BTN_View_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(698, 32);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 62);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(698, 100);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(68, 62);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // UC_ElectionTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BTN_View);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.LBL_ElectionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBL_Description);
            this.Controls.Add(this.LBL_ElectionTitle);
            this.Name = "UC_ElectionTitle";
            this.Size = new System.Drawing.Size(781, 214);
            this.Load += new System.EventHandler(this.UC_ElectionTitle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ElectionTitle;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_ElectionID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button BTN_View;
    }
}
