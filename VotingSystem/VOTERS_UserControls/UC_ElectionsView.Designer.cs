namespace VotingSystem.VOTERS_UserControls
{
    partial class UC_ElectionsView
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
            this.LBL_ElectionTitle = new System.Windows.Forms.Label();
            this.BTN_View = new System.Windows.Forms.Button();
            this.LBL_ElectionID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_ElectionTitle
            // 
            this.LBL_ElectionTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ElectionTitle.Location = new System.Drawing.Point(34, 92);
            this.LBL_ElectionTitle.Name = "LBL_ElectionTitle";
            this.LBL_ElectionTitle.Size = new System.Drawing.Size(140, 154);
            this.LBL_ElectionTitle.TabIndex = 0;
            this.LBL_ElectionTitle.Text = "Elections Title";
            this.LBL_ElectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ElectionTitle.Click += new System.EventHandler(this.LBL_ElectionTitle_Click);
            // 
            // BTN_View
            // 
            this.BTN_View.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_View.FlatAppearance.BorderSize = 0;
            this.BTN_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_View.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_View.ForeColor = System.Drawing.Color.White;
            this.BTN_View.Location = new System.Drawing.Point(34, 237);
            this.BTN_View.Name = "BTN_View";
            this.BTN_View.Size = new System.Drawing.Size(140, 43);
            this.BTN_View.TabIndex = 13;
            this.BTN_View.Text = "View";
            this.BTN_View.UseVisualStyleBackColor = false;
            this.BTN_View.Click += new System.EventHandler(this.BTN_View_Click);
            // 
            // LBL_ElectionID
            // 
            this.LBL_ElectionID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ElectionID.Location = new System.Drawing.Point(34, 39);
            this.LBL_ElectionID.Name = "LBL_ElectionID";
            this.LBL_ElectionID.Size = new System.Drawing.Size(140, 29);
            this.LBL_ElectionID.TabIndex = 14;
            this.LBL_ElectionID.Text = "Election ID";
            this.LBL_ElectionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Election ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Election Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_ElectionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_ElectionID);
            this.Controls.Add(this.BTN_View);
            this.Controls.Add(this.LBL_ElectionTitle);
            this.Name = "UC_ElectionsView";
            this.Size = new System.Drawing.Size(205, 311);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_ElectionTitle;
        private System.Windows.Forms.Button BTN_View;
        private System.Windows.Forms.Label LBL_ElectionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
