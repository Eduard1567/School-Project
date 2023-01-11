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
            MainProgram.LoadListaElevi();
            MainProgram.LoadListaProfesori();

            SetFormLanguage();


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
                        MainProgram.OpenForm(new ProfesorForm(user));
                    else
                        MainProgram.OpenForm(new ElevForm(user));
                }
                else
                {
                    if (MainProgram.programLanguage.Equals("EN"))
                        MessageBox.Show("Incorrect password!");
                    else
                        MessageBox.Show("Parola incorecta!");

                    userTxtBox.Text = "username";
                    passwdTxtBox.Text = "password";
                }
            }
            else
            {
                if (MainProgram.programLanguage.Equals("EN"))
                    MessageBox.Show("Username doesn't exist, try to create an account!");
                else
                    MessageBox.Show("Numele de utilizator nu exista, creeaza-ti un cont!");
            }
        }

        private void SetFormLanguage()
        {
            // Change text based on language set
            if(MainProgram.programLanguage.Equals("EN"))
            {
                // English interface
                userTxtBox.Text = "username";
                checkBox1.Text = "Teacher";
                button2.Text = "LOGIN";
                button1.Text = "SIGN UP";
                settingsToolStripMenuItem.Text = "Settings";
                languageToolStripMenuItem.Text = "Language";
                englishENToolStripMenuItem.Text = "English (EN)";
                romanianROToolStripMenuItem.Text = "Romanian (EN)";
            }
            else
            {
                // Romanian interface
                userTxtBox.Text = "utilizator";
                checkBox1.Text = "Profesor";
                button2.Text = "Logare";
                button1.Text = "Creare cont";
                settingsToolStripMenuItem.Text = "Setari";
                languageToolStripMenuItem.Text = "Limba";
                englishENToolStripMenuItem.Text = "English (EN)";
                romanianROToolStripMenuItem.Text = "Romana (RO)";
            }
        }

        private void englishENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.ChangeLanguage("EN");
            SetFormLanguage();
        }

        private void romanianROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.ChangeLanguage("RO");
            SetFormLanguage();
        }
    }
}