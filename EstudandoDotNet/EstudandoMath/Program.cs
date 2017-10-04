using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /* CAMPOS da CLASSE MATH
             * Math.E
             * Math.Pi
             */

            //Métodos
            /* ABS() retona valor absoluto de um número, ou seja, tira o sinal e deixa sempre positivo
             * Ou também chamado de módulo de um numero
             */
            Console.WriteLine(Math.Abs(-12.2)); //12.2
            Console.WriteLine(Math.Abs(-5 + 2)); //3

            /* BigMul() retorna o produto de n1 por n2 Ex. n1 * n2 */
            Console.WriteLine(Math.BigMul(2, 6));

            /* Ceiling() pega um double/decimal e sempre arredonda pra CIMA */
            Console.WriteLine(Math.Ceiling(2.8)); //3

            /* Floor() pega um double/decimal e sempre arredonda pra BAIXO */
            Console.WriteLine(Math.Floor(2.8)); //2

            /* Round() Pega um double/decimal(Ex 5.5) e até .5 pra cima sempre arredona pra cima sendo agora 6
             * e até .4 sempre arredonda pra baixo sendo agora 5 */
            Console.WriteLine(Math.Round(5.5)); //6
            Console.WriteLine(Math.Round(5.4)); //5


            /* Ainda no Round você pode escolher quantas casas decimais ele vai arredondar
             * Ex Math.Round(5.6 , 2); o segundo parametro é o numero de casas q vc quer que ele arredonde
             * ideal para usar em numero grandes
             */ 


             /* DivRem() retona o quociente e o resto da diviso de n1 por n2
              * Ex. quociente = Math.DivRem(n1, n2, out resto); */
            int quociente;
            quociente = Math.DivRem(6, 2, out int resto);
            Console.WriteLine("Quociente é: " + quociente + " e o Resto é: " + resto); //quociente 3 e resto 0

            /* IEEERemainder() retorna o resto da divisao de n1 por n2
             * Semelhante ao mod, embora ambos retornem omod, não é mod pq a fórmula q usam são diferentes
             * ATENÇÃO: IEEERemainder pode retornar restos negativos enquanto o mesmo resto nomod é positivo */
            Console.WriteLine(Math.IEEERemainder(5, 2)); //1

            /* Max() retorna o maior valor entre n1 e n2 */
            Console.WriteLine(Math.Max(4, 6.2));

            /* Min() retorna o menor valor entre n1 e n2 */
            Console.WriteLine(Math.Min(0.6, 0));

            /* Pow() retorna o valor de n1 elevado a n2, ou seja base elevada ao expoente */
            Console.WriteLine(Math.Pow(2, 3));

            /*Sign() 
             * retorna -1 se o valor for negativo
             * retorna 0 se o valor for zero
             * retorna 1 se o valor for positivo
             */
            Console.WriteLine(Math.Sign(5.8)); //1
            Console.WriteLine(Math.Sign(0000)); //0
            Console.WriteLine(Math.Sign(-5.8)); //-1

            /* Truncate() retorna a parte inteira de um valor
             * Ex Math.Truncate(120.987444) retorna apenas a parte inteira ou seja 120
             */
            Console.WriteLine(Math.Truncate(-02.9)); //-2


            /* Sqrt() retorna a raiz quadrada de um valor */
            Console.WriteLine(Math.Sqrt(9)); //3

            Console.ReadKey();
        }
    }
}
