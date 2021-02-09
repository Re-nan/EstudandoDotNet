using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* GENERICS
 * Um tipo Generic é identificado pelo código <T>, mas poderia ser qualquer outro nome/letra
 * 
 * Os Generics permite que classes e métodos utilizem tipos parametrizados, 
 * dos mais variados tipos. 
 * 
 * Generics resolve o problema de performance causados pelos muitos processos de 
 * "unboxing e boxing" + "garbage collector". E obriga que os tipos usados sejam
 * verificados no momento da compilação
 * 
 * Mesmo tendo seu tipo genérico, podem terem um valor padrão podendo serem usados com 
 * value types ou reference types, através da palavra chave default()
 * value type = 0; 
 * refence type = null;
 */

namespace Estudando.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /* BOXING
             * Ex. Tipo Object que é um tipo Referência(Heap) recebendo um int que é um tipo 
             * valor(Stack). Por trás disso ocorre o BOXING que é esse valor int ser 
             * copiado/empacotado para dentro de um tipo Object do Heap e a var o passa a 
             * referenciar o tipo Object
             */
            Object o = 10;
            Console.WriteLine(o);

            /* UNBOXING
             * E quando eu atribuo um tipo Object para um tipo int ocorre o UNBOXIG que é 
             * quando o valor deixa de sereu faço um cast passando o tipo no qual o Object será 
             * "transformado" em int (tipo valor) e assim ele deixa de ser referênciado na memória
             */
            int i = (int)o;
            Console.WriteLine(i);


            /* Quando a classe usa Generics, o tipo parametrizado deve ser fornecido no 
             * momento da criação do objeto
             */
            Pacote<string> pct1 = new Pacote<string>();
            pct1.Elem1 = "Teste";

            // Criando uma instância com mais  de um tipo parâmetrizado 
            Propriedade<int, string> prop1 = new Propriedade<int, string>(1, "Um");



            Console.ReadKey();
        }
    }
}
