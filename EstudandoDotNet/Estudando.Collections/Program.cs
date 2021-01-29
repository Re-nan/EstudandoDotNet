using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Collections
 * Utilizamos coleções de dados para agrupar dados de determinados tipos(int, string, Pessoas)
 * 
 * A plataforma .net fornece uma série de tipos de coleções:
 * 
 * - Lists (Listas)
 * - Sets (Conjuntos)
 * - Dictionaries (Dicionários)
 * - Queues (Filas)
 * - Stacks (Pilhas)
 * entre outras....
 * 
 * Existem duas categorias de coleções de dados, as legada e as atuais, as legadas são antes
 * do .net 2.0 pois nessa versão não existiam Generics
 * Essas coleções legadas( ArrayList, SortedList, HashTable) fazem parte do namespace 
 * System.Collections
 * 
 * E agorava devemos dar prioridades para as interfaces:
 * 
 * ICollection<T> 
 * Representa o conceito de coleção. Count, Add(), Remove() e Clear() são
 * propriedades e métodos importantes
 * 
 * IList<T> 
 * Representa uma lista sequência de elementos
 * 
 * ISet<T> 
 * Representa um conjunto, onde não há duplicação de elementos
 * 
 * IDictionary<K, V> 
 * Representa um dicionários, que armazena pares de chave e valor. 
 * Um valor pode ser obtido com base na sua chave
 * 
 * Todas do namespace System.Collections.Generic
 */

/* Árvore de herança de Interfaces/Classes
* 
*          ICollection<T>
*              |      
*            IList<T>
*           /     \
*         List<T>  LinkedList<T>
*/

namespace Estudando.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaLinguagens = new List<string>();
            // Ou List<string> listaLinguagens = new List<string>() {"C#", "Java", "C++"};
            // Ou List<string> listaLinguagens = new List<string>(new string[] {"C#", "Java", "C++" });

            // Add() add ao final da lista
            listaLinguagens.Add("C#"); 
            listaLinguagens.Add("Java");
            listaLinguagens.Add("C++");

            /* AddRange() add vários elementos ao final da lista 
             * no caso estou add um array de strings
             */ 
            listaLinguagens.AddRange(new string[] {"Javascript", "Python", "Kotlin" });

            /* Insert() add um elemento no meio da lista, é necessário
             * forneceser o índice
             */
            listaLinguagens.Insert(1, "Go");

            /* Insert() add vários elementos no meio da lista, é necessário
             * forneceser o índice
             */
            listaLinguagens.InsertRange(0, new string[] {"Swift", "Php", "C#"});

            /* Diferente do array onde ele subtitui o valor passado na posição
             * aqui os elementos são deslocados a direita dentro da lista
             */

            // Retorna -1 se o elemento procurado não existir na lista
            int posicao = listaLinguagens.IndexOf("C#");
            Console.WriteLine(posicao);

            /* Retorna o útimo índice encontrado caso o valor procurado esteja em mais 
             * de uma posição
             */ 
            int ultimaPosicao = listaLinguagens.LastIndexOf("C#");
            Console.WriteLine(ultimaPosicao);

            // Get no elemento através de um índice, assim como em array
            string primeiroElemento = listaLinguagens[0];
            Console.WriteLine(primeiroElemento);


            // Retorna um bool para saber se um elemento existe ou não na lista
            bool existe = listaLinguagens.Contains("C#");
            Console.WriteLine(existe);

            // Remove o primeiro elemento da lista, passando o indice
            listaLinguagens.RemoveAt(0);

            // Remover o elemento em si, independente onde ele esteja
            listaLinguagens.Remove("C#"); //retorna um bool confirmando se removeu ou não

            /* Orderna os elementos da lista por ordem alfabética ou numérica
             * se sua lista for de objetos é preciso implementar a interface
             * IComparable na sua classe "Pessoa", "Alunos" e etc..
             */ 
            listaLinguagens.Sort();



            Console.WriteLine();
            foreach (var item in listaLinguagens)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
