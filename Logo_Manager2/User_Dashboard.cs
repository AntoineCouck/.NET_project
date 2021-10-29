using Logo_Manager2.User_forms;
using System.Windows.Forms;

namespace Logo_Manager2
{
    public partial class User_Dashboard : Form
    {
        // instances of my forms 

        public static Log_in log_In = new Log_in();
        public static Sign_in sign_in = new Sign_in();
        // instances of my forms 
        public static readonly Logo_managerEntities logo_ManagerEntities = new Logo_managerEntities();
        public User_Dashboard()
        {
            InitializeComponent();
        }

        private void User_Dashboard_Load(object sender, System.EventArgs e)
        {
            log_In.ShowDialog();
        }

        private void disconnectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // disconect button 
        }
    }
}
