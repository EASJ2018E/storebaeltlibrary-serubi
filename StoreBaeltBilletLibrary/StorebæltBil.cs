using System;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class StorebæltBil : Bil
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        public StorebæltBil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = false;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        /// <param name="brobizz">Om Brobizz blev brugt til betaling</param>
        public StorebæltBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        /// <summary>
        /// Får den totale pris for en bil der kører over Storebælt
        /// </summary>
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
