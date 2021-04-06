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
            Client client = new Client(1, "Jean", "Pierre", dateNaiss);
            Assert.IsInstanceOfType(client, typeof(Client));
        }

        [TestMethod()]
        public void ClientAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss);
            var resultId = client.Id;
            var resultPrenom = client.Prenom;
            var resultNom = client.Nom;
            var resultDateNaiss = client.DateNaiss;
            // Test Client attributes
            Assert.AreEqual(resultId, 1);
            Assert.AreEqual(resultPrenom, "Jean");
            Assert.AreEqual(resultNom, "Pierre");
            Assert.AreEqual(resultDateNaiss, dateNaiss);
        }

        [TestMethod()]
        public void ClientSetAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss);

            var NewDateNaiss = new DateTime(2000, 4, 25);
            client.Id = 99;
            client.Prenom = "Cyril";
            client.Nom = "Prost";
            client.DateNaiss = NewDateNaiss;
            // Test Client attributes
            Assert.AreEqual(client.Id, 99);
            Assert.AreEqual(client.Prenom, "Cyril");
            Assert.AreEqual(client.Nom, "Prost");
            Assert.AreEqual(client.DateNaiss, NewDateNaiss);
        }

        [TestMethod()]
        public void ClientDateAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss);

            Assert.AreEqual(client.DateNaiss.Year, 1996);
            Assert.AreEqual(client.DateNaiss.Month, 3);
            Assert.AreEqual(client.DateNaiss.Day, 22);
        }
    }
}