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
            this.usersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.logo_manager2DataSet = new Logo_Manager2.Logo_manager2DataSet();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.input_patient_birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_new_patient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_patient_followup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.input_patient_insurance = new System.Windows.Forms.ComboBox();
            this.insurancesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Logo_Manager2.Logo_manager2DataSetTableAdapters.TableAdapterManager();
            this.insurancesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.InsurancesTableAdapter();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.PatientsTableAdapter();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.TestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
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
            this.input_patient_user.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource4, "Name", true));
            this.input_patient_user.DataSource = this.usersBindingSource3;
            this.input_patient_user.DisplayMember = "Name";
            this.input_patient_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_patient_user.FormattingEnabled = true;
            this.input_patient_user.Location = new System.Drawing.Point(453, 169);
            this.input_patient_user.Name = "input_patient_user";
            this.input_patient_user.Size = new System.Drawing.Size(152, 21);
            this.input_patient_user.TabIndex = 5;
            this.input_patient_user.ValueMember = "Name";
            // 
            // usersBindingSource4
            // 
            this.usersBindingSource4.DataMember = "Users";
            this.usersBindingSource4.DataSource = this.logo_manager2DataSet;
            // 
            // logo_manager2DataSet
            // 
            this.logo_manager2DataSet.DataSetName = "Logo_manager2DataSet";
            this.logo_manager2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "Users";
            this.usersBindingSource3.DataSource = this.logo_manager2DataSet;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
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
            this.label4.Location = new System.Drawing.Point(488, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Follow_up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "DR";
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
            this.input_patient_followup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.input_patient_followup.Location = new System.Drawing.Point(453, 116);
            this.input_patient_followup.Name = "input_patient_followup";
            this.input_patient_followup.Size = new System.Drawing.Size(152, 21);
            this.input_patient_followup.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Insurance";
            // 
            // input_patient_insurance
            // 
            this.input_patient_insurance.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.insurancesBindingSource4, "Name", true));
            this.input_patient_insurance.DataSource = this.insurancesBindingSource3;
            this.input_patient_insurance.DisplayMember = "Name";
            this.input_patient_insurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_patient_insurance.FormattingEnabled = true;
            this.input_patient_insurance.Location = new System.Drawing.Point(453, 240);
            this.input_patient_insurance.Name = "input_patient_insurance";
            this.input_patient_insurance.Size = new System.Drawing.Size(152, 21);
            this.input_patient_insurance.TabIndex = 17;
            this.input_patient_insurance.ValueMember = "Name";
            // 
            // insurancesBindingSource4
            // 
            this.insurancesBindingSource4.DataMember = "Insurances";
            this.insurancesBindingSource4.DataSource = this.logo_manager2DataSet;
            // 
            // insurancesBindingSource3
            // 
            this.insurancesBindingSource3.DataMember = "Insurances";
            this.insurancesBindingSource3.DataSource = this.logo_manager2DataSet;
            // 
            // insurancesBindingSource1
            // 
            this.insurancesBindingSource1.DataMember = "Insurances";
            // 
            // insurancesBindingSource
            // 
            this.insurancesBindingSource.DataMember = "Insurances";
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.logo_manager2DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InsurancesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.PatientsTestsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Logo_Manager2.Logo_manager2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // insurancesBindingSource2
            // 
            this.insurancesBindingSource2.DataMember = "Insurances";
            this.insurancesBindingSource2.DataSource = this.logo_manager2DataSet;
            // 
            // insurancesTableAdapter
            // 
            this.insurancesTableAdapter.ClearBeforeFill = true;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // create_new_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 657);
            this.Controls.Add(this.input_patient_insurance);
            this.Controls.Add(this.label7);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_patient_lastname;
        private System.Windows.Forms.TextBox input_patient_firstname;
        private System.Windows.Forms.DateTimePicker input_patient_birthday;
        private System.Windows.Forms.Button btn_new_patient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private BindingSource usersBindingSource;
        private BindingSource usersBindingSource1;
        private Label label5;
        private ComboBox input_patient_followup;
        private Label label7;
        private BindingSource insurancesBindingSource;
        private BindingSource insurancesBindingSource1;
        private Logo_manager2DataSet logo_manager2DataSet;
        private BindingSource usersBindingSource2;
        private Logo_manager2DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Logo_manager2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource insurancesBindingSource2;
        private Logo_manager2DataSetTableAdapters.InsurancesTableAdapter insurancesTableAdapter;
        private BindingSource patientsBindingSource;
        private Logo_manager2DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private BindingSource testsBindingSource;
        private Logo_manager2DataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        public ComboBox input_patient_user;
        public ComboBox input_patient_insurance;
        private BindingSource usersBindingSource4;
        private BindingSource usersBindingSource3;
        private BindingSource insurancesBindingSource4;
        private BindingSource insurancesBindingSource3;
    }
}