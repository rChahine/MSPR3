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
    /// <summary>
    /// Affiche le form de facturation
    /// </summary>
    public partial class FacturationForm : Form
    {
        /// <summary>
        /// Chemin du fichier
        /// </summary>
        private string filePath;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public FacturationForm()
        {
            InitializeComponent();

            TitreMenuFacturation.Font = new System.Drawing.Font(TitreMenuFacturation.Font.Name, 16F);
        }


        /// <summary>
        /// Ajoute un fichier PDF dans la liste
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
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

        /// <summary>
        /// Affiche la liste des PDF
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                filePath = listBox1.SelectedItem.ToString();
            }
        }

        /// <summary>
        /// Affiche un PDF au clique
        /// </summary>
        /// <param name="sender">Référence vers l'objet ayant trigger le clique</param>
        /// <param name="e">Arguments de l'évènement</param>
        private void ButtonView_Click(object sender, EventArgs e)
        {
            launchPDFReader();
        }

        /// <summary>
        /// Affiche un PDF en utilisant FreePDFReader
        /// <see cref="https://www.01net.com/telecharger/windows/Bureautique/editeur_de_texte/fiches/104998.html"/>
        /// </summary>
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
