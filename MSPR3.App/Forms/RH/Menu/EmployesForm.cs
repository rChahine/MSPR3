using MSPR3.App.Forms.RH.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MSPR3.Forms.RH.Menu
{
    /// <summary>
    /// Classe du form des employes
    /// </summary>
    public partial class EmployesForm : Form
    {
        /// <summary>
        /// Chaine à sérialiser
        /// </summary>
        private string jsonString;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public EmployesForm()
        {
            InitializeComponent();
            GetEmployeData();
            Employe employe1 = new Employe("Asri", "Nicolas", "IT", "12/12/2020");
            Employe employe2 = new Employe("Asri", "Nicolas", "IT", "12/12/2020");

            List<Employe> allStockEmployes = new List<Employe> { employe1, employe2 };

            listViewEmploye.View = View.Details;
            listViewEmploye.CheckBoxes = true;

            listViewEmploye.Columns.Add("Nom", 100, HorizontalAlignment.Left);
            listViewEmploye.Columns.Add("Prenom", 100, HorizontalAlignment.Left);
            listViewEmploye.Columns.Add("Service", 100, HorizontalAlignment.Left);
            listViewEmploye.Columns.Add("Date de Recrutement", 150, HorizontalAlignment.Left);

            FillListViewer(GetEmployeData());
        }

        /// <summary>
        /// Rempli la vue des employés
        /// </summary>
        /// <param name="listEmploye"></param>
        private void FillListViewer(List<Employe> listEmploye)
        {
            foreach(Employe employe in listEmploye)
            {
                string[] row = { employe.Nom, employe.Prenom, employe.Service, employe.DateRecrutement };
                ListViewItem item = new ListViewItem(row);
                listViewEmploye.Items.Add(item);
            }
        }

        /// <summary>
        /// Affiche le formulaire d'ajout d'employé
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void adEmployeOnClick(object sender, EventArgs e)
        {
            Forms.RH.Menu.AddEmployeForm RH = new Forms.RH.Menu.AddEmployeForm();
            RH.ShowDialog();
            Hide();
        }

        /// <summary>
        /// Récupère la liste des employés
        /// </summary>
        /// <returns>Une liste des employé</returns>
        private List<Employe> GetEmployeData() {
            List<Employe> allEmployesData = new List<Employe>();

            string json = File.ReadAllText("../../../Forms/RH/Data/employeesDataStock.json");
            allEmployesData = JsonConvert.DeserializeObject<List<Employe>>(json);

            return allEmployesData;
        }

        /// <summary>
        /// Supprime un employé au clique
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void delEmployeOnClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewEmploye.CheckedItems)
            {
                listViewEmploye.Items.Remove(item);
            }
        }
    }
}
