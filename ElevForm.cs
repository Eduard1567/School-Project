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
        public ElevForm()
        {
            InitializeComponent();
        }

        private void ElevForm_Load(object sender, EventArgs e)
        {
            MainProgram.SetActiveForm(this);
        }
    }
}
