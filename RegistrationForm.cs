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

        private void CreateNewAccount()
        {
            // ADAUGARE POSIBILE ERORI!!!!!!!!!!!!
            // De exemplu faptul ca poti sa faci cont chiar daca utilizatorul exista deja
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
                }
                else
                {
                    path = MainProgram.programPath + "//Elevi//" + username + ".txt";

                    CreateDetailsFile(username, true);
                    CreateNoteFile(username);


                }

                FileHelper.FileWriter.Write(path, username + "\n" + password + "\n" + nume);

                MainProgram.LoadListaElevi();

                MessageBox.Show("Account was successfully created!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Your confirmation password doesn't match with your password!");

                userTxtBox.Text = "username";
                passwdTxtBox.Text = "password";
                confirmPasswdTxtBox.Text = "";
            }
        }

        private void CreateDetailsFile(string username, bool elev)
        {
            string path = "";

            if (elev)
            {
                path = MainProgram.detaliiEleviPath + "//" + username + ".txt";

                // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!!!
                FileHelper.FileWriter.Write(path, "-1\n");
            }

            // Fa si pentru profesori!!
        }

        private void CreateNoteFile(string username)
        {
            string path = MainProgram.detaliiEleviPath + "//note_" + username + ".txt";

            FileHelper.FileWriter.Write(path, "");
        }

    }
}
