using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public class CarelloManagement
    {
        private static IDictionary<int, Abbigliamento> ListaProdotti()
        {
            IDictionary<int, Abbigliamento> prodottiAbbigliamento = new Dictionary<int, Abbigliamento>()
            {
                [0] = new Abbigliamento() { Codice = 0, Descrizione = "Pantaloni", Prezzo = 25.20, Sconto = 0, Taglia = "M", Brand = "Zara" },
                [1] = new Abbigliamento() { Codice = 1, Descrizione = "Maglia", Prezzo = 30, Sconto = 0.2, Taglia = "xl", Brand = "Zara" },
                [2] = new Abbigliamento() { Codice = 2, Descrizione = "Sandali", Prezzo = 43.2, Sconto = 0, Taglia = "S", Brand = "Zara" }
            };
            return prodottiAbbigliamento;
        }
        private static IDictionary<int, Abbigliamento> prodottoCaricato = ListaProdotti();
        public static int AggiungiProdotto()
        {

            int codice;
            do
            {
                Console.WriteLine("Inserisci il codice prodotto");
            }
            while (!(Int32.TryParse(Console.ReadLine(), out codice)) || !prodottoCaricato.ContainsKey(codice));

            return codice;
        }
    }
}
