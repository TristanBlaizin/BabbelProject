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
        DataRow InfosExo;
        public ExoDesordre()
        {
            InitializeComponent();
        }

        public ExoDesordre(DataRow InfosExo)
        {
            InitializeComponent();
            this.InfosExo = InfosExo;
        }
        private void ExoDesordre_Load(object sender, EventArgs e)
        {

        }
    }
}
