using SchoolProject.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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

                string path = MainProgram.programPath + "//Elevi//" + username + ".txt";
                FileHelper.FileWriter.Write(path, username + "\n" + password);

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
    }
}
