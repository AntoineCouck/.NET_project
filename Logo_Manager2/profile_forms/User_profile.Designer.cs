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
            this.btn_del_user = new System.Windows.Forms.Button();
            this.btn_modify_user = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.input_paztient_insurance = new System.Windows.Forms.TextBox();
            this.profile_info_followBy = new System.Windows.Forms.TextBox();
            this.profile_info_lastname = new System.Windows.Forms.TextBox();
            this.profile_info_birthday = new System.Windows.Forms.TextBox();
            this.profile_info_firstname = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.patient_total = new System.Windows.Forms.TextBox();
            this.input_patient_remove = new System.Windows.Forms.NumericUpDown();
            this.input_patient_add = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.testsList = new System.Windows.Forms.ListBox();
            this.testsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.logo_manager2DataSet = new Logo_Manager2.Logo_manager2DataSet();
            this.testsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add_test_to_patient = new System.Windows.Forms.Button();
            this.testsTableAdapter1 = new Logo_Manager2.Logo_manager2DataSetTableAdapters.TestsTableAdapter();
            this.testsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.testsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.testsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new Logo_Manager2.Logo_manager2DataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_profile_patient
            // 
            this.title_profile_patient.AutoSize = true;
            this.title_profile_patient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_profile_patient.Location = new System.Drawing.Point(43, 43);
            this.title_profile_patient.Name = "title_profile_patient";
            this.title_profile_patient.Size = new System.Drawing.Size(111, 30);
            this.title_profile_patient.TabIndex = 26;
            this.title_profile_patient.Text = "Profile of ";
            // 
            // btn_del_user
            // 
            this.btn_del_user.BackColor = System.Drawing.Color.Red;
            this.btn_del_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_del_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_user.Location = new System.Drawing.Point(266, 252);
            this.btn_del_user.Name = "btn_del_user";
            this.btn_del_user.Size = new System.Drawing.Size(99, 23);
            this.btn_del_user.TabIndex = 35;
            this.btn_del_user.Text = "Delete user";
            this.btn_del_user.UseVisualStyleBackColor = false;
            this.btn_del_user.Click += new System.EventHandler(this.btn_del_user_Click);
            // 
            // btn_modify_user
            // 
            this.btn_modify_user.BackColor = System.Drawing.Color.Turquoise;
            this.btn_modify_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modify_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modify_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify_user.Location = new System.Drawing.Point(161, 252);
            this.btn_modify_user.Name = "btn_modify_user";
            this.btn_modify_user.Size = new System.Drawing.Size(99, 23);
            this.btn_modify_user.TabIndex = 36;
            this.btn_modify_user.Text = "Modify user";
            this.btn_modify_user.UseVisualStyleBackColor = false;
            this.btn_modify_user.Click += new System.EventHandler(this.btn_modify_user_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(315, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 6;
            // 
            // input_paztient_insurance
            // 
            this.input_paztient_insurance.BackColor = System.Drawing.SystemColors.Menu;
            this.input_paztient_insurance.Enabled = false;
            this.input_paztient_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_paztient_insurance.Location = new System.Drawing.Point(88, 189);
            this.input_paztient_insurance.Name = "input_paztient_insurance";
            this.input_paztient_insurance.Size = new System.Drawing.Size(191, 26);
            this.input_paztient_insurance.TabIndex = 5;
            // 
            // profile_info_followBy
            // 
            this.profile_info_followBy.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_followBy.Enabled = false;
            this.profile_info_followBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.profile_info_followBy.Location = new System.Drawing.Point(315, 125);
            this.profile_info_followBy.Name = "profile_info_followBy";
            this.profile_info_followBy.Size = new System.Drawing.Size(158, 23);
            this.profile_info_followBy.TabIndex = 4;
            // 
            // profile_info_lastname
            // 
            this.profile_info_lastname.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_lastname.Enabled = false;
            this.profile_info_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profile_info_lastname.Location = new System.Drawing.Point(88, 125);
            this.profile_info_lastname.Name = "profile_info_lastname";
            this.profile_info_lastname.Size = new System.Drawing.Size(191, 26);
            this.profile_info_lastname.TabIndex = 2;
            // 
            // profile_info_birthday
            // 
            this.profile_info_birthday.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_birthday.Enabled = false;
            this.profile_info_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profile_info_birthday.Location = new System.Drawing.Point(88, 157);
            this.profile_info_birthday.Name = "profile_info_birthday";
            this.profile_info_birthday.Size = new System.Drawing.Size(191, 26);
            this.profile_info_birthday.TabIndex = 1;
            // 
            // profile_info_firstname
            // 
            this.profile_info_firstname.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_info_firstname.Enabled = false;
            this.profile_info_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profile_info_firstname.Location = new System.Drawing.Point(88, 94);
            this.profile_info_firstname.Name = "profile_info_firstname";
            this.profile_info_firstname.Size = new System.Drawing.Size(191, 26);
            this.profile_info_firstname.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_save.Location = new System.Drawing.Point(217, 240);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(97, 35);
            this.button_save.TabIndex = 30;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // patient_total
            // 
            this.patient_total.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.patient_total.Enabled = false;
            this.patient_total.Location = new System.Drawing.Point(226, 121);
            this.patient_total.Name = "patient_total";
            this.patient_total.Size = new System.Drawing.Size(79, 29);
            this.patient_total.TabIndex = 8;
            this.patient_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_patient_remove
            // 
            this.input_patient_remove.Location = new System.Drawing.Point(297, 171);
            this.input_patient_remove.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.input_patient_remove.Name = "input_patient_remove";
            this.input_patient_remove.Size = new System.Drawing.Size(120, 29);
            this.input_patient_remove.TabIndex = 1;
            // 
            // input_patient_add
            // 
            this.input_patient_add.Location = new System.Drawing.Point(114, 171);
            this.input_patient_add.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.input_patient_add.Name = "input_patient_add";
            this.input_patient_add.Size = new System.Drawing.Size(120, 29);
            this.input_patient_add.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(655, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 30);
            this.label6.TabIndex = 30;
            this.label6.Text = "Passed tests";
            // 
            // testsList
            // 
            this.testsList.BackColor = System.Drawing.Color.Honeydew;
            this.testsList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.testsBindingSource4, "Name", true));
            this.testsList.DisplayMember = "Name";
            this.testsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testsList.FormattingEnabled = true;
            this.testsList.ItemHeight = 21;
            this.testsList.Location = new System.Drawing.Point(622, 90);
            this.testsList.Name = "testsList";
            this.testsList.Size = new System.Drawing.Size(212, 424);
            this.testsList.TabIndex = 31;
            this.testsList.ValueMember = "Name";
            // 
            // testsBindingSource4
            // 
            this.testsBindingSource4.DataMember = "Tests";
            this.testsBindingSource4.DataSource = this.logo_manager2DataSet;
            // 
            // logo_manager2DataSet
            // 
            this.logo_manager2DataSet.DataSetName = "Logo_manager2DataSet";
            this.logo_manager2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testsBindingSource2
            // 
            this.testsBindingSource2.DataMember = "Tests";
            this.testsBindingSource2.DataSource = this.logo_manager2DataSet;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            // 
            // testsBindingSource1
            // 
            this.testsBindingSource1.DataMember = "Tests";
            // 
            // btn_add_test_to_patient
            // 
            this.btn_add_test_to_patient.BackColor = System.Drawing.Color.MintCream;
            this.btn_add_test_to_patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_test_to_patient.Location = new System.Drawing.Point(676, 557);
            this.btn_add_test_to_patient.Name = "btn_add_test_to_patient";
            this.btn_add_test_to_patient.Size = new System.Drawing.Size(118, 35);
            this.btn_add_test_to_patient.TabIndex = 33;
            this.btn_add_test_to_patient.Text = "Add test";
            this.btn_add_test_to_patient.UseVisualStyleBackColor = false;
            this.btn_add_test_to_patient.Click += new System.EventHandler(this.btn_add_test_to_patient_Click);
            // 
            // testsTableAdapter1
            // 
            this.testsTableAdapter1.ClearBeforeFill = true;
            // 
            // testsBindingSource3
            // 
            this.testsBindingSource3.DataMember = "Tests";
            this.testsBindingSource3.DataSource = this.logo_manager2DataSet;
            // 
            // testsBindingSource5
            // 
            this.testsBindingSource5.DataMember = "Tests";
            this.testsBindingSource5.DataSource = this.logo_manager2DataSet;
            // 
            // testsBindingSource6
            // 
            this.testsBindingSource6.DataMember = "Tests";
            this.testsBindingSource6.DataSource = this.logo_manager2DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.testsBindingSource6, "Name", true));
            this.comboBox1.DataSource = this.testsBindingSource6;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(622, 530);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.ValueMember = "Name";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InsurancesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PatientsTestsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = this.testsTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Logo_Manager2.Logo_manager2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 382);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient-information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.btn_del_user);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_modify_user);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.input_paztient_insurance);
            this.groupBox3.Controls.Add(this.profile_info_followBy);
            this.groupBox3.Controls.Add(this.profile_info_lastname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.profile_info_firstname);
            this.groupBox3.Controls.Add(this.profile_info_birthday);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 357);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(312, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Speech therapist";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(312, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Following for";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sessions-manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Bisque;
            this.groupBox4.Controls.Add(this.button_save);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.patient_total);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.input_patient_remove);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.input_patient_add);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(-4, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(585, 356);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sessions manager";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(237, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Actual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Remove";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(154, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Add";
            // 
            // User_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_add_test_to_patient);
            this.Controls.Add(this.testsList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.title_profile_patient);
            this.Name = "User_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_profile";
            this.Load += new System.EventHandler(this.User_profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_patient_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_profile_patient;
        private System.Windows.Forms.TextBox profile_info_followBy;
        private System.Windows.Forms.TextBox profile_info_lastname;
        private System.Windows.Forms.TextBox profile_info_birthday;
        private System.Windows.Forms.TextBox profile_info_firstname;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox patient_total;
        private System.Windows.Forms.NumericUpDown input_patient_remove;
        private System.Windows.Forms.NumericUpDown input_patient_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox testsList;
        private System.Windows.Forms.Button btn_add_test_to_patient;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private System.Windows.Forms.TextBox input_paztient_insurance;
        private System.Windows.Forms.BindingSource testsBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private Logo_manager2DataSet logo_manager2DataSet;
        private System.Windows.Forms.BindingSource testsBindingSource2;
        private Logo_manager2DataSetTableAdapters.TestsTableAdapter testsTableAdapter1;
        private System.Windows.Forms.BindingSource testsBindingSource4;
        private System.Windows.Forms.BindingSource testsBindingSource3;
        private System.Windows.Forms.BindingSource testsBindingSource6;
        private System.Windows.Forms.BindingSource testsBindingSource5;
        private System.Windows.Forms.ComboBox comboBox1;
        private Logo_manager2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_del_user;
        private System.Windows.Forms.Button btn_modify_user;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}