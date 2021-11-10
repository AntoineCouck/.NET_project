using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class Insurance_profile : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();

        public Insurance_profile()
        {
            InitializeComponent();
        }

        private void Insurance_profile_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var insurances = db.Insurances.Where(x => x.Name == User_Dashboard.currentInsuranceId);
            var patientsInsurances = db.Patients.Join(db.Insurances, x => x.InsuranceName, y => y.Name, (x, y) => new
            {
                i = y,
                pName = x.Firstname,
                pLastname = x.Lastname

            }).Where(x => x.i.Name == User_Dashboard.currentInsuranceId);

            foreach (var insurance in insurances)
            {
                title_profile_Insurance.Text = "Insurance:" + " " + insurance.Name;
                profile_insurance_name.Text = insurance.Name;
                profile_insurance_adres.Text = insurance.Adres;
                profile_insurance_telnr.Text = insurance.TelNr;

            }

            foreach (var element in patientsInsurances)
            {
                listBox1.Items.Add(element.pName + " " + element.pLastname);
            }

        }

        private void btn_modify_insurance_Click(object sender, EventArgs e)
        {
            User_Dashboard.modify_Insurance.ShowDialog();

            if (User_Dashboard.modify_Insurance.DialogResult == DialogResult.OK)
            {
                profile_insurance_adres.Text = User_Dashboard.modify_Insurance.Adres;
                profile_insurance_telnr.Text = User_Dashboard.modify_Insurance.Telnr;
            }



        }

        private void btn_del_inusrance_Click(object sender, EventArgs e)
        {
            User_Dashboard.delete_Insurance.ShowDialog();
        }
    }
}
