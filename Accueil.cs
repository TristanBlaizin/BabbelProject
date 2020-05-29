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

        public bool firstLoad = true;

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
            lblTitleCours.Visible = true;
            lblTitleLesson.Visible = true;
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

       

        
        private void Form1_Load(object sender, EventArgs e)
        {
            ch_connect = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\..\baseLangue.mdb";
           
            connec = new OleDbConnection();
            connec.ConnectionString = ch_connect;
            InitDeconnecte();

            DataRowCollection rowArray = Babbel.Tables["Utilisateurs"].Rows;
            foreach(DataRow row in rowArray)
            {
                string prenom = row.ItemArray[2].ToString();
                string nom = row.ItemArray[1].ToString();
                cbxUtilisateur.Items.Add($"{prenom} {nom}");
            }        
        }

        private void CbxUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (firstLoad)
            {
                firstLoad = false;
                ChangeFirstLoad();
            }
            string utilisateur = cbxUtilisateur.SelectedItem.ToString();
            string prenom = utilisateur.Split(' ')[0];
            DataRow InfosUtilisateur = Babbel.Tables["Utilisateurs"].Select($"pnUtil = '{prenom}'")[0];
            string codeCourActuel = InfosUtilisateur.ItemArray[6].ToString();
            DataRow InfosCours = Babbel.Tables["Cours"].Select($"numCours = '{codeCourActuel}'")[0];
            DataRow InfosLecons = Babbel.Tables["Lecons"].Select($"numCours = '{codeCourActuel}'")[0];
            int NbExo = Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0]}'").Length;
            lblCours.Text = InfosCours.ItemArray[1].ToString();
            lblLesson.Text = InfosLecons.ItemArray[2].ToString();
            lblCommentLesson.Text = InfosLecons.ItemArray[3].ToString();
            lblExo.Text = $"Exercices terminés: 0/{NbExo.ToString()}";
            pictureBox2.Visible = true;

        }

        private void BtnExo_Click(object sender, EventArgs e)
        {
            string utilisateur = cbxUtilisateur.SelectedItem.ToString();
            string prenom = utilisateur.Split(' ')[0];
            DataRow InfosUtilisateur = Babbel.Tables["Utilisateurs"].Select($"pnUtil = '{prenom}'")[0];
            string codeCourActuel = InfosUtilisateur.ItemArray[6].ToString();
            DataRow InfosLecons = Babbel.Tables["Lecons"].Select($"numCours = '{codeCourActuel}'")[0];
            DataRow[] InfosExo = Babbel.Tables["Exercices"].Select($"numCours = '{codeCourActuel}' AND numLecon = '{InfosLecons.ItemArray[0].ToString()}'");
            string str = string.Empty;
            string str2 = string.Empty;
            if ((int)(InfosExo[0].ItemArray[5]) == 0)
            {
                LeconVocabulaire LeconVocabulaire = new LeconVocabulaire(InfosExo[0], Babbel);
                LeconVocabulaire.ShowDialog();

            }
            else if ((bool)(InfosExo[0].ItemArray[6]))
            {
                ExoDesordre ExoDesordre = new ExoDesordre(InfosExo[0], Babbel);
                ExoDesordre.ShowDialog();
            }
            else
            {
                ExoTrou ExoATrou = new ExoTrou(InfosExo[0], Babbel);
                ExoATrou.ShowDialog();
            }


        }

        private void cbxUtilisateur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //int largeur= 0;
        //int hauteur = 0; 
        /*private void testdrap_Click(object sender, EventArgs e)
        {
            int exoTerm = 8; //Modifier la source après  que un exo soit fini 
            hauteur +=195;
            Image nomImage = pictureBox1.Image;
            pictureBox1.Size = new Size(hauteur, largeur);
            pictureBox1.Visible = true;
            string utilisateur = cbxUtilisateur.SelectedItem.ToString();
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
        }*/
    }
}
