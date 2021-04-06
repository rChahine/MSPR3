using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSPR3.Metiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers.Tests
{
    [TestClass()]
    public class Produit_Tests
    {
        [TestMethod()]
        public void ProduitTests()
        {
            Produit produit = new Produit(1, "PC", 5, 150.00);
            Assert.IsInstanceOfType(produit, typeof(Produit));
        }

        [TestMethod()]
        public void ProduitAttributesTests()
        {
            Produit produit = new Produit(1, "PC", 5, 150.00);
            var resultId = produit.Id;
            var resultDesignation = produit.Designation;
            var resultQuantite = produit.Quantite;
            var resultPrix = produit.Prix;
            // Test Produit attributes
            Assert.AreEqual(resultId, 1);
            Assert.AreEqual(resultDesignation, "PC");
            Assert.AreEqual(resultQuantite, 5);
            Assert.AreEqual(resultPrix, 150.00);
        }

        [TestMethod()]
        public void ProduitSetAttributesTests()
        {
            Produit produit = new Produit(1, "PC", 5, 150.00);

            produit.Id = 99;
            produit.Designation = "Carte";
            produit.Quantite = 1;
            produit.Prix = 45;
            // Test Produit attributes
            Assert.AreEqual(produit.Id, 99);
            Assert.AreEqual(produit.Designation, "Carte");
            Assert.AreEqual(produit.Quantite, 1);
            Assert.AreEqual(produit.Prix, 45);
        }
    }
}