using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Logo_Manager2.profile_forms
{
    public partial class User_profile : Form
    {

        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        public delegate int leftSessionsdelegate(int total  , int remove , int add);
        public event leftSessionsdelegate NomoreSessions;
        public List<int> _patientId = new List<int>();
        public List<string> _FirstName = new List<string>();
        public List<string> _LastName = new List<string>();
        public List<string> _birthday = new List<string>();
        public List<string> _UserName = new List<string>();
        public List<string> _followup = new List<string>();
        public List<string> _insurance = new List<string>();

        public IList<int> patientId { get { return _patientId; } }
        public IList<string> FirstName { get { return _FirstName; } }
        public IList<string> LastName { get { return _LastName; } }
        public IList<string> birthday { get { return _birthday; } }
        public IList<string> UserName { get { return _UserName; } }
        public IList<string> followup { get { return _followup; } }
        public IList<string> insurance { get { return _insurance; } }


        public User_profile()
        {
            InitializeComponent();
            NomoreSessions += new leftSessionsdelegate(this.CheckNoMoreSessions);
            
        }

        public int CheckNoMoreSessions(int total, int remove , int add)
        {
        
            return total + add - remove;

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

            if (patientId.Contains(User_Dashboard.currentPatientId))
            {
                int index = patientId.IndexOf(User_Dashboard.currentPatientId);

                title_profile_patient.Text = "profile of:" + "" + LastName[index] + " " + FirstName[index];
                profile_info_firstname.Text = FirstName[index];
                profile_info_lastname.Text = LastName[index];
                profile_info_birthday.Text = birthday[index];
                profile_info_followBy.Text = UserName[index];
                input_paztient_insurance.Text = insurance[index];
                textBox1.Text = followup[index];
            }
            else
            {
                foreach (var patient in Patient)
                {
                    title_profile_patient.Text = "profile of:" + "" + patient.Lastname + " " + patient.Firstname;
                    profile_info_firstname.Text = patient.Firstname;
                    profile_info_lastname.Text = patient.Lastname;
                    profile_info_birthday.Text = patient.Birthday.ToString();
                    profile_info_followBy.Text = patient.UserName;
                    input_paztient_insurance.Text = patient.InsuranceName;
                    textBox1.Text = patient.Followup;
                }
            }
            foreach (var patient in Patient)
            {
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

             RemoveChange();


            foreach (var patient in Patient)
            {

                if ((patient.LeftSessions + Add - remove )< 0)
                {
                    patient.LeftSessions = 0;
                } else
                {
                  patient.LeftSessions = patient.LeftSessions + Add - remove;

                }

              
                patient_total.Text = patient.LeftSessions.ToString();
            }

            db.SaveChanges();
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

                if (!patientId.Contains(User_Dashboard.currentPatientId))
                {
                    _patientId.Add(User_Dashboard.currentPatientId);
                    _FirstName.Add(User_Dashboard.modify_profile.FirstName);
                    _LastName.Add(User_Dashboard.modify_profile.LastName);
                    _birthday.Add(User_Dashboard.modify_profile.birthday);
                    _UserName.Add(User_Dashboard.modify_profile.UserName);
                    _followup.Add(User_Dashboard.modify_profile.followup);
                    _insurance.Add(User_Dashboard.modify_profile.insurance);
                }
                else
                {
                    int index = patientId.IndexOf(User_Dashboard.currentPatientId);

                    FirstName[index] = User_Dashboard.modify_profile.FirstName;
                    LastName[index] = User_Dashboard.modify_profile.LastName;
                    birthday[index] = User_Dashboard.modify_profile.birthday;
                    UserName[index] = User_Dashboard.modify_profile.UserName;
                    insurance[index] = User_Dashboard.modify_profile.followup;
                    followup[index] = User_Dashboard.modify_profile.insurance;

                }


            }
        }



        public void RemoveChange()
        {

            User_profile user_Profile = new User_profile();
            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);
            int result = 0;

            foreach (var element in Patient)
            {

                result = user_Profile.NomoreSessions(element.LeftSessions, (int)input_patient_remove.Value , (int)input_patient_add.Value);
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
