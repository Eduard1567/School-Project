using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    public class Persoana
    {

        private string? name = "Undefined";
        private int age = -1;


        // Constructor
        public Persoana(string? Name, int Age)
        {
            this.name = Name;
            this.age = Age; ;
        }



        // Metode private

        //

        // Metode publice

        public string? GetName() { return this.name; }

        public int GetAge() { return this.age; }

        //

    }
}
