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
            this.cbxUtilisateur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPresentation5 = new System.Windows.Forms.Label();
            this.lblPresentation4 = new System.Windows.Forms.Label();
            this.lblPresentation3 = new System.Windows.Forms.Label();
            this.lblPresentation2 = new System.Windows.Forms.Label();
            this.lblPresentation1 = new System.Windows.Forms.Label();
            this.btnExo = new System.Windows.Forms.Button();
            this.lblExo = new System.Windows.Forms.Label();
            this.lblCommentLesson = new System.Windows.Forms.Label();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblTitleLesson = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblTitleCours = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUtilisateur
            // 
            this.cbxUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.cbxUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUtilisateur.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUtilisateur.ForeColor = System.Drawing.Color.Transparent;
            this.cbxUtilisateur.FormattingEnabled = true;
            this.cbxUtilisateur.Location = new System.Drawing.Point(155, 55);
            this.cbxUtilisateur.Margin = new System.Windows.Forms.Padding(0);
            this.cbxUtilisateur.Name = "cbxUtilisateur";
            this.cbxUtilisateur.Size = new System.Drawing.Size(172, 26);
            this.cbxUtilisateur.TabIndex = 1;
            this.cbxUtilisateur.SelectedIndexChanged += new System.EventHandler(this.CbxUtilisateur_SelectedIndexChanged);
            this.cbxUtilisateur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxUtilisateur_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identifiez-vous: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblPresentation5);
            this.groupBox1.Controls.Add(this.lblPresentation4);
            this.groupBox1.Controls.Add(this.lblPresentation3);
            this.groupBox1.Controls.Add(this.lblPresentation2);
            this.groupBox1.Controls.Add(this.lblPresentation1);
            this.groupBox1.Controls.Add(this.btnExo);
            this.groupBox1.Controls.Add(this.lblExo);
            this.groupBox1.Controls.Add(this.lblCommentLesson);
            this.groupBox1.Controls.Add(this.lblLesson);
            this.groupBox1.Controls.Add(this.lblTitleLesson);
            this.groupBox1.Controls.Add(this.lblCours);
            this.groupBox1.Controls.Add(this.lblTitleCours);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxUtilisateur);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 312);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mon cours actuel: ";
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
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExo.Location = new System.Drawing.Point(543, 54);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(0, 23);
            this.lblExo.TabIndex = 8;
            // 
            // lblCommentLesson
            // 
            this.lblCommentLesson.AutoSize = true;
            this.lblCommentLesson.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentLesson.Location = new System.Drawing.Point(8, 178);
            this.lblCommentLesson.Name = "lblCommentLesson";
            this.lblCommentLesson.Size = new System.Drawing.Size(0, 18);
            this.lblCommentLesson.TabIndex = 7;
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesson.Location = new System.Drawing.Point(84, 147);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(0, 18);
            this.lblLesson.TabIndex = 6;
            // 
            // lblTitleLesson
            // 
            this.lblTitleLesson.AutoSize = true;
            this.lblTitleLesson.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLesson.Location = new System.Drawing.Point(7, 143);
            this.lblTitleLesson.Name = "lblTitleLesson";
            this.lblTitleLesson.Size = new System.Drawing.Size(71, 23);
            this.lblTitleLesson.TabIndex = 5;
            this.lblTitleLesson.Text = "Leçon :";
            this.lblTitleLesson.Visible = false;
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.Location = new System.Drawing.Point(182, 111);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(0, 18);
            this.lblCours.TabIndex = 4;
            // 
            // lblTitleCours
            // 
            this.lblTitleCours.AutoSize = true;
            this.lblTitleCours.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCours.Location = new System.Drawing.Point(7, 106);
            this.lblTitleCours.Name = "lblTitleCours";
            this.lblTitleCours.Size = new System.Drawing.Size(175, 23);
            this.lblTitleCours.TabIndex = 3;
            this.lblTitleCours.Text = "Votre cours actuel: ";
            this.lblTitleCours.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(547, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 130);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(547, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 130);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.label6.Location = new System.Drawing.Point(215, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 43);
            this.label6.TabIndex = 6;
            this.label6.Text = "La Casa de Babbel";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblTitleCours;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblTitleLesson;
        private System.Windows.Forms.Label lblCommentLesson;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Button btnExo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPresentation3;
        private System.Windows.Forms.Label lblPresentation2;
        private System.Windows.Forms.Label lblPresentation1;
        private System.Windows.Forms.Label lblPresentation5;
        private System.Windows.Forms.Label lblPresentation4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

