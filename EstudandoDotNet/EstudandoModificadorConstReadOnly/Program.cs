using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Modificador const 
 * - Impede que o field possa ter seu valor alterado
 * - fields declarado como const são implicitamente static também
 * (ou seja são da classe, e não da instancia)
 * - Precisam terem seu valor setados no momento de sua criação
 */

/* Modificador readonly
 * - Diferente de const o modificador readonly não define o elemento como
 * static
 * - Não precisam terem seu valor atribuição no momento da declaração;
 * - Porém após setado um valor este não pode ser alterado
 */

/* RESUMINDO
 * - Tanto um como o outro não pode ter seu valor alterado
 * - A diferença é que o const torna a propriedade a ser static(da classe) e
 * ser atribuída no momento da declaração e esse valor é compartilhado entre
 * todas as instâncias daquela classe. Já o readonly a ser da instância
 * - Porém como dito, após receberm um valor não pode serem alterado
 * - Um readonly deve ser declarado e inicializado dentro de um construtor
 * - Se um read only for denifido como static, ele deve ser inicializaod dentro 
 * de um costrutor
 */ 

namespace Estudando.Modificador.ConstReadOnly
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
         * não pode ter seu valor alterado
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
