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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            TitreMenuFinanciere.Font = new System.Drawing.Font(TitreMenuFinanciere.Font.Name, 16F);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.GF.GestionAchat.GestionAchatForm GestionA = new Forms.GF.GestionAchat.GestionAchatForm();
            GestionA.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.GF.Facturation.FacturationForm Facturation = new Forms.GF.Facturation.FacturationForm();
            Facturation.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.GF.GestionFournisseur.GestionFournisseurForm GestionF = new Forms.GF.GestionFournisseur.GestionFournisseurForm();
            GestionF.ShowDialog();
        }
    }
}
