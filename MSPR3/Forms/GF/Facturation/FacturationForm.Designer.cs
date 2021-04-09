namespace MSPR3.Forms.GF.Facturation
{
    partial class FacturationForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TitreMenuFacturation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 292);
            this.listBox1.TabIndex = 1;
            //this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TitreMenuFacturation
            // 
            this.TitreMenuFacturation.AutoSize = true;
            this.TitreMenuFacturation.Location = new System.Drawing.Point(255, 65);
            this.TitreMenuFacturation.Name = "TitreMenuFacturation";
            this.TitreMenuFacturation.Size = new System.Drawing.Size(79, 17);
            this.TitreMenuFacturation.TabIndex = 0;
            this.TitreMenuFacturation.Text = "Facturation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter une facture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FacturationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TitreMenuFacturation);
            this.Name = "FacturationForm";
            this.Text = "FacturationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TitreMenuFacturation;
        private System.Windows.Forms.Button button1;
    }
}