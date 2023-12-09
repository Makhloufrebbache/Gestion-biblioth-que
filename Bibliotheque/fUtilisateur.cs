using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class fUtilisateur : Form
    {
        public fUtilisateur()
        {
            InitializeComponent();
        }

        private void fUtilisateur_Load(object sender, EventArgs e)
        {
            Listes.ListUtilisateurs.Clear();
            Utilisateur user1 = new Utilisateur(1, "REBBACHE", "Makhlouf", DateOnly.Parse ("1987 - 03 - 01"), "Masculin");
            Utilisateur user2 = new Utilisateur(2, "HASSANI", "Faycel", DateOnly.Parse("1983 - 03 - 01"), "Masculin");
            Utilisateur user3 = new Utilisateur(3, "KANEM", "aMINE", DateOnly.Parse("1997 - 07 - 01"), "Masculin");
            Utilisateur user4 = new Utilisateur(4, "MOUSSOUNI", "Sofiane", DateOnly.Parse("1997 - 03 - 01"), "Masculin");
            Listes.ListUtilisateurs.Add(user1);
            Listes.ListUtilisateurs.Add(user2);
            Listes.ListUtilisateurs.Add(user3);
            Listes.ListUtilisateurs.Add(user4);
            dtgUtilisateurs.DataSource = null;
            dtgUtilisateurs.DataSource = Listes.ListUtilisateurs;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            if(codeUser.Text == "" | nomUser.Text == "" | prenomUser.Text == "" | (btnRadionM.Checked == false && btnRadionF.Checked == false)) {

                     MessageBox.Show("Veuillez renseigner tout les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Code = Int32.Parse(codeUser.Text);
            utilisateur.Nom = nomUser.Text;
            utilisateur.Prenom= prenomUser.Text;
            utilisateur.DateNaissance = DateOnly.Parse(dateNaissance.Text);

            if (btnRadionM.Checked) { 
                utilisateur.Sexe = "Masculin";
            }
            else {
                utilisateur.Sexe = "Fiminin";
             }
           
            utilisateur.ajouterUtilisateur(utilisateur.Code, utilisateur.Nom, utilisateur.Prenom, utilisateur.DateNaissance,utilisateur.Sexe);
            Listes.ListUtilisateurs.Add(utilisateur);
            dtgUtilisateurs.DataSource = null;
            dtgUtilisateurs.DataSource = Listes.ListUtilisateurs;

            MessageBox.Show("Utilisateur ajouté avec succés", "Succes", MessageBoxButtons.OK);
            codeUser.Text = "";
            nomUser.Text = "";
            prenomUser.Text = "";
        }

        private void codeUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur();
            string matricule = dtgUtilisateurs.CurrentRow.Cells[0].Value.ToString();
            utilisateur.Code= Int32.Parse(matricule);
            utilisateur.Nom= nomUser.Text;
            utilisateur.Prenom = prenomUser.Text;

            if (btnRadionM.Checked)
            {
                utilisateur.Sexe = "Masculin";
            }
            else
            {
                utilisateur.Sexe = "Fiminin";
            }

            utilisateur.DateNaissance = DateOnly.Parse(dateNaissance.Text);
            utilisateur.modifierUtilisateur(utilisateur.Code, utilisateur.Nom, utilisateur.Prenom, utilisateur.DateNaissance, utilisateur.Sexe);
            dtgUtilisateurs.DataSource = null;
            dtgUtilisateurs.DataSource = Listes.ListUtilisateurs;

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string matricule = dtgUtilisateurs.CurrentRow.Cells[0].Value.ToString();
            Utilisateur utilisateur = new Utilisateur();
           utilisateur.supprimerUtilisateur(Int32.Parse(matricule));
            dtgUtilisateurs.DataSource= null;
            dtgUtilisateurs.DataSource = Listes.ListUtilisateurs;
            //pour afficher le message apres l'ajout
            MessageBox.Show("Utilisateur supprimé avec succés");

        }

        private void dtgUtilisateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codeUser.Text = dtgUtilisateurs.CurrentRow.Cells[0].Value.ToString();
            nomUser.Text = dtgUtilisateurs.CurrentRow.Cells[1].Value.ToString();
            prenomUser.Text = dtgUtilisateurs.CurrentRow.Cells[2].Value.ToString();
        }

        private void Utilisateur_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           fAuteur formAuteur = new fAuteur();
            formAuteur.Show();
           
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
        //fUtilisateur formUtilisateur = new fUtilisateur();
        //formUtilisateur.Show();
        //dtgUtilisateurs.DataSource = listeUtilisateurs.ListUtilisateurs;
         
          
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
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

