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
            //// TODO: This line of code loads data into the 'logo_managerDataSet.Insurances' table. You can move, or remove it, as needed.
            //this.insurancesTableAdapter1.Fill(this.logo_managerDataSet2.Insurances);
            //this.insurancesTableAdapter1.Fill(this.logo_manager2DataSet.Insurances);
            //// TODO: This line of code loads data into the 'logo_managerDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter1.Fill(this.logo_managerDataSet2.Users);

        }

        private void btn_new_patient_Click(object sender, EventArgs e)
        {
            var patient = new Patient();
            bool createPatient = true;

            var result = db.Patients;
            //var Users = db.Users;
            //var insurances = db.Insurances;

            if (string.IsNullOrEmpty(input_patient_firstname.Text) == true)
            {
                MessageBox.Show("The given firstName  must be completed");
                createPatient = false;
                input_patient_firstname.Text = null;
                input_patient_lastname.Text = null;
                input_patient_birthday.Value = DateTime.Now;
                input_patient_followup.Text = null;
                input_patient_user.Text = null;
                input_patient_insurance.Text = null;
            }
            else if (string.IsNullOrEmpty(input_patient_lastname.Text) == true)
            {
                MessageBox.Show("The given lastname  must be completed");
                createPatient = false;
                input_patient_firstname.Text = null;
                input_patient_lastname.Text = null;
                input_patient_birthday.Value = DateTime.Now;
                input_patient_followup.Text = null;
                input_patient_user.Text = null;
                input_patient_insurance.Text = null;

            }

            else if (input_patient_firstname.Text.Length > 50 || input_patient_lastname.Text.Length > 50)
            {
                MessageBox.Show("LastName or Firstname are too large , max 50 chars.");
                createPatient = false;
                input_patient_firstname.Text = null;
                input_patient_lastname.Text = null;
                input_patient_birthday.Value = DateTime.Now;
                input_patient_followup.Text = null;
                input_patient_user.Text = null;
                input_patient_insurance.Text = null;
            }


            else if (input_patient_birthday.Value > DateTime.Now)
            {
                MessageBox.Show("The birthday is in the future, try again please");
                createPatient = false;
                input_patient_firstname.Text = null;
                input_patient_lastname.Text = null;
                input_patient_birthday.Value = DateTime.Now;
                input_patient_followup.Text = null;
                input_patient_user.Text = null;
                input_patient_insurance.Text = null;
            }
            else
            {
                createPatient = true;
            }



            foreach (var element in result)
            {
                if (element.Firstname == input_patient_firstname.Text && element.Lastname == input_patient_lastname.Text && !(string.IsNullOrEmpty(input_patient_firstname.Text)))
                {
                    MessageBox.Show("This duo of first + lastname are already in use, try again");
                    createPatient = false;
                    input_patient_firstname.Text = null;
                    input_patient_lastname.Text = null;
                    input_patient_birthday.Value = DateTime.Now;
                    input_patient_followup.Text = null;
                    input_patient_user.Text = null;
                    input_patient_insurance.Text = null;
                }

            }

            bool isNottrue = true;

          
            foreach(var element in input_patient_followup.Items)
            {
                if(element.ToString() == input_patient_followup.Text )
                {
                    isNottrue = false;
                }
            }

            if(isNottrue && !(string.IsNullOrEmpty(input_patient_firstname.Text)))
            {
                MessageBox.Show("the followUp must be part the list");
                createPatient = false;
                input_patient_firstname.Text = null;
                input_patient_lastname.Text = null;
                input_patient_birthday.Value = DateTime.Now;
                input_patient_followup.Text = null;
                input_patient_user.Text = null;
                input_patient_insurance.Text = null;
                isNottrue = false;
            }

            //foreach(var user in input_patient_user.Items)
            //{
            //    if(input_patient_user.Text == user.ToString())
            //    {
            //        isNottrue = false;
            //        MessageBox.Show("sedfezsdfq");
            //    }
            //}

            //if(isNottrue && !(string.IsNullOrEmpty(input_patient_firstname.Text)))
            //{
            //    MessageBox.Show("the User must be part the list");
            //    createPatient = false;
            //    input_patient_firstname.Text = null;
            //    input_patient_lastname.Text = null;
            //    input_patient_birthday.Value = DateTime.Now;
            //    input_patient_followup.Text = null;
            //    input_patient_user.Text = null;
            //    input_patient_insurance.Text = null;
            //    isNottrue = false;
            //}


            if (createPatient == true)
            {
                patient.Firstname = input_patient_firstname.Text;
                patient.Lastname = input_patient_lastname.Text;
                patient.Birthday = input_patient_birthday.Value;
                patient.Followup = input_patient_followup.Text;
                patient.UserName = input_patient_user.Text;
                patient.InsuranceName = input_patient_insurance.Text;

                db.Patients.Add(patient);

                db.SaveChanges();

                input_patient_firstname.Text = null;
                input_patient_lastname.Text = null;
                input_patient_birthday.Value = DateTime.Now;
                input_patient_followup.Text = null;
                input_patient_user.Text = null;
                input_patient_insurance.Text = null;

                this.Close();
            }

        

        }
    }
}
