using Logo_Manager2.User_forms;
using Logo_Manager2.create_forms;
using System.Windows.Forms;

namespace Logo_Manager2
{
    public partial class User_Dashboard : Form
    {
        // instances of my forms 

        public static Log_in log_In = new Log_in();
        public static Sign_in sign_in = new Sign_in();
        public static create_new_patient create_patient = new create_new_patient();
        public static bool is_connected = false;
        public static string username;
        
        public User_Dashboard()
        {
            InitializeComponent();
        }

        private void User_Dashboard_Load(object sender, System.EventArgs e)
        {
            log_In.ShowDialog();
            username = log_In.username;
            is_connected = log_In.is_connected;

            AccountName.Text = username;

           

            // TODO: This line of code loads data into the 'logo_managerDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.logo_managerDataSet.Tests);
            // TODO: This line of code loads data into the 'logo_managerDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.logo_managerDataSet.Patients);

            
        }

        private void disconnectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void managementToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // menu strip button 
        }

        private void btn_dashboard_add_patient_Click(object sender, System.EventArgs e)
        {
            create_patient.ShowDialog();
        }
    }
}
