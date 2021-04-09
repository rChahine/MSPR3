using System;
using System.Collections.Generic;
using Xunit;

namespace MSPR3.Metiers.Tests
{
    public class Service_Tests
    {
        [Fact]
        public void ServiceTests()
        {
            Service service = new Service(1, "RH", new List<Salarie>());
            Assert.IsType<Service>(service);
        }

        [Fact]
        public void ServiceAttributesTests()
        {
            Service service = new Service(1, "RH", new List<Salarie>());

            // Test Service attributes
            Assert.Equal(1, service.Id);
            Assert.Equal("RH", service.Designation);
        }

        [Fact]
        public void ServiceSetAttributesTests()
        {
            Service service = new Service(1, "RH", new List<Salarie>());
            // Set Id, Designation
            service.Id = 99;
            service.Designation = "RessHum";
            // Test Service attributes
            Assert.Equal(99, service.Id);
            Assert.Equal("RessHum", service.Designation);
        }

        [Fact]
        public void ServiceListSalarieTests()
        {
            // Test Servcie attribute List<Salarie>()
            Service service = new Service(1, "RH", new List<Salarie>());
            var dateNaissSalarie = new DateTime(1996, 3, 22);
            var dateNaissSalarie2 = new DateTime(1992, 9, 4);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaissSalarie);
            Salarie salarie2 = new Salarie(1, "Astrid", "Boboulard", dateNaissSalarie2);

            // Test adding Produit to a list 
            service.Salaries.Add(salarie);
            service.Salaries.Add(salarie2);
            var resultSizeofProduits = service.Salaries.Count;
            Assert.Equal(2, resultSizeofProduits);

            // Test adding Produit to a list 
            var dateNaissSalarie3 = new DateTime(1985, 5, 21);
            Salarie salarie3 = new Salarie(1, "Didier", "Trousse", dateNaissSalarie3);
            service.Salaries.Add(salarie3);
            var newResultSizeofProduits = service.Salaries.Count;
            Assert.Equal(3, newResultSizeofProduits);

            // Test Produit names in a list
            var designationProduit = service.Salaries[0].Nom;
            var designationProduit2 = service.Salaries[1].Prenom;
            Assert.Equal("Pierre", designationProduit);
            Assert.Equal("Astrid", designationProduit2);
        }
    }
}