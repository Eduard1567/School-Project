using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    internal class Materie
    {
        private Profesor profesor;
        private string description = "Undefined";



        public Materie(Profesor _profesor, string _description)
        {
            this.profesor = _profesor;
            this.description = _description;
        }



        // Metode private

        //


        // Metode publice

        public void AssignProfesor(Profesor p)
        {
            profesor = p;
        }

        //
    }
}
