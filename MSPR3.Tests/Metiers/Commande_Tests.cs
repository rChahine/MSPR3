using System;
using System.Collections.Generic;
using Xunit;


namespace MSPR3.Metiers.Tests
{
    /// <summary>
    /// Classe Commande_Tests
    /// </summary>
    public class Commande_Tests
    {
        /// <summary>
        /// Test le type de la classe Commande
        /// </summary>
        [Fact]
        public void CommandeTests()
        {
            //DatTime(Year, Month, Day)
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new Dictionary<Produit, int>());
            Assert.IsType<Commande>(commande);
        }

        /// <summary>
        /// Test les attributs de la classe Client
        /// </summary>
        [Fact]
        public void CommandeAttributesTests()
        {
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new Dictionary<Produit, int>());

            // Test Commande attributes
            Assert.Equal(1, commande.Id);
            Assert.Equal(commande.Date, date);
        }

        /// <summary>
        /// Test le changement d'un attribut avec les setters
        /// </summary>
        [Fact]
        public void CommandeSetAttributesTests()
        {
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new Dictionary<Produit, int>());

            var NewDate = new DateTime(2021, 4, 25);
            commande.Id = 99;
            commande.Date = NewDate;
            // Test Commande attributes
            Assert.Equal(99, commande.Id);
            Assert.Equal(commande.Date, NewDate);
        }

        /// <summary>
        /// Test la liste et l'ajout dans la liste des Produit d'une Commande
        /// </summary>
        [Fact]
        public void CommandeListProduitTests()
        {
            // Test Commande attribute List<Dictionary<Produit, int>>()
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new Dictionary<Produit, int>());

            //Produit, quantite
            Dictionary<Produit, int> dicoProd = new Dictionary<Produit, int>();

            Produit produit = new Produit(1, "PC", 5, 150.00);
            Produit produit2 = new Produit(2, "Souris", 15, 15.00);

            // Test adding Produit to a Dictionary 
            commande.Produits.Add(produit, 5);
            commande.Produits.Add(produit2, 2);
            Assert.Equal(2, commande.Produits.Count);

        }
    }
}