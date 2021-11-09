using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class delete_insurance : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();

        public delete_insurance()
        {
            InitializeComponent();
        }

        private void delete_insurance_Load(object sender, EventArgs e)
        {
            var insurances = db.Insurances.Where(x => x.Name == User_Dashboard.currentInsuranceId);

            foreach (var element in insurances)
            {

                title_del_insurance.Text = title_del_insurance.Text + " " + element.Name + "?";

            }
        }

        private void btn_confirm_delete_insurance_Click(object sender, EventArgs e)
        {
            var insurances = db.Insurances.Where(x => x.Name == User_Dashboard.currentInsuranceId);

            //var patientTest = db.PatientsTests.Where(x => x.TestId == User_Dashboard.currentTestId);

            foreach (var insurance in insurances)
            {
                db.Insurances.Remove(insurance);
            }
            //foreach (var element2 in patientTest)
            //{
            //    db.PatientsTests.Remove(element2);
            //}

            db.SaveChanges();
            this.Close();
            User_Dashboard.insurance_Profile.Close();
            MessageBox.Show("The insurance was deleted!");
        }

        private void btn_notdelete_insurance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
