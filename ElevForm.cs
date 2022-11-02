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
        private string userName = "Undefined";

        public ElevForm(string username)
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
            numeTxtBox.Text = FileHelper.FileReader.ReadLinesList(MainProgram.pathElevi + "//" + userName + ".txt").ElementAt(2);

        }

    }
}
