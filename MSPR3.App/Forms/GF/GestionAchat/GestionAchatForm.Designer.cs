namespace MSPR3.Forms.GF.GestionAchat
{
    partial class GestionAchatForm
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
            this.TitreMenuGA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitreMenuGA
            // 
            this.TitreMenuGA.AutoSize = true;
            this.TitreMenuGA.Location = new System.Drawing.Point(279, 80);
            this.TitreMenuGA.Name = "TitreMenuGA";
            this.TitreMenuGA.Size = new System.Drawing.Size(138, 20);
            this.TitreMenuGA.TabIndex = 0;
            this.TitreMenuGA.Text = "Gestions des achats";
            // 
            // GestionAchatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.TitreMenuGA);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestionAchatForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreMenuGA;
    }
}