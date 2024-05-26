using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class CommandeDocument : Commande
    {

        public int NbExemplaires { get; set; }
        public string IdLivreDvd { get; set; }
        public string EtapeSuivi { get; set; }

        public CommandeDocument(string id, DateTime dateCmd, double montant, int nbExemplaires, string idLivreDvd, string etapeSuivi)
            : base(id, montant, dateCmd)
        {
            this.IdLivreDvd = idLivreDvd;
            this.NbExemplaires = nbExemplaires;
            this.EtapeSuivi = etapeSuivi;
        }
    }
}
