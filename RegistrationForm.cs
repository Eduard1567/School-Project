using SchoolProject.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolProject
{
    public partial class RegistrationForm : Form
    {
        private bool profesorAccount = false;


        public RegistrationForm()
        {
            InitializeComponent();
        }
        public RegistrationForm(bool _profesorAccount)
        {
            InitializeComponent();
            profesorAccount = _profesorAccount;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewAccount();
        }

        private bool IsStringInRange(string str, int min, int max)
        {
            if (str.Length >= min && str.Length <= max)
                return true;
            else return false;
        }

        private bool CapitalInString(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToUpper())
                    return true;
            }

            return false;
        }

        private bool IsUsernameOk(string username)
        {
            int minimumCharacters = 3;
            int maximumCharacters = 30;


            if (IsStringInRange(username, minimumCharacters, maximumCharacters))
                return true;
            else return false;

        }

        private bool IsPasswordOk(string password)
        {
            int minimumCharacters = 3;
            int maximumCharacters = 50;

            if(!AnyLetterInString(password))
            {
                string errMessage;

                if (MainProgram.programLanguage.Equals("EN"))
                    errMessage = "Only numbers are not accepted as password!";
                else
                    errMessage = "Parola formata doar din numere nu este acceptata!";

                MainProgram.errorHandler.ThrowError(errMessage);
                return false;
            }

            if(!IsStringInRange(password, minimumCharacters, maximumCharacters))
            {
                string errMessage;

                if (MainProgram.programLanguage.Equals("EN"))
                    errMessage = "Your password must have at least " + minimumCharacters + " characters and maximum " + maximumCharacters + "!";
                else
                    errMessage = "Parola ta trebuie sa contina minimum " + minimumCharacters + " caractere si maximum " + maximumCharacters + "!";

                MainProgram.errorHandler.ThrowError(errMessage);
                return false;
            }

            if(!CapitalInString(password))
            {
                string errMessage;

                if (MainProgram.programLanguage.Equals("EN"))
                    errMessage = "You must have at least one capital letter in your password!";
                else
                    errMessage = "Parola trebuie sa contina minimum o litera mare!";

                MainProgram.errorHandler.ThrowError(errMessage);
                return false;
            }

          

            return true;
        }

        private bool AnyLetterInString(string s)
        {
            return s.Any(char.IsLetter);
        }

        private bool IsClasaOk(string clasa)
        {
            if(int.Parse(clasa) < 1 || int.Parse(clasa) > 12)
            {
                string errMessage;

                if (MainProgram.programLanguage.Equals("EN"))
                    errMessage = "Error 103: Invalid grade!";
                else
                    errMessage = "Eroarea 103: Clasa invalida";

                MainProgram.errorHandler.ThrowError(errMessage);
                return false;
            }

            return true;
        }

        private void CreateNewAccount()
        {
            // ADAUGARE POSIBILE ERORI!!!!!!!!!!!!
            // De exemplu faptul ca poti sa faci cont chiar daca utilizatorul exista deja
            if(!IsUsernameOk(userTxtBox.Text))
            {
                string errMessage;

                if (MainProgram.programLanguage.Equals("EN"))
                    errMessage = "Username must have at least 3 characters and maximum 30!";
                else
                    errMessage = "Numele de utilizator trebuie sa contina minimum 3 caractere si maximum 30";

                MainProgram.errorHandler.ThrowError(errMessage);
                userTxtBox.Text = "username";
                return;
            }

            if(!IsPasswordOk(passwdTxtBox.Text))
            {
                return;
            }

            if(!IsClasaOk(clasaTxtBox.Text))
            {
                return;
            }

            if (passwdTxtBox.Text.Equals(confirmPasswdTxtBox.Text))
            {
                string username = userTxtBox.Text;
                string password = passwdTxtBox.Text;

                string nume = numeTxtBox.Text;

                // Check wheter profesor or elev account is user attempting to create
                string path = "";
                if(profesorAccount)
                {
                    path = MainProgram.programPath + "//Profesori//" + username + ".txt";

                    CreateDetailsFile(username, false);
                    CreateInboxFile(username, false);
                }
                else
                {
                    path = MainProgram.programPath + "//Elevi//" + username + ".txt";

                    CreateDetailsFile(username, true);
                    CreateNoteFile(username);
                    CreateInboxFile(username, true);
                }

                FileHelper.FileWriter.Write(path, username + "\n" + password + "\n" + nume);

                MainProgram.LoadListaElevi();


                if (MainProgram.programLanguage.Equals("EN"))
                    MessageBox.Show("Account was successfully created!");
                else
                    MessageBox.Show("Contul a fost creat cu succes!");

                this.Close();
            }
            else
            {
                if (MainProgram.programLanguage.Equals("EN"))
                    MessageBox.Show("Your confirmation password doesn't match with your password!");
                else
                    MessageBox.Show("Confirmarea parolei nu corespunde cu parola!");

                

                userTxtBox.Text = "username";
                passwdTxtBox.Text = "password";
                confirmPasswdTxtBox.Text = "";
            }
        }


        private void CreateInboxFile(string username, bool elev)
        {
            string path = "";

            if (elev)
                path = MainProgram.detaliiEleviPath + "//inbox_" + username + ".txt";
            else
                path = MainProgram.detaliiProfesoriPath + "//inbox_" + username + ".txt";

            File.WriteAllText(path, "");
        }

        private void CreateDetailsFile(string username, bool elev)
        {
            string path = "";

            if (elev)
            {
                path = MainProgram.detaliiEleviPath + "//" + username + ".txt";

                // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!!!
                FileHelper.FileWriter.Write(path, clasaTxtBox.Text + "\n");  // Setare clasa elev
            }

            // Fa si pentru profesori!!
        }

        private void CreateNoteFile(string username)
        {
            string path = MainProgram.detaliiEleviPath + "//note_" + username + ".txt";

            FileHelper.FileWriter.Write(path, "");
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            if(profesorAccount)
            {
                // Hide clasa textbox and label
                label3.Hide();
                clasaTxtBox.Hide();
            }

            SetFormLanguage();
        }

        private void SetFormLanguage()
        {
            // Change text based on language set
            if (MainProgram.programLanguage.Equals("EN"))
            {
                // English interface
                this.Text = "Registration form";
                userTxtBox.Text = "username";
                label1.Text = "Confirm password";
                label2.Text = "Full name";
                label3.Text = "Grade";
                button1.Text = "Create Account";
            }
            else
            {
                // Romanian interface
                this.Text = "Formular inregistrare";
                userTxtBox.Text = "utilizator";
                label1.Text = "Confirmare parola";
                label2.Text = "Nume complet";
                label3.Text = "Clasa";
                button1.Text = "Creeaza Cont";
            }
        }

        private void clasaTxtBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int x = int.Parse(clasaTxtBox.Text);
            }
            catch
            {
                clasaTxtBox.Text = String.Empty;
                return;
            }

            if(int.Parse(clasaTxtBox.Text) > 12)
            {
                clasaTxtBox.Text = "12";
            }
            else if(int.Parse(clasaTxtBox.Text) < 1)
                clasaTxtBox.Text = "1";

        }

        private void userTxtBox_Click(object sender, EventArgs e)
        {
            userTxtBox.Text = String.Empty;
        }

        private void passwdTxtBox_Click(object sender, EventArgs e)
        {
            passwdTxtBox.Text = String.Empty;
        }

        private void confirmPasswdTxtBox_Click(object sender, EventArgs e)
        {
            confirmPasswdTxtBox.Text = String.Empty;    
        }

        private void numeTxtBox_Click(object sender, EventArgs e)
        {
            numeTxtBox.Text = String.Empty;
        }

        private void clasaTxtBox_Click(object sender, EventArgs e)
        {
            clasaTxtBox.Text = String.Empty;
        }
    }
}
