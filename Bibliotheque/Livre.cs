using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    internal class Livre:Article
    {
        private string auteur;
        private string codeISBN;
        private DateOnly dateEdition;
        public Livre() { }
        public Livre(string titre, string type, string auteur, string code, DateOnly date, string statut,string utilisateur) { 
            this.Titre = titre;
            this.TypeArticle= type;
            this.Auteur = auteur;
            this.CodeISBN = code;
            this.DateEdition = date;
            this.Statut = statut;
            this.Utilisateur= utilisateur;
        }
        public string Auteur { get { return auteur; } set { auteur = value; } }
        public string CodeISBN { get { return codeISBN; } set { codeISBN = value; } }
        public DateOnly DateEdition { get { return dateEdition; } set { dateEdition = value; } }
        public void ajouterLivre(string titre, string type, string auteur, string code, DateOnly date,string statut, string utilisateur)
        {
            this.Titre = titre;
            this.TypeArticle = type;
            this.Auteur = auteur;
            this.CodeISBN = code;
            this.DateEdition = date;
            this.Statut = statut;
            this.Utilisateur= utilisateur;
        }

    }
}
