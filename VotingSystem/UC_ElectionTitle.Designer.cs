﻿namespace VotingSystem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_ElectionID = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LBL_ElectionTitle
            // 
            this.LBL_ElectionTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ElectionTitle.ForeColor = System.Drawing.Color.Black;
            this.LBL_ElectionTitle.Location = new System.Drawing.Point(185, 13);
            this.LBL_ElectionTitle.Name = "LBL_ElectionTitle";
            this.LBL_ElectionTitle.Size = new System.Drawing.Size(406, 102);
            this.LBL_ElectionTitle.TabIndex = 0;
            this.LBL_ElectionTitle.Text = "Election Title";
            this.LBL_ElectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ElectionTitle.Click += new System.EventHandler(this.LBL_ElectionTitle_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "Election Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Election ID:";
            // 
            // LBL_ElectionID
            // 
            this.LBL_ElectionID.AutoSize = true;
            this.LBL_ElectionID.Location = new System.Drawing.Point(86, 57);
            this.LBL_ElectionID.Name = "LBL_ElectionID";
            this.LBL_ElectionID.Size = new System.Drawing.Size(0, 13);
            this.LBL_ElectionID.TabIndex = 3;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 3);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(778, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 211);
            this.panel1.TabIndex = 23;
            // 
            // UC_ElectionTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.LBL_ElectionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_ElectionTitle);
            this.Name = "UC_ElectionTitle";
            this.Size = new System.Drawing.Size(781, 214);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_ElectionTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_ElectionID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
