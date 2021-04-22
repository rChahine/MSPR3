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
    public partial class EmployesForm : Form
    {
        private string jsonString;

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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FillListViewer(List<Employe> listEmploye)
        {
            foreach(Employe employe in listEmploye)
            {
                string[] row = { employe.Nom, employe.Prenom, employe.Service, employe.DateRecrutement };
                ListViewItem item = new ListViewItem(row);
                listViewEmploye.Items.Add(item);
            }
        }

        private void EmployesForm_Click(object sender, EventArgs e)
        {

        }

        private void adEmployeOnClick(object sender, EventArgs e)
        {
            Forms.RH.Menu.AddEmployeForm RH = new Forms.RH.Menu.AddEmployeForm();
            RH.ShowDialog();
            Hide();
        }

        private List<Employe> GetEmployeData() {
            List<Employe> allEmployesData = new List<Employe>();

            string json = File.ReadAllText("../../../Forms/RH/Data/employeesDataStock.json");
            allEmployesData = JsonConvert.DeserializeObject<List<Employe>>(json);

            return allEmployesData;
        }
    }
}
