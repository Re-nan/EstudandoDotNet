using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.TipoString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tipo valor = Stack       Tipo Referencia = Heap
             * CLASSE Sring faz parte do System.String
             * é um tipo referencia ou seja os objs strings são armazenadoa na área
             * da memória chamada da reap. Um obj string é imutável ou seja, quando ele é criado o seu conteúdo
             * não pode ser modificado(alterado, excluido). A cada atribuição em uma var string ela troca o endereço
             * de memoria por outro e o endereço de antes fica pro garbage collector limpar
             */
            
            /* Já o tipo CLASSE StringBuilder faz parte do System.Text.StringBuilder
             * permite criar objs strings e dai sim, permite adcionar e alterar valores no mesmo endereço
             * de memoria.
             */

            /* Campos
             * empty retorna o valor de uma variavel vazia como se fosse nome = "";
             * Ex nome = ""; ou nome = String.empty;
             * Empty é um método estático e somente leitura, ñ tem como alterar, apenas ler
             */

            string texto = "exemplo";

            Console.WriteLine("var texto contém: " + string.Empty);
            texto = string.Empty;
            if (texto == String.Empty)
            {
                Console.WriteLine("String vazia");
            }

            Console.WriteLine();

            /* Lenght() - Toda string também é um array de caracteres e todo array tem o metodo Lenght
             * que conta o número de elemento de um array ou o numero de letras de uma string, já que 
             * cada letra esta em uma posição implicitamente*/
            string nome = "Renan";
            Console.WriteLine("O tamenho de caracteres em renan é: " + nome.Length); //5

            // Através da classe GC eu posso executar o Garbage Collector com o método Collect
            GC.Collect();

            Console.WriteLine();

            /* Caractres de escape em uma string
             * 
             * \n = quebra de linha
             * \" aspas
             * \t tab
             * \\ barra invertida
             */
           
            Console.WriteLine("Texto em \nduas linhas");
            Console.WriteLine("Texto entre \"aspas\"");
            Console.WriteLine("Nome:\tMaria");
            Console.WriteLine("C:\\projetos\\CSharp");

            Console.WriteLine();

            /* Verbatin strings
             * São prefeixadas com o caracter @
             * Ao utilizar uma verbatin strings você não precisa utilizar caracteres de escape
             */

            Console.WriteLine(@"Texto 
                        em 
                3 linhas");

            Console.WriteLine(@"Texto entre ""aspas""");
            Console.WriteLine(@"C:\projetos\CSharp");

            /* Alguns métodos(e uma propriedade) da classe String

            Length Retorna o tamanho da string
            Compare() Compara duas strings
            Contains() Verifica se uma string está contida em outra
            PadLeft() Preenche a string com caracteres desejados (à esquerda)
            PadRight() Preenche a string com caracteres desejados (à direita)
            Replace() Substitui caracteres em uma string
            Trim() Removes os espaços em branco iniciais e finais da string
            ToUpper() Converte todos os caracteres da string para maiúsculo
            ToLower() Converte todos os caracteres da string para minúsculo
             */


            Console.ReadKey();
        }
    }
}