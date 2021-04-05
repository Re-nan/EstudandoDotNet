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
            List<Fruta> frutas = new List<Fruta>
            {
                new Fruta("Banana",     2.00m),
                new Fruta("Maçã",       2.50m),
                new Fruta("Melancia",   5.50m),
                new Fruta("Pera",       10.50m),
                new Fruta("Pitaya",     30.00m),
                new Fruta("Tangerina",  2.50m),
                new Fruta("Uva",        18.00m),
                new Fruta("Maçã",       7.00m),
            };

            // Retorna todas as frutas que o preço seja maior que 5
            // Temos 2 tipos de sintaxe que fazem a mesma coisa
            // Toda consulta LINQ retorna um IEnumerable<T>
            IEnumerable<Fruta> frutasMaioriesQue5;

            frutasMaioriesQue5 = frutas.Where(f => f.Preco > 5);
            // ou
            frutasMaioriesQue5 = from f in frutas
                                 where f.Preco > 5
                                 select f;

            // Ambas as sintaxes fazem a mesma coisa 

            // Ordenando a lista por DESC
            frutasMaioriesQue5.OrderByDescending(f => f);

            // Ordenando a lista por ASC
            frutasMaioriesQue5.OrderBy(f => f);

            Console.WriteLine("=== Frutas com o preço maiores que 5 ===");
            foreach (var item in frutasMaioriesQue5)
            {
                Console.WriteLine(item.Nome);
            }

            Console.WriteLine();

            Console.WriteLine("=== Algumas consultas ===");


            // Existe algum elemento da lista com o nome Pera?
            bool nomeUva = frutas.Any(p => p.Nome == "Uva");
            Console.WriteLine("nomeUva = " + nomeUva);

            // Retorne primeiro elemento da lista com o nome Maçã
            // Se não encontrar retorna um System.InvalidOperationException
            Fruta primeiroMaca = frutas.First(p => p.Nome == "Maçã");
            Console.WriteLine($"primeiroMaca = {primeiroMaca.Nome} {primeiroMaca.Preco}");

            // Retorne ultimo elemento da lista com o nome Maçã
            Fruta ultimoMaca = frutas.Last(p => p.Nome == "Maçã");
            Console.WriteLine($"ultimoMaca = {ultimoMaca.Nome} {ultimoMaca.Preco}");

            // Outra caso de mesma sintaxe
            frutas.Where(f => f.Preco > 5).FirstOrDefault();
            frutas.Where(f => f.Preco > 5).LastOrDefault();
            frutas.Where(f => f.Preco > 5).Count();
            
            /* Fazer consultas assim não estão erradas, mas também não otimizadas.
             * Não existe a necessidade de chamar o Where antes de chamar o First, Last, 
             * Count, entre outros. Você pode passar a expressão Lambda dentro do método 
             * que você quer chamar, tendo um código mais curto e limpo. 
             * Ficando da seguinte maneira:
             */
            
            frutas.FirstOrDefault(f => f.Preco > 5);
            frutas.LastOrDefault(f => f.Preco > 5);
            frutas.Count(f => f.Preco > 5);

           /* First vs FirstOrDefault
            * Quando você procura um elemento e esse elemento existe na listagem, ambas
            * irão retornam o mesmo elemento e não possuem diferenças.
            * amos supor que você queira a primeira fruta com o nome laranja:
            */

            // frutas.FirstOrDefault(f => f.Nome == "Laranja");
            // ou
            // frutas.First(f => f.Nome == "Laranja");

           /* Como a fruta laranja não existe em nossa listagem, o FirstOrDefault 
            * irá retornar o valor padrão de um objeto vazio, que no caso de uma 
            * classe é null. Já no caso do First, irá ocorrer uma exceção de 
            * System.InvalidOperationException
            * Portanto, tome cuidado ao utilizar o First, pois ele pode quebrar o 
            * seu código e te causar transtornos.
            */

            /* First vs Single
             * Single e First tem propósitos bem diferentes. O First, assim como vimos no
             * tópico anterior, sempre trás o primeiro elemento da lista. Enquanto o Single 
             * trás o único elemento da lista, mas se a sua lista tiver mais do que um 
             * elemento, ele irá retornar um erro de System.InvalidOperationException.
             */

            /* O Single também possui a versão SingleOrDefault, que possui um comportamento 
             * um pouco diferente do comum. Ambos os casos retornam exceção caso a lista 
             * possuir mais do que um elemento no retorno, mas no caso do Single, se a lista 
             * também não possuir um elemento para retornar, uma exceção de 
             * System.InvalidOperationException é disparada, enquanto o SigleOrDefault 
             * retornará o valor padrão de um objeto vazio.
             */
            
            Console.ReadKey();
        }
    }

    class Fruta
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Fruta(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

}