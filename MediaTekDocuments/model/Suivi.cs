using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Suivi (suivi d'une commande)
    /// </summary>
    public class Suivi
    {
        public string EtapeSuivi { get; set; }
        public string CommandeDocumentId { get; set; }
        public string Id { get; set; }

        public Suivi(string etapeSuivi, string commandeDocumentId, string id)
        {
            this.EtapeSuivi = etapeSuivi;
            this.CommandeDocumentId = commandeDocumentId;
            this.Id = id;
        }
    }
}
