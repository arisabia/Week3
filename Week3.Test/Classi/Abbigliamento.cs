using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public class Abbigliamento : Prodotti
    {
        public String Taglia { get; set; }
        public String Brand { get; set; }

        public Abbigliamento(int codice, string descrizione, double prezzo, double sconto, string taglia, string brand)
            : base(codice, descrizione, prezzo, sconto)
        {
            Taglia = taglia;
            Brand = brand;
        }
        public Abbigliamento() { }
    }
}
