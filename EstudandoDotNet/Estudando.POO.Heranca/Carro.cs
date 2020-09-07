using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Heranca
{
    class Carro : Veiculo
    {
        public Carro() : base("Jeep")
        {
            Console.WriteLine("Marca do carro: {0}", Marca);
        }
        
    }
}
