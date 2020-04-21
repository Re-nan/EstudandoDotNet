using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Polimorfismo2
{
    class Cafe : Bebida
    {
        public override void AdicionarAcucar()
        {
            Console.WriteLine("Adicionando açúcar ao Café");
        }

        public override void AdicionarAgua()
        {
            Console.WriteLine("Adicionando água ao Café");
        }

        public override void AdicionarSubstancia()
        {
            Console.WriteLine("Adicionando Café");
        }
    }
}
