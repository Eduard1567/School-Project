using SchoolProject.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            SetFormLanguage();
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
            if(MainProgram.programLanguage.Equals("EN"))
                MessageBox.Show("Have a good day!");
            else
                MessageBox.Show("O zi buna!");

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
                if(MainProgram.programLanguage.Equals("EN"))
                    listBox1.Items.Add("no feedback recieved yet...");
                else
                    listBox1.Items.Add("niciun feedback momentan...");

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
            if(MainProgram.programLanguage.Equals("EN"))
            {
                if ((MessageBox.Show("Are you sure you want to delete feedback message?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    string? feedbackText = listBox1.SelectedItem.ToString();
                    listBox1.Items.RemoveAt(index);
                    RemoveFeedbackFromFile(feedbackText);

                    MessageBox.Show("Feedback successfully deleted!");
                }
            }
            else
            {
                if ((MessageBox.Show("Doresti sa stergi mesajul de feedback?", "Sterge", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    string? feedbackText = listBox1.SelectedItem.ToString();
                    listBox1.Items.RemoveAt(index);
                    RemoveFeedbackFromFile(feedbackText);

                    MessageBox.Show("Mesajul de feedback a fost sters cu succes!");
                }
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
            string text;

            if(MainProgram.programLanguage.Equals("EN"))
                text = "Teachers List: \n";
            else
                text = "Lista profesori: \n";

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
            string text;

            if (MainProgram.programLanguage.Equals("EN"))
                text = "Students List: \n";
            else
                text = "Lista elevi: \n";

            int contor = 1;
            foreach (Elev e in MainProgram.listaElevi)
            {
                text += contor.ToString() + ". " + e.GetName() + "\n";
                contor += 1;
            }

            MessageBox.Show(text);
        }

        private void SetFormLanguage()
        {
            // Change text based on language set
            if (MainProgram.programLanguage.Equals("EN"))
            {
                // English interface
                this.Text = "ADMIN";
                label1.Text = "Students feedbacks";
                createToolStripMenuItem.Text = "Create";
                globalMessageToolStripMenuItem.Text = "Global Message";
                accountToolStripMenuItem.Text = "Account";
                elevToolStripMenuItem.Text = "Student";
                profesorToolStripMenuItem.Text = "Teacher";
                editToolStripMenuItem.Text = "Display";
                accountToolStripMenuItem1.Text = "Teachers";
                clasaToolStripMenuItem1.Text = "Students";
                closeToolStripMenuItem.Text = "Close";
                logoutToolStripMenuItem.Text = "Logout";
            }
            else
            {
                // Romanian interface
                this.Text = "ADMIN";
                label1.Text = "Feedback-uri de la elevi";
                createToolStripMenuItem.Text = "Creeaza";
                globalMessageToolStripMenuItem.Text = "Mesaj global";
                accountToolStripMenuItem.Text = "Cont";
                elevToolStripMenuItem.Text = "Elev";
                profesorToolStripMenuItem.Text = "Profesor";
                editToolStripMenuItem.Text = "Afisare";
                accountToolStripMenuItem1.Text = "Profesori";
                clasaToolStripMenuItem1.Text = "Elevi";
                closeToolStripMenuItem.Text = "Inchide";
                logoutToolStripMenuItem.Text = "Deconectare";

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.OpenForm(new Form1());
            this.Close();
        }

    }
}
