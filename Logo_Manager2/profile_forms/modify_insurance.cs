using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logo_Manager2.profile_forms
{
    public partial class modify_insurance : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();

        public string Name { get; set; }

        public string Adres { get; set; }

        public string Telnr { get; set; }

        public modify_insurance()
        {
            InitializeComponent();
        }

        private void modify_insurance_Load(object sender, EventArgs e)
        {
            var Insurances = db.Insurances.Where(x => x.Name == User_Dashboard.currentInsuranceId);
            foreach (var insurance in Insurances)
            {

                input_name_mod.Text = insurance.Name;
                input_adres_mod.Text = insurance.Adres;
                input_telnr_mod.Text = insurance.TelNr;

            }
        }

        private void btn_del_test_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modify_test_confirm_Click(object sender, EventArgs e)
        {

            var Insurances = db.Insurances.Where(x => x.Name == User_Dashboard.currentInsuranceId);
            bool edit_insurance = true;


            if (input_adres_mod.Text.Length > 50 || string.IsNullOrEmpty(input_adres_mod.Text))
            {
                edit_insurance = false;
                input_adres_mod.Text = null;
                MessageBox.Show("adres is too large or empty , try again please");

            }
            else if (input_telnr_mod.Text.Length > 50 || string.IsNullOrEmpty(input_telnr_mod.Text))
            {
                edit_insurance = false;
                input_telnr_mod.Text = null;
                MessageBox.Show("telnr is too large or empty , try again please");

            }
            else
            {
                edit_insurance = true;
            }

            if (edit_insurance)
            {
                foreach (var insurance in Insurances)
                {
                   
                    insurance.TelNr = input_telnr_mod.Text;
                    insurance.Adres = input_adres_mod.Text;
                }


            }


            Telnr = input_telnr_mod.Text;
            Adres = input_adres_mod.Text;

            db.SaveChanges();
            MessageBox.Show("this test was succesfull modified");



        }


    }
}

