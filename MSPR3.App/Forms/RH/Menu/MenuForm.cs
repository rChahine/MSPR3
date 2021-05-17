using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MSPR3.Forms.RH.Menu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRHStock_Click(object sender, EventArgs e)
        {
            Forms.RH.Menu.FormRH RH = new Forms.RH.Menu.FormRH();
            RH.ShowDialog();
        }
    }
}
