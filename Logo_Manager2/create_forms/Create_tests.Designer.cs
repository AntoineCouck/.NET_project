namespace Logo_Manager2.create_forms
{
    partial class Create_tests
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_new_patient = new System.Windows.Forms.Button();
            this.input_test_name = new System.Windows.Forms.TextBox();
            this.input_test_age = new System.Windows.Forms.TextBox();
            this.input_test_followup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_tests_maxage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(246, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Create a new test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Min. Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Follow_up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // btn_new_patient
            // 
            this.btn_new_patient.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_new_patient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_new_patient.FlatAppearance.BorderSize = 2;
            this.btn_new_patient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_patient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_new_patient.Location = new System.Drawing.Point(260, 340);
            this.btn_new_patient.Name = "btn_new_patient";
            this.btn_new_patient.Size = new System.Drawing.Size(130, 39);
            this.btn_new_patient.TabIndex = 19;
            this.btn_new_patient.Text = "Create";
            this.btn_new_patient.UseVisualStyleBackColor = false;
            this.btn_new_patient.Click += new System.EventHandler(this.btn_new_patient_Click);
            // 
            // input_test_name
            // 
            this.input_test_name.Location = new System.Drawing.Point(167, 175);
            this.input_test_name.Name = "input_test_name";
            this.input_test_name.Size = new System.Drawing.Size(122, 20);
            this.input_test_name.TabIndex = 15;
            // 
            // input_test_age
            // 
            this.input_test_age.Location = new System.Drawing.Point(381, 175);
            this.input_test_age.Name = "input_test_age";
            this.input_test_age.Size = new System.Drawing.Size(122, 20);
            this.input_test_age.TabIndex = 14;
            // 
            // input_test_followup
            // 
            this.input_test_followup.Location = new System.Drawing.Point(260, 292);
            this.input_test_followup.Name = "input_test_followup";
            this.input_test_followup.Size = new System.Drawing.Size(122, 20);
            this.input_test_followup.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Max age";
            // 
            // input_tests_maxage
            // 
            this.input_tests_maxage.Location = new System.Drawing.Point(381, 234);
            this.input_tests_maxage.Name = "input_tests_maxage";
            this.input_tests_maxage.Size = new System.Drawing.Size(122, 20);
            this.input_tests_maxage.TabIndex = 28;
            // 
            // Create_tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 414);
            this.Controls.Add(this.input_tests_maxage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_test_followup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_new_patient);
            this.Controls.Add(this.input_test_name);
            this.Controls.Add(this.input_test_age);
            this.Name = "Create_tests";
            this.Text = "Create_tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_new_patient;
        private System.Windows.Forms.TextBox input_test_name;
        private System.Windows.Forms.TextBox input_test_age;
        private System.Windows.Forms.TextBox input_test_followup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_tests_maxage;
    }
}