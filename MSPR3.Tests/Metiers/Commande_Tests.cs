using System;
using System.Collections.Generic;
using Xunit;


namespace MSPR3.Metiers.Tests
{
    public class Commande_Tests
    {
        [Fact]
        public void CommandeTests()
        {
            //DatTime(Year, Month, Day)
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new Dictionary<Produit, int>());
            Assert.IsType<Commande>(commande);
        }

        [Fact]
        public void CommandeAttributesTests()
        {
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new Dictionary<Produit, int>());

            // Test Commande attributes
            Assert.Equal(1, commande.Id);
            Assert.Equal(commande.Date, date);
        }

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

        [Fact]
        public void CommandeListSalarieTests()
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