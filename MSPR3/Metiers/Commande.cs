using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers
{
    public class Commande
    {
        private int id;
        private DateTime date;
        private List<Dictionary<Produit, int>> produits; // TODO A verifier avec la team


        # region getters and setters 
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<Dictionary<Produit, int>> Produits { get => produits; set => produits = value; }
        #endregion

        public Commande(int id, DateTime date, List<Dictionary<Produit, int>> produits)
        {
            this.id = id;
            this.date = date;
            this.produits = produits;
        }

        
    }
}
