using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
   public class clsListEmployee
    {
        private Dictionary<string, clsEmployee> maListe;

        public clsListEmployee()
        {
            //Classe
            maListe = new Dictionary<string, clsEmployee>();
        }

        public Dictionary<string, clsEmployee>.ValueCollection Elements
        {
            get
            {
                return maListe.Values;
            }


        }

        public int Nombre
        {
            get
            {
                return maListe.Count();
            }

            //set
            //{
            //}
        }

        public bool Ajouter(clsEmployee Employee)
        {
            //verification si le joueur existe ou pas
            if (Exist(Employee.RefEmployee))
            {
                return false; //s'il existe retourne faux
            }
            //si le joueur n'existe pas
            else
            {
                //ajout du joueur dans le dictionnaire
                maListe.Add(Employee.RefEmployee, Employee);
                //retourne vrai
                return true;
            }
        }

        public bool Supprimer(string RefEmployee)
        {
            return maListe.Remove(RefEmployee);
        }

        public clsEmployee Trouver(string RefEmployee)
        {
            if (Exist(RefEmployee))
            {
                return maListe[RefEmployee];
            }
            else
            {
                return null;
            }
        }

        public bool Exist(string RefEmployee)
        {
            return maListe.ContainsKey(RefEmployee);
        }

        public string Afficher()
        {
            string info = "\n----------\n";
            foreach (clsEmployee hs in maListe.Values)
            {
                info += Afficher();
            }
            return info;
        }
    }
}
