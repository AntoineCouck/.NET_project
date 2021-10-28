using System.Windows.Forms;
using Logo_Manager2.User_forms;

namespace Logo_Manager2
{
    public  partial class Log_in : Form
    {

       

        public Log_in()
        {
            InitializeComponent();
        }

      

        private void link_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
          User_Dashboard.sign_in.ShowDialog();

        }
    }
}
