using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public abstract class Prodotti
    {
        public int Codice { get; set; }
        public String Descrizione { get; set; }

        public double Prezzo { get; set; }
        public double Sconto { get; set; }

        public Prodotti(int codice, string descrizione, double prezzo, double sconto)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Sconto = sconto;
        }

        public Prodotti() { }
    }
}
