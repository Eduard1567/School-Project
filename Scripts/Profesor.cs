using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    public class Profesor : Persoana
    {

        private string username;

        public Profesor(string Name, int Age, string Username) : base(Name, Age)
        {
            this.username = Username;
        }

#pragma warning disable CS8604
        public static Profesor CreateProfesor(string username)
        {
            string? name = MainProgram.FindNameByUsername(username, false);

            return new Profesor(name, -1, username);
        }
#pragma warning restore CS8604

        public static void GiveGrade(Elev e, float nota)
        {
            e.AddNota(nota);

            // Adaugare nota in baza de date
            string path = MainProgram.detaliiEleviPath + "//note_" + e.GetUsername() + ".txt";
            File.AppendAllText(path, nota.ToString() + "\n");
        }

        // Metode private

        //


        // Metode publice

        //
    }
}
