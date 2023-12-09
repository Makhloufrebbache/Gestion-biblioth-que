using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    internal abstract class Personne
    {
        private int code;
        private string nom;
        private string prenom;
        private DateOnly dateNaissance;
        private string sexe;

        public int Code { get { return code; } set { code = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public DateOnly DateNaissance { get { return dateNaissance; } set { dateNaissance = value; } }

        public string Sexe { get { return sexe; } set { sexe = value; } }
       

    }
}
