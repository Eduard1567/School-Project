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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MainProgram.SetActiveForm(this);

            LoadFeedback();
        }

        private void elevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.ShowForm(new RegistrationForm());
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.ShowForm(new RegistrationForm(true));

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good day!");
            Application.Exit();
        }



        // Methods

        private void LoadFeedback()
        {
            string path = MainProgram.directiunePath + "//feedback.txt";

            foreach(string s in FileHelper.FileReader.ReadLinesList(path))
            {
                listBox1.Items.Add(s);
                this.Controls.Add(listBox1);
            }

            if(listBox1.Items.Count == 0)
            {
                listBox1.Items.Add("no feedback recieved yet...");
            }    
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                listBox1.SelectedIndex = listBox1.IndexFromPoint(new Point(e.X, e.Y));

                if (listBox1.SelectedIndex == -1)
                    return;

                AskToDelete(listBox1.SelectedIndex);
            }
        }

        private void AskToDelete(int index)
        {

            if ((MessageBox.Show("Doresti sa stergi mesajul de feedback?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                string? feedbackText = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(index);
                RemoveFeedbackFromFile(feedbackText);

                MessageBox.Show("Mesajul de feedback a fost sters cu succes!");
            }

        }

        private void RemoveFeedbackFromFile(string? feedbackMessage)
        {
            if (feedbackMessage == null)
                return;

            string path = MainProgram.directiunePath + "//feedback.txt";

            List<string> oldFeedbackFile = FileHelper.FileReader.ReadLinesList(path);
            string newFeedbackFile = "";

            for(int i = 0; i < oldFeedbackFile.Count; i++)
            {
                if (!oldFeedbackFile.ElementAt(i).Contains(feedbackMessage.Substring(feedbackMessage.IndexOf(":"))))
                {
                    newFeedbackFile += oldFeedbackFile.ElementAt(i);

                    if (i != oldFeedbackFile.Count - 1)
                        newFeedbackFile += "\n";
                }
            }

            FileHelper.FileWriter.Write(path, newFeedbackFile);
        }

        private void globalMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.ShowForm(new AdminGlobalMessageForm());
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowTeachersList();
        }


        private void ShowTeachersList()
        {
            string text = "Lista profesori: \n";

            int contor = 1;
            foreach(Profesor p in MainProgram.listaProfesori)
            {
                text += contor.ToString() + ". " + p.GetName() + "\n";
                contor += 1;
            }

            MessageBox.Show(text);
        }

        private void clasaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowStudentsList();
        }

        private void ShowStudentsList()
        {
            string text = "Lista studenti: \n";

            int contor = 1;
            foreach (Elev e in MainProgram.listaElevi)
            {
                text += contor.ToString() + ". " + e.GetName() + "\n";
                contor += 1;
            }

            MessageBox.Show(text);
        }
    }
}
