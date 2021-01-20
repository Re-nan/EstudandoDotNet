using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formas de criar e inicializar um array

            int[] array = new int[2];
            array[0] = 1;
            array[1] = 2;

            int[] array2 = new int[2] { 1, 2 };
            int[] array3 = new int[] { 1, 2};
            int[] array4 = { 1, 2 };


            // Criando um array utilizando a class Array
            Array objArray = Array.CreateInstance(typeof(int), 5);
            objArray.SetValue(10, 0); // valor 10 na posição 0
            int i = (int)objArray.GetValue(0); // o mesmo que objArray[0]
            Console.WriteLine(i);

            // Convertando obj array em sintax array tradicional
            int[] array5 = (int[])objArray;

            /* Quando criamos um array, estamos de forma implícita herdando as propriedades 
             * e métodos da class Array de System.Array
             */

            // === Propriedades ===

            // Retorna o tamanho/qtd de índices do array
            Console.WriteLine(array.Length);

            // Retornando o número de dimensões do array
            Console.WriteLine(array.Rank);

            // === Métodos ===

            // Copiando um array para outro array existente iniciando do indice 0
            int[] array6 = new int[2];
            array.CopyTo(array6, 0);

            // === Métodos STATIC ===

            // Seta o valor default de cada tipo de cada elemento do array
            Array.Clear(array2, 0, 1);

            // inverte os elementos de um array
            Array.Reverse(array3);

            // Ordenano os elementos de um array
            // Número ordem crescente
            // Strings ordem alfabética
            Array.Sort(array);



            Console.ReadKey();
        }
    }
}
