namespace Logo_Manager2.profile_forms
{
    partial class modify_patient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profile_edit_birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_modify_back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_modify_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_edit_lastname = new System.Windows.Forms.TextBox();
            this.input_edit_name = new System.Windows.Forms.TextBox();
            this.title_edit_patient = new System.Windows.Forms.Label();
            this.profile_edit_followby = new System.Windows.Forms.ComboBox();
            this.profile_edit_following_for = new System.Windows.Forms.ComboBox();
            this.logo_manager2DataSet = new Logo_Manager2.Logo_manager2DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.UsersTableAdapter();
            this.input_edit_insurance = new System.Windows.Forms.ComboBox();
            this.insurancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesTableAdapter = new Logo_Manager2.Logo_manager2DataSetTableAdapters.InsurancesTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.insurancesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.input_edit_insurance);
            this.groupBox1.Controls.Add(this.profile_edit_following_for);
            this.groupBox1.Controls.Add(this.profile_edit_followby);
            this.groupBox1.Controls.Add(this.profile_edit_birthday);
            this.groupBox1.Controls.Add(this.btn_modify_back);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_modify_confirm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.input_edit_lastname);
            this.groupBox1.Controls.Add(this.input_edit_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(221, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 225);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // profile_edit_birthday
            // 
            this.profile_edit_birthday.CustomFormat = "dd MMM yyyy";
            this.profile_edit_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.profile_edit_birthday.Location = new System.Drawing.Point(15, 97);
            this.profile_edit_birthday.Name = "profile_edit_birthday";
            this.profile_edit_birthday.Size = new System.Drawing.Size(146, 23);
            this.profile_edit_birthday.TabIndex = 32;
            // 
            // btn_modify_back
            // 
            this.btn_modify_back.BackColor = System.Drawing.Color.Red;
            this.btn_modify_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modify_back.Location = new System.Drawing.Point(188, 183);
            this.btn_modify_back.Name = "btn_modify_back";
            this.btn_modify_back.Size = new System.Drawing.Size(75, 23);
            this.btn_modify_back.TabIndex = 31;
            this.btn_modify_back.Text = "Back";
            this.btn_modify_back.UseVisualStyleBackColor = false;
            this.btn_modify_back.Click += new System.EventHandler(this.btn_modify_back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(248, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Follow by";
            // 
            // btn_modify_confirm
            // 
            this.btn_modify_confirm.BackColor = System.Drawing.Color.Green;
            this.btn_modify_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_modify_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modify_confirm.Location = new System.Drawing.Point(90, 183);
            this.btn_modify_confirm.Name = "btn_modify_confirm";
            this.btn_modify_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_modify_confirm.TabIndex = 30;
            this.btn_modify_confirm.Text = "Confirm";
            this.btn_modify_confirm.UseVisualStyleBackColor = false;
            this.btn_modify_confirm.Click += new System.EventHandler(this.btn_modify_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(233, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Following for";
            // 
            // input_edit_lastname
            // 
            this.input_edit_lastname.BackColor = System.Drawing.SystemColors.Menu;
            this.input_edit_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_edit_lastname.Location = new System.Drawing.Point(15, 64);
            this.input_edit_lastname.Name = "input_edit_lastname";
            this.input_edit_lastname.Size = new System.Drawing.Size(146, 26);
            this.input_edit_lastname.TabIndex = 2;
            // 
            // input_edit_name
            // 
            this.input_edit_name.BackColor = System.Drawing.SystemColors.Menu;
            this.input_edit_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_edit_name.Location = new System.Drawing.Point(15, 32);
            this.input_edit_name.Name = "input_edit_name";
            this.input_edit_name.Size = new System.Drawing.Size(146, 26);
            this.input_edit_name.TabIndex = 0;
            // 
            // title_edit_patient
            // 
            this.title_edit_patient.AutoSize = true;
            this.title_edit_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title_edit_patient.Location = new System.Drawing.Point(216, 72);
            this.title_edit_patient.Name = "title_edit_patient";
            this.title_edit_patient.Size = new System.Drawing.Size(104, 26);
            this.title_edit_patient.TabIndex = 29;
            this.title_edit_patient.Text = "Profile of ";
            // 
            // profile_edit_followby
            // 
            this.profile_edit_followby.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource4, "Name", true));
            this.profile_edit_followby.DataSource = this.usersBindingSource3;
            this.profile_edit_followby.DisplayMember = "Name";
            this.profile_edit_followby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profile_edit_followby.FormattingEnabled = true;
            this.profile_edit_followby.Location = new System.Drawing.Point(215, 64);
            this.profile_edit_followby.Name = "profile_edit_followby";
            this.profile_edit_followby.Size = new System.Drawing.Size(121, 24);
            this.profile_edit_followby.TabIndex = 33;
            this.profile_edit_followby.ValueMember = "Name";
            // 
            // profile_edit_following_for
            // 
            this.profile_edit_following_for.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profile_edit_following_for.FormattingEnabled = true;
            this.profile_edit_following_for.Items.AddRange(new object[] {
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
            this.profile_edit_following_for.Location = new System.Drawing.Point(215, 131);
            this.profile_edit_following_for.Name = "profile_edit_following_for";
            this.profile_edit_following_for.Size = new System.Drawing.Size(121, 24);
            this.profile_edit_following_for.TabIndex = 34;
            // 
            // logo_manager2DataSet
            // 
            this.logo_manager2DataSet.DataSetName = "Logo_manager2DataSet";
            this.logo_manager2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // input_edit_insurance
            // 
            this.input_edit_insurance.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.insurancesBindingSource2, "Name", true));
            this.input_edit_insurance.DataSource = this.insurancesBindingSource1;
            this.input_edit_insurance.DisplayMember = "Name";
            this.input_edit_insurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_edit_insurance.FormattingEnabled = true;
            this.input_edit_insurance.Location = new System.Drawing.Point(15, 131);
            this.input_edit_insurance.Name = "input_edit_insurance";
            this.input_edit_insurance.Size = new System.Drawing.Size(146, 24);
            this.input_edit_insurance.TabIndex = 35;
            this.input_edit_insurance.ValueMember = "Name";
            // 
            // insurancesBindingSource
            // 
            this.insurancesBindingSource.DataMember = "Insurances";
            this.insurancesBindingSource.DataSource = this.logo_manager2DataSet;
            // 
            // insurancesTableAdapter
            // 
            this.insurancesTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.logo_manager2DataSet;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.logo_manager2DataSet;
            // 
            // insurancesBindingSource1
            // 
            this.insurancesBindingSource1.DataMember = "Insurances";
            this.insurancesBindingSource1.DataSource = this.logo_manager2DataSet;
            // 
            // insurancesBindingSource2
            // 
            this.insurancesBindingSource2.DataMember = "Insurances";
            this.insurancesBindingSource2.DataSource = this.logo_manager2DataSet;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "Users";
            this.usersBindingSource3.DataSource = this.logo_manager2DataSet;
            // 
            // usersBindingSource4
            // 
            this.usersBindingSource4.DataMember = "Users";
            this.usersBindingSource4.DataSource = this.logo_manager2DataSet;
            // 
            // modify_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title_edit_patient);
            this.Controls.Add(this.groupBox1);
            this.Name = "modify_patient";
            this.Text = "modify_patient";
            this.Load += new System.EventHandler(this.modify_patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_manager2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurancesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_edit_lastname;
        private System.Windows.Forms.TextBox input_edit_name;
        private System.Windows.Forms.Button btn_modify_back;
        private System.Windows.Forms.Button btn_modify_confirm;
        private System.Windows.Forms.Label title_edit_patient;
        private System.Windows.Forms.DateTimePicker profile_edit_birthday;
        private System.Windows.Forms.ComboBox profile_edit_followby;
        private System.Windows.Forms.ComboBox profile_edit_following_for;
        private Logo_manager2DataSet logo_manager2DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Logo_manager2DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox input_edit_insurance;
        private System.Windows.Forms.BindingSource insurancesBindingSource;
        private Logo_manager2DataSetTableAdapters.InsurancesTableAdapter insurancesTableAdapter;
        private System.Windows.Forms.BindingSource insurancesBindingSource2;
        private System.Windows.Forms.BindingSource insurancesBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource4;
        private System.Windows.Forms.BindingSource usersBindingSource3;
    }
}