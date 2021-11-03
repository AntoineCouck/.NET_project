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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.patient_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_patient_remove = new System.Windows.Forms.NumericUpDown();
            this.input_patient_add = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_add)).BeginInit();
            this.SuspendLayout();
            // 
            // title_profile_patient
            // 
            this.title_profile_patient.AutoSize = true;
            this.title_profile_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_profile_patient.Location = new System.Drawing.Point(389, 40);
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
            this.groupBox1.Size = new System.Drawing.Size(359, 161);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.button_save);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.patient_total);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.input_patient_remove);
            this.groupBox2.Controls.Add(this.input_patient_add);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(266, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 201);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sessions manager";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(141, 167);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(68, 28);
            this.button_save.TabIndex = 30;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Actual";
            // 
            // patient_total
            // 
            this.patient_total.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.patient_total.Enabled = false;
            this.patient_total.Location = new System.Drawing.Point(152, 67);
            this.patient_total.Name = "patient_total";
            this.patient_total.Size = new System.Drawing.Size(47, 23);
            this.patient_total.TabIndex = 8;
            this.patient_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add";
            // 
            // input_patient_remove
            // 
            this.input_patient_remove.Location = new System.Drawing.Point(209, 117);
            this.input_patient_remove.Name = "input_patient_remove";
            this.input_patient_remove.Size = new System.Drawing.Size(120, 23);
            this.input_patient_remove.TabIndex = 1;
            this.input_patient_remove.ValueChanged += new System.EventHandler(this.input_patient_remove_ValueChanged);
            // 
            // input_patient_add
            // 
            this.input_patient_add.Location = new System.Drawing.Point(27, 117);
            this.input_patient_add.Name = "input_patient_add";
            this.input_patient_add.Size = new System.Drawing.Size(120, 23);
            this.input_patient_add.TabIndex = 0;
            this.input_patient_add.ValueChanged += new System.EventHandler(this.input_patient_add_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(389, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Manager";
            // 
            // User_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_profile_patient);
            this.Name = "User_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_profile";
            this.Load += new System.EventHandler(this.User_profile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_add)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patient_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown input_patient_remove;
        private System.Windows.Forms.NumericUpDown input_patient_add;
    }
}