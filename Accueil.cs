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
        public DataRow InfosCours;
        public DataRow InfosLecons;
        public DataRow InfosUtilisateur;
        public DataRow[] InfosExo;
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
            TableVerifExo.Columns.Add(new DataColumn("finish", typeof(int)));
        }
        public void changeTableVerif(DataRow utilisateur, DataRow[] exos)
        {
            int i = 0;
            TableVerifExo.Rows.Clear();
            foreach (DataRow row in exos)
            {
                DataRow[] drs = Babbel.Tables["ConcerneMots"].Select($"numCours = '{InfosCours.ItemArray[0].ToString()}' AND numLecon = {InfosLecons.ItemArray[0]} AND numExo = {exos[i].ItemArray[0]}");
                if (drs.Length != 0)
                    TableVerifExo.Rows.Add(row.ItemArray[0], 2);
                else if (i < (int)utilisateur.ItemArray[4])
                    TableVerifExo.Rows.Add(row.ItemArray[0], 1);
                else
                    TableVerifExo.Rows.Add(row.ItemArray[0], 0);
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
            admin.Add("Véronique Richard");
            admin.Add("Murielle Torregrossa");

            gpbAcceuil.Text = "";

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
            InfosUtilisateur = Babbel.Tables["Utilisateurs"].Select($"pnUtil = '{prenom}'")[0];

            string codeCourActuel = InfosUtilisateur.ItemArray[6].ToString();

            InfosCours = Babbel.Tables["Cours"].Select($"numCours = '{codeCourActuel}'")[0];
            InfosLecons = Babbel.Tables["Lecons"].Select($"numCours = '{codeCourActuel}'")[0];
            InfosExo = Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = {InfosLecons.ItemArray[0]}");

            int NbExo = Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0]}'").Length;
            lblAccueilCours2.Text = InfosCours.ItemArray[1].ToString();
            lblAccueilLecon2.Text = InfosLecons.ItemArray[2].ToString();
            lblAccueilComentLecon.Text = InfosLecons.ItemArray[3].ToString();
            lblAccueilExo.Text = $"Exercices terminés: {InfosUtilisateur.ItemArray[4]}/{NbExo.ToString()}";
            ptbAccueilDrapeauNoirBlanc.Visible = true;

            changeTableVerif(InfosUtilisateur, Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0]}'"));
            changeDrapeau();

            for (int i = 0; i < admin.Count; i++)
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
            lblAcceuilIdentification.Visible = false;
            cbxAcceuilUtilisateur.Visible = false;
            lblAccueilBienvenue.Text = "Bienvenue " + cbxAcceuilUtilisateur.SelectedItem.ToString();
            lblAccueilBienvenue.Visible = true;
            btnAccueilDeconnexion.Visible = true;

            lblPresentation1.Visible = false;
            lblPresentation2.Visible = false;
            lblPresentation3.Visible = false;
            lblPresentation4.Visible = false;
            lblPresentation5.Visible = false;
            lblAcceuilCoursActuelle.Visible = true;
            lblAcceuilLecon.Visible = true;
            btnExo.Visible = true;
            lblAccueilExo.Visible = true;
            lblAccueilCours2.Visible = true;
            lblAccueilLecon2.Visible = true;
        }

        private void BtnExo_Click(object sender, EventArgs e)
        {
            bool firstfalse = false;
            int i = 0;
            int numeroExo = 0;
            string utilisateur = cbxAcceuilUtilisateur.SelectedItem.ToString();

            DataRow currentExo = null;

            while (!firstfalse && i < TableVerifExo.Rows.Count)
            {
                if ((int)TableVerifExo.Rows[i].ItemArray[1] == 0 || (int)TableVerifExo.Rows[i].ItemArray[1] == 2)
                {
                    numeroExo = (int)TableVerifExo.Rows[i].ItemArray[0];
                    firstfalse = true;
                }
                i++;
            }
            if (numeroExo > 0)
            {
                currentExo = InfosExo[numeroExo - 1];

            }

            if (i == TableVerifExo.Rows.Count)
            {
                currentExo = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0].ToString()}' AND numLecon = '{(int)InfosLecons.ItemArray[0] + 1}'")[0];
                numeroExo = (int)currentExo.ItemArray[0];
            }


            if ((int)(currentExo.ItemArray[5]) == 0)
            {
                LeconVocabulaire LeconVocabulaire = new LeconVocabulaire(currentExo, Babbel, utilisateur, TableVerifExo);
                LeconVocabulaire.ShowDialog();

            }
            else if ((bool)(currentExo.ItemArray[6]))
            {
                ExoDesordre ExoDesordre = new ExoDesordre(currentExo, Babbel, utilisateur, TableVerifExo);
                ExoDesordre.ShowDialog();
            }
            else
            {
                ExoTrou ExoATrou = new ExoTrou(currentExo, Babbel, utilisateur, TableVerifExo);
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
            DataRowCollection rowArray = Babbel.Tables["Cours"].Rows;
            foreach (DataRow row in rowArray)
            {
                string titreCours = row.ItemArray[1].ToString();
                cbxAdminCours.Items.Add(titreCours);
            }

            lblAdminCours.Visible = true;
            cbxAdminCours.Visible = true;
            btnAccueilDeconnexion.Visible = false;
            lblAccueilBienvenue.Visible = false;

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

        int compteurExo = 0;
        int numCurrentExo = 0;
        int nbExo = 0;
        int nbVoc = 0;
        private void cbxAdminLecon_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbExo = 0;
            nbVoc = 0;
            compteurExo = 0;
            numCurrentExo = 1;

            DataRow InfosCours = Babbel.Tables["Cours"].Select($"titreCours = '{cbxAdminCours.SelectedItem}'")[0];
            DataRow InfosLecon = Babbel.Tables["Lecons"].Select($"titreLecon = '{cbxAdminLecon.SelectedItem}'")[0];
            DataRow exo = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0]}' AND numLecon = '{InfosLecon.ItemArray[0]}'")[0];
            DataRow[] phrase = Babbel.Tables["Phrases"].Select($"codePhrase = '{exo.ItemArray[5]}'");
            DataRow[] InfosExoSuivant = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0]}' AND numLecon = '{InfosLecon.ItemArray[0]}' AND numExo = {(int)(exo.ItemArray[0]) + compteurExo}");

            foreach (Object item in exo.ItemArray)
            {
                if ((int)(exo.ItemArray[5]) == 0)
                {
                    nbVoc += 1;
                }
                else
                {
                    nbExo += 1;
                }
            }
            lblAdminNbExo.Text = numCurrentExo + "/" + nbExo;
            lblAdminNbExo.Visible = true;

            btnAdminSuivant.Visible = true;
            btnAdminFin.Visible = true;

            try
            {
                if (InfosExoSuivant.Length != 0)
                {
                    if((int)(InfosExoSuivant[0].ItemArray[5]) == 0)
                    {
                        passerAuSuivant();
                    }
                    else if((bool)(InfosExoSuivant[0].ItemArray[6]))
                    {
                        lblAdminConsigne.Visible = true;
                        lblAdminConsigne.Text = InfosExoSuivant[0].ItemArray[3].ToString();
                        lblAdminPhrase.Visible = true;
                        lblAdminPhrase.Text = phrase[0].ItemArray[1].ToString();
                        lblAdminNbExo.Text = numCurrentExo + "/" + nbExo;
                        if (numCurrentExo == nbExo)
                        {
                            btnAdminSuivant.Visible = false;
                            btnAdminFin.Visible = false;
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void changeDrapeau()
        {
            ptbAccueilDrapeauNoirBlanc.Visible = false;
            int nbExoTotaux = TableVerifExo.Rows.Count;
            int nbExoFait = TableVerifExo.Select("finish = 1").Length;
            int hauteur = ptbAccueilDrapeauNoirBlanc.Height;
            int largeur = (ptbAccueilDrapeauNoirBlanc.Width / nbExoTotaux) * nbExoFait;
            ptbAccueilDrapeauCouleur.Size = new Size(largeur,hauteur);
            ptbAccueilDrapeauCouleur.Visible = true;
                 
        }

        private void btnAdminSuivant_Click(object sender, EventArgs e)
        {
           
            passerAuSuivant();
            btnAdminDebut.Visible = true;
            btnAdminPrecedent.Visible = true;
        }


        public void passerAuSuivant()
        {
            compteurExo += 1;
            numCurrentExo += 1;

            DataRow InfosCours = Babbel.Tables["Cours"].Select($"titreCours = '{cbxAdminCours.SelectedItem}'")[0];
            DataRow InfosLecon = Babbel.Tables["Lecons"].Select($"titreLecon = '{cbxAdminLecon.SelectedItem}'")[0];
            DataRow exo = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0]}' AND numLecon = '{InfosLecon.ItemArray[0]}'")[0];
            DataRow[] InfosExoSuivant = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0]}' AND numLecon = '{InfosLecon.ItemArray[0]}' AND numExo = {(int)(exo.ItemArray[0]) + compteurExo}");
            DataRow[] phrase = Babbel.Tables["Phrases"].Select($"codePhrase = '{InfosExoSuivant[0].ItemArray[5]}'");

            try
            {
                if (InfosExoSuivant.Length != 0)
                {
                    if ((int)(InfosExoSuivant[0].ItemArray[5]) == 0)
                    {
                        numCurrentExo -= 1;
                        passerAuSuivant();

                    }
                    else if ((bool)(InfosExoSuivant[0].ItemArray[6]))
                    {
                        lblAdminConsigne.Visible = true;
                        lblAdminConsigne.Text = InfosExoSuivant[0].ItemArray[3].ToString();
                        lblAdminPhrase.Visible = true;
                        lblAdminPhrase.Text = phrase[0].ItemArray[1].ToString();
                        lblAdminNbExo.Text = numCurrentExo + "/" + nbExo;
                        if (numCurrentExo == nbExo)
                        {
                            btnAdminSuivant.Visible = false;
                            btnAdminFin.Visible = false;
                        }


                    }
                    else
                    {
                        lblAdminConsigne.Visible = true;
                        lblAdminConsigne.Text = InfosExoSuivant[0].ItemArray[3].ToString();
                        lblAdminPhrase.Visible = true;
                        lblAdminPhrase.Text = phrase[0].ItemArray[1].ToString();
                        lblAdminNbExo.Text = numCurrentExo + "/" + nbExo;
                        if (numCurrentExo == nbExo)
                        {
                            btnAdminSuivant.Visible = false;
                            btnAdminFin.Visible = false;

                        }

                    }
                    


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnAdminPrecedent_Click(object sender, EventArgs e)
        {

            revenirAuPrecedent();
        }
        public void revenirAuPrecedent()
        {
            compteurExo -= 1;
            numCurrentExo -= 1;
            DataRow InfosCours = Babbel.Tables["Cours"].Select($"titreCours = '{cbxAdminCours.SelectedItem}'")[0];
            DataRow InfosLecon = Babbel.Tables["Lecons"].Select($"titreLecon = '{cbxAdminLecon.SelectedItem}'")[0];
            DataRow exo = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0]}' AND numLecon = '{InfosLecon.ItemArray[0]}'")[0];
            DataRow[] InfosExoPrecedent = Babbel.Tables["Exercices"].Select($"numCours = '{InfosCours.ItemArray[0]}' AND numLecon = '{InfosLecon.ItemArray[0]}' AND numExo = {(int)(exo.ItemArray[0]) + compteurExo}");
            DataRow[] phrase = Babbel.Tables["Phrases"].Select($"codePhrase = '{InfosExoPrecedent[0].ItemArray[5]}'");

            try
            {
                if (InfosExoPrecedent.Length != 0)
                {
                    if (numCurrentExo == 1)
                    {
                        btnAdminPrecedent.Visible = false;
                        btnAdminDebut.Visible = false;
                    }
                    if ((int)(InfosExoPrecedent[0].ItemArray[5]) == 0)
                    {
                        numCurrentExo += 1;
                        revenirAuPrecedent();
                    }
                    else if ((bool)(InfosExoPrecedent[0].ItemArray[6]))
                    {
                        lblAdminConsigne.Visible = true;
                        lblAdminConsigne.Text = InfosExoPrecedent[0].ItemArray[3].ToString();
                        lblAdminPhrase.Visible = true;
                        lblAdminPhrase.Text = phrase[0].ItemArray[1].ToString();
                        lblAdminNbExo.Text = numCurrentExo + "/" + nbExo;


                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAccueilDeconnexion_Click(object sender, EventArgs e)
        {
            lblAcceuilIdentification.Visible = true;
            cbxAcceuilUtilisateur.Visible = true;
            lblAccueilBienvenue.Text = "Bienvenue " + cbxAcceuilUtilisateur.SelectedItem.ToString();
            lblAccueilBienvenue.Visible = false;
            btnAccueilDeconnexion.Visible = false;
            btnExo.Visible = false;
            lblAccueilExo.Visible = false;
            lblAcceuilLecon.Visible = false;
            lblAccueilCours2.Visible = false;
            lblAccueilLecon2.Visible = false;
            lblAcceuilCoursActuelle.Visible = false;
            lblPresentation1.Visible = true;
            lblPresentation2.Visible = true;
            lblPresentation3.Visible = true;
            lblPresentation4.Visible = true;
            lblPresentation5.Visible = true;
            btnAdmin.Visible = false;
            ptbAccueilDrapeauCouleur.Visible = false;

        }

        private void btnAdminAccueil_Click(object sender, EventArgs e)
        {
            gpbAcceuil.Text = "";
            lblAcceuilCoursActuelle.Visible = true;
            lblAcceuilLecon.Visible = true;
            ptbAccueilDrapeauCouleur.Visible = true;
            lblAccueilLecon2.Visible = true;
            lblAccueilComentLecon.Visible = true;
            lblAccueilCours2.Visible = true;
            lblAccueilExo.Visible = true;
            btnExo.Visible = true;
            btnAdmin.Visible = true;
            lblAdminLaCasaDeBabel.Visible = false;
            lblAcceuilLaCasaDeBabel.Visible = true;
            btnAdminAccueil.Visible = false;
            lblAdminConsigne.Visible = false;
            lblAdminCours.Visible = false;
            lblAdminLaCasaDeBabel.Visible = false;
            lblAdminLecon.Visible = false;
            lblAdminNbExo.Visible = false;
            lblAdminPhrase.Visible = false;
            btnAdminAccueil.Visible = false;
            btnAdminDebut.Visible = false;
            btnAdminPrecedent.Visible = false;
            btnAdminSuivant.Visible = false;
            btnAdminFin.Visible = false;
            cbxAdminCours.Visible = false;
            cbxAdminLecon.Visible = false;
            lblAccueilBienvenue.Visible = true;
            btnAccueilDeconnexion.Visible = true;
            cbxAdminCours.Items.Clear();
            
        }
    }
}
