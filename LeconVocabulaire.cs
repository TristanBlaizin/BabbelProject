using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabbelProject
{
    public partial class LeconVocabulaire : Form
    {
        public DataRow InfosExo;
        public DataSet Babbel;
        public DataTable TableVerifExo;
        public string utilisateur;
        public LeconVocabulaire()
        {
            InitializeComponent();
        }
        public LeconVocabulaire(DataRow InfosExo, DataSet BDD, string utilisateur, DataTable TableVerifExo)
        {
            InitializeComponent();
            this.InfosExo = InfosExo;
            this.Babbel = BDD;
            this.utilisateur = utilisateur;
            this.TableVerifExo = TableVerifExo;
        }

        private void LeconVocabulaire_Load(object sender, EventArgs e)
        {
            DataRow[] InfosConcerneMot = Babbel.Tables["ConcerneMots"].Select($"numCours = '{InfosExo.ItemArray[1]}' AND numLecon = '{InfosExo.ItemArray[2]}' AND numExo = '{InfosExo.ItemArray[0]}'");
            DataRow InfosMots;

            string str = string.Empty;
            int compteur = 0;
            int positionHorizonGenerale = 0;
            int hauteur = 280;
            int nbImage = 0;
            foreach (DataRow row in InfosConcerneMot)
            {
                nbImage++;
            }
            int largeur = 776 / nbImage;
            foreach (DataRow row in InfosConcerneMot)
            {
                foreach (Object item in row.ItemArray)
                {
                    str += item.ToString() + " ";
                }
                str += "\n";

                InfosMots = Babbel.Tables["Mots"].Select($"numMot = '{InfosConcerneMot[compteur].ItemArray[3]}'")[0];
                

                //Groupe box
                GroupBox grb = new GroupBox();
                pnl.Controls.Add(grb);
                grb.Left = positionHorizonGenerale;
                grb.Top = 0;
                grb.BackColor = Color.Transparent;
                grb.Size = new Size(largeur , hauteur) ;                 

                //Label mot espagnol
                Label lbl = new Label();
                grb.Controls.Add(lbl);
                lbl.Visible = true;
                lbl.AutoSize = false;
                lbl.Width = grb.Width;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Top = 10;
                lbl.Text += InfosMots.ItemArray[1].ToString();
                lbl.Font = new Font("Georgia", 12);
                lbl.ForeColor = Color.FromArgb(247, 215, 148);
                lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                lbl.Name = $"lbl_{compteur}";


                //Image 
                PictureBox pcb = new PictureBox();
                grb.Controls.Add(pcb);
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Visible = true;
                pcb.Left = 10;
                pcb.Top = lbl.Height + 15;
                pcb.Size = new Size(largeur-20,hauteur/2);
                if (!string.IsNullOrEmpty(InfosMots.ItemArray[3].ToString()))
                {
                    pcb.Image = Image.FromFile($"..\\..\\baseImages\\{InfosMots.ItemArray[3].ToString()}");
                }
                pcb.Name = $"pcb_{compteur}";

                //Label traduc
                Label lblTraduc = new Label();
                grb.Controls.Add(lblTraduc);
                lblTraduc.AutoSize = false;
                lblTraduc.Width = grb.Width;
                lblTraduc.TextAlign = ContentAlignment.MiddleCenter;
                lblTraduc.Top = lbl.Height + 15 + pcb.Height + 10;
                lblTraduc.Text += InfosMots.ItemArray[2].ToString();
                lblTraduc.Font = new Font("Georgia", 12);
                lblTraduc.ForeColor = Color.FromArgb(247, 215, 148);
                lblTraduc.Font = new Font(lbl.Font, FontStyle.Italic);
                lblTraduc.Name = $"lbl_{compteur}";

                //Label origine du mot
                Label lblOrigin = new Label();
                grb.Controls.Add(lblOrigin);
                lblOrigin.Visible = true;
                lblOrigin.AutoSize = false;
                lblOrigin.Width = grb.Width;
                lblOrigin.TextAlign = ContentAlignment.MiddleCenter;
                lblOrigin.Top = lbl.Height + 15 + pcb.Height + 10 + lblTraduc.Height + 45;
                lblOrigin.Text += InfosMots.ItemArray[4].ToString();
                lblOrigin.Font = new Font("Georgia", 12);
                lblOrigin.ForeColor = Color.FromArgb(247, 215, 148);
                lblOrigin.Name = $"lbl_{compteur}";

                //Groupe box
                grb.Name = $"grb_{compteur}";
                positionHorizonGenerale += grb.Width;



                compteur += 1;
            }

        }

        private void btnTrouTerminer_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] InfosExoSuivant = Babbel.Tables["Exercices"].Select($"numCours = '{InfosExo.ItemArray[1].ToString()}' AND numLecon = '{InfosExo.ItemArray[2].ToString()}' AND numExo = {(int)(InfosExo.ItemArray[0]) + 1}");
                if (InfosExoSuivant.Length != 0)
                {
                    if ((int)(InfosExoSuivant[0].ItemArray[5]) == 0)
                    {
                        LeconVocabulaire LeconVocabulaire = new LeconVocabulaire(InfosExoSuivant[0], Babbel, utilisateur, TableVerifExo);
                        LeconVocabulaire.Show();

                    }
                    else if ((bool)(InfosExoSuivant[0].ItemArray[6]))
                    {
                        ExoDesordre ExoDesordre = new ExoDesordre(InfosExoSuivant[0], Babbel, utilisateur, TableVerifExo);
                        ExoDesordre.Show();
                    }
                    else
                    {
                        ExoTrou ExoATrou = new ExoTrou(InfosExoSuivant[0], Babbel, utilisateur, TableVerifExo);
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

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
