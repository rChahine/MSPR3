
namespace MSPR3.Forms.RH.Menu
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
            this.btnRHStock = new System.Windows.Forms.Button();
            this.btnRHFinance = new System.Windows.Forms.Button();
            this.btnRHProd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRHStock
            // 
            this.btnRHStock.Location = new System.Drawing.Point(333, 216);
            this.btnRHStock.Name = "btnRHStock";
            this.btnRHStock.Size = new System.Drawing.Size(147, 160);
            this.btnRHStock.TabIndex = 0;
            this.btnRHStock.Text = "RH Stock";
            this.btnRHStock.UseVisualStyleBackColor = true;
            this.btnRHStock.Click += new System.EventHandler(this.btnRHStock_Click);
            // 
            // btnRHFinance
            // 
            this.btnRHFinance.Location = new System.Drawing.Point(122, 216);
            this.btnRHFinance.Name = "btnRHFinance";
            this.btnRHFinance.Size = new System.Drawing.Size(147, 160);
            this.btnRHFinance.TabIndex = 1;
            this.btnRHFinance.Text = "RH Finance";
            this.btnRHFinance.UseVisualStyleBackColor = true;
            this.btnRHFinance.Click += new System.EventHandler(this.btnRHFinance_Click);
            // 
            // btnRHProd
            // 
            this.btnRHProd.Location = new System.Drawing.Point(543, 216);
            this.btnRHProd.Name = "btnRHProd";
            this.btnRHProd.Size = new System.Drawing.Size(147, 160);
            this.btnRHProd.TabIndex = 2;
            this.btnRHProd.Text = "RH Production";
            this.btnRHProd.UseVisualStyleBackColor = true;
            this.btnRHProd.Click += new System.EventHandler(this.btnRHProd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 59);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 106);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion RH";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRHProd);
            this.Controls.Add(this.btnRHFinance);
            this.Controls.Add(this.btnRHStock);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRHStock;
        private System.Windows.Forms.Button btnRHFinance;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRHProd;
    }
}