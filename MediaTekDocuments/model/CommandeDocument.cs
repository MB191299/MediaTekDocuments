using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class CommandeDocument : Commande
    {

        public int NbExemplaire { get; set; }
        public string IdLivreDvd { get; set; }
        public string EtapeSuivi { get; set; }

        public CommandeDocument(string id, DateTime dateCommande, double montant, int nbExemplaire, string idLivreDvd, string etapeSuivi)
            : base(id, montant, dateCommande)
        {
            this.IdLivreDvd = idLivreDvd;
            this.NbExemplaire = nbExemplaire;
            this.EtapeSuivi = etapeSuivi;
        }
    }
}
