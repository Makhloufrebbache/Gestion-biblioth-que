using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    internal  abstract class Article {
        private string titre;
        private string typeArticle;
        private string utilisateur;
        private string statut;
        public string TypeArticle { get { return typeArticle; } set { typeArticle = value; } }
        public string Titre { get { return titre; } set { titre = value; } }
        public string Statut { get { return statut; } set { statut = value; } }
        public string Utilisateur { get { return utilisateur; } set { utilisateur = value; } }
    }
        
 }

