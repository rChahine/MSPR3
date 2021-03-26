using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSPR3.Metiers;
using MSPR3.Forms.GA.Menu;
using MSPR3.Forms.RH.Menu;
using MSPR3.Forms.GF.Menu;

namespace MSPR3
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }

        private void bt_GA_Click(object sender, EventArgs e)
        {
            Forms.GA.Menu.MenuForm GA = new Forms.GA.Menu.MenuForm();
            GA.ShowDialog();
            
        }

        private void bt_RH_Click(object sender, EventArgs e)
        {
            Forms.RH.Menu.MenuForm RH = new Forms.RH.Menu.MenuForm();
            RH.ShowDialog();
        }

        private void bt_GF_Click(object sender, EventArgs e)
        {
            Forms.GF.Menu.MenuForm GF = new Forms.GF.Menu.MenuForm();
            GF.ShowDialog();
        }
    }
}
