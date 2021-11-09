namespace Logo_Manager2.profile_forms
{
    partial class delete_insurance
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
            this.btn_notdelete_insurance = new System.Windows.Forms.Button();
            this.btn_confirm_delete_insurance = new System.Windows.Forms.Button();
            this.title_del_insurance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_notdelete_insurance
            // 
            this.btn_notdelete_insurance.BackColor = System.Drawing.Color.Red;
            this.btn_notdelete_insurance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_notdelete_insurance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_notdelete_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notdelete_insurance.Location = new System.Drawing.Point(101, 59);
            this.btn_notdelete_insurance.Name = "btn_notdelete_insurance";
            this.btn_notdelete_insurance.Size = new System.Drawing.Size(75, 23);
            this.btn_notdelete_insurance.TabIndex = 8;
            this.btn_notdelete_insurance.Text = "Back";
            this.btn_notdelete_insurance.UseVisualStyleBackColor = false;
            this.btn_notdelete_insurance.Click += new System.EventHandler(this.btn_notdelete_insurance_Click);
            // 
            // btn_confirm_delete_insurance
            // 
            this.btn_confirm_delete_insurance.BackColor = System.Drawing.Color.Green;
            this.btn_confirm_delete_insurance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirm_delete_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_delete_insurance.Location = new System.Drawing.Point(7, 59);
            this.btn_confirm_delete_insurance.Name = "btn_confirm_delete_insurance";
            this.btn_confirm_delete_insurance.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm_delete_insurance.TabIndex = 7;
            this.btn_confirm_delete_insurance.Text = "Delete";
            this.btn_confirm_delete_insurance.UseVisualStyleBackColor = false;
            this.btn_confirm_delete_insurance.Click += new System.EventHandler(this.btn_confirm_delete_insurance_Click);
            // 
            // title_del_insurance
            // 
            this.title_del_insurance.AutoSize = true;
            this.title_del_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_del_insurance.Location = new System.Drawing.Point(27, 65);
            this.title_del_insurance.Name = "title_del_insurance";
            this.title_del_insurance.Size = new System.Drawing.Size(64, 20);
            this.title_del_insurance.TabIndex = 6;
            this.title_del_insurance.Text = "Delete  ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.btn_notdelete_insurance);
            this.groupBox1.Controls.Add(this.btn_confirm_delete_insurance);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // delete_insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 336);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title_del_insurance);
            this.Name = "delete_insurance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_insurance";
            this.Load += new System.EventHandler(this.delete_insurance_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_notdelete_insurance;
        private System.Windows.Forms.Button btn_confirm_delete_insurance;
        private System.Windows.Forms.Label title_del_insurance;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}