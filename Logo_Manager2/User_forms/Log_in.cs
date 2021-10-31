using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Linq;


namespace Logo_Manager2
{
    public partial class Log_in : Form
    {

        protected string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antoine\source\repos\project.net\.NETproject\Logo_Manager2\Logo_manager.mdf;Integrated Security=True";
        Logo_managerEntities context = new Logo_managerEntities();
        public string username { get; set; }
        public bool is_connected {  get; set; }

        
       

        public Log_in()
        {
            InitializeComponent();
        }


        private void login_submit_Click(object sender, EventArgs e)
        {

            string email = email_login_input.Text;
            string password = password_login_input.Text;

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {


                MessageBox.Show("password or email are incorrect , try again");
                email_login_input.Text = null;
                password_login_input.Text = null;


            } else    
            {
                var result = context.Users.Where(x => x.Email == email && x.Password == password).ToList();

                foreach(User user in result)
                {
                    username = user.Name;
                    is_connected = true;
                }

                if (is_connected)
                {
                  Close();
                }

                email_login_input.Text = null;
                password_login_input.Text = null;
            }


        }

        private void link_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // in log-in → sign in 

            User_Dashboard.sign_in.ShowDialog();

        }

     
    }
}
