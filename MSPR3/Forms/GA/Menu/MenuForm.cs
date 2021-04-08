using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CR = MSPR3.Forms.GA.CompteResultat;

namespace MSPR3.Forms.GA.Menu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CR.CompteResultat cr = new CR.CompteResultat();
            cr.ShowDialog();
        }
    }
}
