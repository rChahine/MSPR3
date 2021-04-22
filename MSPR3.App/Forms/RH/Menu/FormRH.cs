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
    public partial class FormRH : Form
    {
        public FormRH()
        {
            InitializeComponent();
        }

        private void btnGestionEmploye(object sender, EventArgs e)
        {
            Forms.RH.Menu.EmployesForm RH = new Forms.RH.Menu.EmployesForm();
            RH.ShowDialog();
        }

        private void btnBack(object sender, EventArgs e)
        {
            Close();
        }
    }
}
