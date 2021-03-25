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

namespace MSPR3
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
            Client client = new Client(1, "pierre", "paul", new DateTime(1997, 3, 22));
            Console.WriteLine(client.ToString());
        }
    }
}
