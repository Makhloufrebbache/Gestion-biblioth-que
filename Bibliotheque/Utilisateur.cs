using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    internal class Utilisateur : Personne
    {
        public Utilisateur() { }
        public Utilisateur(int code, string nom1, string prenom1, DateOnly date1, string sexe1) {
            this.Code = code;
            this.Nom = nom1;
            this.Prenom = prenom1;
            this.DateNaissance = date1;
            this.Sexe = sexe1;
        }
        public void ajouterUtilisateur(int code ,string nom1, string prenom1, DateOnly date1, string sexe1)
        {
            this.Code = code;
            this.Nom = nom1;
            this.Prenom = prenom1;
            this.DateNaissance = date1;
            this.Sexe = sexe1;
        }
        public void supprimerUtilisateur(int code1)
        {
            foreach (Utilisateur utilisateur in Listes.ListUtilisateurs)
            {
                if (utilisateur.Code == code1)
                {
                   Listes.ListUtilisateurs.Remove(utilisateur);
                   break;
                }
            }
        }
        public void modifierUtilisateur(int code1, string nom1, string prenom1, DateOnly date1, string sexe1)
        {
            foreach (Utilisateur utilisateur in Listes.ListUtilisateurs)
            {
                if (utilisateur.Code == code1)
                {
                   utilisateur.Code= code1;
                   utilisateur.Nom= nom1;
                   utilisateur.Prenom= prenom1;
                   utilisateur.DateNaissance= date1;
                   utilisateur.Sexe= sexe1;
                   break;
                }
            }
        }
    }
    
}
