namespace Logo_Manager2
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
        
            this.Menu_dashboard.SuspendLayout();
          
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
            this.btn_dashboard_add_test.Location = new System.Drawing.Point(1000, 567);
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
            this.btn_dashboard_add_patient.Location = new System.Drawing.Point(227, 567);
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
            // btn_dashboard_addInsurance
            // 
            this.btn_dashboard_addInsurance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_dashboard_addInsurance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dashboard_addInsurance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dashboard_addInsurance.Location = new System.Drawing.Point(1428, 567);
            this.btn_dashboard_addInsurance.Name = "btn_dashboard_addInsurance";
            this.btn_dashboard_addInsurance.Size = new System.Drawing.Size(100, 39);
            this.btn_dashboard_addInsurance.TabIndex = 14;
            this.btn_dashboard_addInsurance.Text = "Add Insurance";
            this.btn_dashboard_addInsurance.UseVisualStyleBackColor = true;
            this.btn_dashboard_addInsurance.Click += new System.EventHandler(this.btn_dashboard_addInsurance_Click);
          
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1684, 758);
            //this.Controls.Add(this.patientsDataGridView);
            //this.Controls.Add(this.insurancesDataGridView);
            //this.Controls.Add(this.testsDataGridView);
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
        private System.Windows.Forms.Button btn_dashboard_add_patient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem refreshPageToolStripMenuItem;
        private System.Windows.Forms.Button btn_dashboard_addInsurance;
     
    }
}

