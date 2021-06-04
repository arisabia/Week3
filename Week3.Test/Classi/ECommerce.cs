using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public class ECommerce
    {
        private Utente _utente = new Utente()
        {
            Username = "Rossi90",
            Password = "12334jj",
            Nome = "Maria",
            Cognome = "Rossi"

        };
        //costruttore non arg per sfruttore oggetto utente
        public Utente Utente1 { get { return _utente; } }


    }
}
