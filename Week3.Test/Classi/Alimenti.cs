using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public class Alimenti : Prodotti
    {
        public DateTime DataScadenza { get; }
        public Alimenti(int codice, string descrizione, double prezzo, double sconto, DateTime dataScadenza)
            : base(codice, descrizione, prezzo, sconto)
        {
            DataScadenza = dataScadenza;
        }

    }
}
