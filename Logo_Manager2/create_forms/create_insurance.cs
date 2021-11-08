using System;
using System.Windows.Forms;

namespace Logo_Manager2.create_forms
{
    public partial class create_insurance : Form
    {

        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        public create_insurance()
        {
            InitializeComponent();
        }

        private void btn_new_insurance_Click(object sender, EventArgs e)
        {

            bool createInsurance = true;
            var result = db.Insurances;

            if(input_insurance_name.Text.Length > 50 || (string.IsNullOrEmpty(input_insurance_name.Text) == true))
            {
                MessageBox.Show("the name is too large  or empty , try again ");
                input_insurance_name.Text = null;
                createInsurance = false;
            }
            else if(input_insurance_adres.Text.Length > 50 || (string.IsNullOrEmpty(input_insurance_adres.Text) == true))
            {
                MessageBox.Show("the adres is too large  or empty , try again ");
                input_insurance_adres.Text = null;
                createInsurance = false;
            }
            else if(input_insurance_telnr.Text.Length > 50 || (string.IsNullOrEmpty(input_insurance_telnr.Text) == true ))
            {
                MessageBox.Show("the telnr is too large  or empty , try again ");
                input_insurance_telnr.Text = null;
                createInsurance = false;
            } 

           
            foreach(var element in result)
            {
                if(element.Name == input_insurance_name.Text)
                {
                    MessageBox.Show("Sorry but this name is already in use , try again please");

                    createInsurance = false;
                    input_insurance_name.Text = null;
                  
                }
            }
            



            if (createInsurance)
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
