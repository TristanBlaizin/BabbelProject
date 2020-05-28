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
            this.lblRegle = new System.Windows.Forms.Label();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblRegle
            // 
            this.lblRegle.AutoSize = true;
            this.lblRegle.Location = new System.Drawing.Point(381, 9);
            this.lblRegle.Name = "lblRegle";
            this.lblRegle.Size = new System.Drawing.Size(41, 13);
            this.lblRegle.TabIndex = 1;
            this.lblRegle.Text = "balbel2";
            // 
            // grpContainer
            // 
            this.grpContainer.Location = new System.Drawing.Point(18, 223);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(770, 215);
            this.grpContainer.TabIndex = 3;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Phrase dans le désordre";
            // 
            // ExoDesordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpContainer);
            this.Controls.Add(this.lblRegle);
            this.Name = "ExoDesordre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ExoDesordre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegle;
        private System.Windows.Forms.GroupBox grpContainer;
    }
}