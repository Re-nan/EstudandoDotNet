using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Herança
 * A herança ocorre quando uma classe herda de outra, podemos também dizer que sua classe
 * extende as funcionalidades de outra. Também chamada de superclasse, classe pai, classe base
 * 
 * Uma classe com o modificador sealed não pode ser herdada por outra.
 * 
 * Ao instanciar uma classe, o construtor da super classe é sempre executado primeiro, ou seja
 * o contrutor de Object é sempre chamado primeiro e em seguida os das sub classes, em cadeia.
 * 
 * Quando queremos invocar o contrutor da super classe usamos o código :base() ao lado do nosso
 * contrutor.
 */

namespace Estudando.POO.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            Skate sk8 = new Skate();

            Console.ReadKey();
        }
    }
}
