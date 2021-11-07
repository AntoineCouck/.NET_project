namespace Logo_Manager2.profile_forms
{
    partial class delete_user
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
            this.name = new System.Windows.Forms.Label();
            this.btn_confirm_delete = new System.Windows.Forms.Button();
            this.btn_notdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(33, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Delete  ";
            // 
            // btn_confirm_delete
            // 
            this.btn_confirm_delete.BackColor = System.Drawing.Color.Green;
            this.btn_confirm_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirm_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_delete.Location = new System.Drawing.Point(22, 90);
            this.btn_confirm_delete.Name = "btn_confirm_delete";
            this.btn_confirm_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm_delete.TabIndex = 1;
            this.btn_confirm_delete.Text = "Delete";
            this.btn_confirm_delete.UseVisualStyleBackColor = false;
            this.btn_confirm_delete.Click += new System.EventHandler(this.btn_confirm_delete_Click);
            // 
            // btn_notdelete
            // 
            this.btn_notdelete.BackColor = System.Drawing.Color.Red;
            this.btn_notdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_notdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notdelete.Location = new System.Drawing.Point(116, 90);
            this.btn_notdelete.Name = "btn_notdelete";
            this.btn_notdelete.Size = new System.Drawing.Size(75, 23);
            this.btn_notdelete.TabIndex = 2;
            this.btn_notdelete.Text = "Back";
            this.btn_notdelete.UseVisualStyleBackColor = false;
            this.btn_notdelete.Click += new System.EventHandler(this.btn_notdelete_Click);
            // 
            // delete_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 333);
            this.ControlBox = false;
            this.Controls.Add(this.btn_notdelete);
            this.Controls.Add(this.btn_confirm_delete);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "delete_user";
            this.Text = "delete_user";
            this.Load += new System.EventHandler(this.delete_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btn_confirm_delete;
        private System.Windows.Forms.Button btn_notdelete;
    }
}