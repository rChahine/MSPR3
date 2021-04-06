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
    public class Fournisseur_Tests
    {
        [TestMethod()]
        public void FournisseurTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "test", "test", null);
            Assert.IsInstanceOfType(fournisseur, typeof(Fournisseur));
        }

        [TestMethod()]
        public void FournisseurAttributesTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "testRaisonSocial", "testAdresse", new List<Produit>());

            // Test Fournisseur attributes
            Assert.AreEqual(fournisseur.Adresse, "testAdresse");
            Assert.AreEqual(fournisseur.Id, 1);
            Assert.AreEqual(fournisseur.RaisonSocial, "testRaisonSocial");
        }

        [TestMethod()]
        public void FournisseurListProduitTests()
        {
            // Test Fournisseur attribute List<Produit>()
            Fournisseur fournisseur = new Fournisseur(1, "testRaisonSocial", "testAdresse", new List<Produit>());
            Produit produit = new Produit(1, "PC", 5, 150.00);
            Produit produit2 = new Produit(2, "Souris", 15, 15.00);

            // Test adding Produit to a list 
            fournisseur.Produits.Add(produit);
            fournisseur.Produits.Add(produit2);
            var resultSizeofProduits = fournisseur.Produits.Count;
            Assert.AreEqual(resultSizeofProduits, 2);

            // Test adding Produit to a list 
            Produit produit3 = new Produit(3, "Clavier", 5, 10.00);
            fournisseur.Produits.Add(produit3);
            var newResultSizeofProduits = fournisseur.Produits.Count;
            Assert.AreEqual(newResultSizeofProduits, 3);

            // Test Produit names in a list
            var designationProduit = fournisseur.Produits[0].Designation;
            var designationProduit2 = fournisseur.Produits[1].Designation;
            Assert.AreEqual(designationProduit, "PC");
            Assert.AreEqual(designationProduit2, "Souris");
        }

        [TestMethod()]
        public void FournisseurSetAttributesTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "testRaisonSocial", "testAdresse", new List<Produit>());

            fournisseur.Id = 99;
            fournisseur.RaisonSocial = "newRaisonSocial";
            fournisseur.Adresse = "newAdresse";
            // Test Fournisseur attributes
            Assert.AreEqual(fournisseur.Id, 99);
            Assert.AreEqual(fournisseur.RaisonSocial, "newRaisonSocial");
            Assert.AreEqual(fournisseur.Adresse, "newAdresse");
        }
    }
}