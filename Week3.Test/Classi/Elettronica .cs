using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public class Elettronica : Prodotti
    {
        public String Produttore { get; }
    
    public Elettronica(int codice, string descrizione, double prezzo, double sconto, string produttore)
            : base(codice, descrizione, prezzo, sconto)
    {
            Produttore = produttore;
    }
    }
}
