using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Nullable Types (Tipos nulos/anulados) (?)
 * É uma técnica para permitir que ValueTypes(int, double, long, float...) possa receber 
 * o valor null, com Nullable Types você consegue fazer isso, foram criados para serem 
 * utilizados somente com ValueTypes
 */ 

/* Null-coalescing operator (??)
 * Permite atribuir um valor padrão para uma variável se o valor 
 * dela for null 
 * Pode ser utilizado com value types e reference types
 */

namespace Estudando.NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = null; //Erro de compilação
            
            /* Para converter um tipo primitivo em Nullable Type você utiliza um 
             * ponto de interrogação(?) após o seu tipo
             */

            int? n = null; //Agora pode receber null


            /* Quando você trabalha com Nullable Types você precisar testar se o
             * valor é null, e isso podemos fazer de algumas formas
             */ 

            /* Se n == null, exibe a mensagem */
            if (n == null)
            {
                Console.WriteLine("1 - O valor de n é: " + n);
            }

            /* Propriedade de valores Nullable que identifica se n tem algum valor 
             * que não seja null
             */
            if (n.HasValue)
            {
                Console.WriteLine("2 - O valor de n é: " + n);
            }
   

            bool? b1 = true;
            bool b2 = b1 ?? false; //Se b1 for null, atribua false, se não, atribua o valor de b1

            Console.WriteLine("O valor de b2 é: " + b2);

            Console.ReadKey();
        }
    }
}