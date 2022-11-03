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
    public partial class ElevInfo : Form
    {
        private Elev elevObj;

        public ElevInfo(Elev e)
        {
            InitializeComponent();

            elevObj = e;
        }

        private void ElevInfo_Load(object sender, EventArgs e)
        {
            label1.Text = elevObj.GetName();
        }
    }
}
