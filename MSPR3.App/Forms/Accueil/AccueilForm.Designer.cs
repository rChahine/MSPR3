
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
            this.label1.Location = new System.Drawing.Point(361, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Accueil";
            // 
            // bt_GF
            // 
            this.bt_GF.Image = ((System.Drawing.Image)(resources.GetObject("bt_GF.Image")));
            this.bt_GF.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_GF.Location = new System.Drawing.Point(543, 194);
            this.bt_GF.Name = "bt_GF";
            this.bt_GF.Size = new System.Drawing.Size(207, 149);
            this.bt_GF.TabIndex = 6;
            this.bt_GF.Text = "Gestion financière";
            this.bt_GF.UseVisualStyleBackColor = true;
            this.bt_GF.Click += new System.EventHandler(this.bt_GF_Click);
            // 
            // bt_RH
            // 
            this.bt_RH.Image = ((System.Drawing.Image)(resources.GetObject("bt_RH.Image")));
            this.bt_RH.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_RH.Location = new System.Drawing.Point(292, 194);
            this.bt_RH.Name = "bt_RH";
            this.bt_RH.Size = new System.Drawing.Size(205, 149);
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
            this.bt_GA.Location = new System.Drawing.Point(54, 194);
            this.bt_GA.Name = "bt_GA";
            this.bt_GA.Size = new System.Drawing.Size(201, 149);
            this.bt_GA.TabIndex = 4;
            this.bt_GA.Text = "Gestion des achats";
            this.bt_GA.UseVisualStyleBackColor = true;
            this.bt_GA.Click += new System.EventHandler(this.bt_GA_Click);
            // 
            // AccueilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_GF);
            this.Controls.Add(this.bt_RH);
            this.Controls.Add(this.bt_GA);
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

