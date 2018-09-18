using System;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class StorebæltBil : Bil
    {
        // Constructor
        public StorebæltBil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = false;
        }

        public StorebæltBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        /// <summary>
        /// Får den totale pris for en bil der kører over Storebælt
        /// </summary>
        /// <param name="bil"></param>
        /// <returns>Total pris med weekend tilbud inkluderet</returns>
        public decimal GetPrice()
        {
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return (Pris() - (Pris() * 0.2m));
            }
            return Pris();
        }
    }
}
