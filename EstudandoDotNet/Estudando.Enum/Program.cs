using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(linguagens.CSharp);
            Console.WriteLine((int)linguagens.Java);
            Console.WriteLine("Nome: " + linguagens.SQL + " --- Seu id na lista é: " + (int)linguagens.SQL);
            Console.ReadKey();
        }

        /* ENUM 
         * geralmente utilizados quando temos valores fixos para determinar algo
         * Também muito utilizado para representar informações que são fixas em uma base de dados
         * os itens de um ENUM recebem numerações automáticas iniciando do zero, porém pode se definir o número
         * inicial de um item e os demais seguirão automayicamente a ordem numérica
         */
        enum linguagens
        {
            CSharp = 3, Java, SQL = 10
        }
    }
}
