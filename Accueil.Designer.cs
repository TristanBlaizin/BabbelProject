namespace BabbelProject
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.cbxAcceuilUtilisateur = new System.Windows.Forms.ComboBox();
            this.lblAcceuilIdentification = new System.Windows.Forms.Label();
            this.gpbAcceuil = new System.Windows.Forms.GroupBox();
            this.lblPresentation5 = new System.Windows.Forms.Label();
            this.lblPresentation4 = new System.Windows.Forms.Label();
            this.lblPresentation3 = new System.Windows.Forms.Label();
            this.lblPresentation2 = new System.Windows.Forms.Label();
            this.lblPresentation1 = new System.Windows.Forms.Label();
            this.btnExo = new System.Windows.Forms.Button();
            this.lblAccueilExo = new System.Windows.Forms.Label();
            this.lblAccueilComentLecon = new System.Windows.Forms.Label();
            this.lblAccueilLecon2 = new System.Windows.Forms.Label();
            this.lblAcceuilLecon = new System.Windows.Forms.Label();
            this.lblAccueilCours2 = new System.Windows.Forms.Label();
            this.lblAcceuilCoursActuelle = new System.Windows.Forms.Label();
            this.ptbAccueilDrapeauCouleur = new System.Windows.Forms.PictureBox();
            this.ptbAccueilDrapeauNoirBlanc = new System.Windows.Forms.PictureBox();
            this.lblAcceuilLaCasaDeBabel = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblAdminLaCasaDeBabel = new System.Windows.Forms.Label();
            this.cbxAdminCours = new System.Windows.Forms.ComboBox();
            this.cbxAdminLecon = new System.Windows.Forms.ComboBox();
            this.lblAdminLecon = new System.Windows.Forms.Label();
            this.lblAdminCours = new System.Windows.Forms.Label();
            this.btnAdminAccueil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminConsigne = new System.Windows.Forms.Label();
            this.lblAdminPhrase = new System.Windows.Forms.Label();
            this.gpbAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccueilDrapeauCouleur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccueilDrapeauNoirBlanc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAcceuilUtilisateur
            // 
            this.cbxAcceuilUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.cbxAcceuilUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAcceuilUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAcceuilUtilisateur.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAcceuilUtilisateur.ForeColor = System.Drawing.Color.Transparent;
            this.cbxAcceuilUtilisateur.FormattingEnabled = true;
            this.cbxAcceuilUtilisateur.Location = new System.Drawing.Point(155, 55);
            this.cbxAcceuilUtilisateur.Margin = new System.Windows.Forms.Padding(0);
            this.cbxAcceuilUtilisateur.Name = "cbxAcceuilUtilisateur";
            this.cbxAcceuilUtilisateur.Size = new System.Drawing.Size(172, 26);
            this.cbxAcceuilUtilisateur.TabIndex = 1;
            this.cbxAcceuilUtilisateur.SelectedIndexChanged += new System.EventHandler(this.CbxUtilisateur_SelectedIndexChanged);
            this.cbxAcceuilUtilisateur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxUtilisateur_KeyPress);
            // 
            // lblAcceuilIdentification
            // 
            this.lblAcceuilIdentification.AutoSize = true;
            this.lblAcceuilIdentification.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuilIdentification.Location = new System.Drawing.Point(6, 54);
            this.lblAcceuilIdentification.Name = "lblAcceuilIdentification";
            this.lblAcceuilIdentification.Size = new System.Drawing.Size(146, 23);
            this.lblAcceuilIdentification.TabIndex = 2;
            this.lblAcceuilIdentification.Text = "Identifiez-vous: ";
            // 
            // gpbAcceuil
            // 
            this.gpbAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.gpbAcceuil.Controls.Add(this.lblAdminPhrase);
            this.gpbAcceuil.Controls.Add(this.lblAdminConsigne);
            this.gpbAcceuil.Controls.Add(this.lblAdminCours);
            this.gpbAcceuil.Controls.Add(this.lblAdminLecon);
            this.gpbAcceuil.Controls.Add(this.cbxAdminLecon);
            this.gpbAcceuil.Controls.Add(this.cbxAdminCours);
            this.gpbAcceuil.Controls.Add(this.lblPresentation5);
            this.gpbAcceuil.Controls.Add(this.lblPresentation4);
            this.gpbAcceuil.Controls.Add(this.lblPresentation3);
            this.gpbAcceuil.Controls.Add(this.lblPresentation2);
            this.gpbAcceuil.Controls.Add(this.lblPresentation1);
            this.gpbAcceuil.Controls.Add(this.btnExo);
            this.gpbAcceuil.Controls.Add(this.lblAccueilExo);
            this.gpbAcceuil.Controls.Add(this.lblAccueilComentLecon);
            this.gpbAcceuil.Controls.Add(this.lblAccueilLecon2);
            this.gpbAcceuil.Controls.Add(this.lblAcceuilLecon);
            this.gpbAcceuil.Controls.Add(this.lblAccueilCours2);
            this.gpbAcceuil.Controls.Add(this.lblAcceuilCoursActuelle);
            this.gpbAcceuil.Controls.Add(this.lblAcceuilIdentification);
            this.gpbAcceuil.Controls.Add(this.cbxAcceuilUtilisateur);
            this.gpbAcceuil.Controls.Add(this.ptbAccueilDrapeauCouleur);
            this.gpbAcceuil.Controls.Add(this.ptbAccueilDrapeauNoirBlanc);
            this.gpbAcceuil.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAcceuil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.gpbAcceuil.Location = new System.Drawing.Point(13, 126);
            this.gpbAcceuil.Name = "gpbAcceuil";
            this.gpbAcceuil.Size = new System.Drawing.Size(775, 312);
            this.gpbAcceuil.TabIndex = 3;
            this.gpbAcceuil.TabStop = false;
            this.gpbAcceuil.Text = "Mon cours actuel: ";
            // 
            // lblPresentation5
            // 
            this.lblPresentation5.AutoSize = true;
            this.lblPresentation5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation5.Location = new System.Drawing.Point(8, 214);
            this.lblPresentation5.Name = "lblPresentation5";
            this.lblPresentation5.Size = new System.Drawing.Size(414, 18);
            this.lblPresentation5.TabIndex = 15;
            this.lblPresentation5.Text = "des mots dans le bon odre pour faire des phrases.";
            // 
            // lblPresentation4
            // 
            this.lblPresentation4.AutoSize = true;
            this.lblPresentation4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation4.Location = new System.Drawing.Point(8, 196);
            this.lblPresentation4.Name = "lblPresentation4";
            this.lblPresentation4.Size = new System.Drawing.Size(729, 18);
            this.lblPresentation4.TabIndex = 14;
            this.lblPresentation4.Text = "Vous vous execerez également en complétant des phrases à trous ou bien en remetta" +
    "nt  ";
            // 
            // lblPresentation3
            // 
            this.lblPresentation3.AutoSize = true;
            this.lblPresentation3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation3.Location = new System.Drawing.Point(8, 166);
            this.lblPresentation3.Name = "lblPresentation3";
            this.lblPresentation3.Size = new System.Drawing.Size(111, 18);
            this.lblPresentation3.TabIndex = 13;
            this.lblPresentation3.Text = "en espagnol.";
            // 
            // lblPresentation2
            // 
            this.lblPresentation2.AutoSize = true;
            this.lblPresentation2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation2.Location = new System.Drawing.Point(8, 148);
            this.lblPresentation2.Name = "lblPresentation2";
            this.lblPresentation2.Size = new System.Drawing.Size(724, 18);
            this.lblPresentation2.TabIndex = 12;
            this.lblPresentation2.Text = "En vous identifiant vous pourrez accéder à des cours afin d\'améliorer vos compéte" +
    "nces";
            // 
            // lblPresentation1
            // 
            this.lblPresentation1.AutoSize = true;
            this.lblPresentation1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation1.Location = new System.Drawing.Point(8, 125);
            this.lblPresentation1.Name = "lblPresentation1";
            this.lblPresentation1.Size = new System.Drawing.Size(304, 18);
            this.lblPresentation1.TabIndex = 11;
            this.lblPresentation1.Text = "Bienvenue dans La Casa de Babbel ! ";
            // 
            // btnExo
            // 
            this.btnExo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnExo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnExo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExo.Location = new System.Drawing.Point(518, 268);
            this.btnExo.Name = "btnExo";
            this.btnExo.Size = new System.Drawing.Size(251, 38);
            this.btnExo.TabIndex = 9;
            this.btnExo.Text = "Commencer l\'execice";
            this.btnExo.UseVisualStyleBackColor = false;
            this.btnExo.Visible = false;
            this.btnExo.Click += new System.EventHandler(this.BtnExo_Click);
            // 
            // lblAccueilExo
            // 
            this.lblAccueilExo.AutoSize = true;
            this.lblAccueilExo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilExo.Location = new System.Drawing.Point(543, 54);
            this.lblAccueilExo.Name = "lblAccueilExo";
            this.lblAccueilExo.Size = new System.Drawing.Size(0, 23);
            this.lblAccueilExo.TabIndex = 8;
            // 
            // lblAccueilComentLecon
            // 
            this.lblAccueilComentLecon.AutoSize = true;
            this.lblAccueilComentLecon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilComentLecon.Location = new System.Drawing.Point(8, 178);
            this.lblAccueilComentLecon.Name = "lblAccueilComentLecon";
            this.lblAccueilComentLecon.Size = new System.Drawing.Size(0, 18);
            this.lblAccueilComentLecon.TabIndex = 7;
            // 
            // lblAccueilLecon2
            // 
            this.lblAccueilLecon2.AutoSize = true;
            this.lblAccueilLecon2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilLecon2.Location = new System.Drawing.Point(84, 147);
            this.lblAccueilLecon2.Name = "lblAccueilLecon2";
            this.lblAccueilLecon2.Size = new System.Drawing.Size(0, 18);
            this.lblAccueilLecon2.TabIndex = 6;
            // 
            // lblAcceuilLecon
            // 
            this.lblAcceuilLecon.AutoSize = true;
            this.lblAcceuilLecon.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuilLecon.Location = new System.Drawing.Point(7, 143);
            this.lblAcceuilLecon.Name = "lblAcceuilLecon";
            this.lblAcceuilLecon.Size = new System.Drawing.Size(71, 23);
            this.lblAcceuilLecon.TabIndex = 5;
            this.lblAcceuilLecon.Text = "Leçon :";
            this.lblAcceuilLecon.Visible = false;
            // 
            // lblAccueilCours2
            // 
            this.lblAccueilCours2.AutoSize = true;
            this.lblAccueilCours2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilCours2.Location = new System.Drawing.Point(182, 111);
            this.lblAccueilCours2.Name = "lblAccueilCours2";
            this.lblAccueilCours2.Size = new System.Drawing.Size(0, 18);
            this.lblAccueilCours2.TabIndex = 4;
            // 
            // lblAcceuilCoursActuelle
            // 
            this.lblAcceuilCoursActuelle.AutoSize = true;
            this.lblAcceuilCoursActuelle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuilCoursActuelle.Location = new System.Drawing.Point(7, 106);
            this.lblAcceuilCoursActuelle.Name = "lblAcceuilCoursActuelle";
            this.lblAcceuilCoursActuelle.Size = new System.Drawing.Size(175, 23);
            this.lblAcceuilCoursActuelle.TabIndex = 3;
            this.lblAcceuilCoursActuelle.Text = "Votre cours actuel: ";
            this.lblAcceuilCoursActuelle.Visible = false;
            // 
            // ptbAccueilDrapeauCouleur
            // 
            this.ptbAccueilDrapeauCouleur.Image = ((System.Drawing.Image)(resources.GetObject("ptbAccueilDrapeauCouleur.Image")));
            this.ptbAccueilDrapeauCouleur.Location = new System.Drawing.Point(547, 111);
            this.ptbAccueilDrapeauCouleur.Name = "ptbAccueilDrapeauCouleur";
            this.ptbAccueilDrapeauCouleur.Size = new System.Drawing.Size(196, 130);
            this.ptbAccueilDrapeauCouleur.TabIndex = 10;
            this.ptbAccueilDrapeauCouleur.TabStop = false;
            this.ptbAccueilDrapeauCouleur.Visible = false;
            // 
            // ptbAccueilDrapeauNoirBlanc
            // 
            this.ptbAccueilDrapeauNoirBlanc.Image = ((System.Drawing.Image)(resources.GetObject("ptbAccueilDrapeauNoirBlanc.Image")));
            this.ptbAccueilDrapeauNoirBlanc.Location = new System.Drawing.Point(547, 111);
            this.ptbAccueilDrapeauNoirBlanc.Name = "ptbAccueilDrapeauNoirBlanc";
            this.ptbAccueilDrapeauNoirBlanc.Size = new System.Drawing.Size(196, 130);
            this.ptbAccueilDrapeauNoirBlanc.TabIndex = 16;
            this.ptbAccueilDrapeauNoirBlanc.TabStop = false;
            this.ptbAccueilDrapeauNoirBlanc.Visible = false;
            // 
            // lblAcceuilLaCasaDeBabel
            // 
            this.lblAcceuilLaCasaDeBabel.AutoSize = true;
            this.lblAcceuilLaCasaDeBabel.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceuilLaCasaDeBabel.Font = new System.Drawing.Font("Georgia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuilLaCasaDeBabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.lblAcceuilLaCasaDeBabel.Location = new System.Drawing.Point(215, 48);
            this.lblAcceuilLaCasaDeBabel.Name = "lblAcceuilLaCasaDeBabel";
            this.lblAcceuilLaCasaDeBabel.Size = new System.Drawing.Size(368, 43);
            this.lblAcceuilLaCasaDeBabel.TabIndex = 6;
            this.lblAcceuilLaCasaDeBabel.Text = "La Casa de Babbel";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnAdmin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnAdmin.Location = new System.Drawing.Point(617, 97);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(171, 38);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.Text = "Administration";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblAdminLaCasaDeBabel
            // 
            this.lblAdminLaCasaDeBabel.AutoSize = true;
            this.lblAdminLaCasaDeBabel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminLaCasaDeBabel.Font = new System.Drawing.Font("Georgia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLaCasaDeBabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.lblAdminLaCasaDeBabel.Location = new System.Drawing.Point(20, 36);
            this.lblAdminLaCasaDeBabel.Name = "lblAdminLaCasaDeBabel";
            this.lblAdminLaCasaDeBabel.Size = new System.Drawing.Size(368, 43);
            this.lblAdminLaCasaDeBabel.TabIndex = 19;
            this.lblAdminLaCasaDeBabel.Text = "La Casa de Babbel";
            this.lblAdminLaCasaDeBabel.Visible = false;
            // 
            // cbxAdminCours
            // 
            this.cbxAdminCours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.cbxAdminCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAdminCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAdminCours.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdminCours.ForeColor = System.Drawing.Color.Transparent;
            this.cbxAdminCours.FormattingEnabled = true;
            this.cbxAdminCours.Location = new System.Drawing.Point(87, 42);
            this.cbxAdminCours.Margin = new System.Windows.Forms.Padding(0);
            this.cbxAdminCours.Name = "cbxAdminCours";
            this.cbxAdminCours.Size = new System.Drawing.Size(279, 26);
            this.cbxAdminCours.TabIndex = 17;
            this.cbxAdminCours.Visible = false;
            this.cbxAdminCours.SelectedIndexChanged += new System.EventHandler(this.cbxAdminCour_SelectedIndexChanged);
            // 
            // cbxAdminLecon
            // 
            this.cbxAdminLecon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.cbxAdminLecon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAdminLecon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAdminLecon.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdminLecon.ForeColor = System.Drawing.Color.Transparent;
            this.cbxAdminLecon.FormattingEnabled = true;
            this.cbxAdminLecon.Location = new System.Drawing.Point(464, 44);
            this.cbxAdminLecon.Margin = new System.Windows.Forms.Padding(0);
            this.cbxAdminLecon.Name = "cbxAdminLecon";
            this.cbxAdminLecon.Size = new System.Drawing.Size(305, 26);
            this.cbxAdminLecon.TabIndex = 18;
            this.cbxAdminLecon.Visible = false;
            this.cbxAdminLecon.SelectedIndexChanged += new System.EventHandler(this.cbxAdminLecon_SelectedIndexChanged);
            // 
            // lblAdminLecon
            // 
            this.lblAdminLecon.AutoSize = true;
            this.lblAdminLecon.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLecon.Location = new System.Drawing.Point(393, 43);
            this.lblAdminLecon.Name = "lblAdminLecon";
            this.lblAdminLecon.Size = new System.Drawing.Size(71, 23);
            this.lblAdminLecon.TabIndex = 19;
            this.lblAdminLecon.Text = "Leçon :";
            this.lblAdminLecon.Visible = false;
            // 
            // lblAdminCours
            // 
            this.lblAdminCours.AutoSize = true;
            this.lblAdminCours.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminCours.Location = new System.Drawing.Point(11, 41);
            this.lblAdminCours.Name = "lblAdminCours";
            this.lblAdminCours.Size = new System.Drawing.Size(70, 23);
            this.lblAdminCours.TabIndex = 20;
            this.lblAdminCours.Text = "Cours :";
            this.lblAdminCours.Visible = false;
            // 
            // btnAdminAccueil
            // 
            this.btnAdminAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAdminAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminAccueil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnAdminAccueil.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnAdminAccueil.Location = new System.Drawing.Point(679, 97);
            this.btnAdminAccueil.Name = "btnAdminAccueil";
            this.btnAdminAccueil.Size = new System.Drawing.Size(109, 38);
            this.btnAdminAccueil.TabIndex = 20;
            this.btnAdminAccueil.Text = "Accueil";
            this.btnAdminAccueil.UseVisualStyleBackColor = false;
            this.btnAdminAccueil.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // lblAdminConsigne
            // 
            this.lblAdminConsigne.AutoSize = true;
            this.lblAdminConsigne.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminConsigne.Location = new System.Drawing.Point(7, 92);
            this.lblAdminConsigne.Name = "lblAdminConsigne";
            this.lblAdminConsigne.Size = new System.Drawing.Size(96, 23);
            this.lblAdminConsigne.TabIndex = 21;
            this.lblAdminConsigne.Text = "#consigne";
            this.lblAdminConsigne.Visible = false;
            // 
            // lblAdminPhrase
            // 
            this.lblAdminPhrase.AutoSize = true;
            this.lblAdminPhrase.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPhrase.Location = new System.Drawing.Point(6, 129);
            this.lblAdminPhrase.Name = "lblAdminPhrase";
            this.lblAdminPhrase.Size = new System.Drawing.Size(79, 23);
            this.lblAdminPhrase.TabIndex = 22;
            this.lblAdminPhrase.Text = "#phrase";
            this.lblAdminPhrase.Visible = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminAccueil);
            this.Controls.Add(this.lblAdminLaCasaDeBabel);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblAcceuilLaCasaDeBabel);
            this.Controls.Add(this.gpbAcceuil);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbAcceuil.ResumeLayout(false);
            this.gpbAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccueilDrapeauCouleur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAccueilDrapeauNoirBlanc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxAcceuilUtilisateur;
        private System.Windows.Forms.Label lblAcceuilIdentification;
        private System.Windows.Forms.GroupBox gpbAcceuil;
        private System.Windows.Forms.Label lblAccueilCours2;
        private System.Windows.Forms.Label lblAcceuilCoursActuelle;
        private System.Windows.Forms.Label lblAccueilLecon2;
        private System.Windows.Forms.Label lblAcceuilLecon;
        private System.Windows.Forms.Label lblAccueilComentLecon;
        private System.Windows.Forms.Label lblAccueilExo;
        private System.Windows.Forms.Button btnExo;
        private System.Windows.Forms.Label lblAcceuilLaCasaDeBabel;
        private System.Windows.Forms.PictureBox ptbAccueilDrapeauCouleur;
        private System.Windows.Forms.Label lblPresentation3;
        private System.Windows.Forms.Label lblPresentation2;
        private System.Windows.Forms.Label lblPresentation1;
        private System.Windows.Forms.Label lblPresentation5;
        private System.Windows.Forms.Label lblPresentation4;
        private System.Windows.Forms.PictureBox ptbAccueilDrapeauNoirBlanc;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblAdminLaCasaDeBabel;
        private System.Windows.Forms.ComboBox cbxAdminLecon;
        private System.Windows.Forms.ComboBox cbxAdminCours;
        private System.Windows.Forms.Label lblAdminCours;
        private System.Windows.Forms.Label lblAdminLecon;
        private System.Windows.Forms.Button btnAdminAccueil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminConsigne;
        private System.Windows.Forms.Label lblAdminPhrase;
    }
}

