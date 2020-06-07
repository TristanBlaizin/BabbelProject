namespace BabbelProject
{
    partial class FormResultatLecon
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
            this.lstValide = new System.Windows.Forms.ListBox();
            this.lstNonValide = new System.Windows.Forms.ListBox();
            this.lblLaCasaDeBabbelTrou = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompteRendu = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstValide
            // 
            this.lstValide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.lstValide.FormattingEnabled = true;
            this.lstValide.Location = new System.Drawing.Point(12, 150);
            this.lstValide.Name = "lstValide";
            this.lstValide.Size = new System.Drawing.Size(343, 212);
            this.lstValide.TabIndex = 1;
            // 
            // lstNonValide
            // 
            this.lstNonValide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lstNonValide.FormattingEnabled = true;
            this.lstNonValide.Location = new System.Drawing.Point(445, 150);
            this.lstNonValide.Name = "lstNonValide";
            this.lstNonValide.Size = new System.Drawing.Size(343, 212);
            this.lstNonValide.TabIndex = 0;
            // 
            // lblLaCasaDeBabbelTrou
            // 
            this.lblLaCasaDeBabbelTrou.AutoSize = true;
            this.lblLaCasaDeBabbelTrou.BackColor = System.Drawing.Color.Transparent;
            this.lblLaCasaDeBabbelTrou.Font = new System.Drawing.Font("Georgia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaCasaDeBabbelTrou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.lblLaCasaDeBabbelTrou.Location = new System.Drawing.Point(20, 36);
            this.lblLaCasaDeBabbelTrou.Name = "lblLaCasaDeBabbelTrou";
            this.lblLaCasaDeBabbelTrou.Size = new System.Drawing.Size(368, 43);
            this.lblLaCasaDeBabbelTrou.TabIndex = 8;
            this.lblLaCasaDeBabbelTrou.Text = "La Casa de Babbel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(367, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // lblCompteRendu
            // 
            this.lblCompteRendu.AutoSize = true;
            this.lblCompteRendu.BackColor = System.Drawing.Color.Transparent;
            this.lblCompteRendu.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCompteRendu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.lblCompteRendu.Location = new System.Drawing.Point(254, 100);
            this.lblCompteRendu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompteRendu.Name = "lblCompteRendu";
            this.lblCompteRendu.Size = new System.Drawing.Size(343, 31);
            this.lblCompteRendu.TabIndex = 10;
            this.lblCompteRendu.Text = "Compte Rendu de leçon";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnRestart.Location = new System.Drawing.Point(346, 399);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(118, 39);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Refaire";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnRetour.Location = new System.Drawing.Point(670, 399);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(118, 39);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FormResultatLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabbelProject.Properties.Resources.espagne3_0;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblCompteRendu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLaCasaDeBabbelTrou);
            this.Controls.Add(this.lstValide);
            this.Controls.Add(this.lstNonValide);
            this.Name = "FormResultatLecon";
            this.Text = "FormResultatLecon";
            this.Load += new System.EventHandler(this.FormResultatLecon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstValide;
        private System.Windows.Forms.ListBox lstNonValide;
        private System.Windows.Forms.Label lblLaCasaDeBabbelTrou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompteRendu;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnRetour;
    }
}