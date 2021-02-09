using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Dicionários
 * - Coleção onde cada elemento é associado a uma chave, nela o elemento pode ser acessado
 * através da sua chave, e a chave não pode ser duplicada
 * 
 * - Podem serem conhecidos também como Mapas ou Tabela Hash
 */

/* Árvore de interfaces/classes
 * 
 *                  ICollection<T>
 *                         |
 *               IDictionary<TKey, TValue>
 *               /                     \
 *      Dictionary<TKey, TValue>      SortedDictionary<TKey, TValue>
 */

namespace Estudando.Collections.Dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map1 = new Dictionary<int, string>();

            // Add chave e valor
            map1.Add(1, "Um");
            map1.Add(2, "Dois");
            map1.Add(3, "Três");
            map1.Add(4, "Quatro");

            // Remove passando a chave
            map1.Remove(1);

            /* Pega o elemento passando a chave
             * Se não existir retorna uma KeyNotFoundException
             */
            string val1 = map1[2];

            bool existe = map1.TryGetValue(2, out string val2);
            Console.WriteLine("Existe: {0}, Valor: {1}", existe, val2);

            /* Iterando sobre as chaves
             * KeyCollection é uma classe interna do Dictionary
             */
            Dictionary<int, string>.KeyCollection keys = map1.Keys;

            foreach (var item in map1.Keys /*ou keys */)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            /* Iterando sobre os valores
             * KeyCollection é uma classe interna do Dictionary
             */
            Dictionary<int, string>.ValueCollection vals = map1.Values;

            foreach (var item in map1.Values /*ou vals */)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            /* Obtendo chave e valor
             */
            foreach (KeyValuePair<int, string> entry in map1)
            {
                int key = entry.Key;
                string value = entry.Value;

                Console.WriteLine("Key: " + key + " Value: " + value);
            }


            Console.ReadKey();
        }
    }
}
