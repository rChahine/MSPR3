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
    public class Salarie_Tests
    {
        [TestMethod()]
        public void SalarieTests()
        {
            //DatTime(Year, Month, Day)
            var dateNaiss = new DateTime(1996, 3, 22);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaiss);
            Assert.IsInstanceOfType(salarie, typeof(Salarie));
        }

        [TestMethod()]
        public void SalarieAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaiss); 
            var resultId = salarie.Id;
            var resultPrenom = salarie.Prenom;
            var resultNom = salarie.Nom;
            var resultDateNaiss = salarie.DateNaiss;
            // Test Salarie attributes
            Assert.AreEqual(resultId, 1);
            Assert.AreEqual(resultPrenom, "Jean");
            Assert.AreEqual(resultNom, "Pierre");
            Assert.AreEqual(resultDateNaiss, dateNaiss);
        }

        [TestMethod()]
        public void SalarieSetAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaiss);

            var NewDateNaiss = new DateTime(2000, 4, 25);
            salarie.Id = 99;
            salarie.Prenom = "Cyril";
            salarie.Nom = "Prost";
            salarie.DateNaiss = NewDateNaiss;
            // Test Salarie attributes
            Assert.AreEqual(salarie.Id, 99);
            Assert.AreEqual(salarie.Prenom, "Cyril");
            Assert.AreEqual(salarie.Nom, "Prost");
            Assert.AreEqual(salarie.DateNaiss, NewDateNaiss);
        }

        [TestMethod()]
        public void SalarieDateAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaiss);

            Assert.AreEqual(salarie.DateNaiss.Year, 1996);
            Assert.AreEqual(salarie.DateNaiss.Month, 3);
            Assert.AreEqual(salarie.DateNaiss.Day, 22);
        }
    }
}