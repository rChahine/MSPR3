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
    public class Fournisseur_Tests
    {
        [TestMethod()]
        public void FournisseurTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "test", "test", null);
            Assert.IsInstanceOfType(fournisseur, typeof(Fournisseur));
        }

        [TestMethod()]
        public void FournisseurAttributesTests()
        {
            Fournisseur fournisseur = new Fournisseur(1, "test", "test", null);
            var result = fournisseur.Adresse;
            Assert.AreEqual(result, "test");
        }
    }
}