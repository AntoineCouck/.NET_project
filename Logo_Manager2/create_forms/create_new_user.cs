using System;
using System.Windows.Forms;

namespace Logo_Manager2.create_forms
{
    public partial class create_new_patient : Form
    {

        Logo_managerEntities1 db = new Logo_managerEntities1();
        User_Dashboard d = new User_Dashboard();


        public create_new_patient()
        {
            InitializeComponent();
        }

        private void create_new_patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logo_managerDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.logo_managerDataSet.Users);

        }

        private void btn_new_patient_Click(object sender, EventArgs e)
        {
            var patient = new Patient();

            patient.Firstname = input_patient_firstname.Text;
            patient.Lastname = input_patient_lastname.Text;
            patient.Birthday = input_patient_birthday.Value;
            patient.Followup = input_patient_followup.Text;
            patient.UserName = input_patient_user.Text;

            db.Patients.Add(patient);

            db.SaveChanges();

            this.Close();

        }
    }
}
