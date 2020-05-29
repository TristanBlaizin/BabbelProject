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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSolution = new System.Windows.Forms.GroupBox();
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
            this.grpContainer.Location = new System.Drawing.Point(18, 349);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(770, 89);
            this.grpContainer.TabIndex = 3;
            this.grpContainer.TabStop = false;
            this.grpContainer.Text = "Phrase dans le désordre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // grpSolution
            // 
            this.grpSolution.Location = new System.Drawing.Point(18, 242);
            this.grpSolution.Name = "grpSolution";
            this.grpSolution.Size = new System.Drawing.Size(770, 101);
            this.grpSolution.TabIndex = 6;
            this.grpSolution.TabStop = false;
            this.grpSolution.Text = "Phrase en construction";
            // 
            // ExoDesordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSolution;
    }
}