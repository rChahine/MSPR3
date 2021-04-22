using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers
{
    /// <summary>
    /// Classe Fournisseur
    /// </summary>
    public class Fournisseur
    {
        private int id;
        private string raisonSocial;
        private string adresse;
        private List<Produit> produits;


        #region getters and setters
        public int Id { get => id; set => id = value; }
        public string RaisonSocial { get => raisonSocial; set => raisonSocial = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Produit> Produits { get => produits; set => produits = value; }
        #endregion

        /// <summary>
        /// Constructeur de la classe Fournisseur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="raisonSocial"></param>
        /// <param name="adresse"></param>
        /// <param name="produits"></param>
        public Fournisseur(int id, string raisonSocial, string adresse, List<Produit> produits)
        {
            this.id = id;
            this.raisonSocial = raisonSocial;
            this.adresse = adresse;
            this.produits = produits;
        }
        
    }
}
