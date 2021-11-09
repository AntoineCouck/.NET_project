namespace Logo_Manager2.profile_forms
{
    partial class modify_insurance
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
            this.input_telnr_mod = new System.Windows.Forms.TextBox();
            this.input_adres_mod = new System.Windows.Forms.TextBox();
            this.input_name_mod = new System.Windows.Forms.TextBox();
            this.btn_del_test = new System.Windows.Forms.Button();
            this.btn_modify_test_confirm = new System.Windows.Forms.Button();
            this.title_profile_test = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.input_telnr_mod);
            this.groupBox1.Controls.Add(this.input_adres_mod);
            this.groupBox1.Controls.Add(this.input_name_mod);
            this.groupBox1.Controls.Add(this.btn_del_test);
            this.groupBox1.Controls.Add(this.btn_modify_test_confirm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(221, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 225);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insurance information";
            // 
            // input_telnr_mod
            // 
            this.input_telnr_mod.Location = new System.Drawing.Point(108, 123);
            this.input_telnr_mod.Name = "input_telnr_mod";
            this.input_telnr_mod.Size = new System.Drawing.Size(142, 23);
            this.input_telnr_mod.TabIndex = 39;
            // 
            // input_adres_mod
            // 
            this.input_adres_mod.Location = new System.Drawing.Point(188, 72);
            this.input_adres_mod.Name = "input_adres_mod";
            this.input_adres_mod.Size = new System.Drawing.Size(145, 23);
            this.input_adres_mod.TabIndex = 38;
            // 
            // input_name_mod
            // 
            this.input_name_mod.Enabled = false;
            this.input_name_mod.Location = new System.Drawing.Point(26, 72);
            this.input_name_mod.Name = "input_name_mod";
            this.input_name_mod.Size = new System.Drawing.Size(131, 23);
            this.input_name_mod.TabIndex = 37;
            // 
            // btn_del_test
            // 
            this.btn_del_test.BackColor = System.Drawing.Color.Red;
            this.btn_del_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_del_test.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_del_test.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_test.Location = new System.Drawing.Point(177, 181);
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
            this.btn_modify_test_confirm.Location = new System.Drawing.Point(72, 181);
            this.btn_modify_test_confirm.Name = "btn_modify_test_confirm";
            this.btn_modify_test_confirm.Size = new System.Drawing.Size(99, 23);
            this.btn_modify_test_confirm.TabIndex = 36;
            this.btn_modify_test_confirm.Text = "Modify";
            this.btn_modify_test_confirm.UseVisualStyleBackColor = false;
            this.btn_modify_test_confirm.Click += new System.EventHandler(this.btn_modify_test_confirm_Click);
            // 
            // title_profile_test
            // 
            this.title_profile_test.AutoSize = true;
            this.title_profile_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_profile_test.Location = new System.Drawing.Point(300, 79);
            this.title_profile_test.Name = "title_profile_test";
            this.title_profile_test.Size = new System.Drawing.Size(113, 26);
            this.title_profile_test.TabIndex = 32;
            this.title_profile_test.Text = "Insurance:";
            // 
            // modify_insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_profile_test);
            this.Name = "modify_insurance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modify_insurance";
            this.Load += new System.EventHandler(this.modify_insurance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_del_test;
        private System.Windows.Forms.Button btn_modify_test_confirm;
        private System.Windows.Forms.Label title_profile_test;
        private System.Windows.Forms.TextBox input_telnr_mod;
        private System.Windows.Forms.TextBox input_adres_mod;
        private System.Windows.Forms.TextBox input_name_mod;
    }
}