namespace VotingSystem
{
    partial class FRM_AddCandidates
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_logo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_middleName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_partylistNames = new System.Windows.Forms.ComboBox();
            this.partylistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_VotingSystemDataSet = new VotingSystem.DB_VotingSystemDataSet();
            this.partylistTableAdapter = new VotingSystem.DB_VotingSystemDataSetTableAdapters.PartylistTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.addPL_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partylistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VotingSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Candidates";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(487, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search Candidate name:";
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::VotingSystem.Properties.Resources.icons8_male_user_96;
            this.pb_logo.Location = new System.Drawing.Point(12, 76);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(126, 121);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 6;
            this.pb_logo.TabStop = false;
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.ForeColor = System.Drawing.Color.White;
            this.btn_logo.Location = new System.Drawing.Point(24, 203);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(100, 23);
            this.btn_logo.TabIndex = 7;
            this.btn_logo.Text = "Insert Photo";
            this.btn_logo.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "First name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Middle name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Course:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(144, 93);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(0, 17);
            this.lbl_lastName.TabIndex = 15;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(326, 93);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(0, 17);
            this.lbl_firstName.TabIndex = 16;
            // 
            // lbl_middleName
            // 
            this.lbl_middleName.AutoSize = true;
            this.lbl_middleName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_middleName.Location = new System.Drawing.Point(497, 93);
            this.lbl_middleName.Name = "lbl_middleName";
            this.lbl_middleName.Size = new System.Drawing.Size(0, 17);
            this.lbl_middleName.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Year:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(497, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Age:";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.Location = new System.Drawing.Point(144, 203);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(0, 17);
            this.lbl_course.TabIndex = 20;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(326, 203);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(0, 17);
            this.lbl_year.TabIndex = 21;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(497, 203);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(0, 17);
            this.lbl_Age.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(144, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "PartyList:";
            // 
            // CB_partylistNames
            // 
            this.CB_partylistNames.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partylistBindingSource, "PartylistName", true));
            this.CB_partylistNames.FormattingEnabled = true;
            this.CB_partylistNames.Location = new System.Drawing.Point(147, 229);
            this.CB_partylistNames.Name = "CB_partylistNames";
            this.CB_partylistNames.Size = new System.Drawing.Size(179, 21);
            this.CB_partylistNames.TabIndex = 24;
            this.CB_partylistNames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // partylistBindingSource
            // 
            this.partylistBindingSource.DataMember = "Partylist";
            this.partylistBindingSource.DataSource = this.dB_VotingSystemDataSet;
            // 
            // dB_VotingSystemDataSet
            // 
            this.dB_VotingSystemDataSet.DataSetName = "DB_VotingSystemDataSet";
            this.dB_VotingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partylistTableAdapter
            // 
            this.partylistTableAdapter.ClearBeforeFill = true;
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
            this.button2.Location = new System.Drawing.Point(571, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 26;
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
            this.addPL_btn.Location = new System.Drawing.Point(490, 352);
            this.addPL_btn.Name = "addPL_btn";
            this.addPL_btn.Size = new System.Drawing.Size(75, 29);
            this.addPL_btn.TabIndex = 25;
            this.addPL_btn.Text = "Add Partylist";
            this.addPL_btn.UseVisualStyleBackColor = false;
            // 
            // FRM_AddCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPL_btn);
            this.Controls.Add(this.CB_partylistNames);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_middleName);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_logo);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AddCandidates";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.FRM_AddCandidates_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partylistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VotingSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_logo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_middleName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CB_partylistNames;
        private DB_VotingSystemDataSet dB_VotingSystemDataSet;
        private System.Windows.Forms.BindingSource partylistBindingSource;
        private DB_VotingSystemDataSetTableAdapters.PartylistTableAdapter partylistTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addPL_btn;
    }
}