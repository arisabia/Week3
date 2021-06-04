using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public abstract class Carello
    {
        public String Prodotto { get; set; }
        public int QuantitaOrdinata { get; set; }
       

        public virtual double PrezzoTotale()
        {
            double prezzo = 0;
            foreach (Prodotti prodotto in _prodotti)
            {
                prezzo += prodotto.Prezzo;
            }
            return prezzo;

        }
        public virtual double PrezzoSconto()
        {
            double sconto = PrezzoTotale() - 0.2;
            return sconto;
        }

        //•PrezzoTotale	-il prezzo totale al netto dello sconto (rispetto alla
        //quantità e al prezzo “pieno” del prodotto), 

        public Carello(string prodotto, int quantitaOrdinata)
        {
            Prodotto = prodotto;
            QuantitaOrdinata = quantitaOrdinata;
        }
        public Carello() { }


        public IList<Prodotti> _prodotti = new List<Prodotti>();

 
       
    }
}
