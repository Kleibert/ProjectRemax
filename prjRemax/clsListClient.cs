using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRemax
{
   public class clsListClient
    {
        private Dictionary<string, clsClient> maListe;

        public clsListClient()
        {
            //Classe
            maListe = new Dictionary<string, clsClient>();
        }

        public Dictionary<string, clsClient>.ValueCollection Elements
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

        public bool Ajouter(clsClient Client)
        {
            //verification si le joueur existe ou pas
            if (Exist(Client.RefClient))
            {
                return false; //s'il existe retourne faux
            }
            //si le joueur n'existe pas
            else
            {
                //ajout du joueur dans le dictionnaire
                maListe.Add(Client.RefClient, Client);
                //retourne vrai
                return true;
            }
        }

        public bool Supprimer(string RefClient)
        {
            return maListe.Remove(RefClient);
        }

        public clsClient Trouver(string RefClient)
        {
            if (Exist(RefClient))
            {
                return maListe[RefClient];
            }
            else
            {
                return null;
            }
        }

        public bool Exist(string RefClient)
        {
            return maListe.ContainsKey(RefClient);
        }

        public string Afficher()
        {
            string info = "\n----------\n";
            foreach (clsClient hs in maListe.Values)
            {
                info += Afficher();
            }
            return info;
        }
    }
}
