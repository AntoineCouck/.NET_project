using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace Logo_Manager2.User_forms
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void login_submit_Click(object sender, System.EventArgs e)
        {

            var name = input_name_register.Text;
            var email = input_email_register.Text;
            var password = input_password_register.Text;


            var User = new User
            {
                Name = name,
                Email = email,
                Password = password
            };

            try
            {

                User_Dashboard.logo_ManagerEntities.Users.Add(User);
                User_Dashboard.logo_ManagerEntities.SaveChanges();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (name != null && email != null && password != null)
            {
                User_Dashboard.sign_in.Close();
            }
        }
    }
}
