using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Linq;
using System.ComponentModel;

namespace Logo_Manager2.User_forms
{
    public partial class Sign_in : Form
    {
        protected string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Antoine\source\repos\project.net\.NETproject\Logo_Manager2\Logo_manager.mdf;Integrated Security=True";
        Logo_managerEntities context = new Logo_managerEntities();


        public Sign_in()
        {
            InitializeComponent();
        }


        private SqlConnection GetDbConnectie()
        {

            return new SqlConnection(connectionString);

        }

       

        //public void BewaarPersoon(string Name, string Email, string Password)
        //{

        //    string insertSqlText = "INSERT INTO Users(Name, Email, Password) VALUES(@Name,  @Email,  @Password)";
        //    SqlCommand insertSql = new SqlCommand(insertSqlText);
        //    insertSql.Connection = GetDbConnectie();
        //    insertSql.Parameters.Add(new SqlParameter("@Name", Name));
        //    insertSql.Parameters.Add(new SqlParameter("@Email", Email));
        //    insertSql.Parameters.Add(new SqlParameter("@Password", Password));

        //    try
        //    {
        //        insertSql.Connection.Open(); insertSql.ExecuteNonQuery();

        //    }

        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine("Create peresoon is " + ex.Message);
        //    }

        //    finally
        //    {
        //        if (insertSql.Connection.State == ConnectionState.Open)
        //        {
        //            insertSql.Connection.Close();
        //        }
        //    }




        //}



        private void login_submit_Click(object sender, System.EventArgs e)
        {
            if (input_email_register.Text == String.Empty || input_email_register.Text == String.Empty || input_password_register.Text == String.Empty)
            {

                MessageBox.Show("unvalid input , try again");
            }
            else 
            {

                //BewaarPersoon(input_name_register.Text, input_email_register.Text, input_password_register.Text);

                //input_name_register.Text = null;
                //input_email_register.Text = null;
                //input_password_register.Text = null;
                //User_Dashboard.sign_in.Close();
                //MessageBox.Show("good");

                var user = new User();

                user.Name = input_name_register.Text;
                user.Email = input_email_register.Text;
                user.Password = input_password_register.Text;

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show(user.Email);
                
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
