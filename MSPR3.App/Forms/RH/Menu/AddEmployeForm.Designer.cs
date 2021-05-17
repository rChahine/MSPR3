
namespace MSPR3.Forms.RH.Menu
{
    partial class AddEmployeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDateRecrutement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(98, 56);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(581, 27);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(98, 143);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(581, 27);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(98, 229);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(581, 27);
            this.textBoxService.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Service";
            // 
            // textBoxDateRecrutement
            // 
            this.textBoxDateRecrutement.Location = new System.Drawing.Point(98, 312);
            this.textBoxDateRecrutement.Name = "textBoxDateRecrutement";
            this.textBoxDateRecrutement.Size = new System.Drawing.Size(581, 27);
            this.textBoxDateRecrutement.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date de recrutement";
            // 
            // AddEmployeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDateRecrutement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddEmployeForm";
            this.Text = "AddEmployeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDateRecrutement;
        private System.Windows.Forms.Label label4;
    }
}