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
                test.MinAge = 0;
                input_test_age.Text = null;
                input_test_age.Text = null;



                MessageBox.Show("the given number for age is not a digit , this will be set at age 0");
            }
            if (Utils.IsEveritingADigit(input_tests_maxage.Text) != true)
            {
                test.MaxAge = 0;
                input_test_age.Text = null;
                input_test_age.Text = null;


                MessageBox.Show("the given number for age is not a digit , this will be set at age 0");
            }
            else
            {
                test.MinAge = int.Parse(input_test_age.Text);
                test.MaxAge = int.Parse(input_tests_maxage.Text);
            }

            test.TypefollowUp = comboBox1.Text;

            db.Tests.Add(test);

            db.SaveChanges();

            input_test_name.Text = null;
            input_test_age.Text = null;
            input_tests_maxage.Text = null;
            comboBox1.Text = null;

            this.Close();

        }
    }
}
