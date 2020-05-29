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
            this.grpSolution = new System.Windows.Forms.GroupBox();
            this.btnSolution = new System.Windows.Forms.Button();
            this.lblSolution = new System.Windows.Forms.Label();
            this.lblNonValide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegle
            // 
            this.lblRegle.AutoSize = true;
            this.lblRegle.Location = new System.Drawing.Point(374, 9);
            this.lblRegle.Name = "lblRegle";
            this.lblRegle.Size = new System.Drawing.Size(35, 13);
            this.lblRegle.TabIndex = 1;
            this.lblRegle.Text = "label2";
            // 
            // grpContainer
            // 
            this.grpContainer.Location = new System.Drawing.Point(18, 309);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(770, 129);
            this.grpContainer.TabIndex = 3;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Phrase dans le désordre";
            // 
            // grpSolution
            // 
            this.grpSolution.Location = new System.Drawing.Point(18, 34);
            this.grpSolution.Name = "grpSolution";
            this.grpSolution.Size = new System.Drawing.Size(770, 101);
            this.grpSolution.TabIndex = 6;
            this.grpSolution.TabStop = false;
            this.grpSolution.Text = "Phrase en construction";
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(713, 280);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(75, 23);
            this.btnSolution.TabIndex = 7;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(254, 211);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(35, 13);
            this.lblSolution.TabIndex = 8;
            this.lblSolution.Text = "label1";
            this.lblSolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNonValide
            // 
            this.lblNonValide.AutoSize = true;
            this.lblNonValide.Location = new System.Drawing.Point(347, 239);
            this.lblNonValide.Name = "lblNonValide";
            this.lblNonValide.Size = new System.Drawing.Size(109, 13);
            this.lblNonValide.TabIndex = 10;
            this.lblNonValide.Text = "Excercice Non Validé";
            this.lblNonValide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNonValide.Visible = false;
            // 
            // ExoDesordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNonValide);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.grpSolution);
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
        private System.Windows.Forms.GroupBox grpSolution;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label lblNonValide;
    }
}