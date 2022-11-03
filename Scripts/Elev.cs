using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    public class Elev : Persoana
    {

        private int clasa;
        private List<float> note = new List<float>();


        // Constructor
        public Elev(string? Name, int Clasa, int Age) : base(Name, Age)
        {
            clasa = Clasa;
        }


        public static Elev CreateElev(string username)
        {
            string? name = MainProgram.FindNameByUsername(username, true);
            int clasa = int.Parse(MainProgram.FindClasaElev(username));
            List<float> note = MainProgram.GetNoteElev(username);

            Elev newElev = new Elev(name, clasa, -1);
            newElev.SetNoteList(note);

            return newElev;
        }

        // Metode private

        //

        // Metode publice

        public List<float> GetNote() { return note; }

        public void AddNota(float nota) { note.Add(nota); }

        public float GetMediaAritmetica()
        {
            if(note.Count <= 0) return 0;

            float suma = 0;
            foreach (float x in note)
                suma += x;

            return suma / note.Count;
        }

        public void GiveFeedback(string text)
        {
            string path = MainProgram.directiunePath + "//feedback.txt";

            File.AppendAllText(path, text + "\n");
        }

        public void SetNoteList(List<float> listaNote)
        {
            note = listaNote;
        }

        public int GetClasa() { return clasa; }

        //
    }
}
