using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Checked
 * Um block checked faz o compilador verificar se aquela atribuição irá retornar um 
 * overflow, caso sim irá retorna uma exception de System.OverflowException
 * 
 * O compilador do C# da a opção de habilitar a mesma checagem que o checked faz
 * a checagem vai ocorrer no código todo, para isso basta usar a opção /checked nas
 * configurações do projeto, mas cuidado o ideal é que você use essa opção apenas em
 * desenvolvimento e testes, pois ela prejudica a performance da aplicação
 * 
 * Unchecked
 * Um bloco uncheked faz o contrário do checked, quando a checagem de overflow está 
 * ativada no compilador e unchecked pode ser utilizado para permitir o overflow
 */

namespace Estudando.ExpressoesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Esse código compila com sucesso, porém uma var do tipo byte
             * só pode armazenar valores até 255, e o resultado desta é 300
             * sendo assim ela tem o valor de 44;
             */ 
            byte b1 = 100;
            byte b2 = 200;
            byte soma = (byte)(b1 + b2);

            /* Utilizando o Checked o C# vai lançar uma exceção do tipo
             * System.OverflowException caso essa expressão tente atribuir uma valor
             * acima de 255 para um tipo byte. 
             */ 
            checked
            {
                byte soma2 = (byte)(b1 + b2);
            }


            Console.ReadKey();
        }
    }
}
