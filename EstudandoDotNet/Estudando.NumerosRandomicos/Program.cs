using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A classe Random se encontrda dentro do pacote System, tensdo assim o seu 
 * acesso por System.Random, ela é utilizada na geração de número randômicos
 */
 
namespace Estudando.NumerosRandomicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r;

            /* Quando se usa o construtor vazio o C# usava uma semente aleatória
             * toda vez que esse instância for criada, a sequência de números
             * sempre será aleatória
             * - Um obj do tipo Random possuí vários métodos para tipos de retorno
             * diferentes
             */
            r = new Random();
            Console.WriteLine(r.Next());

            /* Esse valor int do contrutor é uma semente
             * A semente é usada como base para geração de número randômico
             * Uma sequência de números randômicos baseados na mesma semente 
             * é sempre igual
             */
            r = new Random(1000);
            Console.WriteLine(r.Next());

            // O valor sempre será >= 0 AND < número fornecido no parâmetro 
            Console.WriteLine(new Random().Next(5)); //0 1 2 3 4 

            // Criando range de geração, >= 10 AND < 15
            Console.WriteLine(new Random().Next(10, 15));

            // Gerando double entre 0 e 1 (>= 0.0 AND <= 1.0)
            Console.WriteLine(new Random().NextDouble());


            Console.ReadKey();
        }
    }
}
