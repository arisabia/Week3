using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Test.Classi
{
    public interface IUtente
    {
        string Username { get; set; }
        string Password { get; set; }
        string Nome { get; set; }
        string Cognome { get; set; }

        
    }

}
