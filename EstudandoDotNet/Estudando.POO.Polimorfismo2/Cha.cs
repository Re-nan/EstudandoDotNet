using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Polimorfismo2
{
    class Cha : Bebida
    {
        public override void AdicionarAcucar()
        {
            Console.WriteLine("Adicionando açúcar ao Chá");
        }

        public override void AdicionarAgua()
        {
            Console.WriteLine("Adicionando água ao Chá");
        }

        public override void AdicionarSubstancia()
        {
            Console.WriteLine("Adicionando Chá");
        }
    }
}
