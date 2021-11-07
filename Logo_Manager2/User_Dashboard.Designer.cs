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
            this.AccountName = new System.Windows.Forms.TextBox();
            this.btn_dashboard_add_test = new System.Windows.Forms.Button();
            this.btn_dashboard_add_patient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dashboard_addInsurance = new System.Windows.Forms.Button();
            this.logo_manager2DataSet = new Logo_Manager2.Logo_manager2DataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new Logo_Manager2.Logo_manager2DataSetTableAdapters.TableAdapterManager();
            this.insurancesTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.InsurancesTableAdapter();
            this.testsTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.TestsTableAdapter();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.UsersTableAdapter();
            this.Menu_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_dashboard
            // 
            this.Menu_dashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.Menu_dashboard.Location = new System.Drawing.Point(0, 0);
            this.Menu_dashboard.Name = "Menu_dashboard";
            this.Menu_dashboard.Size = new System.Drawing.Size(1732, 24);
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
            this.refreshPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshPageToolStripMenuItem.Text = "Refresh page";
            this.refreshPageToolStripMenuItem.Click += new System.EventHandler(this.refreshPageToolStripMenuItem_Click);
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
            // btn_dashboard_add_test
            // 
            this.btn_dashboard_add_test.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_dashboard_add_test.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dashboard_add_test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dashboard_add_test.Location = new System.Drawing.Point(978, 541);
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
            this.btn_dashboard_add_patient.Location = new System.Drawing.Point(326, 525);
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
            this.label1.Location = new System.Drawing.Point(359, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1002, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tests";
            // 
            // btn_dashboard_addInsurance
            // 
            this.btn_dashboard_addInsurance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_dashboard_addInsurance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dashboard_addInsurance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dashboard_addInsurance.Location = new System.Drawing.Point(1460, 541);
            this.btn_dashboard_addInsurance.Name = "btn_dashboard_addInsurance";
            this.btn_dashboard_addInsurance.Size = new System.Drawing.Size(100, 39);
            this.btn_dashboard_addInsurance.TabIndex = 14;
            this.btn_dashboard_addInsurance.Text = "Add Insurance";
            this.btn_dashboard_addInsurance.UseVisualStyleBackColor = true;
            this.btn_dashboard_addInsurance.Click += new System.EventHandler(this.btn_dashboard_addInsurance_Click);
            // 
            // logo_manager2DataSet
            // 
            this.logo_manager2DataSet.DataSetName = "Logo_manager2DataSet";
            this.logo_manager2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InsurancesTableAdapter = this.insurancesTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.PatientsTestsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = this.testsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Logo_Manager2.Logo_manager2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // insurancesTableAdapter
            // 
            this.insurancesTableAdapter.ClearBeforeFill = true;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.AutoGenerateColumns = false;
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.testsDataGridView.DataSource = this.testsBindingSource;
            this.testsDataGridView.Location = new System.Drawing.Point(826, 72);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.Size = new System.Drawing.Size(408, 445);
            this.testsDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 25;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 135;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MinAge";
            this.dataGridViewTextBoxColumn11.HeaderText = "MinAge";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MaxAge";
            this.dataGridViewTextBoxColumn12.HeaderText = "MaxAge";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TypefollowUp";
            this.dataGridViewTextBoxColumn13.HeaderText = "TypefollowUp";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // insurancesBindingSource
            // 
            this.insurancesBindingSource.DataMember = "Insurances";
            this.insurancesBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // insurancesDataGridView
            // 
            this.insurancesDataGridView.AutoGenerateColumns = false;
            this.insurancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insurancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.insurancesDataGridView.DataSource = this.insurancesBindingSource;
            this.insurancesDataGridView.Location = new System.Drawing.Point(1317, 72);
            this.insurancesDataGridView.Name = "insurancesDataGridView";
            this.insurancesDataGridView.Size = new System.Drawing.Size(345, 445);
            this.insurancesDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TelNr";
            this.dataGridViewTextBoxColumn15.HeaderText = "TelNr";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn16.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
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
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(41, 72);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.Size = new System.Drawing.Size(719, 438);
            this.patientsDataGridView.TabIndex = 17;
            this.patientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "InsuranceName";
            this.dataGridViewTextBoxColumn8.HeaderText = "InsuranceName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1732, 856);
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
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_dashboard;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.TextBox AccountName;
        private System.Windows.Forms.Button btn_dashboard_add_test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem refreshPageToolStripMenuItem;
        private System.Windows.Forms.Button btn_dashboard_addInsurance;
        private Logo_manager2DataSet logo_manager2DataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Logo_manager2DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private Logo_manager2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Logo_manager2DataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private Logo_manager2DataSetTableAdapters.InsurancesTableAdapter insurancesTableAdapter;
        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource insurancesBindingSource;
        private System.Windows.Forms.DataGridView insurancesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        public System.Windows.Forms.Button btn_dashboard_add_patient;
        public System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Logo_manager2DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

