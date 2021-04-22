using System;
using System.Collections.Generic;
using Xunit;

namespace MSPR3.Metiers.Tests
{
    /// <summary>
    /// Classe Produit_Tests
    /// </summary>
    public class Produit_Tests
    {
        /// <summary>
        /// Test le type de la classe Produit
        /// </summary>
        [Fact]
        public void ProduitTests()
        {
            Produit produit = new Produit(1, "PC", 5, 150.00);
            Assert.IsType<Produit>(produit);
        }

        /// <summary>
        /// Test les attributs de la classe Produit
        /// </summary>
        [Fact]
        public void ProduitAttributesTests()
        {
            Produit produit = new Produit(1, "PC", 5, 150.00);

            // Test Produit attributes
            Assert.Equal(1, produit.Id);
            Assert.Equal("PC", produit.Designation);
            Assert.Equal(5, produit.Quantite);
            Assert.Equal(150.00, produit.Prix);
        }

        /// <summary>
        /// Test le changement d'un attribut avec les setters
        /// </summary>
        [Fact]
        public void ProduitSetAttributesTests()
        {
            Produit produit = new Produit(1, "PC", 5, 150.00);

            produit.Id = 99;
            produit.Designation = "Carte";
            produit.Quantite = 1;
            produit.Prix = 45;
            // Test Produit attributes
            Assert.Equal(99, produit.Id);
            Assert.Equal("Carte", produit.Designation);
            Assert.Equal(1, produit.Quantite);
            Assert.Equal(45, produit.Prix);
        }
    }
}