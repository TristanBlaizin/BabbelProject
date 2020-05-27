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
            this.cbxUtilisateur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExo = new System.Windows.Forms.Button();
            this.lblExo = new System.Windows.Forms.Label();
            this.lblCommentLesson = new System.Windows.Forms.Label();
            this.lblLesson = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxUtilisateur
            // 
            this.cbxUtilisateur.FormattingEnabled = true;
            this.cbxUtilisateur.Location = new System.Drawing.Point(93, 51);
            this.cbxUtilisateur.Name = "cbxUtilisateur";
            this.cbxUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.cbxUtilisateur.TabIndex = 1;
            this.cbxUtilisateur.SelectedIndexChanged += new System.EventHandler(this.CbxUtilisateur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identifiez-vous: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExo);
            this.groupBox1.Controls.Add(this.lblExo);
            this.groupBox1.Controls.Add(this.lblCommentLesson);
            this.groupBox1.Controls.Add(this.lblLesson);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxUtilisateur);
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 312);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mon cours actuel: ";
            // 
            // btnExo
            // 
            this.btnExo.Location = new System.Drawing.Point(340, 289);
            this.btnExo.Name = "btnExo";
            this.btnExo.Size = new System.Drawing.Size(183, 23);
            this.btnExo.TabIndex = 9;
            this.btnExo.Text = "Commencez l\'excercie";
            this.btnExo.UseVisualStyleBackColor = true;
            this.btnExo.Click += new System.EventHandler(this.BtnExo_Click);
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.Location = new System.Drawing.Point(7, 198);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(0, 13);
            this.lblExo.TabIndex = 8;
            // 
            // lblCommentLesson
            // 
            this.lblCommentLesson.AutoSize = true;
            this.lblCommentLesson.Location = new System.Drawing.Point(57, 187);
            this.lblCommentLesson.Name = "lblCommentLesson";
            this.lblCommentLesson.Size = new System.Drawing.Size(0, 13);
            this.lblCommentLesson.TabIndex = 7;
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Location = new System.Drawing.Point(106, 143);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(0, 13);
            this.lblLesson.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Leçon: ";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Location = new System.Drawing.Point(113, 106);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(0, 13);
            this.lblCours.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Votre cours actuel: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCommentLesson;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Button btnExo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

