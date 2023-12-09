using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    internal class Auteur:Personne
    {
        
       public Auteur() { }
        public Auteur(int code1, string nom1, string prenom1, DateOnly date1, string sexe1) {
            this.Code = code1;
            this.Nom = nom1;
            this.Prenom = prenom1;
            this.DateNaissance = date1;
            this.Sexe = sexe1;
        }

        public  void ajouterAuteur(int code1, string nom1, string prenom1, DateOnly date1, string sexe1)
        {
            this.Code = code1;
            this.Nom = nom1;
            this.Prenom= prenom1;
            this.DateNaissance = date1;
            this.Sexe = sexe1;
        }
        public void supprimerAuteur(int code1)
        {
            foreach (Auteur auteur in Listes.ListAuteurs)
            {
                if (auteur.Code == code1)
                {
                    Listes.ListAuteurs.Remove(auteur);
                    break;
                }
            }
        }
    }
}

