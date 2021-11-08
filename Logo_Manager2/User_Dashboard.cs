﻿using Logo_Manager2.create_forms;
using Logo_Manager2.profile_forms;
using Logo_Manager2.User_forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2
{
    public partial class User_Dashboard : Form
    {
        // instances of my forms 

        public static Log_in log_In = new Log_in();
        public static Sign_in sign_in = new Sign_in();
        public static create_new_patient create_patient = new create_new_patient();
        public static Create_tests create_Tests = new Create_tests();
        public static User_profile profile = new User_profile();
        public static delete_user delete_User = new delete_user();
        public static modify_patient modify_profile = new modify_patient(); 
        public static create_insurance create_Insurance = new create_insurance();
        public static bool is_connected = false;
        public static string username;
        public static int currentPatientId { get; set; }

        Logo_manager2Entities1 db = new Logo_manager2Entities1();

        public User_Dashboard()
        {
            InitializeComponent();
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {



            log_In.ShowDialog();
            username = log_In.username;
            is_connected = log_In.is_connected;

            AccountName.Text = username;

            if (is_connected)
            {
                // TODO: This line of code loads data into the 'logo_manager2DataSet.Insurances' table. You can move, or remove it, as needed.
                this.insurancesTableAdapter.Fill(this.logo_manager2DataSet.Insurances);
                // TODO: This line of code loads data into the 'logo_manager2DataSet.Tests' table. You can move, or remove it, as needed.
                this.testsTableAdapter.Fill(this.logo_manager2DataSet.Tests);
                // TODO: This line of code loads data into the 'logo_manager2DataSet.Patients' table. You can move, or remove it, as needed.
                this.patientsTableAdapter.Fill(this.logo_manager2DataSet.Patients);
                // TODO: This line of code loads data into the 'logo_manager2DataSet.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.logo_manager2DataSet.Users);
            }

        }


        private void disconnectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void managementToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // menu strip button 
        }

        private void btn_dashboard_add_patient_Click(object sender, System.EventArgs e)
        {

            create_patient.ShowDialog();
            if (create_patient.DialogResult == DialogResult.OK)
            {
                this.patientsTableAdapter.Fill(this.logo_manager2DataSet.Patients);
            }
        }

        private void btn_dashboard_add_test_Click(object sender, EventArgs e)
        {

            create_Tests.ShowDialog();


            if (create_Tests.DialogResult == DialogResult.OK)
            {
                this.testsTableAdapter.Fill(this.logo_manager2DataSet.Tests);
            }
        }

        private void patientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView data = (DataGridView)sender;
            int currentData = data.CurrentCell.RowIndex;
            int teller = 0;

            var result = db.Patients;

            foreach (var test in result)
            {
                if (teller == currentData)
                {
                    currentPatientId = test.Id;
                }

                teller++;
            }

            profile.ShowDialog();

            if (profile.DialogResult == DialogResult.OK)
            {
                this.patientsTableAdapter.Fill(this.logo_manager2DataSet.Patients);
            }

        }

        private void btn_dashboard_addInsurance_Click(object sender, EventArgs e)
        {
            create_Insurance.ShowDialog();

            if (create_Insurance.DialogResult == DialogResult.OK)
            {
                this.insurancesTableAdapter.Fill(this.logo_manager2DataSet.Insurances);
            }
        }


        private void refreshPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logo_manager2DataSet.Insurances' table. You can move, or remove it, as needed.
            this.insurancesTableAdapter.Fill(this.logo_manager2DataSet.Insurances);
            // TODO: This line of code loads data into the 'logo_manager2DataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.logo_manager2DataSet.Tests);
            // TODO: This line of code loads data into the 'logo_manager2DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.logo_manager2DataSet.Patients);
            // TODO: This line of code loads data into the 'logo_manager2DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.logo_manager2DataSet.Users);
        }

        private void createNewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_patient.ShowDialog();
        }

        private void createNewTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_Tests.ShowDialog();

        }

        private void createNewInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_Insurance.ShowDialog();
        }

        private void btn_delete_test_Click(object sender, EventArgs e)
        {

            if(comboBox1.Items.Count > 0)
            {
                string testName = comboBox1.Text;

                var tests = db.Tests.Where(x => x.Name == testName);


                foreach (var element in tests)
                {

                    db.Tests.Remove(element);

                }

                db.SaveChanges();
                MessageBox.Show("The test was succesfull deleted");
                this.testsTableAdapter.Fill(this.logo_manager2DataSet.Tests);



            } else
            {

                MessageBox.Show("Sorry but there are no tests at this moment");
            }




        }

        private void btn_delete_insurance_Click(object sender, EventArgs e)
        {

            if(comboBox2.Items.Count > 0)
            {

                string insuranceName = comboBox2.Text;

                var insurance = db.Insurances.Where(x => x.Name == insuranceName);


                foreach (var element in insurance)
                {

                    db.Insurances.Remove(element);

                }

                db.SaveChanges();
                MessageBox.Show("The insurance was succesfull deleted");
                this.insurancesTableAdapter.Fill(this.logo_manager2DataSet.Insurances);
            } else
            {
                MessageBox.Show("Sorry but there are no insurances at this moment");

            }

        }
    }
}
