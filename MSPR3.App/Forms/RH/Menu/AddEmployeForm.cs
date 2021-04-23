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
    public partial class AddEmployeForm : Form
    {
        public AddEmployeForm()
        {
            InitializeComponent();
        }

        private void OnNomChanged(object sender, EventArgs e)
        {

        }

        private void OnPrenomChanged(object sender, EventArgs e)
        {

        }

        private void OnServiceChanged(object sender, EventArgs e)
        {

        }

        private void OnDateRecrutementChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employe newEmploye = new Employe(textBoxNom.Text, textBoxPrenom.Text, textBoxService.Text, textBoxDateRecrutement.Text);
            AddEmployeToData(newEmploye);

            Close();

            Forms.RH.Menu.EmployesForm RH = new Forms.RH.Menu.EmployesForm();
            RH.ShowDialog();
        }

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
