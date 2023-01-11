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
    public partial class ElevForm : Form
    {
        private Elev elevObj;

        private string userName = "Undefined";

#pragma warning disable CS8618 
        public ElevForm(string username)
#pragma warning restore CS8618 
        {
            InitializeComponent();
            userName = username;
        }

        private void ElevForm_Load(object sender, EventArgs e)
        {
            MainProgram.SetActiveForm(this);

            LoadInfo();
            SetFormLanguage();
        }


        private void LoadInfo()
        {
            elevObj = Elev.CreateElev(userName);


            // Load form info
            this.Text = "Logged in as: " + elevObj.GetName();
            numeTxtBox.Text = elevObj.GetName();
            clasaTxtBox.Text = MainProgram.FindClasaElev(userName);
            medieTxtBox.Text = MainProgram.GetMedieElev(userName).ToString();

            ShowInboxMessages();
        }

        private void ShowInboxMessages()
        {
            string path = MainProgram.GetInboxPath(userName, true);
            string messages = FileHelper.FileReader.ReadAllTextFile(path);

            if (!messages.Equals(String.Empty))
            {
                MessageBox.Show(messages);

                // Clear inbox
                File.WriteAllText(path, "");
            }
        }

        private void listaMateriiTxtBox_MouseEnter(object sender, EventArgs e)
        {
            if (feedbackTxtBox.TextLength > 0 && feedbackTxtBox.Text != "...")
                return;

            feedbackTxtBox.Text = "";
        }

        private void listaMateriiTxtBox_MouseLeave(object sender, EventArgs e)
        {
            if (feedbackTxtBox.TextLength > 0 && feedbackTxtBox.Text != "...")
                return;

            feedbackTxtBox.Text = "...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!
            string path = MainProgram.directiunePath + "//feedback.txt";
            string feedbackText = elevObj.GetName() + ": " + feedbackTxtBox.Text + "\n";

            File.AppendAllText(path, feedbackText);

            MessageBox.Show("Feedback trimis cu succes!");
            feedbackTxtBox.Text = "...";
        }

        private void SetFormLanguage()
        {
            // Change text based on language set
            if (MainProgram.programLanguage.Equals("EN"))
            {
                // English interface
                this.Text = "STUDENT";
                groupBox1.Text = "General details";
                label1.Text = "Name:";
                label2.Text = "Grade:";
                label3.Text = "Average:";
                groupBox2.Text = "Send feedback to principal";
                button1.Text = "Send feedback";
            }
            else
            {
                // Romanian interface
                this.Text = "ELEV";
                groupBox1.Text = "Detalii generale";
                label1.Text = "Nume:";
                label2.Text = "Clasa:";
                label3.Text = "Medie:";
                groupBox2.Text = "Scrie feedback catre directiune";
                button1.Text = "Trimite feedback";

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.OpenForm(new Form1());
            this.Close();
        }
    }
}
