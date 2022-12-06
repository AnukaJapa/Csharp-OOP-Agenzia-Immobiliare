using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Immobile
    {
        private string codice;
        private string indirizzo;
        private string cap;
        private string citta;
        private double superficie;

        public Immobile(string indirizzo, string cap, string citta, double superficie)
        {
            this.codice = GeneraCodice();
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.citta = citta;
            this.superficie = superficie;
        }

        //GETTERS
        public string GetCodice()
        {
            return codice;
        }
        public string GetIndirizzo()
        {
            return indirizzo;
        }

        public string GetCap() { 
           return cap;
        }

        public string GetCitta()
        {
            return citta;
        }

        public double GetSuperficie()
        {
            return superficie;
        }

        //SETTERS
        public void SetSuperficie(int superficie)
        {
            if(superficie > 0)
            {
                this.superficie = superficie;

            } else
            {
                Console.WriteLine("Superficie non può essere 0");
            }
        }
        //Public Methods
        public override string ToString()
        {
            string descrizione = @$"
---------------Immobile {codice}------------------
indirizzo: {indirizzo}
cap: {cap}
citta: {citta}
superficie: {superficie}
";

                return descrizione;
        }


        //Private Methods 
        private string GeneraCodice()
        {
            string[] lettere = {"A","B", "9", "C","1", "6", "D", "0", "8", "E","F","1","J","H", "6", "I","4","J","2","K","L","M","3","4","N", "9", "O","2", "7", "P","Q","R","3","S","T", "5","7", "U","9", "5", "V","W", "3", "X", "8", "W", "5", "Z","6", "4", "7","8", "0"};
            
            // string alfabeto = "ABCDEFGHILMNOPQRSTUVZ0123456789"
            // string lettere = "A1B1C2D2E3F3G4J4K5L5M6N6O7P7Q8R8S9T9U0V0WXYZ";

            string codice = "";

            for(int i = 0; i<10; i++)
            {
                int indiceEstratto = GeneraIndiceArray(lettere.Length);
                codice += lettere[indiceEstratto];
            }        

            return codice;
        }

        /// <summary>
        /// Questa funzione restituisce random tra 0 e numeroMax non compreso.
        /// </summary>
        /// <param name="lunghezzaArray"></param>
        /// <returns></returns>
        private int GeneraIndiceArray(int lunghezzaArray)
        {
            Random randomNum = new Random();
            return randomNum.Next(0, lunghezzaArray);
        }

    }
}
