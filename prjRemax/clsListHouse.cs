using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
    public class clsListHouse
    {
        private Dictionary<string, clsHouse> maListe;

        public clsListHouse()
        {
            //Classe
            maListe = new Dictionary<string, clsHouse>();
        }

        public Dictionary<string, clsHouse>.ValueCollection Elements
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

        public bool Ajouter(clsHouse House)
        {
            //verification 
            if (Exist(House.RefHouse))
            {
                return false; //
            }
            
            else
            {
                //ajout du joueur dans le dictionnaire
                maListe.Add(House.RefHouse, House);
                //retourne vrai
                return true;
            }
        }

        public bool Supprimer(string RefHouse)
        {
            return maListe.Remove(RefHouse);
        }

        public clsHouse Trouver(string RefHouse)
        {
            if (Exist(RefHouse))
            {
                return maListe[RefHouse];
            }
            else
            {
                return null;
            }
        }

        public bool Exist(string RefHouse)
        {
            return maListe.ContainsKey(RefHouse);
        }

        public string Afficher()
        {
            string info = "\n----------\n";
            foreach (clsHouse hs in maListe.Values)
            {
                info += Afficher();
            }
            return info;
        }
    }
}
