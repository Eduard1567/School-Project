using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    public static class MainProgram
    {

        private static Form? activeForm;



        public static void SetActiveForm(Form form) { activeForm = form; }

        public static Form? GetActiveForm() 
        {
            if (activeForm != null)
                return activeForm;
            else
                return null;
        }

        public static void OpenForm(Form form)
        {
            if(activeForm != null)
            {
                Form lastActiveForm = activeForm;

                lastActiveForm.Hide();
                form.ShowDialog();
                lastActiveForm.Close();

            }
            
        }
    }
}
