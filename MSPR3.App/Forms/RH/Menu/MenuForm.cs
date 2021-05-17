using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MSPR3.Forms.RH.Menu
{
    /// <summary>
    /// Classe qui affiche le menu de la gestion des RH
    /// </summary>
    public partial class MenuForm : Form
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ferme le formulaire
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ouvre le menu des RH
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btnRHStock_Click(object sender, EventArgs e)
        {
            Forms.RH.Menu.FormRH RH = new Forms.RH.Menu.FormRH();
            RH.ShowDialog();
        }
    }
}
