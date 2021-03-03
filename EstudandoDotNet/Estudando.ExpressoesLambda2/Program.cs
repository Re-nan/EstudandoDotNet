using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Expressões Lambda
 * Uma expressão lambda é representada da seguinte forma "parametros => processamento"
 * => é chamado de operado lambda
 * 
 * Regra
 * Tudo antes do => são os parametros, e tudos depois do => é a expressão
 * 
 * Ex. sintaxe
 * e => e > 10
 * ou
 * (e) => (e > 10)
 * ou
 * (int e) => e > 10;
 * ou tendo mais de um parametro(aí os parenteses são obrigatórios)
 * (x, y) => x * y
 * ou com sem parametros
 * () => "abc"
 * ou com block entre chaves(aí sou obrigado usar o return)
 * e =>
 * { 
 *   return e > 10;
 * }
 * 
 * Um delegate bastante usado no C# é o Predicate<T>
 * T é o tipo do parâmetro, e o retorno é sempre um bool
 * 
 * Closure
 * Expressões lambda tem a capacidade de acessar variáveis definidas externamente,
 * este recurso se chama closure. 
 * Sempre que uma expressão lambda usa uma var externa, ela tem acesso ao valor mais
 * atual dela, pois ela recebe a variavel em si e não uma cópia do valor
 */

namespace Estudando.ExpressoesLambda2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Utilizando closure
            int x = 10;

            // Utlizando delegate Action do C# que nunca retorna nada
            // x é uma var externa, por tando isso é uma closure
            Action a = () => Console.WriteLine(x);

            //Executando o delegate
            a();


            Console.ReadKey();
        }
    }
}
