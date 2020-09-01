using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Sobrecarga de métodos
 * Significa criar outros métodoso com o mesmo nome mas com assinatura diferente, 
 * a única coisa que um método tem em comum com o outro é o nome.
 * 
 * Internamente o compilador interpreta como se um método fosse independente do outro
 * 
 * Para isso você precisa criar métodos com nomes iguais e tipos ou quantidades de parametros
 * diferentes
 * 
 * Também posso ter sobrecarga de Construtores
 */ 

namespace Estudando.Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = Somar(1, 2);
            int result2 = Somar(1, 2, 3);
            double result3 = Somar(2.5, 2.5);

        }

        static int Somar(int a, int b)
        {
            return a + b;
        }

        static int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Somar(double a, Double b)
        {
            return a + b;
        }

        // Erro mesma quantidade e tipo de parametros já usados, independente do tipo de retorno
        /*
           static float Somar(int a, int b)
            {
                return (float)a + b;
            }
        */
        
    }
}
