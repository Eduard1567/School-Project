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

namespace SchoolProject
{
    public partial class ProfesorForm : Form
    {
        public Profesor? profesorObj;

        private string userName = "Undefined";
        private List<Elev> elevi = new List<Elev>();


        public ProfesorForm(string UserName)
        {
            InitializeComponent();
            this.userName = UserName;
        }

        private void ProfesorForm_Load(object sender, EventArgs e)
        {
            MainProgram.SetActiveForm(this);

            LoadInfo();
            SetFormLanguage();
        }



        // Methods

        private void LoadInfo()
        {
            profesorObj = Profesor.CreateProfesor(userName);

            if (MainProgram.programLanguage.Equals("EN"))
                this.Text = "Logged in as TEACHER: " + profesorObj.GetName();
            else
                this.Text = "Logat ca PROFESOR: " + profesorObj.GetName();

            GetEleviToLista();

        }

        public void UpdateData()
        {
            // Clear listbox to avoid duplicates
            listBox1.Items.Clear();

            foreach (Elev e in elevi)
            {
                string elevInfo;
                if(MainProgram.programLanguage.Equals("EN"))
                    elevInfo = "Name: " + e.GetName() + "; Grade: " + e.GetClasa().ToString() + "; Average: " + e.GetMediaAritmetica().ToString("0.00");
                else
                    elevInfo = "Nume: " + e.GetName() + "; Clasa: " + e.GetClasa().ToString() + "; Medie: " + e.GetMediaAritmetica().ToString("0.00");


                listBox1.Items.Add(elevInfo);

                this.Controls.Add(listBox1);
            }
        }


        private void GetEleviToLista()
        {
            foreach(Elev e in MainProgram.listaElevi)
            {
                string elevInfo;
                if (MainProgram.programLanguage.Equals("EN"))
                    elevInfo = "Name: " + e.GetName() + "; Grade: " + e.GetClasa().ToString() + "; Average: " + e.GetMediaAritmetica().ToString("0.00");
                else
                    elevInfo = "Nume: " + e.GetName() + "; Clasa: " + e.GetClasa().ToString() + "; Medie: " + e.GetMediaAritmetica().ToString("0.00");


                listBox1.Items.Add(elevInfo);

                this.Controls.Add(listBox1);

                elevi.Add(e);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenElevInfoForm(elevi[listBox1.SelectedIndex]);
        }


        
        // Methods

        private void OpenElevInfoForm(Elev e)
        {
            MainProgram.ShowForm(new ElevInfo(e, this));
        }

        private void SetFormLanguage()
        {
            // Change text based on language set
            if (MainProgram.programLanguage.Equals("EN"))
            {
                // English interface
                this.Text = "TEACHER";
                label1.Text = "Students list: (double click to interact)";
            }
            else
            {
                // Romanian interface
                this.Text = "PROFESOR";
                label1.Text = "Lista elevi: (dublu click pentru a interactiona)";

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProgram.OpenForm(new Form1());
            this.Close();
        }
    }
}
