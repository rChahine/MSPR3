
namespace MSPR3.Forms.GA.CompteResultat
{
    partial class CompteResultat
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
            this.dgvCharge = new System.Windows.Forms.DataGridView();
            this.Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbTotalIncome = new System.Windows.Forms.Label();
            this.lbTotalCharge = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btAddCharge = new System.Windows.Forms.Button();
            this.btAddIncome = new System.Windows.Forms.Button();
            this.tbCharge = new System.Windows.Forms.TextBox();
            this.tbIncome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btLineIncome = new System.Windows.Forms.Button();
            this.btLineCharge = new System.Windows.Forms.Button();
            this.lineIncome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lineCharge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCharge
            // 
            this.dgvCharge.AllowUserToAddRows = false;
            this.dgvCharge.AllowUserToDeleteRows = false;
            this.dgvCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Charges});
            this.dgvCharge.Location = new System.Drawing.Point(30, 21);
            this.dgvCharge.Name = "dgvCharge";
            this.dgvCharge.ReadOnly = true;
            this.dgvCharge.RowTemplate.Height = 24;
            this.dgvCharge.Size = new System.Drawing.Size(244, 412);
            this.dgvCharge.TabIndex = 0;
            this.dgvCharge.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCharge_RowPostPaint);
            // 
            // Charges
            // 
            this.Charges.HeaderText = "Charge(s)";
            this.Charges.Name = "Charges";
            this.Charges.ReadOnly = true;
            this.Charges.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Charges.Width = 200;
            // 
            // dgvIncome
            // 
            this.dgvIncome.AllowUserToAddRows = false;
            this.dgvIncome.AllowUserToDeleteRows = false;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvIncome.Location = new System.Drawing.Point(321, 21);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.ReadOnly = true;
            this.dgvIncome.RowTemplate.Height = 24;
            this.dgvIncome.Size = new System.Drawing.Size(244, 412);
            this.dgvIncome.TabIndex = 1;
            this.dgvIncome.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvIncome_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Revenu(s)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Compte de résultat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total charges :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total revenus :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Balance :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIncome);
            this.groupBox1.Controls.Add(this.dgvCharge);
            this.groupBox1.Location = new System.Drawing.Point(458, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 445);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBalance);
            this.groupBox2.Controls.Add(this.lbTotalIncome);
            this.groupBox2.Controls.Add(this.lbTotalCharge);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btAddCharge);
            this.groupBox2.Controls.Add(this.btAddIncome);
            this.groupBox2.Controls.Add(this.tbCharge);
            this.groupBox2.Controls.Add(this.tbIncome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 445);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(132, 416);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(28, 17);
            this.lbBalance.TabIndex = 25;
            this.lbBalance.Text = "0 €";
            // 
            // lbTotalIncome
            // 
            this.lbTotalIncome.AutoSize = true;
            this.lbTotalIncome.Location = new System.Drawing.Point(132, 389);
            this.lbTotalIncome.Name = "lbTotalIncome";
            this.lbTotalIncome.Size = new System.Drawing.Size(28, 17);
            this.lbTotalIncome.TabIndex = 24;
            this.lbTotalIncome.Text = "0 €";
            // 
            // lbTotalCharge
            // 
            this.lbTotalCharge.AutoSize = true;
            this.lbTotalCharge.Location = new System.Drawing.Point(132, 360);
            this.lbTotalCharge.Name = "lbTotalCharge";
            this.lbTotalCharge.Size = new System.Drawing.Size(28, 17);
            this.lbTotalCharge.TabIndex = 23;
            this.lbTotalCharge.Text = "0 €";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "€";
            // 
            // btAddCharge
            // 
            this.btAddCharge.Location = new System.Drawing.Point(314, 102);
            this.btAddCharge.Name = "btAddCharge";
            this.btAddCharge.Size = new System.Drawing.Size(42, 27);
            this.btAddCharge.TabIndex = 20;
            this.btAddCharge.Text = "➕";
            this.btAddCharge.UseVisualStyleBackColor = true;
            this.btAddCharge.Click += new System.EventHandler(this.btAddCharge_Click);
            // 
            // btAddIncome
            // 
            this.btAddIncome.Location = new System.Drawing.Point(314, 62);
            this.btAddIncome.Name = "btAddIncome";
            this.btAddIncome.Size = new System.Drawing.Size(42, 27);
            this.btAddIncome.TabIndex = 19;
            this.btAddIncome.Text = "➕";
            this.btAddIncome.UseVisualStyleBackColor = true;
            this.btAddIncome.Click += new System.EventHandler(this.btAddIncome_Click);
            // 
            // tbCharge
            // 
            this.tbCharge.Location = new System.Drawing.Point(162, 100);
            this.tbCharge.Name = "tbCharge";
            this.tbCharge.Size = new System.Drawing.Size(124, 22);
            this.tbCharge.TabIndex = 18;
            // 
            // tbIncome
            // 
            this.tbIncome.Location = new System.Drawing.Point(162, 62);
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Size = new System.Drawing.Size(124, 22);
            this.tbIncome.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ajouter une charge :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ajouter un revenu :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btLineIncome);
            this.groupBox3.Controls.Add(this.btLineCharge);
            this.groupBox3.Controls.Add(this.lineIncome);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lineCharge);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(6, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 162);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supprimer une ligne d\'un tableau";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "⚠️ Indiquez un numéro de ligne";
            // 
            // btLineIncome
            // 
            this.btLineIncome.Location = new System.Drawing.Point(308, 47);
            this.btLineIncome.Name = "btLineIncome";
            this.btLineIncome.Size = new System.Drawing.Size(42, 27);
            this.btLineIncome.TabIndex = 30;
            this.btLineIncome.Text = "➖";
            this.btLineIncome.UseVisualStyleBackColor = true;
            this.btLineIncome.Click += new System.EventHandler(this.btLineIncome_Click);
            // 
            // btLineCharge
            // 
            this.btLineCharge.Location = new System.Drawing.Point(308, 85);
            this.btLineCharge.Name = "btLineCharge";
            this.btLineCharge.Size = new System.Drawing.Size(42, 27);
            this.btLineCharge.TabIndex = 31;
            this.btLineCharge.Text = "➖";
            this.btLineCharge.UseVisualStyleBackColor = true;
            this.btLineCharge.Click += new System.EventHandler(this.btLineCharge_Click);
            // 
            // lineIncome
            // 
            this.lineIncome.Location = new System.Drawing.Point(209, 47);
            this.lineIncome.Name = "lineIncome";
            this.lineIncome.Size = new System.Drawing.Size(71, 22);
            this.lineIncome.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Supprimer un revenu :";
            // 
            // lineCharge
            // 
            this.lineCharge.Location = new System.Drawing.Point(209, 87);
            this.lineCharge.Name = "lineCharge";
            this.lineCharge.Size = new System.Drawing.Size(71, 22);
            this.lineCharge.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Supprimer une charge :";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 177);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajouter une ligne dans un tableau";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "n°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "n°";
            // 
            // CompteResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompteResultat";
            this.Text = "Compte de résultat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCharge;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAddCharge;
        private System.Windows.Forms.Button btAddIncome;
        private System.Windows.Forms.TextBox tbCharge;
        private System.Windows.Forms.TextBox tbIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.Label lbTotalCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charges;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btLineCharge;
        private System.Windows.Forms.Button btLineIncome;
        private System.Windows.Forms.TextBox lineCharge;
        private System.Windows.Forms.TextBox lineIncome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}