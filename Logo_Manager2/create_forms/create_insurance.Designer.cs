namespace Logo_Manager2.create_forms
{
    partial class create_insurance
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
            this.input_insurance_telnr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_insurance_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_insurance_adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_new_insurance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_insurance_telnr
            // 
            this.input_insurance_telnr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_insurance_telnr.Location = new System.Drawing.Point(74, 135);
            this.input_insurance_telnr.Name = "input_insurance_telnr";
            this.input_insurance_telnr.Size = new System.Drawing.Size(227, 29);
            this.input_insurance_telnr.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tel. nr. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name:";
            // 
            // input_insurance_name
            // 
            this.input_insurance_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_insurance_name.Location = new System.Drawing.Point(74, 65);
            this.input_insurance_name.Name = "input_insurance_name";
            this.input_insurance_name.Size = new System.Drawing.Size(227, 29);
            this.input_insurance_name.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Create a new insurance";
            // 
            // input_insurance_adres
            // 
            this.input_insurance_adres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_insurance_adres.Location = new System.Drawing.Point(74, 201);
            this.input_insurance_adres.Name = "input_insurance_adres";
            this.input_insurance_adres.Size = new System.Drawing.Size(227, 29);
            this.input_insurance_adres.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Adres:";
            // 
            // btn_new_insurance
            // 
            this.btn_new_insurance.BackColor = System.Drawing.Color.LightCyan;
            this.btn_new_insurance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_new_insurance.FlatAppearance.BorderSize = 2;
            this.btn_new_insurance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_insurance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_insurance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_new_insurance.Location = new System.Drawing.Point(127, 245);
            this.btn_new_insurance.Name = "btn_new_insurance";
            this.btn_new_insurance.Size = new System.Drawing.Size(130, 39);
            this.btn_new_insurance.TabIndex = 36;
            this.btn_new_insurance.Text = "Create";
            this.btn_new_insurance.UseVisualStyleBackColor = false;
            this.btn_new_insurance.Click += new System.EventHandler(this.btn_new_insurance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.input_insurance_adres);
            this.groupBox1.Controls.Add(this.btn_new_insurance);
            this.groupBox1.Controls.Add(this.input_insurance_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.input_insurance_telnr);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(202, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 308);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "mutual company";
            // 
            // create_insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "create_insurance";
            this.Text = "create_insurance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_insurance_telnr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_insurance_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_insurance_adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_new_insurance;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}