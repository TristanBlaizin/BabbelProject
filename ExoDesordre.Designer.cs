namespace BabbelProject
{
    partial class ExoDesordre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExoDesordre));
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.grpSolution = new System.Windows.Forms.GroupBox();
            this.btnSolution = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDesordreValider = new System.Windows.Forms.Button();
            this.lblDesordreConsigne = new System.Windows.Forms.Label();
            this.btnDesordreSuivant = new System.Windows.Forms.Button();
            this.lblDesordreEtatExo = new System.Windows.Forms.Label();
            this.lblTraduc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpContainer
            // 
            this.grpContainer.BackColor = System.Drawing.Color.Transparent;
            this.grpContainer.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.grpContainer.Location = new System.Drawing.Point(18, 232);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(770, 94);
            this.grpContainer.TabIndex = 3;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Phrase dans le désordre";
            // 
            // grpSolution
            // 
            this.grpSolution.BackColor = System.Drawing.Color.Transparent;
            this.grpSolution.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.grpSolution.Location = new System.Drawing.Point(18, 125);
            this.grpSolution.Name = "grpSolution";
            this.grpSolution.Size = new System.Drawing.Size(770, 101);
            this.grpSolution.TabIndex = 6;
            this.grpSolution.TabStop = false;
            this.grpSolution.Text = "Phrase en construction";
            // 
            // btnSolution
            // 
            this.btnSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolution.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnSolution.Location = new System.Drawing.Point(670, 90);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(118, 39);
            this.btnSolution.TabIndex = 7;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = false;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            this.btnSolution.MouseHover += new System.EventHandler(this.btnSolution_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 43);
            this.label6.TabIndex = 11;
            this.label6.Text = "La Casa de Babbel";
            // 
            // btnDesordreValider
            // 
            this.btnDesordreValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnDesordreValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesordreValider.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDesordreValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnDesordreValider.Location = new System.Drawing.Point(18, 332);
            this.btnDesordreValider.Name = "btnDesordreValider";
            this.btnDesordreValider.Size = new System.Drawing.Size(118, 39);
            this.btnDesordreValider.TabIndex = 14;
            this.btnDesordreValider.Text = "Valider";
            this.btnDesordreValider.UseVisualStyleBackColor = false;
            this.btnDesordreValider.Click += new System.EventHandler(this.btnTrouValider_Click);
            // 
            // lblDesordreConsigne
            // 
            this.lblDesordreConsigne.AutoSize = true;
            this.lblDesordreConsigne.BackColor = System.Drawing.Color.Transparent;
            this.lblDesordreConsigne.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesordreConsigne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.lblDesordreConsigne.Location = new System.Drawing.Point(23, 90);
            this.lblDesordreConsigne.Name = "lblDesordreConsigne";
            this.lblDesordreConsigne.Size = new System.Drawing.Size(152, 25);
            this.lblDesordreConsigne.TabIndex = 15;
            this.lblDesordreConsigne.Text = "exo desordre";
            // 
            // btnDesordreSuivant
            // 
            this.btnDesordreSuivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnDesordreSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesordreSuivant.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDesordreSuivant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnDesordreSuivant.Location = new System.Drawing.Point(670, 399);
            this.btnDesordreSuivant.Name = "btnDesordreSuivant";
            this.btnDesordreSuivant.Size = new System.Drawing.Size(118, 39);
            this.btnDesordreSuivant.TabIndex = 16;
            this.btnDesordreSuivant.Text = "Suivant";
            this.btnDesordreSuivant.UseVisualStyleBackColor = false;
            this.btnDesordreSuivant.Click += new System.EventHandler(this.btnDesordreSuivant_Click);
            // 
            // lblDesordreEtatExo
            // 
            this.lblDesordreEtatExo.AutoSize = true;
            this.lblDesordreEtatExo.BackColor = System.Drawing.Color.Transparent;
            this.lblDesordreEtatExo.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesordreEtatExo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.lblDesordreEtatExo.Location = new System.Drawing.Point(12, 410);
            this.lblDesordreEtatExo.Name = "lblDesordreEtatExo";
            this.lblDesordreEtatExo.Size = new System.Drawing.Size(172, 31);
            this.lblDesordreEtatExo.TabIndex = 17;
            this.lblDesordreEtatExo.Text = "exo desordre";
            // 
            // lblTraduc
            // 
            this.lblTraduc.AutoSize = true;
            this.lblTraduc.BackColor = System.Drawing.Color.Transparent;
            this.lblTraduc.Font = new System.Drawing.Font("Georgia", 14.2F, System.Drawing.FontStyle.Italic);
            this.lblTraduc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.lblTraduc.Location = new System.Drawing.Point(142, 340);
            this.lblTraduc.Name = "lblTraduc";
            this.lblTraduc.Size = new System.Drawing.Size(102, 23);
            this.lblTraduc.TabIndex = 18;
            this.lblTraduc.Text = "traduction";
            this.lblTraduc.UseWaitCursor = true;
            // 
            // ExoDesordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTraduc);
            this.Controls.Add(this.lblDesordreEtatExo);
            this.Controls.Add(this.btnDesordreSuivant);
            this.Controls.Add(this.lblDesordreConsigne);
            this.Controls.Add(this.btnDesordreValider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.grpSolution);
            this.Controls.Add(this.grpContainer);
            this.Name = "ExoDesordre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ExoDesordre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.GroupBox grpSolution;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDesordreValider;
        private System.Windows.Forms.Label lblDesordreConsigne;
        private System.Windows.Forms.Button btnDesordreSuivant;
        private System.Windows.Forms.Label lblDesordreEtatExo;
        private System.Windows.Forms.Label lblTraduc;
    }
}