using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Logo_Manager2.profile_forms
{
    public partial class modify_patient : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string birthday { get; set; }

        public string UserName { get; set; }

        public string followup { get; set; }

        public string insurance { get; set; }

    


        public modify_patient()
        {
            InitializeComponent();
        }
        private void modify_patient_Load(object sender, EventArgs e)
        {

            var insurances = db.Insurances.Select(x => x.Name).ToArray();
            var users = db.Users.Select(x => x.Name).ToArray();
            input_edit_insurance.DataSource = insurances;
            profile_edit_followby.DataSource = users;

            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);

                foreach (var patient in Patient)
                {
                    title_edit_patient.Text = "profile of:" + "" + patient.Lastname + " " + patient.Firstname;
                    input_edit_name.Text = patient.Firstname;
                    input_edit_lastname.Text = patient.Lastname;
                    profile_edit_birthday.Text = patient.Birthday.ToString();
                     profile_edit_followby.Text = patient.UserName;
                     input_edit_insurance.Text = patient.InsuranceName;
                    profile_edit_following_for.Text = patient.Followup;

                 

                }
                
                

         
        }

        private void btn_modify_confirm_Click(object sender, EventArgs e)
        {
            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);
            bool edit_Patient = true;


            if (input_edit_name.Text.Length > 50 || (string.IsNullOrEmpty(input_edit_name.Text) == true))
            {

                MessageBox.Show("The Firstname is too large or empty , try again please");
                input_edit_name.Text = null;
                edit_Patient = false;

            }
            else if (input_edit_lastname.Text.Length > 50 || (string.IsNullOrEmpty(input_edit_lastname.Text) == true))
            {
                MessageBox.Show("The Lastname is too large or empty , try again please");
                input_edit_lastname.Text = null;
                edit_Patient = false;

            }
            else if (profile_edit_birthday.Value > DateTime.Now)
            {
                MessageBox.Show("This date is in the future , try again");
                profile_edit_birthday.Value = DateTime.Now;
                edit_Patient = false;
            }
            else
            {
                edit_Patient = true;
            }




            if (edit_Patient)
            {



                foreach (var patient in Patient)
                {

                    patient.Firstname = input_edit_name.Text;
                    patient.Lastname = input_edit_lastname.Text;
                    patient.Birthday = profile_edit_birthday.Value;
                    patient.UserName = profile_edit_followby.Text;
                    patient.Followup = profile_edit_following_for.Text;
                    patient.InsuranceName = input_edit_insurance.Text;

                }


                FirstName = input_edit_name.Text;
                LastName = input_edit_lastname.Text;
                birthday = profile_edit_birthday.Value.ToString();
                UserName = profile_edit_followby.Text;
                followup = profile_edit_following_for.Text;
                insurance = input_edit_insurance.Text;


                db.SaveChanges();
                MessageBox.Show("the patient was succesfull modified");


            }


        }

        private void btn_modify_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
