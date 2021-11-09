using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Logo_Manager2.profile_forms
{
    public partial class User_profile : Form
    {

        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        public delegate int leftSessionsdelegate(int total  , int remove);
        public event leftSessionsdelegate NomoreSessions;



        public User_profile()
        {
            InitializeComponent();
            NomoreSessions += new leftSessionsdelegate(this.CheckNoMoreSessions);
        }

        public int CheckNoMoreSessions(int total, int remove)
        {
        
            return total - remove;

        }


        private void User_profile_Load(object sender, EventArgs e)
        {
            testsList.Items.Clear();


            this.testsTableAdapter1.Fill(this.logo_manager2DataSet.Tests);

            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);

            var ListTests = db.PatientsTests.Join(db.Patients, x => x.PatientId, y => y.Id, (x, y) => new
            {
                patienttest = x,
                patientId = y.Id
            }).Join(db.Tests, x => x.patienttest.TestId, y => y.Id, (x, y) => new
            {
                patientTest2 = x,
                testId = y.Id,
                testName = y.Name
            }).Where(x => x.patientTest2.patientId == User_Dashboard.currentPatientId);



            foreach (var patient in Patient)
            {
                title_profile_patient.Text = "profile of:" + "" + patient.Lastname + " " + patient.Firstname;
                profile_info_firstname.Text = patient.Firstname;
                profile_info_lastname.Text = patient.Lastname;
                profile_info_birthday.Text = patient.Birthday.ToString();
                profile_info_followBy.Text = patient.UserName;
                input_paztient_insurance.Text = patient.InsuranceName;
                textBox1.Text = patient.Followup;

                if (patient.LeftSessions == 0)
                {
                    patient_total.Text = "0";
                }
                else
                {
                    patient_total.Text = patient.LeftSessions.ToString();
                }

            }

            foreach (var element in ListTests)
            {
                testsList.Items.Add(element.testName);
            }




        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);


            int Add = int.Parse(input_patient_add.Value.ToString());
            int remove = int.Parse(input_patient_remove.Value.ToString());



            foreach (var patient in Patient)
            {
                patient.LeftSessions = patient.LeftSessions + Add - remove;

                if (patient.LeftSessions + Add - remove < 0)
                {
                    patient.LeftSessions = 0;
                } 

              
                patient_total.Text = patient.LeftSessions.ToString();
            }

            db.SaveChanges();
             RemoveChange();
            input_patient_add.Value = 0;
            input_patient_remove.Value = 0;

        }



        private void btn_add_test_to_patient_Click(object sender, EventArgs e)
        {
            testsList.Items.Clear();

            var list = db.Tests.Where(x => x.Name == comboBox1.Text);
            int testId = 0;

            foreach (var element in list)
            {
                testId = element.Id;
            }


            var Patienttest = new PatientsTest();
            Patienttest.PatientId = User_Dashboard.currentPatientId;
            Patienttest.TestId = testId;

            db.PatientsTests.Add(Patienttest);
            db.SaveChanges();


            var ListTests = db.PatientsTests.Join(db.Patients, x => x.PatientId, y => y.Id, (x, y) => new
            {
                patienttest = x,
                patientId = y.Id
            }).Join(db.Tests, x => x.patienttest.TestId, y => y.Id, (x, y) => new
            {
                patientTest2 = x,
                testId = y.Id,
                testName = y.Name
            }).Where(x => x.patientTest2.patientId == User_Dashboard.currentPatientId);

            foreach (var element in ListTests)
            {
                testsList.Items.Add(element.testName);
            }



        }

        private void btn_del_user_Click(object sender, EventArgs e)
        {
            User_Dashboard.delete_User.ShowDialog();

        }

        private void btn_modify_user_Click(object sender, EventArgs e)
        {
            User_Dashboard.modify_profile.ShowDialog();

            if (User_Dashboard.modify_profile.DialogResult == DialogResult.OK)
            {




                title_profile_patient.Text = "profile of:" + "" + User_Dashboard.modify_profile.LastName + " " + User_Dashboard.modify_profile.FirstName;
                profile_info_firstname.Text = User_Dashboard.modify_profile.FirstName;
                profile_info_lastname.Text = User_Dashboard.modify_profile.LastName;
                profile_info_birthday.Text = User_Dashboard.modify_profile.birthday;
                profile_info_followBy.Text = User_Dashboard.modify_profile.UserName;
                input_paztient_insurance.Text = User_Dashboard.modify_profile.insurance;
                textBox1.Text = User_Dashboard.modify_profile.followup;



            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //private void input_patient_remove_ValueChanged(object sender, EventArgs e)
        //{
        //    RemoveChange();

        //}

        public void RemoveChange()
        {

            User_profile user_Profile = new User_profile();
            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);
            int result = 0;

            foreach (var element in Patient)
            {

                result = user_Profile.NomoreSessions(element.LeftSessions, (int)input_patient_remove.Value);
            }

            if (result <= 0)
            {
                input_patient_remove.Enabled = false;
                MessageBox.Show("The patient has reached the max sessions , there are no sessions left");
            }
            else
            {
                input_patient_remove.Enabled = true;
            }


        }
    }
}
