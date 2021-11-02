namespace Logo_Manager2.profile_forms
{
    partial class User_profile
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
            this.title_profile_patient = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profile_info_followBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_info_lastname = new System.Windows.Forms.TextBox();
            this.profile_info_birthday = new System.Windows.Forms.TextBox();
            this.profile_info_firstname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_profile_patient
            // 
            this.title_profile_patient.AutoSize = true;
            this.title_profile_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_profile_patient.Location = new System.Drawing.Point(382, 41);
            this.title_profile_patient.Name = "title_profile_patient";
            this.title_profile_patient.Size = new System.Drawing.Size(104, 26);
            this.title_profile_patient.TabIndex = 26;
            this.title_profile_patient.Text = "Profile of ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.profile_info_followBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.profile_info_lastname);
            this.groupBox1.Controls.Add(this.profile_info_birthday);
            this.groupBox1.Controls.Add(this.profile_info_firstname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(266, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 142);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // profile_info_followBy
            // 
            this.profile_info_followBy.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_followBy.Enabled = false;
            this.profile_info_followBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.profile_info_followBy.Location = new System.Drawing.Point(215, 64);
            this.profile_info_followBy.Name = "profile_info_followBy";
            this.profile_info_followBy.Size = new System.Drawing.Size(114, 23);
            this.profile_info_followBy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(248, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Follow by";
            // 
            // profile_info_lastname
            // 
            this.profile_info_lastname.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_lastname.Enabled = false;
            this.profile_info_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profile_info_lastname.Location = new System.Drawing.Point(15, 64);
            this.profile_info_lastname.Name = "profile_info_lastname";
            this.profile_info_lastname.Size = new System.Drawing.Size(146, 26);
            this.profile_info_lastname.TabIndex = 2;
            // 
            // profile_info_birthday
            // 
            this.profile_info_birthday.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_birthday.Enabled = false;
            this.profile_info_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profile_info_birthday.Location = new System.Drawing.Point(15, 96);
            this.profile_info_birthday.Name = "profile_info_birthday";
            this.profile_info_birthday.Size = new System.Drawing.Size(146, 26);
            this.profile_info_birthday.TabIndex = 1;
            // 
            // profile_info_firstname
            // 
            this.profile_info_firstname.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_firstname.Enabled = false;
            this.profile_info_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profile_info_firstname.Location = new System.Drawing.Point(15, 32);
            this.profile_info_firstname.Name = "profile_info_firstname";
            this.profile_info_firstname.Size = new System.Drawing.Size(146, 26);
            this.profile_info_firstname.TabIndex = 0;
            // 
            // User_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_profile_patient);
            this.Name = "User_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_profile";
            this.Load += new System.EventHandler(this.User_profile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_profile_patient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox profile_info_followBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profile_info_lastname;
        private System.Windows.Forms.TextBox profile_info_birthday;
        private System.Windows.Forms.TextBox profile_info_firstname;
    }
}