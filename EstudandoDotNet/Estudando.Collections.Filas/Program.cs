using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* FILAS
 * Em uma fila os elementos são processados da forma FIFO (First in First out)
 * O primeiro a chegar é o primeiro a sair, igual uma fila de mercado
 * 
 * Queue = enfileirar
 * Dequeue = desinfilerar
 * ------------------- >
 * |8|13|2|11|6|19|
 * ------------------- >
 * 
 * O 19 foi o primeiro a chegar, então é o primeiro a sair
 */ 

namespace Estudando.Collections.Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando fila
            Queue<char> fila = new Queue<char>();

            // Enfileirando
            fila.Enqueue('A');
            fila.Enqueue('B');
            fila.Enqueue('C');
            fila.Enqueue('D');

            /* Desenfileirando
             * Retorna o primeiro da pilha, mas sem deixar ele lá, remove da fila
             * se a fila estiver vazia ocorre um InvalidOperationException
             */
            char primeiro = fila.Dequeue();
            Console.WriteLine(primeiro);

            // Conta a qtd de elementos
            fila.Count();

            /* Retorna o primeiro da fila, mas deixa ele lá ainda, não remove ele
             * se a fila estiver vazia ocorre um InvalidOperationException
             */
            primeiro = fila.Peek();
            Console.WriteLine(primeiro);

            



            Console.ReadKey();
        }
    }
}
