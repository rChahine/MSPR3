using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPR3.Forms.RH.Menu
{
    /// <summary>
    /// Classe pour les ressources humaines
    /// </summary>
    public partial class FormRH : Form
    {
        /// <summary>
        /// Constucteur de la classe
        /// </summary>
        public FormRH()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ouvre le formulaire de la gestion des employés
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btnGestionEmploye(object sender, EventArgs e)
        {
            Forms.RH.Menu.EmployesForm RH = new Forms.RH.Menu.EmployesForm();
            RH.ShowDialog();
        }

        /// <summary>
        /// Ferme le formulaire
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void btnBack(object sender, EventArgs e)
        {
            Close();
        }
    }
}
