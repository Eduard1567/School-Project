using SchoolProject.Scripts;

namespace SchoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userTxtBox_Click(object sender, EventArgs e)
        {
            userTxtBox.Text = "";
        }
    }
}