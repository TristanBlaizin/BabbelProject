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
        public List<string> phraseEnConstruction = new List<string>();
        int tmpPositionXSolution = 20;
        int tmpPositionySolution = 20;
        public void InitPhrase()
        {
            Random rnd = new Random();
<<<<<<< HEAD
            string[] tblphrase = phrase.Split(' ').OrderBy(word => rnd.Next()).ToArray();
            int x = grpContainer.Location.X + 10;
            int y = (grpContainer.Location.Y - grpContainer.Size.Height) + 30;
=======
            string[] tblphrase = phraseJuste.Split(' ').OrderBy(word => rnd.Next()).ToArray();
            int x = 30;
            int y = 30;
>>>>>>> 2caa05effbf5e3936b5cf41b87da21b063c7e1b1
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
            label2.Text = phraseJuste;
        }

        private void ClickLbl(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            
            phraseEnConstruction.Add(lbl.Text);
            string correction = string.Empty;
            int i = 0;
            foreach(string word in phraseEnConstruction)
            {
                if(phraseEnConstruction[i].Contains('.'))
                {
                    correction += phraseEnConstruction[i];
                }
                else
                {
                    correction += phraseEnConstruction[i] + " ";
                }
                i++;
            }
            label1.Text = correction;
            Label lblSolution = new Label();
            grpSolution.Controls.Add(lblSolution);
            lblSolution.Name = $"lbl_{lbl.Text}";
            lblSolution.Text = lbl.Text;
            lblSolution.AutoSize = true;
            lblSolution.Visible = true;
            lblSolution.Location = new Point(tmpPositionXSolution, tmpPositionySolution);
            lblSolution.Click += new System.EventHandler(lblSolution_Click);
            tmpPositionXSolution += lbl.Width;
            lblSolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lbl.Visible = false;
            lbl.Enabled = false;


            if (label1.Text == phraseJuste)
            {
                MessageBox.Show("GG");
            }
        }

        private void lblSolution_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

        }
    }
}
