using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bibliotheque
{
    public partial class fArticle : Form
    {
        public fArticle()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Auteur auteur in Listes.ListAuteurs)
            {

                Auteur.Items.Add(auteur.Nom + " " + auteur.Prenom);

            }
        }

        private void fArticle_Load(object sender, EventArgs e)
        {
            Listes.ListeArticles.Clear();
            Livre livre1 = new Livre("Coline oblié", "Livre", "Mouloud féraoun", "1C123", DateOnly.Parse("1987 - 03 - 01"), "Disponible","/");
            Livre livre2 = new Livre("Les chiens", "Livre", "Partick Godin", "2C123", DateOnly.Parse("1983 - 01 - 02"), "Disponible","/");
            Livre livre3 = new Livre("To The Forest", "Livre", "Partick Godin", "3C123", DateOnly.Parse("1989 - 04 - 07"), "Disponible", "/");
            Livre livre4 = new Livre("Le fils de pauvre", "Livre", "Mouloud féraoun", "4C123", DateOnly.Parse("1988 - 03 - 09"), "Disponible", "/");
            Listes.ListeArticles.Add(livre1);
            Listes.ListeArticles.Add(livre2);
            Listes.ListeArticles.Add(livre2);
            Listes.ListeArticles.Add(livre4);
            dtgArticle.DataSource = null;
            dtgArticle.DataSource = Listes.ListeArticles;

            foreach (Auteur auteur in Listes.ListAuteurs)
            {

               Auteur.Items.Add(auteur.Nom +" "+ auteur.Prenom);

            }
        }

        private void dtgUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           
                        
            if (typeArticle.SelectedItem.ToString() == "Livre")
            {
                Livre livre = new Livre();
                livre.TypeArticle = typeArticle.Text;
                livre.Titre = titreArticle.Text;
                livre.Auteur = Auteur.SelectedItem.ToString();
                livre.CodeISBN = codeISBN.Text;
                livre.DateEdition = DateOnly.Parse(dateEdition.Text);
                livre.Statut = "Disponible";
                livre.Utilisateur = "/";
                livre.ajouterLivre( livre.Titre,livre.TypeArticle, livre.Auteur, livre.CodeISBN, livre.DateEdition,livre.Statut,livre.Utilisateur);
                Listes.ListeArticles.Add(livre);
                dtgArticle.DataSource = null;
                dtgArticle.DataSource = Listes.ListeArticles;
                

            }
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            fArticle formArticle = new fArticle();
            formArticle.Show();
        }

        private void dtgArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Auteur.Text = dtgArticle.CurrentRow.Cells[0].Value.ToString();
            codeISBN.Text = dtgArticle.CurrentRow.Cells[1].Value.ToString();
            dateEdition.Text = dtgArticle.CurrentRow.Cells[2].Value.ToString();
            typeArticle.Text = dtgArticle.CurrentRow.Cells[3].Value.ToString();
            titreArticle.Text = dtgArticle.CurrentRow.Cells[4].Value.ToString();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            dtgArticle.Refresh();
        }
    }
}









