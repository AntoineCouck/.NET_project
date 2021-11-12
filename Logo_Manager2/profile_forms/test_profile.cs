using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class test_profile : Form
    {

        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        public List<int> _Id = new List<int>();
        public List<string> _Name = new List<string>();
        public List<int> _Minage = new List<int>();
        public List<int> _Maxage = new List<int>();
        public List<string> _Followup = new List<string>();
    

        public IList<int>   Id { get { return _Id; } }
        public IList<string> dName { get { return _Name; } }
        public IList<int> Minage { get { return _Minage; } }
        public IList<int> Maxage { get { return _Maxage; } }
        public IList<string> Followup { get { return _Followup; } }
   
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


            if (Id.Contains(User_Dashboard.currentTestId))
            {
                int index = Id.IndexOf(User_Dashboard.currentTestId);

                title_profile_test.Text = "Test:" + " " + dName[index];
                profile_test_name.Text = dName[index];
                profile_test_minage.Text = Minage[index].ToString();
                profile_test_maxage.Text = Maxage[index].ToString();
                profile_test_followup.Text = Followup[index];

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

                if (Id.Contains(User_Dashboard.currentTestId))
                {
                    int index = Id.IndexOf(User_Dashboard.currentTestId);

                    dName[index] = User_Dashboard.modify_Test.Name;
                    Minage[index] = User_Dashboard.modify_Test.minAge;
                    Maxage[index] = User_Dashboard.modify_Test.maxage;
                    Followup[index] = User_Dashboard.modify_Test.followUp;
                }
                else
                {
                    _Id.Add(User_Dashboard.currentTestId);
                    _Name.Add(User_Dashboard.modify_Test.Name);
                    _Minage.Add(User_Dashboard.modify_Test.minAge);
                    _Maxage.Add(User_Dashboard.modify_Test.maxage);
                    _Followup.Add(User_Dashboard.modify_Test.followUp);
                }

            }

        }

        private void btn_del_test_Click(object sender, EventArgs e)
        {
            User_Dashboard.delete_Test.ShowDialog();
        }
    }
}
