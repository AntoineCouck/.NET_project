namespace Logo_Manager2.profile_forms
{
    partial class Insurance_profile
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
            this.btn_del_inusrance = new System.Windows.Forms.Button();
            this.btn_modify_insurance = new System.Windows.Forms.Button();
            this.profile_insurance_telnr = new System.Windows.Forms.TextBox();
            this.profile_insurance_adres = new System.Windows.Forms.TextBox();
            this.profile_insurance_name = new System.Windows.Forms.TextBox();
            this.title_profile_Insurance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btn_del_inusrance);
            this.groupBox1.Controls.Add(this.btn_modify_insurance);
            this.groupBox1.Controls.Add(this.profile_insurance_telnr);
            this.groupBox1.Controls.Add(this.profile_insurance_adres);
            this.groupBox1.Controls.Add(this.profile_insurance_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(202, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 246);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insurance information";
            // 
            // btn_del_inusrance
            // 
            this.btn_del_inusrance.BackColor = System.Drawing.Color.Red;
            this.btn_del_inusrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_del_inusrance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_del_inusrance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del_inusrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_inusrance.Location = new System.Drawing.Point(200, 184);
            this.btn_del_inusrance.Name = "btn_del_inusrance";
            this.btn_del_inusrance.Size = new System.Drawing.Size(99, 23);
            this.btn_del_inusrance.TabIndex = 35;
            this.btn_del_inusrance.Text = "Delete ";
            this.btn_del_inusrance.UseVisualStyleBackColor = false;
            this.btn_del_inusrance.Click += new System.EventHandler(this.btn_del_inusrance_Click);
            // 
            // btn_modify_insurance
            // 
            this.btn_modify_insurance.BackColor = System.Drawing.Color.Turquoise;
            this.btn_modify_insurance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modify_insurance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modify_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify_insurance.Location = new System.Drawing.Point(95, 184);
            this.btn_modify_insurance.Name = "btn_modify_insurance";
            this.btn_modify_insurance.Size = new System.Drawing.Size(99, 23);
            this.btn_modify_insurance.TabIndex = 36;
            this.btn_modify_insurance.Text = "Modify ";
            this.btn_modify_insurance.UseVisualStyleBackColor = false;
            this.btn_modify_insurance.Click += new System.EventHandler(this.btn_modify_insurance_Click);
            // 
            // profile_insurance_telnr
            // 
            this.profile_insurance_telnr.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_insurance_telnr.Enabled = false;
            this.profile_insurance_telnr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_insurance_telnr.Location = new System.Drawing.Point(111, 115);
            this.profile_insurance_telnr.Name = "profile_insurance_telnr";
            this.profile_insurance_telnr.Size = new System.Drawing.Size(165, 29);
            this.profile_insurance_telnr.TabIndex = 2;
            // 
            // profile_insurance_adres
            // 
            this.profile_insurance_adres.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_insurance_adres.Enabled = false;
            this.profile_insurance_adres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_insurance_adres.Location = new System.Drawing.Point(208, 65);
            this.profile_insurance_adres.Name = "profile_insurance_adres";
            this.profile_insurance_adres.Size = new System.Drawing.Size(165, 29);
            this.profile_insurance_adres.TabIndex = 1;
            // 
            // profile_insurance_name
            // 
            this.profile_insurance_name.BackColor = System.Drawing.SystemColors.Menu;
            this.profile_insurance_name.Enabled = false;
            this.profile_insurance_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_insurance_name.Location = new System.Drawing.Point(6, 65);
            this.profile_insurance_name.Name = "profile_insurance_name";
            this.profile_insurance_name.Size = new System.Drawing.Size(184, 29);
            this.profile_insurance_name.TabIndex = 0;
            // 
            // title_profile_Insurance
            // 
            this.title_profile_Insurance.AutoSize = true;
            this.title_profile_Insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_profile_Insurance.Location = new System.Drawing.Point(197, 46);
            this.title_profile_Insurance.Name = "title_profile_Insurance";
            this.title_profile_Insurance.Size = new System.Drawing.Size(113, 26);
            this.title_profile_Insurance.TabIndex = 30;
            this.title_profile_Insurance.Text = "Insurance:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Salmon;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(202, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 339);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Members";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(95, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 292);
            this.listBox1.TabIndex = 0;
            // 
            // Insurance_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 717);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_profile_Insurance);
            this.Name = "Insurance_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insurance_profile";
            this.Load += new System.EventHandler(this.Insurance_profile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_del_inusrance;
        private System.Windows.Forms.Button btn_modify_insurance;
        private System.Windows.Forms.TextBox profile_insurance_telnr;
        private System.Windows.Forms.TextBox profile_insurance_adres;
        private System.Windows.Forms.TextBox profile_insurance_name;
        private System.Windows.Forms.Label title_profile_Insurance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}