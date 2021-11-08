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
    public partial class test_profile : Form
   {

        Logo_manager2Entities1 db = new Logo_manager2Entities1 ();

        public test_profile()
        {
            InitializeComponent();
        }

        private void test_profile_Load(object sender, EventArgs e)
        {

            var tests = db.Tests.Where(x => x.Id == User_Dashboard.currentTestId);

            foreach(var element in  tests)
            {

                title_profile_test.Text = "Test:" + " " + element.Name;
                profile_test_name.Text = element.Name;
                profile_test_minage.Text =  element.MinAge.ToString();
                profile_test_maxage.Text = element.MaxAge.ToString();
                profile_test_followup.Text = element.TypefollowUp;

            }

        }

        private void btn_modify_test_Click(object sender, EventArgs e)
        {
            User_Dashboard.modify_Test.ShowDialog();

            if(User_Dashboard.modify_Test.DialogResult == DialogResult.OK)
            {
                title_profile_test.Text = "Test:" + " " + User_Dashboard.modify_Test.Name;
                profile_test_name.Text = User_Dashboard.modify_Test.Name;
                profile_test_minage.Text = User_Dashboard.modify_Test.minAge;
                profile_test_maxage.Text = User_Dashboard.modify_Test.maxage;
                profile_test_followup.Text = User_Dashboard.modify_Test.followUp;
            }

        }

        private void btn_del_test_Click(object sender, EventArgs e)
        {
            User_Dashboard.delete_Test.ShowDialog();    
        }
    }
}
