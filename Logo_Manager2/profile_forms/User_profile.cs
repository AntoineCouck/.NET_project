using System;
using System.Data;
using System.Data.Entity;
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

            var Patient = db.Patients.Where(x => x.Id == User_Dashboard.currentPatientId);


            foreach (var patient in Patient)
            {
                title_profile_patient.Text = "profile of:" + "" + patient.Lastname + " " + patient.Firstname;
                profile_info_firstname.Text = patient.Firstname;
                profile_info_lastname.Text = patient.Lastname;
                profile_info_birthday.Text = patient.Birthday.ToString();
                profile_info_followBy.Text = patient.UserName;

                if (patient.LeftSessions == 0)
                {
                    patient_total.Text = "0";
                }
                else
                {
                    patient_total.Text = patient.LeftSessions.ToString();
                }

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

        private void input_patient_add_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void input_patient_remove_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
