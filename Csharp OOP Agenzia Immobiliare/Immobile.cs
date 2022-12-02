using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP_Agenzia_Immobiliare
{
    public class Immobile
    {
        protected string codice;
        protected string indirizzo;
        protected string cap;
        protected string citta;
        protected double superficie;

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
        public void SetIndirizzo(string indirizzo)
        {
            this.indirizzo= indirizzo;
        }

        public void SetCap(string cap)
        {
            this.cap = cap;
        }

        public void SetCitta(string citta)
        {
            this.citta = citta;
        }

        public void SetSuperficie(int superficie)
        {
            this.superficie = superficie;
        }
        //Public Methods
        public override string ToString()
        {
            string descrizione = @$"
---------------Prodotto {codice}------------------
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
            string codice = "";

            for(int i = 0; i<10; i++)
            {

                codice += lettere[GeneraNumeroRandom()];
            }

            int GeneraNumeroRandom()
            {
                Random  randomNum = new Random();
                return randomNum.Next(0,lettere.Length);
            }

            return codice;
        } 

    
    }
}
