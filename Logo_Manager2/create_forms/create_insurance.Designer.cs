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
            this.SuspendLayout();
            // 
            // input_insurance_telnr
            // 
            this.input_insurance_telnr.Location = new System.Drawing.Point(319, 201);
            this.input_insurance_telnr.Name = "input_insurance_telnr";
            this.input_insurance_telnr.Size = new System.Drawing.Size(122, 20);
            this.input_insurance_telnr.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tel. nr. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name";
            // 
            // input_insurance_name
            // 
            this.input_insurance_name.Location = new System.Drawing.Point(319, 131);
            this.input_insurance_name.Name = "input_insurance_name";
            this.input_insurance_name.Size = new System.Drawing.Size(122, 20);
            this.input_insurance_name.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(268, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Create a new insurance";
            // 
            // input_insurance_adres
            // 
            this.input_insurance_adres.Location = new System.Drawing.Point(319, 267);
            this.input_insurance_adres.Name = "input_insurance_adres";
            this.input_insurance_adres.Size = new System.Drawing.Size(122, 20);
            this.input_insurance_adres.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Adres";
            // 
            // btn_new_insurance
            // 
            this.btn_new_insurance.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_new_insurance.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_new_insurance.FlatAppearance.BorderSize = 2;
            this.btn_new_insurance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_insurance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_insurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_new_insurance.Location = new System.Drawing.Point(319, 346);
            this.btn_new_insurance.Name = "btn_new_insurance";
            this.btn_new_insurance.Size = new System.Drawing.Size(130, 39);
            this.btn_new_insurance.TabIndex = 36;
            this.btn_new_insurance.Text = "Create";
            this.btn_new_insurance.UseVisualStyleBackColor = false;
            this.btn_new_insurance.Click += new System.EventHandler(this.btn_new_insurance_Click);
            // 
            // create_insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_new_insurance);
            this.Controls.Add(this.input_insurance_adres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_insurance_telnr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_insurance_name);
            this.Name = "create_insurance";
            this.Text = "create_insurance";
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
    }
}