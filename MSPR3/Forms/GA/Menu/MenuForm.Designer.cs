
namespace MSPR3.Forms.GA.Menu
{
    partial class MenuForm
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
            this.bt_GA = new System.Windows.Forms.Button();
            this.bt_RH = new System.Windows.Forms.Button();
            this.bt_GF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_GA
            // 
            this.bt_GA.Location = new System.Drawing.Point(25, 133);
            this.bt_GA.Name = "bt_GA";
            this.bt_GA.Size = new System.Drawing.Size(201, 256);
            this.bt_GA.TabIndex = 0;
            this.bt_GA.Text = "Gestion des achats";
            this.bt_GA.UseVisualStyleBackColor = true;
            this.bt_GA.Click += new System.EventHandler(this.bt_GA_Click);
            // 
            // bt_RH
            // 
            this.bt_RH.Location = new System.Drawing.Point(294, 133);
            this.bt_RH.Name = "bt_RH";
            this.bt_RH.Size = new System.Drawing.Size(205, 256);
            this.bt_RH.TabIndex = 1;
            this.bt_RH.Text = "Gestion des ressources humaines";
            this.bt_RH.UseVisualStyleBackColor = true;
            this.bt_RH.Click += new System.EventHandler(this.bt_RH_Click);
            // 
            // bt_GF
            // 
            this.bt_GF.Location = new System.Drawing.Point(565, 133);
            this.bt_GF.Name = "bt_GF";
            this.bt_GF.Size = new System.Drawing.Size(207, 256);
            this.bt_GF.TabIndex = 2;
            this.bt_GF.Text = "Gestion financière";
            this.bt_GF.UseVisualStyleBackColor = true;
            this.bt_GF.Click += new System.EventHandler(this.bt_GF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accueil";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_GF);
            this.Controls.Add(this.bt_RH);
            this.Controls.Add(this.bt_GA);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_GA;
        private System.Windows.Forms.Button bt_RH;
        private System.Windows.Forms.Button bt_GF;
        private System.Windows.Forms.Label label1;
    }
}