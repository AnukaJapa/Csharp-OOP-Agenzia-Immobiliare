using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Box : Immobile
    {
        private int numeroAuto;
        public Box(string indirizzo, string cap, string citta, double superficie, int numeroAuto) : base(indirizzo, cap, citta, superficie)
        {
            this.numeroAuto = numeroAuto;
        }

        //GETTERS
        public int getnumeroAuto()
        {
            return numeroAuto;
        }
        
        //SETTERS
        public void SetNumeroAuto(int numeroAuto)
        {
            this.numeroAuto = numeroAuto;
        }

        public override string ToString()
        {

            string descrizione = base.ToString() + $@"Numero Auto : {numeroAuto}
";
            return descrizione;
        }
    }
}
