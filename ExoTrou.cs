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
    public partial class ExoTrou : Form
    {

        public DataRow InfosExo;
        public DataSet Babbel;
        public ExoTrou()
        {
            InitializeComponent();
        }

        public ExoTrou(DataRow InfosExo, DataSet BDD)
        {
            InitializeComponent();
            this.InfosExo = InfosExo;
            this.Babbel = BDD;
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
            label1.Text = phraseComplete.ItemArray[1].ToString();
            string[] tabMot = phraseComplete.ItemArray[1].ToString().Split(' ') ;
            string[] tabMotPerdu = motsPerdu.ItemArray[7].ToString().Split('/');
            string[] tabMotsPhraseATrou = new string[tabMot.Length];

            for (int i = 0; i < tabMot.Length; ++i)
            {
                for (int y = 0;y < tabMotPerdu.Length; y++)
                {
                    if ( i == Int64.Parse(tabMotPerdu[y])-1)
                    {

                    }
                    else {
                        label2.Text += tabMot[i] +" ";

                    }
                }
            }
          
        }
    }
}
