using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Suivi (suivi d'une commande)
    /// </summary>
    public class Suivi
    {
        public string EtapeSuivi { get; set; }
        public string Id { get; set; }

        public Suivi(string id, string etapeSuivi)
        {
            this.Id = id;
            this.EtapeSuivi = etapeSuivi;   
        }
    }
}
