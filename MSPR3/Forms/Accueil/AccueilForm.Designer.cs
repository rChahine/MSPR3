
namespace MSPR3
{
    partial class AccueilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilForm));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_GF = new System.Windows.Forms.Button();
            this.bt_RH = new System.Windows.Forms.Button();
            this.bt_GA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Accueil";
            // 
            // bt_GF
            // 
            this.bt_GF.Image = ((System.Drawing.Image)(resources.GetObject("bt_GF.Image")));
            this.bt_GF.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_GF.Location = new System.Drawing.Point(724, 239);
            this.bt_GF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_GF.Name = "bt_GF";
            this.bt_GF.Size = new System.Drawing.Size(276, 183);
            this.bt_GF.TabIndex = 6;
            this.bt_GF.Text = "Gestion financière";
            this.bt_GF.UseVisualStyleBackColor = true;
            this.bt_GF.Click += new System.EventHandler(this.bt_GF_Click);
            // 
            // bt_RH
            // 
            this.bt_RH.Image = ((System.Drawing.Image)(resources.GetObject("bt_RH.Image")));
            this.bt_RH.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_RH.Location = new System.Drawing.Point(389, 239);
            this.bt_RH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_RH.Name = "bt_RH";
            this.bt_RH.Size = new System.Drawing.Size(273, 183);
            this.bt_RH.TabIndex = 5;
            this.bt_RH.Text = "Gestion des ressources humaines";
            this.bt_RH.UseVisualStyleBackColor = true;
            this.bt_RH.Click += new System.EventHandler(this.bt_RH_Click);
            // 
            // bt_GA
            // 
            this.bt_GA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_GA.Image = ((System.Drawing.Image)(resources.GetObject("bt_GA.Image")));
            this.bt_GA.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_GA.Location = new System.Drawing.Point(72, 239);
            this.bt_GA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_GA.Name = "bt_GA";
            this.bt_GA.Size = new System.Drawing.Size(268, 183);
            this.bt_GA.TabIndex = 4;
            this.bt_GA.Text = "Gestion des achats";
            this.bt_GA.UseVisualStyleBackColor = true;
            this.bt_GA.Click += new System.EventHandler(this.bt_GA_Click);
            // 
            // AccueilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_GF);
            this.Controls.Add(this.bt_RH);
            this.Controls.Add(this.bt_GA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccueilForm";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_GF;
        private System.Windows.Forms.Button bt_RH;
        private System.Windows.Forms.Button bt_GA;
    }
}

