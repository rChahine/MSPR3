using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPR3.Forms.GA.Menu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private void bt_GA_Click(object sender, EventArgs e)
        {
            MenuForm GA = new MenuForm();
            GA.Show();

            this.Close();
        }

        private void bt_RH_Click(object sender, EventArgs e)
        {

        }

        private void bt_GF_Click(object sender, EventArgs e)
        {

        }

    }
}
