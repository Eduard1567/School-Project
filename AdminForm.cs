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
    }
}
