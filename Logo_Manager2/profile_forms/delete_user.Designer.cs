﻿namespace Logo_Manager2.profile_forms
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
            this.btn_confirm_deletetest = new System.Windows.Forms.Button();
            this.btn_notdeleteTest = new System.Windows.Forms.Button();
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
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // btn_confirm_deletetest
            // 
            this.btn_confirm_deletetest.BackColor = System.Drawing.Color.Green;
            this.btn_confirm_deletetest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirm_deletetest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm_deletetest.Location = new System.Drawing.Point(22, 90);
            this.btn_confirm_deletetest.Name = "btn_confirm_deletetest";
            this.btn_confirm_deletetest.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm_deletetest.TabIndex = 1;
            this.btn_confirm_deletetest.Text = "Delete";
            this.btn_confirm_deletetest.UseVisualStyleBackColor = false;
            this.btn_confirm_deletetest.Click += new System.EventHandler(this.btn_confirm_delete_Click);
            // 
            // btn_notdeleteTest
            // 
            this.btn_notdeleteTest.BackColor = System.Drawing.Color.Red;
            this.btn_notdeleteTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_notdeleteTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notdeleteTest.Location = new System.Drawing.Point(116, 90);
            this.btn_notdeleteTest.Name = "btn_notdeleteTest";
            this.btn_notdeleteTest.Size = new System.Drawing.Size(75, 23);
            this.btn_notdeleteTest.TabIndex = 2;
            this.btn_notdeleteTest.Text = "Back";
            this.btn_notdeleteTest.UseVisualStyleBackColor = false;
            this.btn_notdeleteTest.Click += new System.EventHandler(this.btn_notdelete_Click);
            // 
            // delete_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 333);
            this.ControlBox = false;
            this.Controls.Add(this.btn_notdeleteTest);
            this.Controls.Add(this.btn_confirm_deletetest);
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
        private System.Windows.Forms.Button btn_confirm_deletetest;
        private System.Windows.Forms.Button btn_notdeleteTest;
    }
}