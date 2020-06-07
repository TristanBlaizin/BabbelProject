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
    public partial class FormResultatLecon : Form
    {
        public DataTable TableVerifExo;
        public DataSet Babbel;
        public FormResultatLecon(DataTable dataTable, DataSet dataSet)
        {
            InitializeComponent();
            this.TableVerifExo = dataTable;
            this.Babbel = dataSet;
        }

        private void FormResultatLecon_Load(object sender, EventArgs e)
        {
            foreach(DataRow row in TableVerifExo.Rows)
            {
                if((int)row.ItemArray[1] == 1)
                {
                    lstValide.Items.Add("Exercice " + (int)row.ItemArray[0]);
                }
                else if ((int)row.ItemArray[1] == 0)
                {
                    lstNonValide.Items.Add("Exercice " + (int)row.ItemArray[0]);
                }
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            foreach (string str in lstNonValide.Items)
            {
                result += str.Split(' ')[1] + " ";
            }
            string[] listExoARefaire = result.Split(' ');
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
