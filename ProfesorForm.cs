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
    public partial class ProfesorForm : Form
    {
        private List<Elev> elevi = new List<Elev>();


        public ProfesorForm()
        {
            InitializeComponent();
        }

        private void ProfesorForm_Load(object sender, EventArgs e)
        {
            MainProgram.SetActiveForm(this);

            GetEleviToLista();
        }



        // Methods

        private void GetEleviToLista()
        {
            foreach(Elev e in MainProgram.listaElevi)
            {
                string elevInfo = "Nume: " + e.GetName() + "; Clasa: " + e.GetClasa().ToString() + "; Medie: " + e.GetMediaAritmetica().ToString();
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
            MainProgram.ShowForm(new ElevInfo(e));
        }
    }
}
