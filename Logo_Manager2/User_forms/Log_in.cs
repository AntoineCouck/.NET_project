using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Logo_Manager2
{
    public partial class Log_in : Form
    {

        Logo_manager2Entities1 context = new Logo_manager2Entities1();
        public string username { get; set; }
        public bool is_connected { get; set; }




        public Log_in()
        {
            InitializeComponent();
        }


        private void login_submit_Click_1(object sender, EventArgs e)
        {

            string email = email_login_input.Text;
            string password = password_login_input.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {


                MessageBox.Show("password or email are incorrect , try again");
                email_login_input.Text = null;
                password_login_input.Text = null;


            }
            else
            {
                var result = context.Users.Where(x => x.Email == email && x.Password == password).ToList();

                foreach (User user in result)
                {
                    username = user.Name;
                    is_connected = true;
                }

                if (is_connected)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Email or password are incorrect , try again");
                    email_login_input.Text = null;
                    password_login_input.Text = null;
                }

            }


        }

        //private void link_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    // in log-in → sign in 

        //    User_Dashboard.sign_in.ShowDialog();

        //}

        private void link_sign_in_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Dashboard.sign_in.ShowDialog();
        }

      
    }
}
