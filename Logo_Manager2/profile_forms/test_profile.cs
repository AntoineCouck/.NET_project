using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class test_profile : Form
    {

        Logo_manager2Entities1 db = new Logo_manager2Entities1();

        public test_profile()
        {
            InitializeComponent();
        }

        private void test_profile_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            var tests = db.Tests.Where(x => x.Id == User_Dashboard.currentTestId);



            var ListTests = db.PatientsTests.Join(db.Patients, x => x.PatientId, y => y.Id, (x, y) => new
            {
                patienttest = x,
                pfirstName = y.Firstname,
                plastName = y.Lastname
            }).Join(db.Tests, x => x.patienttest.TestId, y => y.Id, (x, y) => new
            {
                patientTest2 = x,
                testId = y.Id,
                testName = y.Name
            }).Where(x => x.testId == User_Dashboard.currentTestId);


            if(User_Dashboard.modify_Test.followUp != null)
            {
                title_profile_test.Text = "Test:" + " " + User_Dashboard.modify_Test.Name;
                profile_test_name.Text = User_Dashboard.modify_Test.Name;
                profile_test_minage.Text = User_Dashboard.modify_Test.minAge.ToString();
                profile_test_maxage.Text = User_Dashboard.modify_Test.maxage.ToString();
                profile_test_followup.Text = User_Dashboard.modify_Test.followUp;

            } else
            {

                foreach (var element in tests)
                {

                    title_profile_test.Text = "Test:" + " " + element.Name;
                    profile_test_name.Text = element.Name;
                    profile_test_minage.Text = element.MinAge.ToString();
                    profile_test_maxage.Text = element.MaxAge.ToString();
                    profile_test_followup.Text = element.TypefollowUp;

                }

            }



            foreach (var element in ListTests)
            {
                listBox1.Items.Add(element.patientTest2.pfirstName + " " + element.patientTest2.plastName);
            }

        }

        private void btn_modify_test_Click(object sender, EventArgs e)
        {
            User_Dashboard.modify_Test.ShowDialog();

            if (User_Dashboard.modify_Test.DialogResult == DialogResult.OK)
            {
                title_profile_test.Text = "Test:" + " " + User_Dashboard.modify_Test.Name;
                profile_test_name.Text = User_Dashboard.modify_Test.Name;
                profile_test_minage.Text = User_Dashboard.modify_Test.minAge.ToString();
                profile_test_maxage.Text = User_Dashboard.modify_Test.maxage.ToString();
                profile_test_followup.Text = User_Dashboard.modify_Test.followUp;
            }

        }

        private void btn_del_test_Click(object sender, EventArgs e)
        {
            User_Dashboard.delete_Test.ShowDialog();
        }
    }
}
