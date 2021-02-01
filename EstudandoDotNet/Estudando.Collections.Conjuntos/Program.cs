using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Conjuntos
 * Um conjunto é uma coleção de dados que não permite elementos duplicados
 * os elementos são SEMPRE ÚNICOS, os conjuntos em C# são representados pela
 * interface ISet<T> e algumas classes que a implementam como a classe HashSet<>
 * 
 * HashSet<T>
 * Nela os elementos são armazenados como base em algoritmo de Hash para fazer a
 * distribuição dentro do conjunto
 */
 
namespace Estudando.Collections.Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dias = new HashSet<string>();

            /* O método add() retornal um boll true se ele for inserido e
             * false se ele já tiver sido inserido
             */ 
            dias.Add("Segunda");
            dias.Add("Segunda");
            dias.Add("Terça");

            foreach (var item in dias)
            {
                Console.WriteLine(item); //Segunda, Terça
            }

            Console.WriteLine();

            // Trabalhando com a classe Conta

            HashSet<Conta> contas = new HashSet<Conta>();

            /* O método add() retornal um boll true se ele for inserido e
             * false se ele já tiver sido inserido
             */
            contas.Add(new Conta(123));
            contas.Add(new Conta(456));
            contas.Add(new Conta(123));

            foreach (var item in contas)
            {
                Console.WriteLine(item.Numero); 
            }

            /* // 123, 345, duplicaria o 123 se eu não tivesse implementado
             * IEquatable<T> e sobreescrevido os
             * métodos Equals e GetHasCode
             * Preciso dizer ao C# que contas com a propriedade Numero são
             * considerado contas iguais, preciso sobrescrever o método Equals()
             * da class Object na class Conta
             */

            Console.WriteLine();

            /* SortedSet<T> é um conjunto Ordenado
             * Se baseia para número em ordem crescente e no alfabeto para letras
             * Ela não usa o Equals e nem o GetHasCode, mas sim o CompareTo
             * 
             * Se você for usar com tipos de classes criadas por você, você
             * precisa implementar a interface IComparable e sobrescrever o 
             * CompareTo para que atende a sua ordenação seja por uma ou mais
             * propriedades
             */
            SortedSet<string> nomes = new SortedSet<string>();
            nomes.Add("Mines");
            nomes.Add("Dinho");
            nomes.Add("Roger");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    // CLASSE CONTA
    class Conta : IEquatable<Conta>
    {
        public int Numero { get; set; }

        public Conta(int numero)
        {
            Numero = numero;
        }

        /* É recomendado que se extenda a interface IEquetable<T>
         * que vai utilizar um tipo parametriado e evitar a ocorrência do Boxing
         * Isso gera ganho de performance
         * 
         * Porém sempre que você sobrescreve Equals você precisa implementar a 
         * interface IEquetable<T> e sobrescrever GetHashCode de Object
         * 
         * E isso sempre que você precisa fazer equiparação de classes que você
         * criou
         */ 

        // Equals de IEquetable<T>
        public override bool Equals(object obj)
        {
            return Equals(obj as Conta);
        }

        // Meu Equals()
        public bool Equals(Conta other)
        {
            if(other == null)
            {
                return false;
            }

            return this.Numero == other.Numero;
        }

        /* Sobreescrevendo GetHashCode() de Object
         * Como eu quem preciso reescrever, geralmente reescrevem com base em
         * números primos
         * 
         * 13 é um número primo
         */
        public override int GetHashCode()
        {
            int hash = 27;
            hash = (13 * hash) + Numero.GetHashCode();

            /* se eu tivesse mais propriedades para comparação eu as adicionaria
             * em baixo mantendo o calculo de hash
             * hash = (13 * hash) + Numero.OutraPropriedade();
             */

            return hash;
        }
    }
}
