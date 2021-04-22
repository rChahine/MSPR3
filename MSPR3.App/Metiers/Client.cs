using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers
{
    /// <summary>
    /// Classe Client
    /// </summary>
    public class Client
    {
        private int id;
        private string prenom;
        private string nom;
        private DateTime dateNaiss;
        private int salaireAnnuel;
        private bool pieceIdValide;
        private bool justificatifDomicileValide;
        private bool justificatifActiviteValide;

        #region getters and setters
        public int Id { get => id; set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public int SalaireAnnuel { get => salaireAnnuel; set => salaireAnnuel = value; }
        public bool PieceIdValide { get => pieceIdValide; set => pieceIdValide = value; }
        public bool JustificatifDomicileValide { get => justificatifDomicileValide; set => justificatifDomicileValide = value; }
        public bool JustificatifActiviteValide { get => justificatifActiviteValide; set => justificatifActiviteValide = value; }
        #endregion

        /// <summary>
        /// Constructeur de la classe Client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="dateNaiss"></param>
        /// <param name="salaireAnnuel"></param>
        /// <param name="pieceIdValide"></param>
        /// <param name="justificatifDomicileValide"></param>
        /// <param name="justificatifActiviteValide"></param>
        public Client(int id, string prenom, string nom, DateTime dateNaiss, int salaireAnnuel, bool pieceIdValide, bool justificatifDomicileValide, bool justificatifActiviteValide)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.dateNaiss = dateNaiss;
            this.salaireAnnuel = salaireAnnuel;
            this.pieceIdValide = pieceIdValide;
            this.justificatifDomicileValide = justificatifDomicileValide;
            this.justificatifActiviteValide = justificatifActiviteValide;
        }
        
        /// <summary>
        /// Retourne si le Client est éligible a un Produit
        /// </summary>
        /// <param name="produit"></param>
        /// <returns>Retourne false ou true</returns>
        public bool EstEligible(Produit produit) 
        {
            switch (produit.Designation)
            {
                case "Livret jeune":
                    if (CalculAge() <= 25 && PeutEtreEligible())
                        return true;
                    else
                        return false;
                case "Livret A":
                    if (PeutEtreEligible())
                        return true;
                    else
                        return false;
                case "Compte basique":
                    if (PeutEtreEligible())
                        return true;
                    else
                        return false;
                case "Compte commun":
                    if (PeutEtreEligible() && justificatifActiviteValide)
                        return true;
                    else
                        return false;
                case "Carte basique":
                    if (CalculAge() >= 16 && PeutEtreEligible())
                        return true;
                    else
                        return false;
                case "Silver Card":
                    if (CalculAge() >= 18 && PeutEtreEligible() && justificatifActiviteValide && salaireAnnuel >= 28000)
                        return true;
                    else
                        return false;
                case "Gold Card":
                    if (CalculAge() >= 23 && PeutEtreEligible() && justificatifActiviteValide && salaireAnnuel >= 35000)
                        return true;
                    else
                        return false;
                case "Black Card":
                    if (CalculAge() >= 26 && PeutEtreEligible() && justificatifActiviteValide && salaireAnnuel >= 80000)
                        return true;
                    else
                        return false;
                default :
                    return false;
            }
        }

        /// <summary>
        /// Retourne l'age du Client
        /// </summary>
        /// <returns>Retourne age</returns>
        public int CalculAge()
        {
            int age = DateTime.Now.Year - DateNaiss.Year;
            return age;
        }

        /// <summary>
        /// Retourne si le Client peut être éligible en fonction si piece d'identité et justificatif domicile sont ok
        /// </summary>
        /// <returns>Retourne false ou true</returns>
        public bool PeutEtreEligible()
        {
            return pieceIdValide && justificatifDomicileValide;
        }
    }
}
