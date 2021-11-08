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
    public partial class modify_test : Form
    {
        Logo_manager2Entities1 db = new Logo_manager2Entities1();
       public string Name {  get; set; }
        public int minAge {  get; set; }

        public int maxage {  get; set; }

        public string followUp {  get; set; }

        public modify_test()
        {
            InitializeComponent();
        }

        private void btn_del_test_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void modify_test_Load(object sender, EventArgs e)
        {
            var tests = db.Tests.Where(x => x.Id == User_Dashboard.currentTestId);
            foreach (var test in tests)
            {

                profile_test_name.Text = test.Name;
                profile_test_minage.Text = test.MinAge.ToString();
                profile_test_maxage.Text = test.MaxAge.ToString();
                profile_test_followup.Text = test.TypefollowUp.ToString();

            }
        }

        private void btn_modify_test_confirm_Click(object sender, EventArgs e)
        {
            var tests = db.Tests.Where(x => x.Id == User_Dashboard.currentTestId);
            bool edit_test = true;


            if (string.IsNullOrEmpty(profile_test_name.Text))
            {
                MessageBox.Show("The name must be completed");
                profile_test_name.Text = null;
                edit_test = false;
            }
            else if (profile_test_name.Text.Length > 50)
            {
                MessageBox.Show("The name is too large, try another");
                profile_test_name.Text = null;
                edit_test = false;
            }


            else if (!(profile_test_minage.Value < profile_test_maxage.Value))
            {
                MessageBox.Show("Sorry but the max age must be higher then the min age");
                profile_test_minage.Value = 0;
                profile_test_maxage.Value = 0;

                edit_test = false;

            } else
            {
                edit_test = true;
            }


            if (edit_test)
            {

                foreach(var test in tests)
                {

                    test.Name = profile_test_name.Text;
                    test.MinAge = (int)profile_test_minage.Value;
                    test.MaxAge = (int)profile_test_maxage.Value;
                    test.TypefollowUp = profile_test_followup.Text;


                }
                
                Name = profile_test_name.Text;
                minAge = (int)profile_test_minage.Value;
                maxage = (int)profile_test_maxage.Value;
                followUp = profile_test_followup.Text;

                db.SaveChanges();
                MessageBox.Show("this test was succesfull modified");
            }


        }
    }
}
