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
            

            foreach(var patient in Patient)
            {
                title_profile_patient.Text = "profile of:" + "" + patient.Lastname + " " + patient.Firstname;
                profile_info_firstname.Text = patient.Firstname;
                profile_info_lastname.Text = patient.Lastname;
                profile_info_birthday.Text = patient.Birthday.ToString();
                profile_info_followBy.Text = patient.UserName;
                
                if(patient.LeftSessions == 0)
                {
                    patient_total.Text = "0";
                } else
                {
                    patient_total.Text = patient.LeftSessions.ToString();
                }

            }


        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // save changes of the patient 

        }
    }
}
