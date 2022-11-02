using SchoolProject.Scripts;

namespace SchoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainProgram.SetActiveForm(this);
        }

        private void passwdTxtBox_Click(object sender, EventArgs e)
        {
            passwdTxtBox.Text = "";
        }

        private void userTxtBox_Click_1(object sender, EventArgs e)
        {
            userTxtBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!!
            Login();
            
        }




        // Methods

        private void Login()
        {
            string username = userTxtBox.Text;
            string password = passwdTxtBox.Text;

            // ADMIN LOGIN
            if(username.Equals("admin") && password.Equals("0000"))
            {
                MainProgram.OpenForm(new AdminForm());
                
            }
        }

        
    }
}