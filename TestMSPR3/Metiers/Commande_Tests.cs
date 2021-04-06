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
    public class Commande_Tests
    {
        [TestMethod()]
        public void CommandeTests()
        {
            //DatTime(Year, Month, Day)
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new List<Dictionary<Produit, int>>());
            Assert.IsInstanceOfType(commande, typeof(Commande));
        }

        [TestMethod()]
        public void CommandeAttributesTests()
        {
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new List<Dictionary<Produit, int>>());
            var resultId = commande.Id;
            var resultDate = commande.Date;
            // Test Commande attributes
            Assert.AreEqual(resultId, 1);
            Assert.AreEqual(resultDate, date);
        }

        [TestMethod()]
        public void CommandeSetAttributesTests()
        {
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new List<Dictionary<Produit, int>>());

            var NewDate = new DateTime(2021, 4, 25);
            commande.Id = 99;
            commande.Date = NewDate;
            // Test Commande attributes
            Assert.AreEqual(commande.Id, 99);
            Assert.AreEqual(commande.Date, NewDate);
        }

        [TestMethod()]
        public void CommandeListSalarieTests()
        {
            // Test Commande attribute List<Dictionary<Produit, int>>()
            var date = new DateTime(2021, 4, 6);
            Commande commande = new Commande(1, date, new List<Dictionary<Produit, int>>());

            List<Dictionary<Produit, int>> listDicoProd = new List<Dictionary<Produit, int>>();

            //Produit, quantite
            Dictionary<Produit, int> dicoProd = new Dictionary<Produit, int>();

            Produit produit = new Produit(1, "PC", 5, 150.00);
            Produit produit2 = new Produit(2, "Souris", 15, 15.00);

            // Test adding Produit to a Dictionary 
            dicoProd.Add(produit, 5);
            dicoProd.Add(produit2, 2);
            Assert.AreEqual(dicoProd.Count, 2);

            // Test adding Dictionary to a list 
            listDicoProd.Add(dicoProd);

            Assert.AreEqual(listDicoProd.Count, 1);

        }
    }
}