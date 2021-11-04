using System.Windows.Forms;

namespace Logo_Manager2.create_forms
{
    partial class create_new_patient
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
            this.components = new System.ComponentModel.Container();
            this.input_patient_lastname = new System.Windows.Forms.TextBox();
            this.input_patient_firstname = new System.Windows.Forms.TextBox();
            this.input_patient_user = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logo_managerDataSet = new Logo_Manager2.Logo_managerDataSet();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.input_patient_birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_new_patient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new Logo_Manager2.Logo_managerDataSetTableAdapters.UsersTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.input_patient_followup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_managerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // input_patient_lastname
            // 
            this.input_patient_lastname.Location = new System.Drawing.Point(216, 169);
            this.input_patient_lastname.Name = "input_patient_lastname";
            this.input_patient_lastname.Size = new System.Drawing.Size(122, 20);
            this.input_patient_lastname.TabIndex = 1;
            // 
            // input_patient_firstname
            // 
            this.input_patient_firstname.Location = new System.Drawing.Point(216, 117);
            this.input_patient_firstname.Name = "input_patient_firstname";
            this.input_patient_firstname.Size = new System.Drawing.Size(122, 20);
            this.input_patient_firstname.TabIndex = 2;
            // 
            // input_patient_user
            // 
            this.input_patient_user.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "Name", true));
            this.input_patient_user.DataSource = this.usersBindingSource1;
            this.input_patient_user.DisplayMember = "Name";
            this.input_patient_user.FormattingEnabled = true;
            this.input_patient_user.Location = new System.Drawing.Point(467, 223);
            this.input_patient_user.Name = "input_patient_user";
            this.input_patient_user.Size = new System.Drawing.Size(122, 21);
            this.input_patient_user.TabIndex = 5;
            this.input_patient_user.ValueMember = "Name";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.logo_managerDataSet;
            // 
            // logo_managerDataSet
            // 
            this.logo_managerDataSet.DataSetName = "Logo_managerDataSet";
            this.logo_managerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.logo_managerDataSet;
            // 
            // input_patient_birthday
            // 
            this.input_patient_birthday.CustomFormat = "dd MMM yyyy";
            this.input_patient_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_patient_birthday.Location = new System.Drawing.Point(216, 237);
            this.input_patient_birthday.Name = "input_patient_birthday";
            this.input_patient_birthday.Size = new System.Drawing.Size(122, 20);
            this.input_patient_birthday.TabIndex = 6;
            this.input_patient_birthday.Value = new System.DateTime(2021, 11, 2, 0, 0, 0, 0);
            // 
            // btn_new_patient
            // 
            this.btn_new_patient.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_new_patient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_new_patient.FlatAppearance.BorderSize = 2;
            this.btn_new_patient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_patient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_new_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_new_patient.Location = new System.Drawing.Point(344, 306);
            this.btn_new_patient.Name = "btn_new_patient";
            this.btn_new_patient.Size = new System.Drawing.Size(130, 39);
            this.btn_new_patient.TabIndex = 7;
            this.btn_new_patient.Text = "Create";
            this.btn_new_patient.UseVisualStyleBackColor = false;
            this.btn_new_patient.Click += new System.EventHandler(this.btn_new_patient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Follow_up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "DR";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(299, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Create a new patient";
            // 
            // input_patient_followup
            // 
            this.input_patient_followup.FormattingEnabled = true;
            this.input_patient_followup.Items.AddRange(new object[] {
            "a: Handicap poursuite profession 55",
            "b1: Aphasie 288",
            "b2: Langage oral ",
            "b3: Dyslexie, dysorthographie, dyscalculie ",
            "b4: Fentes 3",
            "b5: Radiothérapie/chirurgie ",
            "b6.1: Dysglossies ",
            "b6.2: Dysarthries ",
            "b6.3: Troubles chroniques de la parole ",
            "b6.4: Bégaiement ",
            "b6.5: Troubles myofonctionnels ",
            "c1: Laryngectomie ",
            "c2: Troubles organiques (voix) ",
            "d: Troubles de l’ouïe",
            "e: Dysphagie ",
            "f: Dysphasie ",
            "g: Locked-in syndrome (30min)"});
            this.input_patient_followup.Location = new System.Drawing.Point(452, 169);
            this.input_patient_followup.Name = "input_patient_followup";
            this.input_patient_followup.Size = new System.Drawing.Size(152, 21);
            this.input_patient_followup.TabIndex = 14;
            // 
            // create_new_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 455);
            this.Controls.Add(this.input_patient_followup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_new_patient);
            this.Controls.Add(this.input_patient_birthday);
            this.Controls.Add(this.input_patient_user);
            this.Controls.Add(this.input_patient_firstname);
            this.Controls.Add(this.input_patient_lastname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "create_new_patient";
            this.Text = "Create a new patient";
            this.Load += new System.EventHandler(this.create_new_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_managerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_patient_lastname;
        private System.Windows.Forms.TextBox input_patient_firstname;
        private System.Windows.Forms.ComboBox input_patient_user;
        private System.Windows.Forms.DateTimePicker input_patient_birthday;
        private System.Windows.Forms.Button btn_new_patient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Logo_managerDataSet logo_managerDataSet;
        private BindingSource usersBindingSource;
        private Logo_managerDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private BindingSource usersBindingSource1;
        private Label label5;
        private ComboBox input_patient_followup;
    }
}