using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Villa : Appartamento
    {
        private int dimensioneGiardinoMq;
        public Villa(string indirizzo, string cap, string citta, double superficie, int numeroVani, int numeroBagni, int dimensioneGiardinoMq) : base(indirizzo, cap, citta, superficie, numeroVani, numeroBagni)
        {
            this.dimensioneGiardinoMq = dimensioneGiardinoMq;
        }

        public override string ToString()
        {
string descrizione = base.ToString()+$@"Dimensione del Giardino:{dimensioneGiardinoMq}mq;
";
            return descrizione;
        }
    }
}
