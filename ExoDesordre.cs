using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BabbelProject
{
    public partial class ExoDesordre : Form
    {
        public DataRow InfosExo;
        public DataSet Babbel;
        public DataTable TableVerifExo;
        public string utilisateur;

        public string phraseJuste;
        public string correction;
        public List<string> phraseEnConstruction = new List<string>();
        int tmpPositionXSolution = 10;
        int tmpPositionYSolution = 25;
        public void InitPhrase()
        {
            Random rnd = new Random();

            string[] tblphrase = phraseJuste.Split(' ').OrderBy(word => rnd.Next()).ToArray();
            int x =  30;
            int y =  45;



            for (int i = 0; i < tblphrase.Length; i++)
            {

                Label lbl = new Label();
                grpContainer.Controls.Add(lbl);
                lbl.Name = $"lbl_{i}";
                lbl.Text = tblphrase[i];
                lbl.Location = new Point(x, y);
                lbl.Visible = true;
                lbl.AutoSize = true;
                lbl.BorderStyle = BorderStyle.Fixed3D;
                lbl.Font = new Font("Georgia", 11);
                lbl.Click += new System.EventHandler(ClickLbl);
                x += lbl.Width + 10;
                if (x > (grpContainer.Location.X + grpContainer.Size.Width))
                {
                    x = grpContainer.Location.X;
                    y += 30;
                }
            }
        }

        public void InitLabelSolution(int nbrLbl, string[] phrase)
        {
            for(int i = 0; i < nbrLbl; i++)
            {
                Label lblSolution = new Label();
                grpSolution.Controls.Add(lblSolution);
                lblSolution.Name = $"lbl_{i}";
                lblSolution.Text = phrase[i];
                lblSolution.AutoSize = false;
                lblSolution.Size = new Size(75,15);
                lblSolution.Visible = true;
                lblSolution.Font = new Font("Georgia", 12);
                lblSolution.Location = new Point(tmpPositionXSolution, tmpPositionYSolution);
                lblSolution.Font = new Font(lblSolution.Font,FontStyle.Bold);
                lblSolution.Click += new System.EventHandler(lblSolution_Click);
                tmpPositionXSolution += 75;
                if(tmpPositionXSolution > grpSolution.Width - 30)
                {
                    tmpPositionXSolution = 10;
                    tmpPositionYSolution += 15;
                }
            }

            foreach(Control label in grpSolution.Controls)
            {
                label.Text = string.Empty;
            }
            
        }

        public void ModifPhraseConstruction()
        {
            phraseEnConstruction.Clear();
            correction = string.Empty;
            foreach(Control label in grpSolution.Controls)
            {
                phraseEnConstruction.Add(label.Text);
            }
            int i = 0;
            foreach (string word in phraseEnConstruction)
            {
                if (phraseEnConstruction[i].Contains('.') || phraseEnConstruction[i].Contains('?') || phraseEnConstruction[i].Contains('!'))
                {
                    correction += phraseEnConstruction[i];
                }
                else
                {
                    correction += phraseEnConstruction[i] + " ";
                }
                i++;
            }
        }
        public ExoDesordre()
        {
            InitializeComponent();
        }

        public ExoDesordre(DataRow InfosExo, DataSet BDD, string utilisateur, DataTable TableVerifExo)
        {
            InitializeComponent();
            this.InfosExo = InfosExo;
            this.Babbel = BDD;
            this.utilisateur = utilisateur;
            this.TableVerifExo = TableVerifExo;
        }

        private void ExoDesordre_Load(object sender, EventArgs e)
        {
            lblDesordreConsigne.Text = InfosExo.ItemArray[3].ToString();
            int codePhrase = (int)InfosExo.ItemArray[5];
            phraseJuste = Babbel.Tables["Phrases"].Select($"codePhrase = {codePhrase}")[0].ItemArray[1].ToString();
            label1.Text = phraseJuste;
            InitPhrase();
            InitLabelSolution(phraseJuste.Split(' ').Length, phraseJuste.Split(' '));
            lblDesordreEtatExo.Text = "Cet exercice est en cours.";
            lblDesordreEtatExo.Font = new Font(lblDesordreEtatExo.Font, FontStyle.Bold);
            lblTraduc.Text = Babbel.Tables["Phrases"].Select($"codePhrase = {codePhrase}")[0].ItemArray[2].ToString();
        
        }

        private void ClickLbl(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            bool enCoursDeplacement = true;
            int j = 0;
           
            while(j < grpSolution.Controls.Count && enCoursDeplacement)
            {
                Label lblSoluce = (Label)grpSolution.Controls[j];
                if (string.IsNullOrEmpty(lblSoluce.Text))
                {
                    enCoursDeplacement = false;
                    grpSolution.Controls[j].Text = lbl.Text;
                   
                }
                j++;
            
            }
            
            ModifPhraseConstruction();
           
            lbl.Visible = false;
            lbl.Enabled = false;

        }

        private void lblSolution_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            foreach (Control label in grpContainer.Controls)
            {
                if (label.Text == lbl.Text)
                {
                    label.Visible = true;
                    label.Enabled = true;
                    lbl.Text = string.Empty;
                }
            }
            ModifPhraseConstruction();
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {

            foreach (Control label in grpContainer.Controls)
            {
                Label lbl = (Label)label;
                lbl.Visible = true;
                lbl.Enabled = false;
            }
            foreach (Control label in grpSolution.Controls)
            {
                Label lbl = (Label)label;
                lbl.Visible = false;
                lbl.Enabled = false;
            }
            Label lblRep = new Label();
            grpSolution.Controls.Add(lblRep);
            lblRep.Text = phraseJuste;
            lblRep.AutoSize = true;
            lblRep.Visible = true;
            lblRep.Font = new Font("Georgia", 14);
            lblRep.Location = new Point(45, 45);
            lblRep.Name = "lblReponse";
            lblRep.ForeColor = Color.FromArgb(255, 175, 64);
            lblDesordreEtatExo.Text = "Cet exercice est Raté.";
            lblDesordreEtatExo.Font = new Font(lblDesordreEtatExo.Font, FontStyle.Bold);
            lblDesordreEtatExo.ForeColor = Color.FromArgb(255, 77, 77); 
            btnDesordreValider.Enabled = false;

        }

        private void btnSolution_MouseHover(object sender, EventArgs e)
        {

            ToolTip messageAttention = new ToolTip();
            messageAttention.AutoPopDelay = 10000;
            messageAttention.SetToolTip(btnSolution, "Attention : si vous appuyez, l'exercice sera à recommencer.");
            
        }

        private void btnDesordreSuivant_Click(object sender, EventArgs e)
        {
            btnValider_Click(sender, e);
      
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

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (correction == phraseJuste)
            {
                lblDesordreEtatExo.Text = "Cet exercice est Validé !";
                lblDesordreEtatExo.ForeColor = Color.FromArgb(50, 255, 126);
                lblDesordreEtatExo.Font = new Font(lblDesordreEtatExo.Font, FontStyle.Bold);
                foreach (Control label in grpSolution.Controls)
                {
                    Label lbl = (Label)label;
                    lbl.Visible = false;
                    lbl.Enabled = false;
                    Label lblRep = new Label();
                    grpSolution.Controls.Add(lblRep);
                    lblRep.Text = phraseJuste;
                    lblRep.AutoSize = true;
                    lblRep.Visible = true;
                    lblRep.Font = new Font("Georgia", 14);
                    lblRep.Location = new Point(45, 45);
                    lblRep.Name = "lblReponse";
                    lblRep.ForeColor = Color.FromArgb(50, 255, 126);
                }
            }
            else
            {
                lblDesordreEtatExo.Text = "Cet exercice est Raté.";
                lblDesordreEtatExo.Font = new Font(lblDesordreEtatExo.Font, FontStyle.Bold);
                lblDesordreEtatExo.ForeColor = Color.FromArgb(255, 77, 77);
                btnDesordreValider.Enabled = false;
                btnSolution.Enabled = false;
                foreach (Control label in grpContainer.Controls)
                {
                    Label lbl = (Label)label;
                    lbl.Visible = false;
                    lbl.Enabled = false;

                }
                foreach (Control label in grpSolution.Controls)
                {
                    Label lbl = (Label)label;
                    lbl.Visible = false;
                    lbl.Enabled = false;
                    lbl.ForeColor = Color.FromArgb(255, 77, 77);
                }
                Label lblRep = new Label();
                grpSolution.Controls.Add(lblRep);
                lblRep.Text = phraseJuste;
                lblRep.AutoSize = true;
                lblRep.Visible = true;
                lblRep.Font = new Font("Georgia", 14);
                lblRep.Location = new Point(45, 45);
                lblRep.Name = "lblReponse";
                lblRep.Font = new Font(lblRep.Font, FontStyle.Bold);
                lblRep.ForeColor = Color.FromArgb(255, 77, 77);
            }
        }
    }
}
