using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Polimorfismo3
{
    class Selo : IColecionavel
    {
        public string GetNomeColecao()
        {
            return "Selos";
        }
    }
}
