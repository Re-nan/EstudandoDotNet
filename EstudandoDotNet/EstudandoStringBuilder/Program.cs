using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A diferença do StringBiulder pro String normal é que a StringBiulder consegue
             * modificar o seu valor enquanto a String só gera uma representação daquela string
             * Ela faz parte da namespace System.Text.StringBuilder a classe StringBuilder não pode
             * ser herdada, pois ela é do tipo sealed que significa que ela não pode ser herdada
             */

            StringBuilder nome = new StringBuilder("Renan");
            /*Ele cria um um obj com a capacidade de 16 caracteres Ex.
             * StringBuilder nome1 = new StringBuilder("Renan"); 16 caracteres por padrão
             * StringBuilder nome2 = new StringBuilder("RenanRenanRenanRenan"); 20 caracteres pq passou de 16 */
            Console.WriteLine(nome.Capacity);

            /* AppendLine() acrescenta no final do obj StringBuilder um terminador de linha, ou seja exibe e pula pra linha
             * de baixo a cada appendLine()
             */

            string linha1 = "linha1";
            string linha2 = "linha2";
            string linha3 = "linha3";
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(sb.Append(linha1).Append(linha2).Append(linha3));
            sb = new StringBuilder(String.Empty); //zerando a variavel pra começar a concatenação das linhas1,2,3 dnv
            Console.WriteLine(sb.AppendLine(linha1).AppendLine(linha2).AppendLine(linha3));

            /* Insert() - Igual o append, mas ele insere algo na posição que eu quiser da string */
            //sb = new StringBuilder(String.Empty);
            Console.WriteLine(sb.Insert(0, true));

            string letras = "ABC";
            Console.WriteLine(sb.Insert(0, letras, 5)); //insere no obj StringBuilder na posição 0 o valor de letras q é ABC e qtd d vezes

            /* Remove() - remove n caracteres a partir da posição de indice de início do obj StringBuilder chamador */
            Console.WriteLine(sb.Remove(0, 15)); //na posição zero removeu os 15 caracteres ABCABCABCABCABC

            /* Replace() - Sobreescreve/substitui um intervalo de n caracteres de um obj StringBuilder chamador, todas as
             * ocorrencias do caracter antigo pelo novo */
            Console.WriteLine(sb.Replace("linha", "cavalo")); // onde achou a palavra linha substituiu por cavalo



            Console.ReadKey();
        }
    }
}
