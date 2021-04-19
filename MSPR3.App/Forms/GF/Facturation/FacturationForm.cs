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
        private string filePath;
        public FacturationForm()
        {
            InitializeComponent();

            TitreMenuFacturation.Font = new System.Drawing.Font(TitreMenuFacturation.Font.Name, 16F);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "pdf files (*.pdf)|*.pdf";
            OFD.FilterIndex = 2;
            OFD.RestoreDirectory = true;
            OFD.Multiselect = true;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                var test = OFD.SafeFileNames;
                for (var i=0; i<test.Length; i++)
                {
                    var fileStream = OFD.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();
                    }

                    listBox1.Items.Add(OFD.FileNames[i]);
                }
                
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                filePath = listBox1.SelectedItem.ToString();
            }
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            launchPDFReader();
        }

        private void launchPDFReader()
        {
            using (Process myProcess = new Process())
            {
                var path = Path.Combine(Environment.CurrentDirectory, "FreePDFReader.exe");
                myProcess.StartInfo.FileName = path;
                Process.Start(myProcess.StartInfo.FileName, filePath);
            }
        }
    }
}
