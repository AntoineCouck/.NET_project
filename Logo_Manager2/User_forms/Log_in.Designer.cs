namespace Logo_Manager2
{
    partial class Log_in
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.password_login_input = new System.Windows.Forms.TextBox();
            this.login_submit = new System.Windows.Forms.Button();
            this.link_sign_in = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_login_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.password_login_input);
            this.groupBox2.Controls.Add(this.login_submit);
            this.groupBox2.Controls.Add(this.link_sign_in);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.email_login_input);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(212, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 279);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log-in informations";
            // 
            // password_login_input
            // 
            this.password_login_input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_login_input.Location = new System.Drawing.Point(36, 139);
            this.password_login_input.Margin = new System.Windows.Forms.Padding(2);
            this.password_login_input.Name = "password_login_input";
            this.password_login_input.PasswordChar = '*';
            this.password_login_input.Size = new System.Drawing.Size(205, 29);
            this.password_login_input.TabIndex = 3;
            // 
            // login_submit
            // 
            this.login_submit.BackColor = System.Drawing.Color.AliceBlue;
            this.login_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.login_submit.Location = new System.Drawing.Point(84, 223);
            this.login_submit.Margin = new System.Windows.Forms.Padding(2);
            this.login_submit.Name = "login_submit";
            this.login_submit.Size = new System.Drawing.Size(109, 32);
            this.login_submit.TabIndex = 4;
            this.login_submit.Text = "Submit";
            this.login_submit.UseVisualStyleBackColor = false;
            this.login_submit.Click += new System.EventHandler(this.login_submit_Click_1);
            // 
            // link_sign_in
            // 
            this.link_sign_in.AutoSize = true;
            this.link_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_sign_in.Location = new System.Drawing.Point(174, 190);
            this.link_sign_in.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_sign_in.Name = "link_sign_in";
            this.link_sign_in.Size = new System.Drawing.Size(52, 17);
            this.link_sign_in.TabIndex = 6;
            this.link_sign_in.TabStop = true;
            this.link_sign_in.Text = "Sign-in";
            this.link_sign_in.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_sign_in_LinkClicked_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(46, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create  account ? ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // email_login_input
            // 
            this.email_login_input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_login_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.email_login_input.Location = new System.Drawing.Point(36, 59);
            this.email_login_input.Margin = new System.Windows.Forms.Padding(2);
            this.email_login_input.Name = "email_login_input";
            this.email_login_input.Size = new System.Drawing.Size(205, 29);
            this.email_login_input.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Log-in";
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 487);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_in";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox password_login_input;
        private System.Windows.Forms.Button login_submit;
        private System.Windows.Forms.LinkLabel link_sign_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_login_input;
        private System.Windows.Forms.Label label4;
    }
}