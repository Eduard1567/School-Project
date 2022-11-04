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

            MessageBox.Show("Mesajul a fost trimis cu succes catre toti elevii!");

            this.Close();
        }
    }
}
