using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.TipoDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tipos Decimal possuem 3 construtores
             * Decimal(double valor) cria um vl decimal a partir de um double
             * Decimal(float valor) cria um nvl decimal a partir d eum float
             * Decimal(tipo que eu quiser e o valor) cria um vl decimal a partir de um tipo int, long, uint, ulong e etc..
             */

            decimal dec1 = new decimal(1);
            Console.WriteLine(dec1);

            decimal d1 = 10.2m, d2 = -5.8m, c;
            c = 10.2m + 5.8m;
            //ou
            c = decimal.Add(d1, d2);
            Console.WriteLine(c);

            /* Ceiling() retorna o menor vl inteiro maior ou igual ao valor passado
             * Quando o resultado é positivo arredonda para positivo o vl inteiro maior entre o valor decimal
             * E quando é negativo descarta a parte inteira entre o valor decimal
             */
            Console.WriteLine(decimal.Ceiling(d1)); // de 10.2 arredondondou pra cima agorar é 11
            Console.WriteLine(decimal.Ceiling(d2)); // de -5.8 arredondondou pra baixo agora é -5 

            //Divide() - retorna o quociente da divisao entre d1 e d2
            Console.WriteLine(decimal.Divide(6, 2));

            /* Floor retorna o maior vl inteiro menor ou igual ao valor que foi passado
             */
            Console.WriteLine(decimal.Floor(d1)); //10.2 arredondondou pra baixo agora é 10 
            Console.WriteLine(Decimal.Floor(d2)); //-5.8 arredondou pra cima agora é -6

            //Multiply retorna a multiplicação
            Console.WriteLine(Decimal.Multiply(10, 10));

            //Remainder() retorna o resto da divisão de d1 por d2
            Console.WriteLine(decimal.Remainder(6, 2));

            //Round() - retorna o valor arredondado para o valor inteiro mais proximo
            //De 5.5 pra cima vira 6 ||| De 5.4 pra baixo arredonda pra baixo
            Console.WriteLine(decimal.Round(5.5m));

            /* ToByte converte decimal pra byte */
            decimal bbb1 = 255m;
            Console.WriteLine(decimal.ToByte(bbb1));

            /* ToDouble converte decimal pra double */
            decimal ddd1 = 2.6m;
            Console.WriteLine(decimal.ToDouble(ddd1));


            Console.ReadKey();
        }
    }
}
