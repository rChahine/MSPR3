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
    public class Client_Tests
    {
        private readonly Produit produitLJ = new Produit(1, "Livret jeune", 1, 0);
        private readonly Produit produitLivretA = new Produit(2, "Livret A", 1, 0);
        private readonly Produit produitCompteBasique = new Produit(3, "Compte basique", 1, 0);
        private readonly Produit produitCompteCommun = new Produit(4, "Compte commun", 1, 0);
        private readonly Produit produitCarteBasique = new Produit(5, "Carte basique", 1, 0);
        private readonly Produit produitSilverCard = new Produit(6, "Silver Card", 1, 0);
        private readonly Produit produitGoldCard = new Produit(7, "Gold Card", 1, 0);
        private readonly Produit produitBlackCard = new Produit(8, "Black Card", 1, 0);

        [TestMethod()]
        public void ClientTests()
        {
            //DatTime(Year, Month, Day)
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);
            Assert.IsInstanceOfType(client, typeof(Client));
        }

        [TestMethod()]
        public void ClientAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);

            // Test Client attributes
            Assert.AreEqual(client.Id, 1);
            Assert.AreEqual(client.Prenom, "Jean");
            Assert.AreEqual(client.Nom, "Pierre");
            Assert.AreEqual(client.DateNaiss, dateNaiss);
            Assert.AreEqual(client.SalaireAnnuel, 16000);
            Assert.AreEqual(client.PieceIdValide, false);
            Assert.AreEqual(client.JustificatifActiviteValide, false);
            Assert.AreEqual(client.JustificatifDomicileValide, false);
        }

        [TestMethod()]
        public void ClientSetAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);

            var NewDateNaiss = new DateTime(2000, 4, 25);
            client.Id = 99;
            client.Prenom = "Cyril";
            client.Nom = "Prost";
            client.DateNaiss = NewDateNaiss;
            client.SalaireAnnuel = 26000;
            client.PieceIdValide = true;
            client.JustificatifActiviteValide = true;
            client.JustificatifDomicileValide = true;
            // Test Client attributes
            Assert.AreEqual(client.Id, 99);
            Assert.AreEqual(client.Prenom, "Cyril");
            Assert.AreEqual(client.Nom, "Prost");
            Assert.AreEqual(client.DateNaiss, NewDateNaiss);
            Assert.AreEqual(client.SalaireAnnuel, 26000);
            Assert.AreEqual(client.PieceIdValide, true);
            Assert.AreEqual(client.JustificatifActiviteValide, true);
            Assert.AreEqual(client.JustificatifDomicileValide, true);
        }

        [TestMethod()]
        public void ClientDateAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);

            Assert.AreEqual(client.DateNaiss.Year, 1996);
            Assert.AreEqual(client.DateNaiss.Month, 3);
            Assert.AreEqual(client.DateNaiss.Day, 22);
        }

        [TestMethod()]
        public void ClientEligible25YoTests()
        {
            // Client 25 year old, 16000 RA
            var year25yo = DateTime.Now.Year - 25;
            var dateNaiss = new DateTime(year25yo, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);
            
            //-----EstEligible Livret Jeune------
            Assert.IsFalse(client.EstEligible(produitLJ));

            client.PieceIdValide = true;
            client.JustificatifActiviteValide = true;
            client.JustificatifDomicileValide = true;

            Assert.IsTrue(client.EstEligible(produitLJ));

            //-----EstEligible Livret A------
            Assert.IsTrue(client.EstEligible(produitLivretA));

            //-----EstEligible Compte basique------
            Assert.IsTrue(client.EstEligible(produitCompteBasique));

            //-----EstEligible Compte commune------
            client.JustificatifActiviteValide = false;
            Assert.IsFalse(client.EstEligible(produitCompteCommun));
            client.JustificatifActiviteValide = true;
            Assert.IsTrue(client.EstEligible(produitCompteCommun));

            //-----EstEligible Compte basique------
            Assert.IsTrue(client.EstEligible(produitCarteBasique));
            //-----EstEligible Compte basique------
            Assert.IsFalse(client.EstEligible(produitSilverCard));
            //-----EstEligible Compte basique------
            Assert.IsFalse(client.EstEligible(produitGoldCard));
            //-----EstEligible Compte basique------
            Assert.IsFalse(client.EstEligible(produitBlackCard));
        }

        [TestMethod()]
        public void ClientEligible46YoTests()
        {
            // Client 46 year old, 36000 RA
            var year25yo = DateTime.Now.Year - 46;
            var dateNaiss = new DateTime(year25yo, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 36000, false, false, false);

            //-----EstEligible Livret Jeune------
            Assert.IsFalse(client.EstEligible(produitLJ));

            client.PieceIdValide = true;
            client.JustificatifActiviteValide = true;
            client.JustificatifDomicileValide = true;

            //-----EstEligible Livret A------
            Assert.IsTrue(client.EstEligible(produitLivretA));

            //-----EstEligible Compte basique------
            Assert.IsTrue(client.EstEligible(produitCompteBasique));

            //-----EstEligible Compte commune------
            client.JustificatifActiviteValide = false;
            Assert.IsFalse(client.EstEligible(produitCompteCommun));
            client.JustificatifActiviteValide = true;
            Assert.IsTrue(client.EstEligible(produitCompteCommun));

            //-----EstEligible Compte basique------
            Assert.IsTrue(client.EstEligible(produitCarteBasique));
            //-----EstEligible Compte basique------
            Assert.IsTrue(client.EstEligible(produitSilverCard));
            //-----EstEligible Compte basique------
            Assert.IsTrue(client.EstEligible(produitGoldCard));
            //-----EstEligible Compte basique------
            Assert.IsFalse(client.EstEligible(produitBlackCard));
        }
    }
}