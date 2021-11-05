using System;
using System.Windows.Forms;

namespace Logo_Manager2.User_forms
{
    public partial class Sign_in : Form
    {
        Logo_managerEntities1 context = new Logo_managerEntities1();


        public Sign_in()
        {
            InitializeComponent();
        }

        private void login_submit_Click(object sender, System.EventArgs e)
        {
            bool UserNotPresent = true;

            var element = context.Users;

            foreach(var user in element)
            {
                if(user.Name == input_name_register.Text)
                {
                    UserNotPresent = false;
                    MessageBox.Show("This name is already in use ");

                } 
                if(user.Email == input_email_register.Text)
                {
                    UserNotPresent = false;
                    MessageBox.Show("This email is already in use ");
                }
            }

            if (input_email_register.Text == String.Empty || input_email_register.Text == String.Empty || input_password_register.Text == String.Empty)
            {

                MessageBox.Show("All fields must be completed");

            }
            else if (input_email_register.Text.Length > 50)
            {
                MessageBox.Show("Email too large");
                input_email_register.Text = null;

            }
            else if (input_name_register.Text.Length > 50)
            {
                MessageBox.Show("Name too large");
                input_name_register.Text = null;

            }
            else if (input_password_register.Text.Length > 12)
            {
                MessageBox.Show("Password too large");
                input_password_register.Text = null;
            }

            else if(UserNotPresent)
            {
                var User = new User();

                User.Name = input_name_register.Text;
                User.Email = input_email_register.Text;
                User.Password = input_password_register.Text;
                context.Users.Add(User);
                context.SaveChanges();

                User_Dashboard.sign_in.Close();


            }


        }

        private void link_log_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // in sign in → log in

            User_Dashboard.sign_in.Close();
        }
    }
}
