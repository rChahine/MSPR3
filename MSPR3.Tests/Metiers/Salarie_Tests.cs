using System;
using System.Collections.Generic;
using Xunit;

namespace MSPR3.Metiers.Tests
{
    /// <summary>
    /// Classe Salarie_Tests
    /// </summary>
    public class Salarie_Tests
    {
        /// <summary>
        /// Test le type de la classe Salarie
        /// </summary>
        [Fact]
        public void SalarieTests()
        {
            //DatTime(Year, Month, Day)
            var dateNaiss = new DateTime(1996, 3, 22);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaiss);
            Assert.IsType<Salarie>(salarie);
        }

        /// <summary>
        /// Test les attributs de la classe Salarie
        /// </summary>
        [Fact]
        public void SalarieAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaiss); 

            // Test Salarie attributes
            Assert.Equal(1, salarie.Id);
            Assert.Equal("Jean", salarie.Prenom);
            Assert.Equal("Pierre", salarie.Nom);
            Assert.Equal(salarie.DateNaiss, dateNaiss);
        }

        // <summary>
        /// Test le changement d'un attribut avec les setters
        /// </summary>
        [Fact]
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
            Assert.Equal(99, salarie.Id);
            Assert.Equal("Cyril", salarie.Prenom);
            Assert.Equal("Prost", salarie.Nom);
            Assert.Equal(expected: salarie.DateNaiss, NewDateNaiss);
        }

        /// <summary>
        /// Test la date de naissance d'un Salarie
        /// </summary>
        [Fact]
        public void SalarieDateAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Salarie salarie = new Salarie(1, "Jean", "Pierre", dateNaiss);

            Assert.Equal(1996, salarie.DateNaiss.Year);
            Assert.Equal(3, salarie.DateNaiss.Month);
            Assert.Equal(22, salarie.DateNaiss.Day);
        }
    }
}