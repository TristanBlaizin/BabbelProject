using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabbelProject
{
    public partial class ExoDesordre : Form
    {
        public DataRow InfosExo;
        public DataSet Babbel;
        public string phraseJuste;
        public string correction;
        public List<string> phraseEnConstruction = new List<string>();
        int tmpPositionXSolution = 20;
        int tmpPositionySolution = 20;
        public void InitPhrase()
        {
            Random rnd = new Random();

            string[] tblphrase = phraseJuste.Split(' ').OrderBy(word => rnd.Next()).ToArray();
            int x =  30;
            int y =  30;



            for (int i = 0; i < tblphrase.Length; i++)
            {

                Label lbl = new Label();
                grpContainer.Controls.Add(lbl);
                lbl.Name = $"lbl_{i}";
                lbl.Text = tblphrase[i];
                lbl.Location = new Point(x, y);
                lbl.Visible = true;
                lbl.AutoSize = true;
                lbl.Click += new System.EventHandler(ClickLbl);
                x += 100;
                if (x > (grpContainer.Location.X + grpContainer.Size.Width))
                {
                    x = grpContainer.Location.X + 30;
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
                lblSolution.Size = new Size(50,15);
                lblSolution.Visible = true;
                lblSolution.Location = new Point(tmpPositionXSolution, tmpPositionySolution);
                lblSolution.Click += new System.EventHandler(lblSolution_Click);
                tmpPositionXSolution += lblSolution.Width;
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
                if (phraseEnConstruction[i].Contains('.'))
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

        public ExoDesordre(DataRow InfosExo, DataSet BDD)
        {
            InitializeComponent();
            this.InfosExo = InfosExo;
            this.Babbel = BDD;
        }
        private void ExoDesordre_Load(object sender, EventArgs e)
        {
            lblRegle.Text = InfosExo.ItemArray[3].ToString();
            int codePhrase = (int)InfosExo.ItemArray[5];
            phraseJuste = Babbel.Tables["Phrases"].Select($"codePhrase = {codePhrase}")[0].ItemArray[1].ToString();
            InitPhrase();
            InitLabelSolution(phraseJuste.Split(' ').Length, phraseJuste.Split(' '));
<<<<<<< HEAD
=======
            label2.Text = phraseJuste;
>>>>>>> 537f684e76b23dea031d4a779ccce618533aca5a
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


            if (correction == phraseJuste)
            {
                MessageBox.Show("GG");
            }
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
            lblSolution.Text = phraseJuste;
            lblNonValide.Visible = true;
            foreach(Control label in grpContainer.Controls)
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

        }
    }
}
