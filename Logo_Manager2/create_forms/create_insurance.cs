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
