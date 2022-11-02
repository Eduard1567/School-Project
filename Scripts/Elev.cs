using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    internal class Elev : Persoana
    {

        private Clasa? clasa;
        private List<float> note = new List<float>();


        // Constructor
        public Elev(string Name, int Age) : base(Name, Age)
        {
            
        }


        // Metode private

        //

        // Metode publice

        public List<float> GetNote() { return note; }

        public void AddNota(float nota) { note.Add(nota); }

        public float GetMediaAritmetica()
        {
            float suma = 0;
            foreach (float x in note)
                suma += x;

            return suma / note.Count;
        }

        //
    }
}
