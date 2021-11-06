﻿namespace Logo_Manager2
{
    partial class User_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu_dashboard = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo_managerDataSet = new Logo_Manager2.Logo_managerDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Logo_Manager2.Logo_managerDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Logo_Manager2.Logo_managerDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter1 = new Logo_Manager2.Logo_managerDataSetTableAdapters.UsersTableAdapter();
            this.AccountName = new System.Windows.Forms.TextBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Logo_Manager2.Logo_managerDataSetTableAdapters.PatientsTableAdapter();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter = new Logo_Manager2.Logo_managerDataSetTableAdapters.TestsTableAdapter();
            this.btn_dashboard_add_test = new System.Windows.Forms.Button();
            this.btn_dashboard_add_patient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insurancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesTableAdapter = new Logo_Manager2.Logo_managerDataSetTableAdapters.InsurancesTableAdapter();
            this.btn_dashboard_addInsurance = new System.Windows.Forms.Button();
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTestsTableAdapter = new Logo_Manager2.Logo_managerDataSetTableAdapters.PatientsTestsTableAdapter();
            this.insurancesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete_patient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeletePatientId = new System.Windows.Forms.NumericUpDown();
            this.Menu_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_managerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePatientId)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_dashboard
            // 
            this.Menu_dashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.Menu_dashboard.Location = new System.Drawing.Point(0, 0);
            this.Menu_dashboard.Name = "Menu_dashboard";
            this.Menu_dashboard.Size = new System.Drawing.Size(1684, 24);
            this.Menu_dashboard.TabIndex = 1;
            this.Menu_dashboard.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPageToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // refreshPageToolStripMenuItem
            // 
            this.refreshPageToolStripMenuItem.Name = "refreshPageToolStripMenuItem";
            this.refreshPageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.refreshPageToolStripMenuItem.Text = "Refresh page";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // logo_managerDataSet
            // 
            this.logo_managerDataSet.DataSetName = "Logo_managerDataSet";
            this.logo_managerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.logo_managerDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InsurancesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PatientsTestsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Logo_Manager2.Logo_managerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // AccountName
            // 
            this.AccountName.BackColor = System.Drawing.Color.LightBlue;
            this.AccountName.Enabled = false;
            this.AccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountName.Location = new System.Drawing.Point(1026, -2);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(100, 26);
            this.AccountName.TabIndex = 3;
            this.AccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.logo_managerDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.logo_managerDataSet;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_dashboard_add_test
            // 
            this.btn_dashboard_add_test.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_dashboard_add_test.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dashboard_add_test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dashboard_add_test.Location = new System.Drawing.Point(931, 567);
            this.btn_dashboard_add_test.Name = "btn_dashboard_add_test";
            this.btn_dashboard_add_test.Size = new System.Drawing.Size(100, 39);
            this.btn_dashboard_add_test.TabIndex = 7;
            this.btn_dashboard_add_test.Text = "Add test";
            this.btn_dashboard_add_test.UseVisualStyleBackColor = true;
            this.btn_dashboard_add_test.Click += new System.EventHandler(this.btn_dashboard_add_test_Click);
            // 
            // btn_dashboard_add_patient
            // 
            this.btn_dashboard_add_patient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dashboard_add_patient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dashboard_add_patient.Location = new System.Drawing.Point(224, 568);
            this.btn_dashboard_add_patient.Name = "btn_dashboard_add_patient";
            this.btn_dashboard_add_patient.Size = new System.Drawing.Size(100, 39);
            this.btn_dashboard_add_patient.TabIndex = 8;
            this.btn_dashboard_add_patient.Text = "Add patient";
            this.btn_dashboard_add_patient.UseVisualStyleBackColor = true;
            this.btn_dashboard_add_patient.Click += new System.EventHandler(this.btn_dashboard_add_patient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(272, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(996, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tests";
            // 
            // insurancesBindingSource
            // 
            this.insurancesBindingSource.DataMember = "Insurances";
            this.insurancesBindingSource.DataSource = this.logo_managerDataSet;
            // 
            // insurancesTableAdapter
            // 
            this.insurancesTableAdapter.ClearBeforeFill = true;
            // 
            // btn_dashboard_addInsurance
            // 
            this.btn_dashboard_addInsurance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_dashboard_addInsurance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dashboard_addInsurance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dashboard_addInsurance.Location = new System.Drawing.Point(1377, 567);
            this.btn_dashboard_addInsurance.Name = "btn_dashboard_addInsurance";
            this.btn_dashboard_addInsurance.Size = new System.Drawing.Size(100, 39);
            this.btn_dashboard_addInsurance.TabIndex = 14;
            this.btn_dashboard_addInsurance.Text = "Add Insurance";
            this.btn_dashboard_addInsurance.UseVisualStyleBackColor = true;
            this.btn_dashboard_addInsurance.Click += new System.EventHandler(this.btn_dashboard_addInsurance_Click);
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.AutoGenerateColumns = false;
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.testsDataGridView.DataSource = this.testsBindingSource;
            this.testsDataGridView.Location = new System.Drawing.Point(779, 61);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.Size = new System.Drawing.Size(477, 500);
            this.testsDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 25;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MinAge";
            this.dataGridViewTextBoxColumn10.HeaderText = "MinAge";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaxAge";
            this.dataGridViewTextBoxColumn11.HeaderText = "MaxAge";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TypefollowUp";
            this.dataGridViewTextBoxColumn12.HeaderText = "TypefollowUp";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // patientsTestsBindingSource
            // 
            this.patientsTestsBindingSource.DataMember = "FK_PatientsToTest";
            this.patientsTestsBindingSource.DataSource = this.patientsBindingSource;
            // 
            // patientsTestsTableAdapter
            // 
            this.patientsTestsTableAdapter.ClearBeforeFill = true;
            // 
            // insurancesDataGridView
            // 
            this.insurancesDataGridView.AutoGenerateColumns = false;
            this.insurancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insurancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.insurancesDataGridView.DataSource = this.insurancesBindingSource;
            this.insurancesDataGridView.Location = new System.Drawing.Point(1306, 61);
            this.insurancesDataGridView.Name = "insurancesDataGridView";
            this.insurancesDataGridView.Size = new System.Drawing.Size(345, 500);
            this.insurancesDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn13.HeaderText = "Name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TelNr";
            this.dataGridViewTextBoxColumn14.HeaderText = "TelNr";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn15.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(0, 61);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.Size = new System.Drawing.Size(707, 500);
            this.patientsDataGridView.TabIndex = 14;
            this.patientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Followup";
            this.dataGridViewTextBoxColumn5.HeaderText = "Followup";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LeftSessions";
            this.dataGridViewTextBoxColumn6.HeaderText = "LeftSessions";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn16.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "InsuranceName";
            this.dataGridViewTextBoxColumn17.HeaderText = "InsuranceName";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // btn_delete_patient
            // 
            this.btn_delete_patient.Location = new System.Drawing.Point(343, 597);
            this.btn_delete_patient.Name = "btn_delete_patient";
            this.btn_delete_patient.Size = new System.Drawing.Size(99, 39);
            this.btn_delete_patient.TabIndex = 16;
            this.btn_delete_patient.Text = "Delete a patient";
            this.btn_delete_patient.UseVisualStyleBackColor = true;
            this.btn_delete_patient.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1037, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete a test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1483, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 39);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete a insurance";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DeletePatientId
            // 
            this.DeletePatientId.Location = new System.Drawing.Point(343, 571);
            this.DeletePatientId.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.DeletePatientId.Name = "DeletePatientId";
            this.DeletePatientId.Size = new System.Drawing.Size(99, 20);
            this.DeletePatientId.TabIndex = 21;
            this.DeletePatientId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1684, 758);
            this.Controls.Add(this.DeletePatientId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_delete_patient);
            this.Controls.Add(this.patientsDataGridView);
            this.Controls.Add(this.insurancesDataGridView);
            this.Controls.Add(this.testsDataGridView);
            this.Controls.Add(this.btn_dashboard_addInsurance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dashboard_add_patient);
            this.Controls.Add(this.btn_dashboard_add_test);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.Menu_dashboard);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu_dashboard;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Dashboard_Load);
            this.Menu_dashboard.ResumeLayout(false);
            this.Menu_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_managerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePatientId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_dashboard;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private Logo_managerDataSet logo_managerDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Logo_managerDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Logo_managerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Logo_managerDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.TextBox AccountName;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Logo_managerDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private Logo_managerDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.Button btn_dashboard_add_test;
        private System.Windows.Forms.Button btn_dashboard_add_patient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStripMenuItem refreshPageToolStripMenuItem;
        private System.Windows.Forms.BindingSource insurancesBindingSource;
        private Logo_managerDataSetTableAdapters.InsurancesTableAdapter insurancesTableAdapter;
        private System.Windows.Forms.Button btn_dashboard_addInsurance;
        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.BindingSource patientsTestsBindingSource;
        private Logo_managerDataSetTableAdapters.PatientsTestsTableAdapter patientsTestsTableAdapter;
        private System.Windows.Forms.DataGridView insurancesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button btn_delete_patient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown DeletePatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

