namespace Logo_Manager2.profile_forms
{
    partial class modify_test
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
            this.profile_test_maxage = new System.Windows.Forms.NumericUpDown();
            this.profile_test_followup = new System.Windows.Forms.ComboBox();
            this.profile_test_minage = new System.Windows.Forms.NumericUpDown();
            this.btn_del_test = new System.Windows.Forms.Button();
            this.btn_modify_test_confirm = new System.Windows.Forms.Button();
            this.profile_test_name = new System.Windows.Forms.TextBox();
            this.title_profile_test = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_test_maxage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_test_minage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.profile_test_maxage);
            this.groupBox1.Controls.Add(this.profile_test_followup);
            this.groupBox1.Controls.Add(this.profile_test_minage);
            this.groupBox1.Controls.Add(this.btn_del_test);
            this.groupBox1.Controls.Add(this.btn_modify_test_confirm);
            this.groupBox1.Controls.Add(this.profile_test_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(202, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 243);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test information";
            // 
            // profile_test_maxage
            // 
            this.profile_test_maxage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_maxage.Location = new System.Drawing.Point(232, 100);
            this.profile_test_maxage.Name = "profile_test_maxage";
            this.profile_test_maxage.Size = new System.Drawing.Size(120, 29);
            this.profile_test_maxage.TabIndex = 33;
            // 
            // profile_test_followup
            // 
            this.profile_test_followup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profile_test_followup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_followup.FormattingEnabled = true;
            this.profile_test_followup.Items.AddRange(new object[] {
            "a: Handicap poursuite profession ",
            "b1: Aphasie ",
            "b2: Langage oral ",
            "b3: Dyslexie, dysorthographie, dyscalculie ",
            "b4: Fentes ",
            "b5: Radiothérapie/chirurgie ",
            "b6.1: Dysglossies ",
            "b6.2: Dysarthries ",
            "b6.3: Troubles chroniques de la parole ",
            "b6.4: Bégaiement ",
            "b6.5: Troubles myofonctionnels ",
            "c1: Laryngectomie ",
            "c2: Troubles organiques (voix)",
            "d: Troubles de l’ouïe ",
            "e: Dysphagie ",
            "f: Dysphasie ",
            "g: Locked-in syndrome "});
            this.profile_test_followup.Location = new System.Drawing.Point(26, 100);
            this.profile_test_followup.Name = "profile_test_followup";
            this.profile_test_followup.Size = new System.Drawing.Size(184, 29);
            this.profile_test_followup.TabIndex = 37;
            // 
            // profile_test_minage
            // 
            this.profile_test_minage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_minage.Location = new System.Drawing.Point(232, 65);
            this.profile_test_minage.Name = "profile_test_minage";
            this.profile_test_minage.Size = new System.Drawing.Size(120, 29);
            this.profile_test_minage.TabIndex = 32;
            // 
            // btn_del_test
            // 
            this.btn_del_test.BackColor = System.Drawing.Color.Red;
            this.btn_del_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_del_test.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_del_test.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_test.Location = new System.Drawing.Point(194, 164);
            this.btn_del_test.Name = "btn_del_test";
            this.btn_del_test.Size = new System.Drawing.Size(99, 23);
            this.btn_del_test.TabIndex = 35;
            this.btn_del_test.Text = "Back";
            this.btn_del_test.UseVisualStyleBackColor = false;
            this.btn_del_test.Click += new System.EventHandler(this.btn_del_test_Click);
            // 
            // btn_modify_test_confirm
            // 
            this.btn_modify_test_confirm.BackColor = System.Drawing.Color.Turquoise;
            this.btn_modify_test_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modify_test_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_modify_test_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modify_test_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify_test_confirm.Location = new System.Drawing.Point(89, 164);
            this.btn_modify_test_confirm.Name = "btn_modify_test_confirm";
            this.btn_modify_test_confirm.Size = new System.Drawing.Size(99, 23);
            this.btn_modify_test_confirm.TabIndex = 36;
            this.btn_modify_test_confirm.Text = "Modify test";
            this.btn_modify_test_confirm.UseVisualStyleBackColor = false;
            this.btn_modify_test_confirm.Click += new System.EventHandler(this.btn_modify_test_confirm_Click);
            // 
            // profile_test_name
            // 
            this.profile_test_name.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_test_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_test_name.Location = new System.Drawing.Point(26, 65);
            this.profile_test_name.Name = "profile_test_name";
            this.profile_test_name.Size = new System.Drawing.Size(185, 29);
            this.profile_test_name.TabIndex = 0;
            // 
            // title_profile_test
            // 
            this.title_profile_test.AutoSize = true;
            this.title_profile_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_profile_test.Location = new System.Drawing.Point(197, 86);
            this.title_profile_test.Name = "title_profile_test";
            this.title_profile_test.Size = new System.Drawing.Size(59, 26);
            this.title_profile_test.TabIndex = 30;
            this.title_profile_test.Text = "Test:";
            // 
            // modify_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_profile_test);
            this.Name = "modify_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modify_test";
            this.Load += new System.EventHandler(this.modify_test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_test_maxage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_test_minage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_del_test;
        private System.Windows.Forms.Button btn_modify_test_confirm;
        private System.Windows.Forms.TextBox profile_test_name;
        private System.Windows.Forms.Label title_profile_test;
        private System.Windows.Forms.ComboBox profile_test_followup;
        private System.Windows.Forms.NumericUpDown profile_test_maxage;
        private System.Windows.Forms.NumericUpDown profile_test_minage;
    }
}