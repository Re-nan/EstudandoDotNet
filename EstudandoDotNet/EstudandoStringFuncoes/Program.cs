using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoStringFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Renan";
            string texto = string.Empty;

            /* Compare() que é de uso clase diferente do CompareTo() que é de uso do obj
             * compara caracter por caracter
             * retorna 1 se string1 for maior que string2 
             * retorna 0 se string1 for igual a string2
             * retorna -1 se string1 for menor que string2
             */

            string ani1 = "dog", ani2 = "cat";
            Console.WriteLine(String.Compare(ani1, ani2)); //d de dog vem depois de c, então é maior na tabela ascii

            string str1 = "Amor", str2 = "Amor";
            Console.WriteLine(string.Compare(str1, str2, true));


            /* outro construtor que compara a partir do meio da string */
            Console.WriteLine(string.Compare(str1, 2, str2, 2, 2)); // (str1, PosiçãoInicio1, str2, Posiçãoinicio2, qtd) são iguais comparam o "or"

            /* Concat()
             * retorna qualquer concatenção de strings
             */
            string[] vet = { "AAA", "BBB", "CCC", "DDD", "E" };
            Console.WriteLine(String.Concat(vet));

            /*Join()
             * tipo especial de concat que usa um separador em todos os elementos do array*/
            Console.WriteLine(String.Join(" - ", vet));

            /* ToLower deixa tudo em minúsculo */
            string f = String.Concat(vet);
            Console.WriteLine(f.ToLower());

            /* ToUpper deixa tudo em maiusculo */
            Console.WriteLine(f.ToUpper());

            /* Copy() retorna a copia de uma string */
            string copiada = string.Copy(nome);
            Console.WriteLine(copiada);

            Console.WriteLine();

            /* ToCharArray
             * copia o valor dos caracteres de uma string em um array de caracteres */
            char[] arrayDeChar = nome.ToCharArray();

            for (int i = 0; i < nome.Length; i++)//exibindo com for
            {
                Console.WriteLine(arrayDeChar[i]);
            }

            Console.WriteLine();

            foreach (char elemento in arrayDeChar) //exibindo com foreach
            {
                Console.WriteLine(elemento);
            }


            Console.WriteLine();

            /* Remove() Elimina caracteres da string passando a posição inicial até a ultima posição
             * retornando uma nova string*/

            /* criei uma string com um texto
             * contei do 0 até 15 para armazenar os caracteres que serão removidos q são "Programando em "
             * em baixo pedi pra remover do 0 até o 15 que é a qtd de caracteres que quis remover de Programando em C#
             * para sobrar só C#*/

            string remover = "Programando em C#";
            string nrLetras = remover.Substring(0, 15); //ponto de inicio, quantidade de carac a serem removidos
            Console.WriteLine(remover.Remove(0, nrLetras.Length).ToString());

            /*Insert() insere na posição indicada um caracter*/
            Console.WriteLine(remover.Insert(17, " e Java")); //ou remover.Length no lugar do 17

            /*Contains() retorna true se um valor estiver contido naquela string*/
            Console.WriteLine(remover.Contains("C#")); //true

            /* EndWith() retorna true se a string termina com tal letra ou palavra*/
            Console.WriteLine(remover.EndsWith(" em C#"));

            /* IndexOf() - retorna a posição em que achou aquele carcater ou palavra designado, não encontrando nada retorna -1*/
            Console.WriteLine(remover.IndexOf(" C#")); //posição 14

            /*IndexOfAny() - retorna a ocorrencia de uma das letras passadas */
            char[] letras = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine(remover.IndexOfAny(letras, 0)); //na posição 2 achou o 'o'

            /* LastIndexOf - retorna o indice da ultima ocorrencia da letra/palavra passada */
            Console.WriteLine(remover.LastIndexOf('o')); //posição 10

            /* SubString() - é uma parte de uma string
             * retorna a parte de uma string, é como recortar uma parte daquela string*/
            Console.WriteLine("RENAN".Substring(2, 3)); //NAN

            /* StartWith() - retorna true se a string começa com a primeira letra/palavra que a passada */
            Console.WriteLine(nome.StartsWith("R")); //true

            /* EndWith() - retorna true se a string começa com a ultima letra/palavra que a passada */
            Console.WriteLine(nome.EndsWith("an")); //true 

            /* Split() - retorna um array de strings contendo Substrings() do obj chamador q são delimitados por um ou mais caracteres
             * de separação */
            string linguagens = "Java,C#,SQL,HTML";
            string[] arrayDeSubStringLinguagens;
            char[] separador = { ',' };

            arrayDeSubStringLinguagens = linguagens.Split(separador);
            Console.WriteLine(arrayDeSubStringLinguagens.Length);

            /* IsNullEmpty() - retorna true se a string estiver nula ou vazia */
            Console.WriteLine(String.IsNullOrEmpty(texto)); //foi usado o método Empty() nela no começo do codigo

            /* IsNullOrWhiteSpace retorna true tanto para Empty() como para um ou vários espaços em branco*/
            String n = "";
            Console.WriteLine(string.IsNullOrWhiteSpace(n)); //mesma coisa mas detecta espaço em branco

            /* PadLeft() - Alinha a direita a string, preenchendo com espaço vazio ou algum caracter determinado
             * a esquerda até atingir o tamando da string
             * PadRight() faz a mesma coisa, mas invertendo
             */
            string alinhar = "alinhando";
            Console.WriteLine(alinhar.PadLeft(50, '*'));

            /* Replace() - Substitui as ocorrencias do caracter carac1 pelo carac2 
             * Posso substituir tanto char como string
             */
            Console.WriteLine(nome.Replace('n', '%')); //Re%a%

            /*Trim() - Elimina do string chamador, os caracteres que sejam iguais aos do array passado como parametro
             * elimina caracter da esquerda ou da direita
             * elimina ou um ou multiplos caracteres
             */
            char[] vettt = { ' ' };
            string varTrim = "**DANIELLE*%***";
            Console.WriteLine(varTrim.Trim('*', '%')); //Removeu os * e % de **DANIELLE*%*** deixando só DANIELLE
            Console.WriteLine(varTrim.Length); //15 porque a String é imutavel, ele só removeu naquele contexto, naquela representação

            Console.WriteLine();

            string aawss = "  ".Trim(); //remove os espaços em branco tanto da esquerda como da direita deixando assim ""
            string v1 = null; //null
            String v2 = ""; // "" é diferente disso " " 
            if (aawss == v1 || aawss == v2)
            {
                Console.WriteLine("É nulo ou vazia");
            }
            else
            {
                Console.WriteLine("Nem nulo e nem vazia");
            }

            Console.ReadKey();
        }
    }
}
