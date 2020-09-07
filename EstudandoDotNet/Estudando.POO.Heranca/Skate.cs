using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Heranca
{
    sealed class  Skate : Veiculo
    {
        public Skate() : base("Element")
        {
            Console.WriteLine("Marca do skate: " + Marca);
        }

    }
}
