using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Parâmetros de SAIDA
 * Além dos tipos de passagem de parâmetros por VALOR e REFERENCIA existem os Parâmetros de SAIDA
 * 
 * São parâmetros cujos valores são definidos pelo método chamado e nele quem chama não
 * precisa inicializar a variável, porque essa variável tem seu valor definido pelo método 
 * que o está chamando
 * 
 * Pode se mais de um parametro de saída por método, geralmente usasse métodos com parametros 
 * de saída quando você tem que retornar mais de um valor tem em mente que um método só pode
 * retornar um valor
 * 
 * 
 * PS: O C# passa parametros de saída como referência de forma automática, pois do contrário
 * ele não funcionari ada forma que deveria
 */

/* Parâmetros OPCIONAIS
 * São parametros que podem ou não serem passados, se não forem passados, assumem um valor padrão
 */

namespace EstudandoPassagemParametro3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando parametros de SAIDA
            int result;
            Somar(5, 10, out result); //o prefixo out também definido
            Console.WriteLine(result);



            // Utilizando parametros OPCIONAIS
            result = Calcular(6, 1, '-');
            Console.WriteLine(result);

            // Utilizando parametros OPCIONAIS
            result = Calcular(6, 1);
            Console.WriteLine(result);



            Console.ReadKey();
        }

        /* para definirmos um parametro de saída usamos o prefixo out */
        static int Somar(int x, int y, out int r)
        {
            r = x + y;
            return r;
        }

        /* para definirmos um parametro com valor padrão atribuimos na assinatura
         * e sempre sendo o ultimo na ordem dos parametros
         */
        static int Calcular(int x, int y, char op = '+')
        {
            if(op == '+')
            {
                return x + y;
            }
            else if (op == '-')
            {
                return x - y;
            }
            else
            {
                return 0;
            }
        }



    }
}
