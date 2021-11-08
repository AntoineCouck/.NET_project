using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class delete_test : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        public delete_test()
        {
            InitializeComponent();
        }
        private void delete_test_Load(object sender, EventArgs e)
        {
            var test = db.Tests.Where(x => x.Id == User_Dashboard.currentTestId);

            foreach (var element in test)
            {

                name.Text = name.Text + " " + element.Name  + "?";

            }
        }

        private void btn_confirm_delete_Click(object sender, EventArgs e)
        {
            var tests = db.Tests.Where(x => x.Id == User_Dashboard.currentTestId);

            //var patientTest = db.PatientsTests.Where(x => x.TestId == User_Dashboard.currentTestId);

            foreach (var test in tests)
            {
                db.Tests.Remove(test);
            }
            //foreach (var element2 in patientTest)
            //{
            //    db.PatientsTests.Remove(element2);
            //}

            db.SaveChanges();
            this.Close();
            User_Dashboard.test_Profile.Close();
            MessageBox.Show("The test was deleted!");
        }

        private void btn_notdelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
