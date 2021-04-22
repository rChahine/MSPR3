
namespace MSPR3.Forms.RH.Menu
{
    partial class EmployesForm
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
            this.listViewEmploye = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewEmploye
            // 
            this.listViewEmploye.HideSelection = false;
            this.listViewEmploye.Location = new System.Drawing.Point(260, 12);
            this.listViewEmploye.Name = "listViewEmploye";
            this.listViewEmploye.Size = new System.Drawing.Size(528, 426);
            this.listViewEmploye.TabIndex = 0;
            this.listViewEmploye.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter un employé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.adEmployeOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Supprimer un employé";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employés Finances";
            // 
            // EmployesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewEmploye);
            this.Name = "EmployesForm";
            this.Text = "EmployesForm";
            this.Click += new System.EventHandler(this.EmployesForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmploye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}