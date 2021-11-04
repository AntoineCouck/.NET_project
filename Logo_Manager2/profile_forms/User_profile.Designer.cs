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
            this.components = new System.ComponentModel.Container();
            this.title_profile_patient = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_paztient_insurance = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.testsList = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logo_managerDataSet = new Logo_Manager2.Logo_managerDataSet();
            this.btn_add_test_to_patient = new System.Windows.Forms.Button();
            this.testsTableAdapter = new Logo_Manager2.Logo_managerDataSetTableAdapters.TestsTableAdapter();
            this.testsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_managerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_profile_patient
            // 
            this.title_profile_patient.AutoSize = true;
            this.title_profile_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_profile_patient.Location = new System.Drawing.Point(270, 40);
            this.title_profile_patient.Name = "title_profile_patient";
            this.title_profile_patient.Size = new System.Drawing.Size(104, 26);
            this.title_profile_patient.TabIndex = 26;
            this.title_profile_patient.Text = "Profile of ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.input_paztient_insurance);
            this.groupBox1.Controls.Add(this.profile_info_followBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.profile_info_lastname);
            this.groupBox1.Controls.Add(this.profile_info_birthday);
            this.groupBox1.Controls.Add(this.profile_info_firstname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(134, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 174);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // input_paztient_insurance
            // 
            this.input_paztient_insurance.BackColor = System.Drawing.SystemColors.Menu;
            this.input_paztient_insurance.Enabled = false;
            this.input_paztient_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_paztient_insurance.Location = new System.Drawing.Point(15, 128);
            this.input_paztient_insurance.Name = "input_paztient_insurance";
            this.input_paztient_insurance.Size = new System.Drawing.Size(146, 26);
            this.input_paztient_insurance.TabIndex = 5;
            // 
            // profile_info_followBy
            // 
            this.profile_info_followBy.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_followBy.Enabled = false;
            this.profile_info_followBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.profile_info_followBy.Location = new System.Drawing.Point(215, 128);
            this.profile_info_followBy.Name = "profile_info_followBy";
            this.profile_info_followBy.Size = new System.Drawing.Size(114, 23);
            this.profile_info_followBy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(248, 109);
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
            this.groupBox2.Location = new System.Drawing.Point(134, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 201);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sessions manager";
            // 
            // button_save
            // 
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            this.label4.Size = new System.Drawing.Size(51, 16);
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
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add";
            // 
            // input_patient_remove
            // 
            this.input_patient_remove.Location = new System.Drawing.Point(209, 117);
            this.input_patient_remove.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.input_patient_remove.Name = "input_patient_remove";
            this.input_patient_remove.Size = new System.Drawing.Size(120, 23);
            this.input_patient_remove.TabIndex = 1;
            // 
            // input_patient_add
            // 
            this.input_patient_add.Location = new System.Drawing.Point(27, 117);
            this.input_patient_add.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.input_patient_add.Name = "input_patient_add";
            this.input_patient_add.Size = new System.Drawing.Size(120, 23);
            this.input_patient_add.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(270, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(655, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Passed tests";
            // 
            // testsList
            // 
            this.testsList.FormattingEnabled = true;
            this.testsList.Location = new System.Drawing.Point(622, 174);
            this.testsList.Name = "testsList";
            this.testsList.Size = new System.Drawing.Size(212, 303);
            this.testsList.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.testsBindingSource, "Name", true));
            this.comboBox1.DataSource = this.testsBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(622, 493);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "Name";
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.logo_managerDataSet;
            // 
            // logo_managerDataSet
            // 
            this.logo_managerDataSet.DataSetName = "Logo_managerDataSet";
            this.logo_managerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_add_test_to_patient
            // 
            this.btn_add_test_to_patient.Location = new System.Drawing.Point(684, 530);
            this.btn_add_test_to_patient.Name = "btn_add_test_to_patient";
            this.btn_add_test_to_patient.Size = new System.Drawing.Size(75, 23);
            this.btn_add_test_to_patient.TabIndex = 33;
            this.btn_add_test_to_patient.Text = "button1";
            this.btn_add_test_to_patient.UseVisualStyleBackColor = true;
            this.btn_add_test_to_patient.Click += new System.EventHandler(this.btn_add_test_to_patient_Click);
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // testsBindingSource1
            // 
            this.testsBindingSource1.DataMember = "Tests";
            this.testsBindingSource1.DataSource = this.logo_managerDataSet;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(215, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(248, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Follow by";
            // 
            // User_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 601);
            this.Controls.Add(this.btn_add_test_to_patient);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.testsList);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_managerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox testsList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_add_test_to_patient;
        private Logo_managerDataSet logo_managerDataSet;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private Logo_managerDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.TextBox input_paztient_insurance;
        private System.Windows.Forms.BindingSource testsBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}