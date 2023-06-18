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
            this.SuspendLayout();
            // 
            // LBL_ElectionTitle
            // 
            this.LBL_ElectionTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ElectionTitle.Location = new System.Drawing.Point(30, 26);
            this.LBL_ElectionTitle.Name = "LBL_ElectionTitle";
            this.LBL_ElectionTitle.Size = new System.Drawing.Size(144, 163);
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
            this.BTN_View.Location = new System.Drawing.Point(34, 235);
            this.BTN_View.Name = "BTN_View";
            this.BTN_View.Size = new System.Drawing.Size(140, 43);
            this.BTN_View.TabIndex = 13;
            this.BTN_View.Text = "View";
            this.BTN_View.UseVisualStyleBackColor = false;
            this.BTN_View.Click += new System.EventHandler(this.BTN_View_Click);
            // 
            // UC_ElectionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BTN_View);
            this.Controls.Add(this.LBL_ElectionTitle);
            this.Name = "UC_ElectionsView";
            this.Size = new System.Drawing.Size(205, 311);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_ElectionTitle;
        private System.Windows.Forms.Button BTN_View;
    }
}
