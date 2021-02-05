using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Collections.Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando pilha
            Stack<char> pilha = new Stack<char>();

            // Empilhando
            pilha.Push('A');
            pilha.Push('B');
            pilha.Push('C');

            /* Desimpilhando
             * Retorna o primeiro da pilha, mas sem deixar ele lá, remove da pilha
             * se a pilha estiver vazia ocorre um InvalidOperationException
             */
            char ultimo = pilha.Pop();
            Console.WriteLine(ultimo);

            // Conta a qtd de elementos
            pilha.Count();

            /* Retorna o primeiro da pilha, mas deixa ele lá ainda, não remove ele
             * se a pilha estiver vazia ocorre um InvalidOperationException
             */
            ultimo = pilha.Peek();
            Console.WriteLine(ultimo);


            Console.ReadKey();
        }
    }
}
