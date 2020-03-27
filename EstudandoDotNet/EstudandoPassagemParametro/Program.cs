using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A passagem de parâmetros é feita por métodos que podem receber um, vários ou nenhum parâmetro
 * 
 * Os tipos de dados em C# são divididos em duas categorias
 * 
 * ValueTypes = byte, short, int, long, float, double, decimal e etc...
 * ReferenceTypes = Classes(Caneta, Pessoa e etc...)
 * 
 * A diferença entre eles é que os ValueTypes são armezenados na memória Stack
 * e os ReferenceTypes na memória Heap
 */

namespace EstudandoPassagemParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            /* Passagem de parâmetros por VALOR
             * é feita uma cópia do valor da variável para o parâmetro
             */
            TrocarPorValor(x);

            Console.WriteLine(x);

            Console.WriteLine();

            /* Passagem de parâmetros por REFERENCIA
             * é feita uma cópia do ENDEREÇO DE MEMÓRIA variável seja ela da stack ou heap para o parâmetro
             */
            TrocarPorReferencia(ref x);

            Console.WriteLine(x);

            Console.ReadKey();

        }

        /* Por padrão toda passagem de parâmetros assume ser por VALOR
         */
        static void TrocarPorValor(int z)
        {
            /* Essa alteração é feita no valor de z do parâmetro 
             */
            z = 10;
        }

        /* É preciso especificar no método que a passagem de parâmetros para ele
         * será feita por REFERENCIA e não por valor
         */
        static void TrocarPorReferencia(ref int z) //recebe o local da memória de onde o valor está armazenado
        {
            /* Essa alteração é feita no mesmo endereço de memória que x e z, 
             * pois x e z apontam pro mesmo endereço de memória
             */
            z = 10; //z referencia o mesmo local na memória que x
        }

    }
}