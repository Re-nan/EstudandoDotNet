using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Polimorfismo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Selo s = new Selo();
            ImprimirColecao(s);

            Console.WriteLine();

            Bone b = new Bone();
            ImprimirColecao(b);


            Console.ReadKey();
        }

        /* Método que trabalha com um tipo Genérico, justamente para que você
         * possa informar tipos específicos(Selo, Boné) mas sendo referenciados
         * como tipos mais genpericos(IColecionavel), coleções que você crie
         * futuramente na aplicação se encaixam aqui sem que você precise mexer
         * no código. Isso é o polimorfismo.
         */
        static void ImprimirColecao(IColecionavel c)
        {
            Console.WriteLine("Essa é uma coleção de " + c.GetNomeColecao());
        }
    }
}
