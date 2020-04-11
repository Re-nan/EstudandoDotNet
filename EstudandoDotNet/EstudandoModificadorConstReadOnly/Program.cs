using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Modificador const 
 * - Impede que o field possa ter seu valor alterado
 * - fields declarado como const são implicitamente static também
 * - Precisam terem seu valor setados no momento de sua criação
 */

/* Modificador readonly
 * Diferente de const o modificador readonly não define o elemento como
 * static
 * Não precisam terem seu valor inicializado no momento de sua criação
 * Mas após setaod um valro este não pode ser alterado
 */

/* Tanto um como o outro não pode ter seu valor alterado */ 

namespace EstudandoModificadorConstReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PI: " + Matematica.PI);

            Matematica m = new Matematica();
            Console.WriteLine("E: " + m.E);


            Console.ReadKey();
        }
    }

    class Matematica
    {
        /* PI
         * não pode ter sue valor alterado
         * é do tipo static implicitamente
         * pertence a classe e não a instancia
         */
        public const double PI = 3.1416;


        /* Número de Euler
         * pertence a instancia, porém se adc o static, pertence somente a classe
         */
        public readonly double E = 2.71828;

    }

}
