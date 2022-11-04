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

            if (messages != null)
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
    }
}
