using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.TipoDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menor valor positivo maior que 0
            Console.WriteLine(Double.Epsilon);
            //Valor que não é considerado um numero Ex dividir zero por zero, retorna um NAN
            Console.WriteLine(Double.NaN);

            //Verifica se é um numero NaN? retorna true se o vl ñ for um numero
            Console.WriteLine(Double.IsNaN(0.0 / 0)); //retorna true
            //Representa o valor infinito negativo e positivo
            //Quando o resultador for maior que o MaxValue teremos um PositiveInfinity
            //Quanto o resultado for menor que o MinValue teremos um NegativeInfinity

            //Retorna True se for NegativeInfinity ou PositiveInfinity
            Console.WriteLine(Double.IsInfinity(6.0 / 0));

            //isPositiveInfinity
            Console.WriteLine(Double.IsPositiveInfinity(6.0 / 0)); //true
            Console.WriteLine(Double.IsNegativeInfinity(6.0 / 0)); //false


            Console.ReadKey();
        }
    }
}
