
namespace MSPR3.Forms.GF.Menu
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
            this.TitreMenuFinanciere = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitreMenuFinanciere
            // 
            this.TitreMenuFinanciere.AutoSize = true;
            this.TitreMenuFinanciere.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TitreMenuFinanciere.Location = new System.Drawing.Point(244, 64);
            this.TitreMenuFinanciere.Name = "TitreMenuFinanciere";
            this.TitreMenuFinanciere.Size = new System.Drawing.Size(154, 20);
            this.TitreMenuFinanciere.TabIndex = 3;
            this.TitreMenuFinanciere.Text = "GESTION FINANCIERE";
            this.TitreMenuFinanciere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(52, 206);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(168, 20);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Gestion des fournisseurs";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(52, 285);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(82, 20);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Facturation";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.TitreMenuFinanciere);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitreMenuFinanciere;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}