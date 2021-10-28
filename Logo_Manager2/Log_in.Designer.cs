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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password_login_input = new System.Windows.Forms.TextBox();
            this.email_login_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.link_sign_in = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.link_sign_in);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.login_submit);
            this.groupBox1.Controls.Add(this.password_login_input);
            this.groupBox1.Controls.Add(this.email_login_input);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 599);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log-In";
            // 
            // password_login_input
            // 
            this.password_login_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_login_input.Location = new System.Drawing.Point(373, 280);
            this.password_login_input.Name = "password_login_input";
            this.password_login_input.Size = new System.Drawing.Size(168, 30);
            this.password_login_input.TabIndex = 3;
            // 
            // email_login_input
            // 
            this.email_login_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.email_login_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.email_login_input.Location = new System.Drawing.Point(373, 182);
            this.email_login_input.Name = "email_login_input";
            this.email_login_input.Size = new System.Drawing.Size(168, 30);
            this.email_login_input.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // login_submit
            // 
            this.login_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.login_submit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.login_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.login_submit.Location = new System.Drawing.Point(403, 350);
            this.login_submit.Name = "login_submit";
            this.login_submit.Size = new System.Drawing.Size(103, 39);
            this.login_submit.TabIndex = 4;
            this.login_submit.Text = "Submit";
            this.login_submit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(308, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create  account ? ";
            // 
            // link_sign_in
            // 
            this.link_sign_in.AutoSize = true;
            this.link_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_sign_in.Location = new System.Drawing.Point(480, 416);
            this.link_sign_in.Name = "link_sign_in";
            this.link_sign_in.Size = new System.Drawing.Size(61, 20);
            this.link_sign_in.TabIndex = 6;
            this.link_sign_in.TabStop = true;
            this.link_sign_in.Text = "Sign-in";
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 599);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_in";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_login_input;
        private System.Windows.Forms.TextBox email_login_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_submit;
        private System.Windows.Forms.LinkLabel link_sign_in;
        private System.Windows.Forms.Label label3;
    }
}