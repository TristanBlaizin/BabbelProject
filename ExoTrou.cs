using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BabbelProject
{
    public partial class ExoTrou : Form
    {

        public DataRow InfosExo;
        public DataSet Babbel;
        public string utilisateur;
        public ExoTrou()
        {
            InitializeComponent();
        }

        public ExoTrou(DataRow InfosExo, DataSet BDD, string utilisateur)
        {
            InitializeComponent();
            this.InfosExo = InfosExo;
            this.Babbel = BDD;
            this.utilisateur = utilisateur;
        }
        private void ExoTrou_Load(object sender, EventArgs e)
        {
            string str = string.Empty;
            foreach (Object item in InfosExo.ItemArray)
            {
                str += item.ToString() + " ";
            }

            lblTrouConsigne.Text = InfosExo.ItemArray[3].ToString();
            DataRow phraseComplete = Babbel.Tables["Phrases"].Select($"codePhrase = '{InfosExo.ItemArray[5]}'")[0];
            DataRow motsPerdu = Babbel.Tables["Exercices"].Select($"listeMots = '{InfosExo.ItemArray[7]}'")[0];
            string traduction = phraseComplete.ItemArray[1].ToString();
            string reponse = phraseComplete.ItemArray[2].ToString();
            string[] tabMot = phraseComplete.ItemArray[1].ToString().Split(' ') ;
            string[] tabMotPerdu = motsPerdu.ItemArray[7].ToString().Split('/');
            string[] tabMotsPhraseATrou = new string[tabMot.Length];
            int positionHorizon = 24;
            int positionVetical = 0;
            bool placementtxt = false;
            for (int i = 0; i < tabMot.Length; ++i)
            {
                foreach(string str1 in tabMotPerdu)
                {
                    if(i == int.Parse(str1)-1 && !placementtxt)
                    {
                        placementtxt = true;
                        positionVetical = 53;
                        TextBox txt = new TextBox();
                        grbTrou.Controls.Add(txt);
                        txt.Visible = true;
                        txt.Left = positionHorizon;
                        txt.Top = positionVetical;
                        positionHorizon += txt.Width + 5;
                        txt.Font = new Font("Georgia", 14);
                        txt.Name = $"txt_{i}";
                    }
                    else if(!placementtxt)
                    {
                        placementtxt = true;
                        positionVetical = 55;
                        Label lbl = new Label();
                        grbTrou.Controls.Add(lbl);
                        lbl.AutoSize = true;
                        lbl.Visible = true;
                        lbl.Left = positionHorizon;
                        lbl.Top = positionVetical;
                        lbl.Text += tabMot[i] + " ";
                        lbl.Font = new Font("Georgia", 14);
                        lbl.ForeColor = Color.FromArgb(247, 215, 148);
                        lbl.Name = $"lbl_{i}";
                        positionHorizon += lbl.Width;
                    }
                }
                placementtxt = false;        
            }
            
            lblTraduc.Text = reponse;
            foreach (Control c in grbTrou.Controls)
            {
                if ( c is TextBox)
                {
                    this.TextChanged += new EventHandler(txtVerification_TextChanged);
                }
            }
          
        }
        public void txtVerification_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            DataRow motsPerdu = Babbel.Tables["Exercices"].Select($"listeMots = '{InfosExo.ItemArray[7]}'")[0];
            DataRow phraseComplete = Babbel.Tables["Phrases"].Select($"codePhrase = '{InfosExo.ItemArray[5]}'")[0];
            string[] tabMotPerdu = motsPerdu.ItemArray[7].ToString().Split('/');
            string[] tabMot = phraseComplete.ItemArray[1].ToString().Split(' ');
            foreach (Control c in grbTrou.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = tabMot[Int64.Parse(tabMotPerdu[0]) - 1];
                    c.Enabled = false;
                    c.BackColor = Color.FromArgb(255, 175, 64);
                }
            }
            btnTrouValider.Enabled = false;
            btnTrouValider.Visible = false;

        }

        private void btnTrouSuivant_Click(object sender, EventArgs e)
        {
            btnVAlider_Click(sender, e);
            try
            {
                DataRow[] InfosExoSuivant = Babbel.Tables["Exercices"].Select($"numCours = '{InfosExo.ItemArray[1].ToString()}' AND numLecon = '{InfosExo.ItemArray[2].ToString()}' AND numExo = {(int)(InfosExo.ItemArray[0]) + 1}");
                if (InfosExoSuivant.Length != 0)
                {
                    if ((int)(InfosExoSuivant[0].ItemArray[5]) == 0)
                    {
                        LeconVocabulaire LeconVocabulaire = new LeconVocabulaire(InfosExoSuivant[0], Babbel, utilisateur);
                        LeconVocabulaire.Show();

                    }
                    else if ((bool)(InfosExoSuivant[0].ItemArray[6]))
                    {
                        ExoDesordre ExoDesordre = new ExoDesordre(InfosExoSuivant[0], Babbel, utilisateur, TableVerifExo);
                        ExoDesordre.Show();
                    }
                    else
                    {
                        ExoTrou ExoATrou = new ExoTrou(InfosExoSuivant[0], Babbel, utilisateur);
                        ExoATrou.Show();
                    }
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnVAlider_Click(object sender, EventArgs e)
        {
            DataRow motsPerdu = Babbel.Tables["Exercices"].Select($"listeMots = '{InfosExo.ItemArray[7]}'")[0];
            DataRow phraseComplete = Babbel.Tables["Phrases"].Select($"codePhrase = '{InfosExo.ItemArray[5]}'")[0];
            string[] tabMotPerdu = motsPerdu.ItemArray[7].ToString().Split('/');
            string[] tabMot = phraseComplete.ItemArray[1].ToString().Split(' ');
            int nbMotsPerdu = tabMotPerdu.Length;
            Dictionary<String, bool> reponseJuste = new Dictionary<string, bool>();
            foreach (Control c in grbTrou.Controls)
            {
                if (c is TextBox)
                {
                    string reponse = c.Text;

                    if (reponse == tabMot[Int64.Parse(tabMotPerdu[0]) - 1])
                    {
                        c.BackColor = Color.FromArgb(50, 255, 126);
                    }
                    else
                    {
                        c.BackColor = Color.FromArgb(255, 77, 77);
                    }
                }
            }
        }
    }
}
