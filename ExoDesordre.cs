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
            int codePhrase = (int)InfosExo.ItemArray[5];
            lblRegle.Text = InfosExo.ItemArray[3].ToString();
            
            string[] phrase = Babbel.Tables["Phrases"].Select($"codePhrase = {codePhrase}")[0].ItemArray[1].ToString().Split(' ');
            int y = 10;
            for(int i = 0; i <= phrase.Length; i++)
            {
                
                Label lbl = new Label();
                lbl.Name = $"lbl_{i}";
                lbl.Text = phrase[i];
                lbl.Location = new Point(100, y);
                lbl.Visible = true;
                y++;
            }
        }
    }
}
