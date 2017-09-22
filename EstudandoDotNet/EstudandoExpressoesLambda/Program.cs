using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoExpressoesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listCidades = new List<string>();
            listCidades.Add("São Paulo");
            listCidades.Add("Praia Grande");
            listCidades.Add("Santos");
            listCidades.Add("São Vicente");
            listCidades.Add("Guarujá");

            //exibirCidades(listCidades);

            Console.WriteLine(exibirPrimeiroComForeach(listCidades, "Santos"));
            Console.WriteLine(exibirPrimeiroComLinq(listCidades, "Guarujá"));
            Console.WriteLine(exibirPrimeiroComLambda(listCidades, "Praia Grande"));

            Console.WriteLine("");

            //Pra cada item dessa lista eu quero fazer um Console.WriteLine
            exibirListaComLinq(listCidades, "a").ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            exibirListaComLambda(listCidades, "o").ForEach(x => Console.WriteLine(x));


            Console.ReadKey();
        }

        public static void exibirCidades(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
        //------ Pesquisando um item e retornando ele
        //Pesquisa se tem a cidade Santos, se sim, retorna o nome da cidade
        //Com Foreach
        public static string exibirPrimeiroComForeach(List<string> lista, string cidade)
        {
            foreach (var item in lista)
            {
                if (item.Equals(cidade))
                {
                    return item;
                }
            }
            return null;
        }


        /* Há duas formas de se retornar com Linq, com o Linq puro que é próximo a sintaxe do sql
        ou com expressões Lambda */
        public static string exibirPrimeiroComLinq(List<string> lista, string cidade)
        {
            /*a cada iteração na lista irá receber o valor no item, no where ficara vericando se
            o item é igual ao recebido por parametro. Caso satisfaça a condição acima, retorne o item em questão */
            return (from item in lista where item.Equals(cidade) select item).First();
        }

        //Linq com expressões lambda
        public static string exibirPrimeiroComLambda(List<string> lista, string cidade)
        {
            /*Para cada iteração da minha lista a variavel que vai receber o valor será o x
            E ai eu digo que o x tem que ser igual ao meu termo cidade*/
            return lista.First(x => x.Equals(cidade));
        }


        //------ Retorna todos os itens em uma lista List<>, que contenham o nome do meu termo, ñ precisa ser igual, mas sim que contenha 
        public static List<string> exibirListaComLinq(List<string> lista, string cidade)
        {
            return (from item in lista where item.Contains(cidade) select item).ToList();
        }

        public static List<string> exibirListaComLambda(List<string> lista, string cidade)
        {
            return lista.Where(x => x.Contains(cidade)).ToList();
        }
    }
}
