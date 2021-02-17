using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* LINQ (Language Integration Query)
 * Permite a contrução de queries para extrair dados, tem muita similiaridade com a
 * linguagem SQL, com uma sintaxe que lembra o SQL mas não é exatamente igual. O LINQ
 * pode extrair dados de várias fontes
 * - Objetos (Coleções e arrays)
 * - XML
 * - DataSet (compontente do ADO.net(api para trabalhar com banco de dados relacionais)
 * - Entities (ORM Entity Framework)
 * 
 * O usod e LINQ se apoia em alguns conceitos da linguagem C#
 * - Expressões lambda
 * - Extension methods
 * - Tipo de dados var
 * - Tipos anônimos 
 * 
 * Uma consulta com LINQ retorna um obj do tipo IEnumerable<T> que é uma outra coleção
 * para armazenar os dados do seu select
 * 
 * Uma operação LINQ só é executada quando a iteração sobre os elementos é realizada
 * Ou seja, no momento do foreach iterando sobre os elementos ou forçando  o obj com
 * os métodos ToArray(), ToList(), ToDictionary()
 */

namespace Estudando.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Extraindo pessoas maiores que 20 anos
             * 
             */

            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "Maria" }
            };
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
    }

}