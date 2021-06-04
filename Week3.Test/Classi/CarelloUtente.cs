using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    class CarelloUtente : Carello
    {
        public CarelloUtente(string prodotti, int quantitaOrdinata) : base(prodotti, quantitaOrdinata)
        {

        }
        public override double PrezzoSconto()
        {
            return base.PrezzoSconto();
        }
        public override double PrezzoTotale()
        {
            return base.PrezzoTotale();
        }

    }
}
