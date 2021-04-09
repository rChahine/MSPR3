using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPR3.Forms.GF.Facturation
{
    public partial class FacturationForm : Form
    {
        public FacturationForm()
        {
            InitializeComponent();

            TitreMenuFacturation.Font = new System.Drawing.Font(TitreMenuFacturation.Font.Name, 16F);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            OFD.FilterIndex = 2;
            OFD.RestoreDirectory = true;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                var filePath = OFD.FileName;
                var fileStream = OFD.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    var fileContent = reader.ReadToEnd();
                }

                listBox1.Items.Add(filePath);
            }

        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var file = (FileInfo)listBox1.SelectedItem;
        //    Process.Start(file.FullName); 
        //}
    }
}
