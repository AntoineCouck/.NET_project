using System.Windows.Forms;

namespace Logo_Manager2
{
    public partial class Log_in : Form
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
