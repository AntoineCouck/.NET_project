using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class delete_user : Form
    {

        Logo_manager2Entities1 db = new Logo_manager2Entities1();

        public delete_user()
        {
            InitializeComponent();
        }
        private void delete_user_Load(object sender, EventArgs e)
        {
            var user = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);

            foreach (var element in user)
            {

                name.Text = name.Text + " " + element.Firstname + " " + element.Lastname + "?";

            }

        }

        private void btn_confirm_delete_Click(object sender, EventArgs e)
        {

            var user = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);

            var patientTest = db.PatientsTests.Where(x => x.PatientId == User_Dashboard.currentPatientId);

            foreach (var element in user)
            {
                db.Patients.Remove(element);
            }
            foreach (var element2 in patientTest)
            {
                db.PatientsTests.Remove(element2);
            }

            db.SaveChanges();
            this.Close();
            User_Dashboard.profile.Close();
            MessageBox.Show("The patient was deleted!");
        }

        private void btn_notdelete_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
