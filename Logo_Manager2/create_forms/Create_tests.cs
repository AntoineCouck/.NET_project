using System;
using System.Windows.Forms;

namespace Logo_Manager2.create_forms
{
    public partial class Create_tests : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();
        Utils utils = new Utils();

        public Create_tests()
        {
            InitializeComponent();
        }

        private void btn_new_patient_Click(object sender, EventArgs e)
        {


            bool createObj = true;




            if (string.IsNullOrEmpty(input_test_name.Text))
            {
                MessageBox.Show("The name must be completed");

                createObj = false;
            }
            else if (input_test_name.Text.Length > 50)
            {
                MessageBox.Show("The name is too large, try another");
                createObj = false;
            }


            else if (!(input_test_age.Value < input_tests_maxage.Value))
            {
                MessageBox.Show("Sorry but the max age must be higher then the min age");
                createObj = false;

            } 

            else if(input_tests_maxage.Value == null || input_test_age.Value == null)
            {
                MessageBox.Show("Sorry but min and max age must be completed");
                input_test_age.Value = 0;
                input_tests_maxage.Value = 0;
                createObj = false;
            }


            if (createObj == true)
            {
                var test = new Test();
                test.Name = input_test_name.Text;
                test.MinAge = int.Parse(input_test_age.Text);
                test.MaxAge = int.Parse(input_tests_maxage.Text);
                test.TypefollowUp = comboBox1.Text;
                db.Tests.Add(test);
                db.SaveChanges();
                this.Close();

            }




            input_test_name.Text = null;
            input_test_age.Text = null;
            input_tests_maxage.Text = null;
            comboBox1.Text = null;





        }
    }
}
