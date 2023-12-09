using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque
{
    public partial class fEmprunt : Form
    {
        public fEmprunt()
        {
            InitializeComponent();
        }

        private void fEmprunt_Load(object sender, EventArgs e)
        {
            Listes.ListeArticles.Clear();
            Livre livre1 = new Livre("Coline oblié", "Livre", "Mouloud féraoun", "1C123", DateOnly.Parse("1987 - 03 - 01"), "Disponible", "/");
            Livre livre2 = new Livre("Les chiens", "Livre", "Partick Godin", "2C123", DateOnly.Parse("1983 - 01 - 02"), "Disponible", "/");
            Livre livre3 = new Livre("To The Forest", "Livre", "Partick Godin", "3C123", DateOnly.Parse("1989 - 04 - 07"), "Disponible", "");
            Livre livre4 = new Livre("Le fils de pauvre", "Livre", "Mouloud féraoun", "4C123", DateOnly.Parse("1988 - 03 - 09"), "Disponible", "");
            Listes.ListeArticles.Add(livre1);
            Listes.ListeArticles.Add(livre2);
            Listes.ListeArticles.Add(livre2);
            Listes.ListeArticles.Add(livre4);
            Listes.ListAuteurs.Clear();
            Auteur auteur1 = new Auteur(1, "Mouloud", "Feraoun", DateOnly.Parse("1987 - 03 - 01"), "Masculin");
            Auteur auteur2 = new Auteur(2, "Kateb", "Yacine", DateOnly.Parse("1983 - 03 - 01"), "Masculin");
            Listes.ListAuteurs.Add(auteur1);
            Listes.ListAuteurs.Add(auteur2);
            Listes.ListUtilisateurs.Clear();
            Utilisateur user1 = new Utilisateur(1, "REBBACHE", "Makhlouf", DateOnly.Parse("1987 - 03 - 01"), "Masculin");
            Utilisateur user2 = new Utilisateur(2, "HASSANI", "Faycel", DateOnly.Parse("1983 - 03 - 01"), "Masculin");
            Utilisateur user3 = new Utilisateur(3, "KANEM", "aMINE", DateOnly.Parse("1997 - 07 - 01"), "Masculin");
            Utilisateur user4 = new Utilisateur(4, "MOUSSOUNI", "Sofiane", DateOnly.Parse("1997 - 03 - 01"), "Masculin");
            Listes.ListUtilisateurs.Add(user1);
            Listes.ListUtilisateurs.Add(user2);
            Listes.ListUtilisateurs.Add(user3);
            Listes.ListUtilisateurs.Add(user4);
            foreach (Utilisateur user in Listes.ListUtilisateurs)
            {
                User.Items.Add(user.Nom + " " + user.Prenom);
            }


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void codeISBN_TextChanged(object sender, EventArgs e)
        {
            foreach (Livre article in Listes.ListeArticles)
            {
            if (codeISBN.Text == article.CodeISBN) 
                { 
                 titreArticle.Text = article.Titre;
                 typeArticle.Text = article.TypeArticle;
                 Auteur.Text = article.Auteur;
                 guna2TextBox1.Text = article.Statut;
                 User.Text = article.Utilisateur;

                }

            }


        }

        private void Auteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateEdition_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            foreach (Livre article in Listes.ListeArticles)
            {
                if (article.CodeISBN == codeISBN.Text)
                {
                  
                    article.Utilisateur = User.Text;
                    article.Statut = "Emprunter";
                }

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            foreach (Livre article in Listes.ListeArticles)
            {
                if (article.CodeISBN == codeISBN.Text)
                {

                    article.Utilisateur = "/";
                    article.Statut = "Disponible";
                }

            }

        }
    }
}

