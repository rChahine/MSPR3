using System;
using Xunit;


namespace MSPR3.Metiers.Tests
{
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

        [Fact]
        public void ClientTests()
        {
            //DatTime(Year, Month, Day)
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);
            Assert.IsType<Client>(client);
        }

        [Fact]
        public void ClientAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);

            // Test Client attributes
            Assert.Equal(1, client.Id);
            Assert.Equal("Jean", client.Prenom);
            Assert.Equal("Pierre", client.Nom);
            Assert.Equal(expected: client.DateNaiss, dateNaiss);
            Assert.Equal(16000, client.SalaireAnnuel);
            Assert.False(client.PieceIdValide);
            Assert.False(client.JustificatifActiviteValide);
            Assert.False(client.JustificatifDomicileValide);
        }

        [Fact]
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
            Assert.Equal(99, client.Id);
            Assert.Equal("Cyril", client.Prenom);
            Assert.Equal("Prost", client.Nom);
            Assert.Equal(client.DateNaiss, NewDateNaiss);
            Assert.Equal(26000, client.SalaireAnnuel);
            Assert.True(client.PieceIdValide);
            Assert.True(client.JustificatifActiviteValide);
            Assert.True(client.JustificatifDomicileValide);
        }

        [Fact]
        public void ClientDateAttributesTests()
        {
            var dateNaiss = new DateTime(1996, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);

            Assert.Equal(1996, client.DateNaiss.Year);
            Assert.Equal(3, client.DateNaiss.Month);
            Assert.Equal(22, client.DateNaiss.Day);
        }

        [Fact]
        public void ClientEligible25YoTests()
        {
            // Client 25 year old, 16000 RA
            var year25yo = DateTime.Now.Year - 25;
            var dateNaiss = new DateTime(year25yo, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 16000, false, false, false);
            
            //-----EstEligible Livret Jeune------
            Assert.False(client.EstEligible(produitLJ));

            client.PieceIdValide = true;
            client.JustificatifActiviteValide = true;
            client.JustificatifDomicileValide = true;

            Assert.True(client.EstEligible(produitLJ));

            //-----EstEligible Livret A------
            Assert.True(client.EstEligible(produitLivretA));

            //-----EstEligible Compte basique------
            Assert.True(client.EstEligible(produitCompteBasique));

            //-----EstEligible Compte commune------
            client.JustificatifActiviteValide = false;
            Assert.False(client.EstEligible(produitCompteCommun));
            client.JustificatifActiviteValide = true;
            Assert.True(client.EstEligible(produitCompteCommun));

            //-----EstEligible Compte basique------
            Assert.True(client.EstEligible(produitCarteBasique));
            //-----EstEligible Compte basique------
            Assert.False(client.EstEligible(produitSilverCard));
            //-----EstEligible Compte basique------
            Assert.False(client.EstEligible(produitGoldCard));
            //-----EstEligible Compte basique------
            Assert.False(client.EstEligible(produitBlackCard));
        }

        [Fact]
        public void ClientEligible46YoTests()
        {
            // Client 46 year old, 36000 RA
            var year25yo = DateTime.Now.Year - 46;
            var dateNaiss = new DateTime(year25yo, 3, 22);
            Client client = new Client(1, "Jean", "Pierre", dateNaiss, 36000, false, false, false);

            //-----EstEligible Livret Jeune------
            Assert.False(client.EstEligible(produitLJ));

            client.PieceIdValide = true;
            client.JustificatifActiviteValide = true;
            client.JustificatifDomicileValide = true;

            //-----EstEligible Livret A------
            Assert.True(client.EstEligible(produitLivretA));

            //-----EstEligible Compte basique------
            Assert.True(client.EstEligible(produitCompteBasique));

            //-----EstEligible Compte commune------
            client.JustificatifActiviteValide = false;
            Assert.False(client.EstEligible(produitCompteCommun));
            client.JustificatifActiviteValide = true;
            Assert.True(client.EstEligible(produitCompteCommun));

            //-----EstEligible Compte basique------
            Assert.True(client.EstEligible(produitCarteBasique));
            //-----EstEligible Compte basique------
            Assert.True(client.EstEligible(produitSilverCard));
            //-----EstEligible Compte basique------
            Assert.True(client.EstEligible(produitGoldCard));
            //-----EstEligible Compte basique------
            Assert.False(client.EstEligible(produitBlackCard));
        }
    }
}