using System.Windows.Forms;
using System.Linq;

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
            var password = Utils.HashDefaultPassword();

            var User = new User
            {
                Name = name,
                E_mail = email,
                Password = password
            };

            User_Dashboard.logo_ManagerEntities.Add();
        }
    }
}
