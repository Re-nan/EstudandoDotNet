using Estudando.Heranca2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Interfaces
 * - Assim como classes, intrfaces também são tipos de dados. Em interfaces temos apenas
 * assinaturas de métodos ou properties. Nada é implementado, fields e constutores não são
 * permitidos
 * - Tudo o que você declara em uma interface é por padrão public, definido implicitamente
 * - O conceito de interface é focar no que o objeto faz e não como eles faz!
 * - As classes que implementam uma interfaces se tornam do tipo da interface, assim como
 * classes, também usamos o termo "É UM". Porém cuidado com o excesso de "É UM" em sua hierarquia
 * e acabar engessando as classes. opte pela associação "TEM UM" em que uma classe é composta
 * de outras classes ou interfaces
 */

namespace Estudando.POO.Heranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.NomeCarro = "Jeep Renegade";
            c.NomeMotor = "2.0 Multijet II";

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
