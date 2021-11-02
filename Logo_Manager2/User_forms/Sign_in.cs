using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logo_Manager2.User_forms
{
    public partial class Sign_in : Form
    {
        protected string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antoine\source\repos\project.net\.NETproject\Logo_Manager2\Logo_manager.mdf;Integrated Security=True";
        Logo_managerEntities1 context = new Logo_managerEntities1();


        public Sign_in()
        {
            InitializeComponent();
        }


        private SqlConnection GetDbConnectie()
        {

            return new SqlConnection(connectionString);

        }

        private void login_submit_Click(object sender, System.EventArgs e)
        {
            if (input_email_register.Text == String.Empty || input_email_register.Text == String.Empty || input_password_register.Text == String.Empty)
            {

                MessageBox.Show("unvalid input , try again");
            }
            else
            {


                var user = new User();

                user.Name = input_name_register.Text;
                user.Email = input_email_register.Text;
                user.Password = input_password_register.Text;

                context.Users.Add(user);
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
