namespace VotingSystem
{
    partial class FRM_Position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Position));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Minimize_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Position information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.icons8_user_account_96;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_btn.Image")));
            this.Minimize_btn.Location = new System.Drawing.Point(771, 0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(29, 27);
            this.Minimize_btn.TabIndex = 7;
            this.Minimize_btn.Text = " ";
            this.Minimize_btn.UseVisualStyleBackColor = true;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::VotingSystem.Properties.Resources.icons8_close_32;
            this.button1.Location = new System.Drawing.Point(806, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 510);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Position";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button button1;
    }
}