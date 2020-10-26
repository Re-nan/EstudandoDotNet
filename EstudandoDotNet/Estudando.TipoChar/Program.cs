using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.TipoChar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Campos
             * MaxValue = representa o MAIOR valor que um tipo char pode ter que é 65535
             * MinValue = representa o MENOR valor que um tipo char pode ter que é 0
             */

            char c1 = 'a', c2 = 'b';
            Console.WriteLine("O maior valor que um char pode ter é: " + Char.MaxValue); //Retorna >>> ? pq é o retorno de um tipo char ou seja unico caracter
            Console.WriteLine("O maior valor que um char pode ter é: " + (int)Char.MaxValue); //Retorna >>> 65535 pq é o retorno em formato int atraves de um cast explícito

            /* CompareTo()
             * Esse método compara dois objetos char de acordo com a tabela ASCII (letras maiusculas são menores que minusculas)
             * POSITIVO = se o obj que chama for MAIOR e o outro MENOR retornando a disntancia entre um ao outro na tabela
             * NEGATIVO = se o obj que chama for MENOR e o outro MAIOR retornando a disntancia entre um ao outro na tabela
             * ZERO = se os objs forem iguais
             */
            Console.WriteLine(c1.CompareTo(c2)); //Retorna negativo porque a vem antes de b
            Console.WriteLine('R'.CompareTo('r')); //Retorna negativo porque R vem bem antes de r
            Console.WriteLine(c1.CompareTo('!')); //Retorna positivo porque a vem DEPOIS de simbols

            /* Equals()
             * retorna TRUE = se o obj chamador for igual ao outro
             * retorna FALSE = se for diferente
             */

            Console.WriteLine(c1.Equals('a')); //retorna TRUE
            Console.WriteLine(c1.Equals('A')); //retorna FALSE

            /* GetNumericValue()
             * Retorna o valor somente de número em um char ou string
             * se não encontrar um numero no char ou na string retorna -1
             */
            Console.WriteLine(Char.GetNumericValue('9')); //retorna 9
            Console.WriteLine(Char.GetNumericValue('p')); //retorna -1
            Console.WriteLine(Char.GetNumericValue("renan19", 6)); //retorna 9

            /* GetUnicodeCarcatere()
             * Padrão de caracteres unicode, pressinando a tecla alt + numero na tabela ascii Ex. alt + 68 = D
             * Esse metodo retorna a categoria do caractere dizendo se ele é maiusculo ou minusculo ou tipo do simbolo
             */
            Console.WriteLine(Char.GetUnicodeCategory('@'));
            Console.WriteLine(Char.GetUnicodeCategory('A'));
            Console.WriteLine(Char.GetUnicodeCategory('2'));
            Console.WriteLine(Char.GetUnicodeCategory('+'));

            //varre uma string vendo se os carac são letras retornando true ou false
            string nome = "REN4N";
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(Char.IsLetter(nome, i));
            }

            //Lendo cada caracter de uma string
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }

            //ATRIBUINDO CADA LETRA DE UMA STRING EM UM VET DE CHAR
            string nomeeee = "GABS";
            char[] vet = new char[nomeeee.Length];
            for (int i = 0; i < nomeeee.Length; i++)
            {
                vet[i] = nomeeee[i];
            }

            Console.WriteLine("----");
            //EXIBE GABS NA VERTICAL
            for (int i = 0; i < nomeeee.Length; i++)
            {
                Console.WriteLine(vet[i]);

            }

            //EXIBE GABS NA HORIZONTAL
            Console.WriteLine();
            for (int i = 0; i < nomeeee.Length; i++)
            {
                Console.Write(vet[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
