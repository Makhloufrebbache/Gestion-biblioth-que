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
    public partial class fAuteur : Form
    {
        public fAuteur()
        {
            InitializeComponent();
        }

        private void fAuteur_Load(object sender, EventArgs e)
        {
            Listes.ListAuteurs.Clear();
            Auteur auteur1 = new Auteur(1, "Mouloud", "Feraoun", DateOnly.Parse("1987 - 03 - 01"), "Masculin");
            Auteur auteur2 = new Auteur(2, "Kateb", "Yacine", DateOnly.Parse("1983 - 03 - 01"), "Masculin");
            Listes.ListAuteurs.Add(auteur1);
            Listes.ListAuteurs.Add(auteur2);
            dtgAuteurs.DataSource = null;
            dtgAuteurs.DataSource = Listes.ListAuteurs;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Auteur auteur = new Auteur();
            if (codeAuteur.Text == "" | nomAuteur.Text == "" | prenomAuteur.Text == "" | (btnRadionM.Checked == false && btnRadionF.Checked == false))
            {

                MessageBox.Show("Veuillez renseigner tout les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            auteur.Code = Int32.Parse(codeAuteur.Text);
            auteur.Nom = nomAuteur.Text;
            auteur.Prenom = prenomAuteur.Text;
            auteur.DateNaissance = DateOnly.Parse(dateNaissance.Text);

            if (btnRadionM.Checked)
            {
                auteur.Sexe = "Masculin";
            }
            else
            {
                auteur.Sexe = "Fiminin";
            }

            auteur.ajouterAuteur(auteur.Code, auteur.Nom, auteur.Prenom, auteur.DateNaissance, auteur.Sexe);
            Listes.ListAuteurs.Add(auteur);
            dtgAuteurs.DataSource = null;
            dtgAuteurs.DataSource = Listes.ListAuteurs ;

            MessageBox.Show("Auteur ajouté avec succés", "Succes", MessageBoxButtons.OK);
            codeAuteur.Text = "";
            nomAuteur.Text = "";
            prenomAuteur.Text = "";
            
        }

        private void dtgUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codeAuteur.Text = dtgAuteurs.CurrentRow.Cells[0].Value.ToString();
            nomAuteur.Text = dtgAuteurs.CurrentRow.Cells[1].Value.ToString();
            prenomAuteur.Text = dtgAuteurs.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            fUtilisateur formUtilisateur = new fUtilisateur();
            formUtilisateur.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fArticle formArticle = new fArticle();
            formArticle.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            fEmprunt formEmprunt = new fEmprunt();
            formEmprunt.Show();
        }
    }
}
