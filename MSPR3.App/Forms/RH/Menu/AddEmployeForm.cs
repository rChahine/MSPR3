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
    /// Classe pour ajouter un employé
    /// </summary>
    public partial class AddEmployeForm : Form
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public AddEmployeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ajoute un employé dans la liste
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Employe newEmploye = new Employe(textBoxNom.Text, textBoxPrenom.Text, textBoxService.Text, textBoxDateRecrutement.Text);
            AddEmployeToData(newEmploye);

            Close();

            Forms.RH.Menu.EmployesForm RH = new Forms.RH.Menu.EmployesForm();
            RH.ShowDialog();
        }

        /// <summary>
        /// Ajouter un employé dans une liste
        /// </summary>
        /// <param name="newEmploye">Employe</param>
        private void AddEmployeToData(Employe newEmploye)
        {
            List<Employe> employelist = new List<Employe>();

            string json = File.ReadAllText("../../../Forms/RH/Data/employeesDataStock.json");
            employelist = JsonConvert.DeserializeObject<List<Employe>>(json);

            employelist.Add(newEmploye);

            File.WriteAllText("../../../Forms/RH/Data/employeesDataStock.json", JsonConvert.SerializeObject(employelist));
        }

    }
}
