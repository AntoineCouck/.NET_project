namespace Logo_Manager2.profile_forms
{
    partial class test_profile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_del_test = new System.Windows.Forms.Button();
            this.btn_modify_test = new System.Windows.Forms.Button();
            this.profile_test_followup = new System.Windows.Forms.TextBox();
            this.profile_test_minage = new System.Windows.Forms.TextBox();
            this.profile_test_maxage = new System.Windows.Forms.TextBox();
            this.profile_test_name = new System.Windows.Forms.TextBox();
            this.title_profile_test = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btn_del_test);
            this.groupBox1.Controls.Add(this.btn_modify_test);
            this.groupBox1.Controls.Add(this.profile_test_followup);
            this.groupBox1.Controls.Add(this.profile_test_minage);
            this.groupBox1.Controls.Add(this.profile_test_maxage);
            this.groupBox1.Controls.Add(this.profile_test_name);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(176, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 245);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test information";
            // 
            // btn_del_test
            // 
            this.btn_del_test.BackColor = System.Drawing.Color.Red;
            this.btn_del_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_del_test.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_del_test.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_test.Location = new System.Drawing.Point(227, 144);
            this.btn_del_test.Name = "btn_del_test";
            this.btn_del_test.Size = new System.Drawing.Size(99, 33);
            this.btn_del_test.TabIndex = 35;
            this.btn_del_test.Text = "Delete test";
            this.btn_del_test.UseVisualStyleBackColor = false;
            this.btn_del_test.Click += new System.EventHandler(this.btn_del_test_Click);
            // 
            // btn_modify_test
            // 
            this.btn_modify_test.BackColor = System.Drawing.Color.Turquoise;
            this.btn_modify_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modify_test.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modify_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify_test.Location = new System.Drawing.Point(122, 144);
            this.btn_modify_test.Name = "btn_modify_test";
            this.btn_modify_test.Size = new System.Drawing.Size(99, 33);
            this.btn_modify_test.TabIndex = 36;
            this.btn_modify_test.Text = "Modify test";
            this.btn_modify_test.UseVisualStyleBackColor = false;
            this.btn_modify_test.Click += new System.EventHandler(this.btn_modify_test_Click);
            // 
            // profile_test_followup
            // 
            this.profile_test_followup.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_test_followup.Enabled = false;
            this.profile_test_followup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_followup.Location = new System.Drawing.Point(22, 86);
            this.profile_test_followup.Name = "profile_test_followup";
            this.profile_test_followup.Size = new System.Drawing.Size(188, 29);
            this.profile_test_followup.TabIndex = 5;
            // 
            // profile_test_minage
            // 
            this.profile_test_minage.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_test_minage.Enabled = false;
            this.profile_test_minage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_minage.Location = new System.Drawing.Point(220, 51);
            this.profile_test_minage.Name = "profile_test_minage";
            this.profile_test_minage.Size = new System.Drawing.Size(190, 29);
            this.profile_test_minage.TabIndex = 2;
            // 
            // profile_test_maxage
            // 
            this.profile_test_maxage.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_test_maxage.Enabled = false;
            this.profile_test_maxage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_maxage.Location = new System.Drawing.Point(220, 86);
            this.profile_test_maxage.Name = "profile_test_maxage";
            this.profile_test_maxage.Size = new System.Drawing.Size(188, 29);
            this.profile_test_maxage.TabIndex = 1;
            // 
            // profile_test_name
            // 
            this.profile_test_name.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_test_name.Enabled = false;
            this.profile_test_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_name.Location = new System.Drawing.Point(22, 51);
            this.profile_test_name.Name = "profile_test_name";
            this.profile_test_name.Size = new System.Drawing.Size(190, 29);
            this.profile_test_name.TabIndex = 0;
            // 
            // title_profile_test
            // 
            this.title_profile_test.AutoSize = true;
            this.title_profile_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_profile_test.Location = new System.Drawing.Point(171, 41);
            this.title_profile_test.Name = "title_profile_test";
            this.title_profile_test.Size = new System.Drawing.Size(59, 26);
            this.title_profile_test.TabIndex = 28;
            this.title_profile_test.Text = "Test:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Salmon;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(176, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 367);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passed the test";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(122, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 310);
            this.listBox1.TabIndex = 0;
            // 
            // test_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_profile_test);
            this.Name = "test_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test_profile";
            this.Load += new System.EventHandler(this.test_profile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_del_test;
        private System.Windows.Forms.Button btn_modify_test;
        private System.Windows.Forms.TextBox profile_test_followup;
        private System.Windows.Forms.TextBox profile_test_minage;
        private System.Windows.Forms.TextBox profile_test_maxage;
        private System.Windows.Forms.TextBox profile_test_name;
        private System.Windows.Forms.Label title_profile_test;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}