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
    }
}