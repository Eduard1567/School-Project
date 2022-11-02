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
        public static string programPath = Application.StartupPath;

        public static string pathElevi = programPath + "//Elevi";
        public static string pathProfesori = programPath + "//Profesori";
        public static string detaliiEleviPath = programPath + "//Elevi//Detalii";
        public static string detaliiProfesoriPath = programPath + "//Profesori//Detalii";

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

        public static void ShowForm(Form form)
        {
            form.Show();
        }

        public static void CreateNecessaryFiles()
        {

            // Creating users folder
            if (!Directory.Exists(pathElevi))
                Directory.CreateDirectory(pathElevi);

            // Creating profesori folder
            if (!Directory.Exists(pathProfesori))
                Directory.CreateDirectory(pathProfesori);

            // Creating Detalii Elevi folder
            if (!Directory.Exists(detaliiEleviPath))
                Directory.CreateDirectory(detaliiEleviPath);

            // Creating Detalii Elevi folder
            if (!Directory.Exists(detaliiProfesoriPath))
                Directory.CreateDirectory(detaliiProfesoriPath);
        }
    }
}
