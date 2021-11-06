using System;
using System.Windows.Forms;

namespace Logo_Manager2.create_forms
{
    public partial class create_insurance : Form
    {

        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        bool makeNewInsurance = true;
        public create_insurance()
        {
            InitializeComponent();
        }

        private void btn_new_insurance_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(input_insurance_name.Text))
            {
                MessageBox.Show("the name must be completed");
                makeNewInsurance = false;
            } 
            else if (string.IsNullOrEmpty(input_insurance_adres.Text))
            {
                MessageBox.Show("the adres must be completed");
                makeNewInsurance = false;
            }

            else if (string.IsNullOrEmpty(input_insurance_telnr.Text))
            {
                MessageBox.Show("the telnr must be completed");
                makeNewInsurance = false;
            }
            else if(input_insurance_name.Text.Length > 50 || input_insurance_adres.Text.Length > 50 || input_insurance_telnr.Text.Length > 50)
            {
                MessageBox.Show("One or more fields are too large, try again");
                makeNewInsurance = false;
            } else
            {
                makeNewInsurance = true;
            }
             






            if (makeNewInsurance)
            {

                var insurance = new Insurance();

                insurance.Name = input_insurance_name.Text;
                insurance.Adres = input_insurance_adres.Text;
                insurance.TelNr = input_insurance_telnr.Text;

                db.Insurances.Add(insurance);

                db.SaveChanges();

                input_insurance_name.Text = null;
                input_insurance_adres.Text = null;
                input_insurance_telnr.Text = null;

                this.Close();

            }

     
        }
    }
}
