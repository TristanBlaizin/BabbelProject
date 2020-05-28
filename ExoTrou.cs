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

        }
    }
}
