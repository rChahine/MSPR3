using System;
using System.Collections.Generic;
using Xunit;

namespace MSPR3.Metiers.Tests
{
    /// <summary>
    /// Classe Fournisseur_Tests
    /// </summary>
    public class Fournisseur_Tests
    {
        /// <summary>
        /// Test le type de la classe Fournisseur
        /// </summary>
        [Fact]
        public void FournisseurTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "test", "test", null);
            Assert.IsType<Fournisseur>(fournisseur);
        }

        /// <summary>
        /// Test les attributs de la classe Fournisseur
        /// </summary>
        [Fact]
        public void FournisseurAttributesTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "testRaisonSocial", "testAdresse", new List<Produit>());

            // Test Fournisseur attributes
            Assert.Equal("testAdresse", fournisseur.Adresse);
            Assert.Equal(1, fournisseur.Id);
            Assert.Equal("testRaisonSocial", fournisseur.RaisonSocial);
        }

        /// <summary>
        /// Test la liste et l'ajout dans la liste des produit d'un Fournisseur
        /// </summary>
        [Fact]
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
            Assert.Equal(2, resultSizeofProduits);

            // Test adding Produit to a list 
            Produit produit3 = new Produit(3, "Clavier", 5, 10.00);
            fournisseur.Produits.Add(produit3);
            var newResultSizeofProduits = fournisseur.Produits.Count;
            Assert.Equal(3, newResultSizeofProduits);

            // Test Produit names in a list
            var designationProduit = fournisseur.Produits[0].Designation;
            var designationProduit2 = fournisseur.Produits[1].Designation;
            Assert.Equal("PC", designationProduit);
            Assert.Equal("Souris", designationProduit2);
        }

        /// <summary>
        /// Test le changement d'un attribut avec les setters
        /// </summary>
        [Fact]
        public void FournisseurSetAttributesTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "testRaisonSocial", "testAdresse", new List<Produit>());

            fournisseur.Id = 99;
            fournisseur.RaisonSocial = "newRaisonSocial";
            fournisseur.Adresse = "newAdresse";
            // Test Fournisseur attributes
            Assert.Equal(99, fournisseur.Id);
            Assert.Equal("newRaisonSocial", fournisseur.RaisonSocial);
            Assert.Equal("newAdresse", fournisseur.Adresse);
        }
    }
}