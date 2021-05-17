using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPR3.Forms.GA.CompteResultat
{
    /// <summary>
    /// Classe qui permet d'afficher le compte de résultat
    /// </summary>
    public partial class CompteResultat : Form
    {
        /// <summary>
        /// Revenus
        /// </summary>
        private int totalIncome = 0;

        /// <summary>
        /// charges
        /// </summary>
        private int totalCharge = 0;

        /// <summary>
        /// bénéfices ou perte (revenus - charges)
        /// </summary>
        private int balance = 0;

        /// <summary>
        /// Constructeur de la classe, initialise les valeurs des labels
        /// </summary>
        public CompteResultat()
        {
            InitializeComponent();
            lbTotalCharge.Text = Convert.ToString(this.totalCharge);
            lbTotalIncome.Text = Convert.ToString(this.totalIncome);
            lbBalance.Text = Convert.ToString(this.balance);
        }

        /// <summary>
        /// Compute balance and changes le label "balance"
        /// </summary>
        private void computeBalance()
        {
            int charges = 0;
            int incomes = 0;

            foreach(DataGridViewRow row in dgvCharge.Rows)
            {
                charges += (int)row.Cells[0].Value;
            }

            foreach (DataGridViewRow row in dgvIncome.Rows)
            {
                incomes += (int)row.Cells[0].Value;
            }

            // Update balance label
            this.lbBalance.Text = Convert.ToString(incomes - charges + " €");
        }

        /// <summary>
        /// Ajoute un revenu dans le datagridview et actualise le label
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btAddIncome_Click(object sender, EventArgs e)
        {
            try { 
                int value = Int32.Parse(tbIncome.Text);
                int index = dgvIncome.Rows.Add();

                dgvIncome.Rows[index].Cells[0].Value = value;

                // Ajouter au total des revenus
                this.totalIncome += value;
                this.lbTotalIncome.Text = Convert.ToString(this.totalIncome + " €");

                this.computeBalance();

            }
            catch (FormatException)
            {
                MessageBox.Show("La valeur doit-être numérique", "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ajoute une charge dans le datagridview et change la valeur du label
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btAddCharge_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Int32.Parse(tbCharge.Text);
                int index = dgvCharge.Rows.Add();

                dgvCharge.Rows[index].Cells[0].Value = value;

                // Ajouter au total des charges
                this.totalCharge += value;
                this.lbTotalCharge.Text = Convert.ToString(this.totalCharge + " €");

                this.computeBalance();
            }
            catch (FormatException)
            {
                MessageBox.Show("La valeur doit-être numérique", "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Permet de recharger le numéro des lignes du datagridview à la suppression ou l'ajout d'une valeur
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void dgvCharge_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(this.dgvCharge.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        /// <summary>
        /// Permet de recharger le numéro des lignes du datagridview à la suppression ou l'ajout d'une valeur
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void dgvIncome_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(this.dgvIncome.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        /// <summary>
        /// Supprime une ligne dans les revenus du datagrid view des revenus
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btLineIncome_Click(object sender, EventArgs e)
        {
            try
            {
                int line = Int32.Parse(lineIncome.Text) - 1;
                int value = (int)dgvIncome.Rows[line].Cells[0].Value;

                dgvIncome.Rows.RemoveAt(line);

                // Enlever un income
                this.totalCharge -= value;
                this.lbTotalCharge.Text = Convert.ToString(this.totalCharge + " €");

                this.computeBalance();
            }
            catch (FormatException)
            {
                MessageBox.Show("La valeur doit-être numérique", "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Pour supprimer une ligne, il faut donner le numéro de ligne correspondant à la case que vous voulez supprimer.", "Numéro de ligne incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Supprime une ligne dans les charges du datagrid view des charges
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btLineCharge_Click(object sender, EventArgs e)
        {
            try
            {
                int line = Int32.Parse(lineCharge.Text) -1;
                int value = (int)dgvCharge.Rows[line].Cells[0].Value;

                dgvIncome.Rows.RemoveAt(line);

                // Enlever un income
                this.totalIncome -= value;
                this.lbTotalIncome.Text = Convert.ToString(this.totalIncome + " €");

                this.computeBalance();
            }
            catch (FormatException)
            {
                MessageBox.Show("La valeur doit-être numérique", "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Numéro de ligne incorrect", "Pour supprimer une ligne, il faut donner le numéro de ligne correspondant à la case que vous voulez supprimer.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
