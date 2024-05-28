using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Commande (commmande d'un document)
    /// </summary>
    public class Commande
    {
        public double Montant { get; set; }
        public DateTime DateCommande { get; set; }
        public string Id { get; set; }

        public Commande(string id, double montant, DateTime dateCommande)
        {
            this.Montant = montant;
            this.DateCommande = dateCommande;
            this.Id = id;
        }

    }
}
