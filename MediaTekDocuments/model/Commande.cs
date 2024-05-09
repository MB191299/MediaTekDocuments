using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Commande (commmande d'un document)
    /// </summary>
    public class Commande
    {
        public double Montant { get; set; }
        public DateTime DateCmd { get; set; }
        public string Id { get; set; }

        public Commande(string id, double montant, DateTime dateCmd)
        {
            this.Montant = montant;
            this.DateCmd = dateCmd;
            this.Id = id;
        }

    }
}
