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
        public string phrase;
        public void InitPhrase()
        {
            Random rnd = new Random();
            string[] tblphrase = phrase.Split(' ').OrderBy(word => rnd.Next()).ToArray();
            int x = grpContainer.Location.X + 10;
            int y = (grpContainer.Location.Y - grpContainer.Size.Height) + 30;
            for (int i = 0; i < tblphrase.Length; i++)
            {

                Label lbl = new Label();
                grpContainer.Controls.Add(lbl);
                lbl.Name = $"lbl_{i}";
                lbl.Text = tblphrase[i];
                lbl.Location = new Point(x, y);
                lbl.Visible = true;
                lbl.AutoSize = true;
                x += 100;
                if (x > (grpContainer.Location.X + grpContainer.Size.Width))
                {
                    x = grpContainer.Location.X + 10;
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
            phrase = Babbel.Tables["Phrases"].Select($"codePhrase = {codePhrase}")[0].ItemArray[1].ToString();
            InitPhrase();
        }
    }
}
