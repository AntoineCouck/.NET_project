using System;
using System.Windows.Forms;

namespace Logo_Manager2.create_forms
{
    public partial class Create_tests : Form
    {
        Logo_managerEntities1 db = new Logo_managerEntities1();
        Utils utils = new Utils();

        public Create_tests()
        {
            InitializeComponent();
        }

        private void btn_new_patient_Click(object sender, EventArgs e)
        {

            var test = new Test();

            test.Name = input_test_name.Text;

            if (Utils.IsEveritingADigit(input_test_age.Text) != true)
            {
                test.Age = 0;
                input_test_age.Text = null;
                input_test_age.Text = null;
                input_test_followup.Text = null;

                MessageBox.Show("the given number for age is not a digit , this will be set at age 0");
            }
            else
            {
                test.Age = int.Parse(input_test_age.Text);
            }

            test.TypefollowUp = input_test_followup.Text;

            db.Tests.Add(test);

            db.SaveChanges();

            this.Close();

        }
    }
}
