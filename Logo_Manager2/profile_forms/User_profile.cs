using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class User_profile : Form
    {

        Logo_managerEntities1 db = new Logo_managerEntities1();




        public User_profile()
        {
            InitializeComponent();
        }

        private void User_profile_Load(object sender, EventArgs e)
        {
            testsList.Items.Clear();
            // TODO: This line of code loads data into the 'logo_managerDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.logo_managerDataSet.Tests);
            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);

            var ListTests = db.PatientsTests.Join( db.Patients, x => x.PatientId, y => y.Id, (x, y) => new
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

            foreach(var element in list)
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
    }
}
