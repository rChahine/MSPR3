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
    public class Service_Tests
    {
        [TestMethod()]
        public void ServiceTests()
        {
            Service service = new Service(1, "RH", new List<Salarie>());
            Assert.IsInstanceOfType(service, typeof(Service));
        }

        [TestMethod()]
        public void ServiceAttributesTests()
        {
            Service service = new Service(1, "RH", new List<Salarie>());
            var resultId = service.Id;
            var resultDesignation = service.Designation;
            // Test Service attributes
            Assert.AreEqual(resultId, 1);
            Assert.AreEqual(resultDesignation, "RH");
        }

        [TestMethod()]
        public void ServiceSetAttributesTests()
        {
            Service service = new Service(1, "RH", new List<Salarie>());

            service.Id = 99;
            service.Designation = "RessHum";
            // Test Service attributes
            Assert.AreEqual(service.Id, 99);
            Assert.AreEqual(service.Designation, "RessHum");
        }

        [TestMethod()]
        public void ServiceListSalarieTests()
        {
            // Test Fournisseur attribute List<Produit>()
            Service service = new Service(1, "RH", new List<Salarie>());
            var dateNaissSalarie = new DateTime(1996, 3, 22);
            var dateNaissSalarie2 = new DateTime(1992, 9, 4);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaissSalarie);
            Salarie salarie2 = new Salarie(1, "Astrid", "Boboulard", dateNaissSalarie2);

            // Test adding Produit to a list 
            service.Salaries.Add(salarie);
            service.Salaries.Add(salarie2);
            var resultSizeofProduits = service.Salaries.Count;
            Assert.AreEqual(resultSizeofProduits, 2);

            // Test adding Produit to a list 
            var dateNaissSalarie3 = new DateTime(1985, 5, 21);
            Salarie salarie3 = new Salarie(1, "Didier", "Trousse", dateNaissSalarie3);
            service.Salaries.Add(salarie3);
            var newResultSizeofProduits = service.Salaries.Count;
            Assert.AreEqual(newResultSizeofProduits, 3);

            // Test Produit names in a list
            var designationProduit = service.Salaries[0].Nom;
            var designationProduit2 = service.Salaries[1].Prenom;
            Assert.AreEqual(designationProduit, "Pierre");
            Assert.AreEqual(designationProduit2, "Astrid");
        }
    }
}