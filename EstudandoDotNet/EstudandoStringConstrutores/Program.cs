using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A classe String possui 3 construtores
 */ 

namespace EstudandoStringConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            
             // 1 - Posso criar uma string a partir de um array de char/caracteres
            char[] chr = { 'D', 'I', 'N', 'O', 'S', 'S', 'A', 'U', 'R', 'O' };
            string nomeAnimal = new string(chr);
            Console.WriteLine("Animal: " + nomeAnimal); //DINOSSAURO

            // 2 - Posso criar uma string de uma posição específica de um char passando a posição de início e quantidade
            String apelido = new String(chr, 5, 5); //Se colocar mais do que a quantidade que você pode varrer, cai na exception 
            Console.WriteLine("Apelido: " + apelido); //SAURO

            // 3 - Posso criar uma string a partir de um caracterer que se repetirá na qtd de vezes q eu quiser*/
            string qtdLetras = new string('R', 10);
            Console.WriteLine(qtdLetras); //RRRRRRRRRR

            Console.ReadKey();
        }
    }
}