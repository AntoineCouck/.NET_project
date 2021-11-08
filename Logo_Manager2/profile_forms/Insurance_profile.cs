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
    public partial class Insurance_profile : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();

        public Insurance_profile()
        {
            InitializeComponent();
        }

        private void Insurance_profile_Load(object sender, EventArgs e)
        {
            var insurances = db.Insurances.Where(x => x.Name == User_Dashboard.currentInsuranceId);

            foreach (var insurance in insurances)
            {
                title_profile_Insurance.Text= "Insurance:" + " " + insurance.Name;
                profile_insurance_name.Text = insurance.Name;
                profile_insurance_adres.Text = insurance.Adres;
                profile_insurance_telnr.Text = insurance.Adres;

            }
        }

        private void btn_modify_insurance_Click(object sender, EventArgs e)
        {
            User_Dashboard.modify_Insurance.ShowDialog();

            if (User_Dashboard.modify_Insurance.DialogResult == DialogResult.OK)
            {
                profile_insurance_name.Text = User_Dashboard.modify_Insurance.Name;
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
