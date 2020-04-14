using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Polimorfismo
{
    class Gato : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Miau");
        }
    }
}
