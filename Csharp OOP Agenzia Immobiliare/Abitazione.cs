using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Abitazione : Immobile
    {
        private int numeroVani;
        private int numeroBagni;

        public Abitazione(string indirizzo, string cap, string citta, double superficie, int numeroVani, int numeroBagni) : base(indirizzo, cap, citta, superficie)
        {
            this.numeroBagni= numeroBagni;
            this.numeroVani= numeroVani;
        }

        //GETTERS
       public int GetNumeroVani()
        {
            return numeroVani;
        }
       public int GetNumeroBagni()
        {
            return numeroBagni;
        }
        //SETTERS
       public void SetNumeroBagni(int numeroBagni)
        {
            this.numeroBagni= numeroBagni;
        }
       public void SetNumeroVani(int numeroVani)
        {
            this.numeroVani = numeroVani;
        }

        //PUBLIC METHODS
        public override string ToString()
        {
            string descrizione = base.ToString() +$@"numero Vani: {numeroVani}
numero Bagni: {numeroBagni}
";
            return descrizione;
        }
    }
}
