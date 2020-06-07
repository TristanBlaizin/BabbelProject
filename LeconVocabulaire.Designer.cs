namespace BabbelProject
{
    partial class LeconVocabulaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeconVocabulaire));
            this.label6 = new System.Windows.Forms.Label();
            this.btnTrouTerminer = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblTrouConsigne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.label6.Location = new System.Drawing.Point(19, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 43);
            this.label6.TabIndex = 8;
            this.label6.Text = "La Casa de Babbel";
            // 
            // btnTrouTerminer
            // 
            this.btnTrouTerminer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(127)))), ((int)(((byte)(103)))));
            this.btnTrouTerminer.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTrouTerminer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.btnTrouTerminer.Location = new System.Drawing.Point(670, 399);
            this.btnTrouTerminer.Name = "btnTrouTerminer";
            this.btnTrouTerminer.Size = new System.Drawing.Size(118, 39);
            this.btnTrouTerminer.TabIndex = 15;
            this.btnTrouTerminer.Text = "Suivant";
            this.btnTrouTerminer.UseVisualStyleBackColor = false;
            this.btnTrouTerminer.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Transparent;
            this.pnl.Location = new System.Drawing.Point(12, 102);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(776, 280);
            this.pnl.TabIndex = 16;
            // 
            // lblTrouConsigne
            // 
            this.lblTrouConsigne.AutoSize = true;
            this.lblTrouConsigne.BackColor = System.Drawing.Color.Transparent;
            this.lblTrouConsigne.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrouConsigne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.lblTrouConsigne.Location = new System.Drawing.Point(304, 68);
            this.lblTrouConsigne.Name = "lblTrouConsigne";
            this.lblTrouConsigne.Size = new System.Drawing.Size(181, 31);
            this.lblTrouConsigne.TabIndex = 1;
            this.lblTrouConsigne.Text = "Vocabulaire";
            // 
            // LeconVocabulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrouConsigne);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnTrouTerminer);
            this.Controls.Add(this.label6);
            this.Name = "LeconVocabulaire";
            this.Text = "LeconVocabulaire";
            this.Load += new System.EventHandler(this.LeconVocabulaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTrouTerminer;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblTrouConsigne;
    }
}