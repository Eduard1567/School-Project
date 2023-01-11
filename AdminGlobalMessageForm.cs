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
    public partial class AdminGlobalMessageForm : Form
    {
        public AdminGlobalMessageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendGlobalMessage();
        }


        private void SendGlobalMessage()
        {
            // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!

            string message = "IMPORTANT!!! DIRECTIUNE: " + textBox1.Text;

            foreach(Elev e in MainProgram.listaElevi)
            {
                string path = MainProgram.GetInboxPath(e.GetUsername(), true);

                File.AppendAllText(path, message);
            }

            if(MainProgram.programLanguage.Equals("EN"))
                MessageBox.Show("Message has been successfully sent to all students!");
            else
                MessageBox.Show("Mesajul a fost trimis cu succes catre toti elevii!");


            this.Close();
        }

        private void AdminGlobalMessageForm_Load(object sender, EventArgs e)
        {
            SetFormLanguage();
        }

        private void SetFormLanguage()
        {
            // Change text based on language set
            if (MainProgram.programLanguage.Equals("EN"))
            {
                // English interface
                this.Text = "ADMINISTRATOR GLOBAL MESSAGE";
                button1.Text = "SEND";
            }
            else
            {
                // Romanian interface
                this.Text = "ADMININSTRATOR MESAJ GLOBAL";
                button1.Text = "TRIMITE";

            }
        }
    }
}
