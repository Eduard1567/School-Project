using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Scripts
{
    internal class Clasa
    {
        public int nrClasa = -1;

        private List<Profesor> profesori = new List<Profesor>();
        private List<Elev> elevi = new List<Elev>();
        private List<Materie>? materii = new List<Materie>();


        public Clasa(int _nrClasa)
        {
            this.nrClasa = _nrClasa;
        }


        // Metode private

        //

        // Metode publice

        public void AddProfesor(Profesor p)
        {
            // POSIBILITATE DE A ADAUGA EROARE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (p == null)
            {
                MessageBox.Show("Imposibil de adaugat un profesor nedefinit!");
                return;
            }

            if (profesori == null)
                MessageBox.Show("Imposibil de adaugat profesorul " + p.GetName() + ", deoarece clasa cu numarul " +
                    nrClasa + " nu are o lista de profesori definita!");
            else
                profesori.Add(p);
        }

        public void DeleteProfesor(Profesor p)
        {
            // POSIBILITATE DE A ADAUGA EROARE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (profesori == null)
            {
                MessageBox.Show("Imposibil de sters profesorul " + p.GetName() + ", deoarece clasa cu numarul " +
                    nrClasa + " nu are o lista de profesori definita!");
                return;
            }
            else if(p == null)
            {
                MessageBox.Show("Imposibil de sters o valoare nula din lista de profesori!");
                return;
            }
                

            if (profesori.Contains(p))
                profesori.Remove(p);
            else
                MessageBox.Show("Profesorul " + p.GetName() + " nu se afla pe lista de profesori ai clasei cu numarul "
                    + nrClasa + "!");
        }


        public void AddElev(Elev e)
        {
            // POSIBILITATE DE A ADAUGA EROARE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (e == null)
            {
                MessageBox.Show("Imposibil de adaugat un elev nedefinit!");
                return;
            }

            if (elevi == null)
                MessageBox.Show("Imposibil de adaugat elevul " + e.GetName() + ", deoarece clasa cu numarul " +
                    nrClasa + " nu are o lista de elevi definita!");
            else
                elevi.Add(e);
        }

        public void DeleteElev(Elev e)
        {
            // POSIBILITATE DE A ADAUGA EROARE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (elevi == null)
            {
                MessageBox.Show("Imposibil de sters elevul " + e.GetName() + ", deoarece clasa cu numarul " +
                    nrClasa + " nu are o lista de elevi definita!");
                return;
            }
            else if (e == null)
            {
                MessageBox.Show("Imposibil de sters o valoare nula din lista de elevi!");
                return;
            }


            if (elevi.Contains(e))
                elevi.Remove(e);
            else
                MessageBox.Show("Elevul " + e.GetName() + " nu se afla pe lista de elevi ai clasei cu numarul "
                    + nrClasa + "!");
        }

        
        public void AddMaterie(Materie m)
        {
            // POSIBILITATE DE A ADAUGA EROARE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if(materii != null)
            {
                materii.Add(m);
                MessageBox.Show("Materie adaugata cu succes!");
            }

        }

        public void DeleteMaterie(Materie m)
        {
            if(materii != null)
            {
                if(materii.Contains(m))
                {
                    materii.Remove(m);
                    MessageBox.Show("Materia a fost stearsa cu succes!");
                }    
            }
        }
        //
    }
}
