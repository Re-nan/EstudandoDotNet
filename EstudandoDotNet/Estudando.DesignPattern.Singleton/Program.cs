using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* DESIGN PATTERN 
 * Um Design Pattern é um conceito que busca ajudar na resolução de problemas
 * de desenvolvimento que são recorrentes
 */

namespace Estudando.DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Eu só posso ter uma única isntancia de Gerenciador em meu
             * projeto.
             * Por ser static eu chamo ela diretamente através da class
             */

            Gerenciador g1 = Gerenciador.Instance;

            /* Não importa quantas vezes eu tente chamar uma nova instancia
             * para um novo obj, a classe sempre irá retornar a mesma instancia
             * 
             * pois eu criei uma field static que é inicializado uma unica vez
             * portando sempre que eu chamo Gerenciador.Instance eu estou retornando
             * o mesmo obj
             */

            Gerenciador g2 = Gerenciador.Instance;
            Gerenciador g3 = Gerenciador.Instance;


            Console.ReadKey();
        }
    }
}
