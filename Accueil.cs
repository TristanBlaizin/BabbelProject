using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BabbelProject
{
    public partial class Accueil : Form
    {
        public static string ch_connect;
        public OleDbConnection connec;

        public DataSet Babbel = new DataSet();
        public DataTable TableVerifExo = new DataTable();
        public bool firstLoad = true;

        public List<string> admin = new List<string>();

        public Accueil()
        {
            InitializeComponent();
        }

        public void ChangeFirstLoad()
        {
            lblPresentation1.Visible = false;
            lblPresentation2.Visible = false;
            lblPresentation3.Visible = false;
            lblPresentation4.Visible = false;
            lblPresentation5.Visible = false;
            lblAcceuilCoursActuelle.Visible = true;
            lblAcceuilLecon.Visible = true;
            btnExo.Visible = true;
        }

        public void InitDeconnecte()
        {
            List<string> TableListe = new List<string>();
            try
            {
                connec.Open();
                DataTable table = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                OleDbDataAdapter adapter;
                string line = String.Empty;
                string commande = String.Empty;
                foreach (DataRow ligne in table.Rows)
                {
                    line = ligne["TABLE_NAME"].ToString();
                    commande = "Select * from " + line;
                    adapter = new OleDbDataAdapter(commande, connec);
                    adapter.Fill(Babbel, line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connec.Close();
            }
        }


        public void InitTableVerif()
        {
            TableVerifExo.Columns.Add(new DataColumn("numExo", typeof(int)));
            TableVerifExo.Columns.Add(new DataColumn("finish", typeof(bool)));
        }
        public void changeTableVerif(DataRow utilisateur, DataRow[] exos)
        {
            int i = 0;
            foreach (DataRow row in exos)
            {
                if(i < (int)utilisateur.ItemArray[4])
                    TableVerifExo.Rows.Add(row.ItemArray[0], true);
                else
                    TableVerifExo.Rows.Add(row.ItemArray[0], false);
                i++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ch_connect = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\..\baseLangue.mdb";

            connec = new OleDbConnection();
            connec.ConnectionString = ch_connect;

            InitDeconnecte();
            InitTableVerif();

            DataRowCollection rowArray = Babbel.Tables["Utilisateurs"].Rows;
            foreach (DataRow row in rowArray)
            {
                string prenom = row.ItemArray[2].ToString();
                string nom = row.ItemArray[1].ToString();
                cbxAcceuilUtilisateur.Items.Add($"{prenom} {nom}");
            }
            admin.Add("Véronique Richard"); //tenter de regler le probleme
            admin.Add("Murielle Torregrossa");

        }

        private void CbxUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (firstLoad)
            {
                firstLoad = false;
                ChangeFirstLoad();
            }
            string utilisateur = cbxAcceuilUtilisateur.SelectedItem.ToString();
            string prenom = utilisateur.Split(' ')[0];
            DataRow InfosUtilisateur = Babbel.Tables["Utilisateurs"].Select($"pnUtil = '{prenom}'")[0];
            string codeCourActuel = InfosUtilisateur.ItemArray[6].ToString();
            DataRow InfosCours = Babbel.Tables["Cours"].Select($"numCours = '{codeCourActuel}'")[0];
            DataRow InfosLecons = Babbel.Tables["Lecons"].Select($"numCours = '{codeCourActuel}'")[0];
            int NbExo = Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0]}'").Length;
            lblAccueilCours2.Text = InfosCours.ItemArray[1].ToString();
            lblAccueilLecon2.Text = InfosLecons.ItemArray[2].ToString();
            lblAccueilComentLecon.Text = InfosLecons.ItemArray[3].ToString();
            lblAccueilExo.Text = $"Exercices terminés: {InfosUtilisateur.ItemArray[4]}/{NbExo.ToString()}";
            ptbAccueilDrapeauNoirBlanc.Visible = true;

            changeDrapeau();
            changeTableVerif(InfosUtilisateur, Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0]}'"));
            for (int i = 0; i<admin.Count; i++)
            {
                if (admin[i] == cbxAcceuilUtilisateur.SelectedItem.ToString())
                {
                    btnAdmin.Visible = true;
                }
                else
                {
                    btnAdmin.Visible = false;
                }
            }

        }

        private void BtnExo_Click(object sender, EventArgs e)
        {
            string utilisateur = cbxAcceuilUtilisateur.SelectedItem.ToString();
            string prenom = utilisateur.Split(' ')[0];
            DataRow InfosUtilisateur = Babbel.Tables["Utilisateurs"].Select($"pnUtil = '{prenom}'")[0];
            string codeCourActuel = InfosUtilisateur.ItemArray[6].ToString();
            DataRow InfosLecons = Babbel.Tables["Lecons"].Select($"numCours = '{codeCourActuel}'")[0];
            DataRow[] InfosExo = Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0].ToString()}'");
            if ((int)(InfosExo[0].ItemArray[5]) == 0)
            {
                LeconVocabulaire LeconVocabulaire = new LeconVocabulaire(InfosExo[0], Babbel,utilisateur);
                LeconVocabulaire.ShowDialog();

            }
            else if ((bool)(InfosExo[0].ItemArray[6]))
            {
                ExoDesordre ExoDesordre = new ExoDesordre(InfosExo[0], Babbel, utilisateur);
                ExoDesordre.ShowDialog();
            }
            else
            {
                ExoTrou ExoATrou = new ExoTrou(InfosExo[0], Babbel, utilisateur);
                ExoATrou.ShowDialog();
            }

            DialogResult = DialogResult.OK;
        }

        private void cbxUtilisateur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            gpbAcceuil.Text = "Panneau d'administration";
            lblAcceuilIdentification.Visible = false;
            cbxAcceuilUtilisateur.Visible = false;
            lblAcceuilCoursActuelle.Visible = false;
            lblAcceuilLecon.Visible = false;
            ptbAccueilDrapeauCouleur.Visible = false;
            ptbAccueilDrapeauNoirBlanc.Visible = false;
            lblAccueilLecon2.Visible = false;
            lblAccueilComentLecon.Visible = false;
            lblAccueilCours2.Visible = false;
            lblAccueilExo.Visible = false;
            btnExo.Visible = false;
            btnAdmin.Visible = false;
            lblAdminLaCasaDeBabel.Visible = true;
            lblAcceuilLaCasaDeBabel.Visible = false;
            btnAdminAccueil.Visible = true;
            //remplir les deux combobox
            DataRowCollection rowArray = Babbel.Tables["Cours"].Rows;
            foreach (DataRow row in rowArray)
            {
                string titreCours = row.ItemArray[1].ToString();
                cbxAdminCours.Items.Add(titreCours);
            }

            lblAdminCours.Visible = true;
            cbxAdminCours.Visible = true;

        }

        private void cbxAdminCour_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAdminLecon.Items.Clear();
            lblAdminLecon.Visible = true;
            cbxAdminLecon.Visible = true;
            DataRow InfosCours = Babbel.Tables["Cours"].Select($"titreCours = '{cbxAdminCours.SelectedItem}'")[0];
            DataRow[] lecon = Babbel.Tables["Lecons"].Select($"numCours = '{InfosCours.ItemArray[0]}'");
            foreach (DataRow row in lecon)
            {
                string titreLecon = row.Field<string>("titreLecon");
                cbxAdminLecon.Items.Add(titreLecon);
            }
        }

        private void cbxAdminLecon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow InfosCours = Babbel.Tables["Cours"].Select($"titreCours = '{cbxAdminCours.SelectedItem}'")[0];
            DataRow InfosLecon = Babbel.Tables["Lecons"].Select($"titreLecon = '{cbxAdminLecon.SelectedItem}'")[0];
            DataRow exo = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0]}' AND numLecon = '{InfosLecon.ItemArray[0]}'")[0];
            DataRow phrase = Babbel.Tables["Phrases"].Select($"codePhrase = '{exo.ItemArray[5]}'")[0];


            lblAdminConsigne.Visible = true;
            lblAdminConsigne.Text = exo.ItemArray[3].ToString();
            lblAdminPhrase.Visible = true;
            lblAdminPhrase.Text = phrase.ItemArray[1].ToString();



        }

        int hauteur = 0;
        int largeur = 0;
        // ptbAccueilDrapeauNoirBlanc
        // 
        private void changeDrapeau()
        { 
            int exoTerm = TableVerifExo.Select("finish = true").Length;
            hauteur +=195;
            string utilisateur = cbxAcceuilUtilisateur.SelectedItem.ToString();
            string prenom = utilisateur.Split(' ')[0];
            DataRow InfosUtilisateur = Babbel.Tables["Utilisateurs"].Select($"pnUtil = '{prenom}'")[0];
            string codeCourActuel = InfosUtilisateur.ItemArray[6].ToString();
            DataRow InfosCours = Babbel.Tables["Cours"].Select($"numCours = '{codeCourActuel}'")[0];
            DataRow InfosLecons = Babbel.Tables["Lecons"].Select($"numCours = '{codeCourActuel}'")[0];
            int NbExo = Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0]}'").Length;
            if (NbExo == 9)
            {
                largeur = exoTerm * (132 / NbExo);
            }
            else
            {
                largeur = exoTerm * (140 / NbExo);
            }
            Image nomImage = ptbAccueilDrapeauCouleur.Image;
            ptbAccueilDrapeauCouleur.Size = new Size(hauteur, largeur);
            ptbAccueilDrapeauCouleur.Visible = true;
            
            
        }
    }
}
