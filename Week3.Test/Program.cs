using System;
using Week3.Test.Classi;

namespace Week3.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();

                switch (scelta)
                {
                    case 1:
                        //aggiugi prodotto al carello
                        //nel casso di prodotto gia inserito, modifica la quantotà
                      CarelloManagement.AggiungiProdotto();
                        
                        break;
                    case 2:
                        //elimina prodotto

                        break;
                    case 3:
                        //modifica la quantita di un prodotto gia incerito
                        break;
                    case 4:
                        //stampa a video riepilogo del carrello dell'utente
                        break;
                    case 5:
                        //Exit
                        break;

                }


            }

        }
        public static int SchermoMenu()
        {
            Console.WriteLine("1. Aggiungi prodotto al carello");
            Console.WriteLine("2. Elimina prodotto");
            Console.WriteLine("3. Modifica la quantita di un prodotto gia inserito");
            Console.WriteLine("4. Stampa a video riepilogo del carrello");
            Console.WriteLine("5. Per uscire");
            int scelta = 0;
            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Inserisci un numero corretto");
                scelta = 0;
            }
            return scelta;
        }
    }
}
