using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPR3.Forms.GF.GestionFournisseur
{
    public partial class GestionFournisseurForm : Form
    {
        public GestionFournisseurForm()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 5; 

            dataGridView1.Columns[0].Name = "Nom"; 
            dataGridView1.Columns[1].Name = "Fournitures"; 
            dataGridView1.Columns[2].Name = "Date d'ajout"; 
            dataGridView1.Columns[3].Name = "Téléphone"; 
            dataGridView1.Columns[4].Name = "Localisation";

            string[] row0 = { "Oberthur-fiduciaire", "Billets de banque", "12/02/2020", "01 42 99 77 00", "7, avenue de Messine CS 30003 75384 Paris Cedex 08, France" };
            string[] row1 = { "Visa", "Carte bancaire", "17/02/2020", "08 00 90 11 79", "26 RUE SAINT CHARLES 75015 Paris 15e Arrondissement" };
            string[] row2 = { "MasterCard", "Carte bancaire", "17/02/2020", "08 00 90 13 87", "112 AV KLEBER, 75116 PARIS" };
            string[] row3 = { "Maison Lyovel", "Alimentaire/Distributeur", "12/02/2020", "04 78 79 18 18", "2266 Avenue de l'Europe, 69140 Rillieux-la-Pape" };
            string[] row4 = { "Inapa France", "Fourniture bureau/papier", "14/02/2020", "01 60 89 90 91", "11 rue de la Nacelle, Villabé 91813 Corbeil - Essonnes Cedex" };
            string[] row5 = { "Ldlc-pro", "Fourniture informatique", "11/02/2020", "04 27 46 60 05", "150 Allée des Frènes, 69760 Limonest" };
            string[] row6 = { "EDF", "Fourniture Gaz/Electricité", "06/02/2020", "09 69 32 15 15", "22-30 Avenue de Wagram, 75008 Paris" };
            string[] row7 = { "Bouygues-immobilier", "Immobilier", "04/02/2020", "01 55 18 70 00", "3 Boulevard Gallieni, 92445 Issy-les-Moulineaux" };
            

            dataGridView1.Rows.Add(row0);
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);
            dataGridView1.Rows.Add(row5);
            dataGridView1.Rows.Add(row6);
            dataGridView1.Rows.Add(row7);
        }
    }
}
