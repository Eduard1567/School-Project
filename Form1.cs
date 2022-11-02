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
            MainProgram.CreateNecessaryFiles();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MainProgram.ShowForm(new RegistrationForm());
        }



        // Methods

        private void Login()
        {
            string username = userTxtBox.Text;
            string password = passwdTxtBox.Text;

            // POSIBILITATE ADAUGARE ERORI!!!!!!!!!!!!!!!!!!!!!
            if (username.Equals("admin") && password.Equals("0000"))
            {
                MainProgram.OpenForm(new AdminForm());
            }
            else
            {
                LoginByCredentials(username, password);
            }
        }


        private void LoginByCredentials(string user, string pass)
        {
            string path = "";

            if (checkBox1.Checked)
                path = MainProgram.programPath + "//Profesori//" + user + ".txt";
            else
                path = MainProgram.programPath + "//Elevi//" + user + ".txt";


            if (File.Exists(path))
            {
                List<string> fileCredentials = FileHelper.FileReader.ReadLinesList(path);

                if(user.Equals(fileCredentials.ElementAt(0)) && pass.Equals(fileCredentials.ElementAt(1)))
                {
                    if(checkBox1.Checked)
                        MainProgram.OpenForm(new ProfesorForm());
                    else
                        MainProgram.OpenForm(new ElevForm(user));
                }
                else
                {
                    MessageBox.Show("Incorrect password!");

                    userTxtBox.Text = "username";
                    passwdTxtBox.Text = "password";
                }
            }
            else
            {
                MessageBox.Show("Username doesn't exist, try to create an account!");
            }
        }
    }
}