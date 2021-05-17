using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPR3.Forms.GF.Menu
{
    /// <summary>
    /// Class du Form menu
    /// </summary>
    public partial class MenuForm : Form
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();

            TitreMenuFinanciere.Font = new System.Drawing.Font(TitreMenuFinanciere.Font.Name, 16F);

        }

        /// <summary>
        /// Ouvre le form des facturations au clique
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.GF.Facturation.FacturationForm Facturation = new Forms.GF.Facturation.FacturationForm();
            Facturation.ShowDialog();
        }

        /// <summary>
        /// Ouvre le form de la gestion des fournisseurs au clique
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.GF.GestionFournisseur.GestionFournisseurForm GestionF = new Forms.GF.GestionFournisseur.GestionFournisseurForm();
            GestionF.ShowDialog();
        }
    }
}
