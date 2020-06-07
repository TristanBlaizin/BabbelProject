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
            this.lblAdminNbExo = new System.Windows.Forms.Label();
            this.btnAdminFin = new System.Windows.Forms.Button();
            this.btnAdminSuivant = new System.Windows.Forms.Button();
            this.btnAdminPrecedent = new System.Windows.Forms.Button();
            this.btnAdminDebut = new System.Windows.Forms.Button();
            this.lblAdminPhrase = new System.Windows.Forms.Label();
            this.lblAdminConsigne = new System.Windows.Forms.Label();
            this.lblAdminCours = new System.Windows.Forms.Label();
            this.lblAdminLecon = new System.Windows.Forms.Label();
            this.cbxAdminLecon = new System.Windows.Forms.ComboBox();
            this.cbxAdminCours = new System.Windows.Forms.ComboBox();
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
            this.btnAdminAccueil = new System.Windows.Forms.Button();
            this.lblAccueilBienvenue = new System.Windows.Forms.Label();
            this.btnAccueilDeconnexion = new System.Windows.Forms.Button();
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
            this.cbxAcceuilUtilisateur.Location = new System.Drawing.Point(298, 228);
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
            this.lblAcceuilIdentification.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuilIdentification.Location = new System.Drawing.Point(300, 190);
            this.lblAcceuilIdentification.Name = "lblAcceuilIdentification";
            this.lblAcceuilIdentification.Size = new System.Drawing.Size(170, 23);
            this.lblAcceuilIdentification.TabIndex = 2;
            this.lblAcceuilIdentification.Text = "Identifiez-vous: ";
            // 
            // gpbAcceuil
            // 
            this.gpbAcceuil.BackColor = System.Drawing.Color.Transparent;
            this.gpbAcceuil.Controls.Add(this.lblAdminNbExo);
            this.gpbAcceuil.Controls.Add(this.btnAdminFin);
            this.gpbAcceuil.Controls.Add(this.btnAdminSuivant);
            this.gpbAcceuil.Controls.Add(this.btnAdminPrecedent);
            this.gpbAcceuil.Controls.Add(this.btnAdminDebut);
            this.gpbAcceuil.Controls.Add(this.lblAdminPhrase);
            this.gpbAcceuil.Controls.Add(this.cbxAcceuilUtilisateur);
            this.gpbAcceuil.Controls.Add(this.lblAdminConsigne);
            this.gpbAcceuil.Controls.Add(this.lblAcceuilIdentification);
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
            // lblAdminNbExo
            // 
            this.lblAdminNbExo.AutoSize = true;
            this.lblAdminNbExo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNbExo.Location = new System.Drawing.Point(336, 276);
            this.lblAdminNbExo.Name = "lblAdminNbExo";
            this.lblAdminNbExo.Size = new System.Drawing.Size(76, 23);
            this.lblAdminNbExo.TabIndex = 26;
            this.lblAdminNbExo.Text = "#nbExo";
            this.lblAdminNbExo.Visible = false;
            // 
            // btnAdminFin
            // 
            this.btnAdminFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAdminFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminFin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnAdminFin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnAdminFin.Location = new System.Drawing.Point(535, 268);
            this.btnAdminFin.Name = "btnAdminFin";
            this.btnAdminFin.Size = new System.Drawing.Size(109, 38);
            this.btnAdminFin.TabIndex = 25;
            this.btnAdminFin.Text = ">>";
            this.btnAdminFin.UseVisualStyleBackColor = false;
            this.btnAdminFin.Visible = false;
            // 
            // btnAdminSuivant
            // 
            this.btnAdminSuivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAdminSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminSuivant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnAdminSuivant.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSuivant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnAdminSuivant.Location = new System.Drawing.Point(420, 268);
            this.btnAdminSuivant.Name = "btnAdminSuivant";
            this.btnAdminSuivant.Size = new System.Drawing.Size(109, 38);
            this.btnAdminSuivant.TabIndex = 24;
            this.btnAdminSuivant.Text = ">";
            this.btnAdminSuivant.UseVisualStyleBackColor = false;
            this.btnAdminSuivant.Visible = false;
            this.btnAdminSuivant.Click += new System.EventHandler(this.btnAdminSuivant_Click);
            // 
            // btnAdminPrecedent
            // 
            this.btnAdminPrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAdminPrecedent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminPrecedent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnAdminPrecedent.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPrecedent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnAdminPrecedent.Location = new System.Drawing.Point(221, 268);
            this.btnAdminPrecedent.Name = "btnAdminPrecedent";
            this.btnAdminPrecedent.Size = new System.Drawing.Size(109, 38);
            this.btnAdminPrecedent.TabIndex = 23;
            this.btnAdminPrecedent.Text = "<";
            this.btnAdminPrecedent.UseVisualStyleBackColor = false;
            this.btnAdminPrecedent.Visible = false;
            this.btnAdminPrecedent.Click += new System.EventHandler(this.btnAdminPrecedent_Click);
            // 
            // btnAdminDebut
            // 
            this.btnAdminDebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAdminDebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminDebut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnAdminDebut.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnAdminDebut.Location = new System.Drawing.Point(106, 268);
            this.btnAdminDebut.Name = "btnAdminDebut";
            this.btnAdminDebut.Size = new System.Drawing.Size(109, 38);
            this.btnAdminDebut.TabIndex = 22;
            this.btnAdminDebut.Text = "<<";
            this.btnAdminDebut.UseVisualStyleBackColor = false;
            this.btnAdminDebut.Visible = false;
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
            // lblAdminConsigne
            // 
            this.lblAdminConsigne.AutoSize = true;
            this.lblAdminConsigne.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminConsigne.Location = new System.Drawing.Point(7, 92);
            this.lblAdminConsigne.Name = "lblAdminConsigne";
            this.lblAdminConsigne.Size = new System.Drawing.Size(0, 23);
            this.lblAdminConsigne.TabIndex = 21;
            this.lblAdminConsigne.Visible = false;
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
            // cbxAdminCours
            // 
            this.cbxAdminCours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.cbxAdminCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAdminCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAdminCours.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAdminCours.ForeColor = System.Drawing.Color.Transparent;
            this.cbxAdminCours.FormattingEnabled = true;
            this.cbxAdminCours.Location = new System.Drawing.Point(87, 44);
            this.cbxAdminCours.Margin = new System.Windows.Forms.Padding(0);
            this.cbxAdminCours.Name = "cbxAdminCours";
            this.cbxAdminCours.Size = new System.Drawing.Size(279, 26);
            this.cbxAdminCours.TabIndex = 17;
            this.cbxAdminCours.Visible = false;
            this.cbxAdminCours.SelectedIndexChanged += new System.EventHandler(this.cbxAdminCour_SelectedIndexChanged);
            // 
            // lblPresentation5
            // 
            this.lblPresentation5.AutoSize = true;
            this.lblPresentation5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation5.Location = new System.Drawing.Point(8, 134);
            this.lblPresentation5.Name = "lblPresentation5";
            this.lblPresentation5.Size = new System.Drawing.Size(414, 18);
            this.lblPresentation5.TabIndex = 15;
            this.lblPresentation5.Text = "des mots dans le bon odre pour faire des phrases.";
            // 
            // lblPresentation4
            // 
            this.lblPresentation4.AutoSize = true;
            this.lblPresentation4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation4.Location = new System.Drawing.Point(7, 112);
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
            this.lblPresentation3.Location = new System.Drawing.Point(8, 88);
            this.lblPresentation3.Name = "lblPresentation3";
            this.lblPresentation3.Size = new System.Drawing.Size(111, 18);
            this.lblPresentation3.TabIndex = 13;
            this.lblPresentation3.Text = "en espagnol.";
            // 
            // lblPresentation2
            // 
            this.lblPresentation2.AutoSize = true;
            this.lblPresentation2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentation2.Location = new System.Drawing.Point(6, 64);
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
            this.lblPresentation1.Location = new System.Drawing.Point(254, 24);
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
            this.lblAccueilCours2.Location = new System.Drawing.Point(192, 59);
            this.lblAccueilCours2.Name = "lblAccueilCours2";
            this.lblAccueilCours2.Size = new System.Drawing.Size(0, 18);
            this.lblAccueilCours2.TabIndex = 4;
            // 
            // lblAcceuilCoursActuelle
            // 
            this.lblAcceuilCoursActuelle.AutoSize = true;
            this.lblAcceuilCoursActuelle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuilCoursActuelle.Location = new System.Drawing.Point(11, 54);
            this.lblAcceuilCoursActuelle.Name = "lblAcceuilCoursActuelle";
            this.lblAcceuilCoursActuelle.Size = new System.Drawing.Size(175, 23);
            this.lblAcceuilCoursActuelle.TabIndex = 3;
            this.lblAcceuilCoursActuelle.Text = "Votre cours actuel: ";
            this.lblAcceuilCoursActuelle.Visible = false;
            // 
            // ptbAccueilDrapeauCouleur
            // 
            this.ptbAccueilDrapeauCouleur.Image = ((System.Drawing.Image)(resources.GetObject("ptbAccueilDrapeauCouleur.Image")));
            this.ptbAccueilDrapeauCouleur.Location = new System.Drawing.Point(547, 112);
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
            this.lblAcceuilLaCasaDeBabel.Location = new System.Drawing.Point(226, 18);
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
            this.btnAdminAccueil.Click += new System.EventHandler(this.btnAdminAccueil_Click);
            // 
            // lblAccueilBienvenue
            // 
            this.lblAccueilBienvenue.AutoSize = true;
            this.lblAccueilBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.lblAccueilBienvenue.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilBienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.lblAccueilBienvenue.Location = new System.Drawing.Point(254, 79);
            this.lblAccueilBienvenue.Name = "lblAccueilBienvenue";
            this.lblAccueilBienvenue.Size = new System.Drawing.Size(125, 23);
            this.lblAccueilBienvenue.TabIndex = 27;
            this.lblAccueilBienvenue.Text = "#bienvenue";
            this.lblAccueilBienvenue.Visible = false;
            // 
            // btnAccueilDeconnexion
            // 
            this.btnAccueilDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnAccueilDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccueilDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.btnAccueilDeconnexion.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueilDeconnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnAccueilDeconnexion.Location = new System.Drawing.Point(12, 12);
            this.btnAccueilDeconnexion.Name = "btnAccueilDeconnexion";
            this.btnAccueilDeconnexion.Size = new System.Drawing.Size(148, 38);
            this.btnAccueilDeconnexion.TabIndex = 28;
            this.btnAccueilDeconnexion.Text = "Deconnexion";
            this.btnAccueilDeconnexion.UseVisualStyleBackColor = false;
            this.btnAccueilDeconnexion.Visible = false;
            this.btnAccueilDeconnexion.Click += new System.EventHandler(this.btnAccueilDeconnexion_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.btnAccueilDeconnexion);
            this.Controls.Add(this.lblAccueilBienvenue);
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
        private System.Windows.Forms.Label lblAdminConsigne;
        private System.Windows.Forms.Label lblAdminPhrase;
        private System.Windows.Forms.Button btnAdminFin;
        private System.Windows.Forms.Button btnAdminSuivant;
        private System.Windows.Forms.Button btnAdminPrecedent;
        private System.Windows.Forms.Button btnAdminDebut;
        private System.Windows.Forms.Label lblAdminNbExo;
        private System.Windows.Forms.Label lblAccueilBienvenue;
        private System.Windows.Forms.Button btnAccueilDeconnexion;
    }
}

