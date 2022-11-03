using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolProject.Scripts
{
    public static class MainProgram
    {
        public static string programPath = Application.StartupPath;

        public static string pathElevi = programPath + "//Elevi";
        public static string pathProfesori = programPath + "//Profesori";
        public static string detaliiEleviPath = programPath + "//Elevi//Detalii";
        public static string detaliiProfesoriPath = programPath + "//Profesori//Detalii";
        public static string directiunePath = programPath + "//Directiune";

        public static List<Elev> listaElevi = new List<Elev>();

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

            // Creating Directiune folder & text file for feedback
            if (!Directory.Exists(directiunePath))
            {
                Directory.CreateDirectory(directiunePath);
                File.WriteAllText(directiunePath + "//feedback.txt", "");
            }
        }

        public static string? FindNameByUsername(string username, bool elev)
        {
            // Set path
            string path = "";

            if (elev)
                path = pathElevi + "//" + username + ".txt";
            else
                path = pathProfesori + "//" + username + ".txt";


            // Check if username can be found in the database
            if (File.Exists(path))
            {
                // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!!!

                return FileHelper.FileReader.ReadLine(path, 2);  // returneaza linia 3 din fisierul gasit dupa username(numele)

            }

            MessageBox.Show("There is no valid username found!");
            return null;

        }

        public static string FindClasaElev(string username)
        {
            // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!!
            string path = detaliiEleviPath + "//" + username + ".txt";

            var text = FileHelper.FileReader.ReadLine(path, 0);

            if (text == null)
                return "-1";

            return text.ToString();
        }

        public static List<float> GetNoteElev(string userName)
        {
            string path = detaliiEleviPath + "//note_" + userName + ".txt";

            List<string> stringList = FileHelper.FileReader.ReadLinesList(path);
            List<float> listaNote = new List<float>();

            // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!!!

            for (int i = 0; i < stringList.Count; i++)
            {
                listaNote.Add(float.Parse(stringList[i]));
            }


            return listaNote;
        }

        public static float GetMedieElev(string userName)
        {
            string path = detaliiEleviPath + "//note_" + userName + ".txt";

            float suma = 0;

            List<string> listaNote = FileHelper.FileReader.ReadLinesList(path);

            // POSIBILITATE ADAUGARE EROARE!!!!!!!!!!!!!!!!!!!!
            if (FileHelper.FileReader.IsEmpty(path))
                return -1;


            for (int i = 0; i < listaNote.Count; i++)
            {
                suma += float.Parse(listaNote.ElementAt(i));
            }

            return suma / listaNote.Count;
        }

        public static void LoadListaElevi()
        {
            // Iterate through all the files having .txt extension in folder Elevi and create new Elev for each
            // then push every one into the list

            listaElevi = new List<Elev>();  // Be sure that the list is empty so you avoid duplicates

            string[] files = Directory.GetFiles(MainProgram.pathElevi);

            // Incarcarea tuturor utilizatorilor in lista
            foreach(string s in files)
            {
                if(s.Contains(".txt"))
                {
                    // Incarcare credentiale
                    string path = s;
                    List<string> credentials = FileHelper.FileReader.ReadLinesList(path);

                    string username = credentials[0];
                    string? nume = credentials[2];
                    int clasa = -1;
                    List<float> note = new List<float>();

                    // Incarcare detalii
                    var cls = "";
                    if((cls = FileHelper.FileReader.ReadLine((MainProgram.detaliiEleviPath + "//" + username + ".txt"), 0)) != null)
                    {
                        clasa = int.Parse(cls.ToString());
                    }

                    // Incarcare lista note
                    note = MainProgram.GetNoteElev(username);

                    Elev newElev = new Elev(nume, clasa, -1);
                    newElev.SetNoteList(note);

                    listaElevi.Add(newElev);
                }
            }
        }
        
    }
}
