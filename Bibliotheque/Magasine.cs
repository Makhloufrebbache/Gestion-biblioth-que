using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    internal class Magasine :Article
    {
        private DateOnly datePublication;
        public DateOnly DatePublication
        {
             get { return datePublication; } set { datePublication = value; } 
        }
        public void ajouterMagasin(string titre, string type, string auteur, DateOnly date, string code)
        {
            this.Titre = titre;
            this.TypeArticle = type;
            this.DatePublication = date;
        }

    }
}
