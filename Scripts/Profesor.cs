using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    internal class Profesor : Persoana
    {
        private Clasa? clasa;
        private Materie? materie;

        public Profesor(string Name, int Age, Clasa? _clasa, Materie? _materie) : base(Name, Age)
        {
            this.clasa = _clasa; 
            this.materie = _materie;
        }


        // Metode private

        //


        // Metode publice

        //
    }
}
