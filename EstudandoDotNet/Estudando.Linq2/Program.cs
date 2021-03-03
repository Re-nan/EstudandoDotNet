using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Realizando consultas simples com LINQ
 * Quando você trabalha com LINQ a primeira que você tem que pensar é, onde estão os
 * dados? Qual será a minha fonte de informação? No nosso caso será a coleção de Alunos
 * 
 * Sintax: (Parecido com uma consulta SQL)
 * 
 * var q =
 * Eu preciso atribuir a minha expressão LINQ a uma variável, normalmente usamos o tipo
 * var, mas toda expressão LINQ retorna uma expressão do tipo IEnumerable<T>
 * 
 * from a in alunos
 * Selecione todos os elementos a em Alunos
 * 
 * Quando a nota de cada elemento for maior ou igual a 5 e o nome começar com J maiusculo
 * where a.Nota >= 5 && a.Nome.StartsWith("J")
 * 
 * Ordenano a lista de resultado por nome em ordem alfabética
 * orderby a.Nota ascending
 * 
 * Defindo o retorno que não será de Aluno mas sim string com os nomes dos Alunos
 * select a.Nome
 * 
 * Defindo o retorno que não será de Aluno mas sim double com as notas dos Alunos
 * select a.Nota
 * 
 * Retornando classe anonima(sem nome) com duas propriedades Nome e a nota multilplicada por 10
 * select new { Inicial = a.Nome[0], Nota = a.Nota * 10 };
 */

namespace Estudando.Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = CriarAlunos();

            var q = from a in alunos
                    where a.Nota >= 5 && a.Nome.StartsWith("J")
                    orderby a.Nota ascending
                    select new { Inicial = a.Nome[0], Nota = a.Nota * 10 };

            foreach (var i in q)
            {
                Console.WriteLine(i);
            }

            //ExtrairAlunos(alunos);

            Console.ReadKey();
        }


        // Método para criar uma coleção de dados com alguns Alunos com nome e nota
        static List<Aluno> CriarAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno() { Nome = "João", Nota = 9.5 });
            alunos.Add(new Aluno() { Nome = "Pedro", Nota = 4 });
            alunos.Add(new Aluno() { Nome = "Maria", Nota = 5 });
            alunos.Add(new Aluno() { Nome = "Joana", Nota = 6.5 });
            alunos.Add(new Aluno() { Nome = "Julia", Nota = 7 });

            return alunos;
        }

        // Método para retornar extrair Alunos
        static List<Aluno> ExtrairAlunos(List<Aluno> alunos)
        {
            var q = from a in alunos
                where a.Nota >= 5 && a.Nome.StartsWith("J")
                orderby a.Nota ascending
                select a;

            // retornando um List de Aluno
            return q.ToList();


            /* ou retornando um Dictionary dizendo que a chave é o nome
             * e mudando a assinatura pra Nome e obj Aluno
             *
             *static Dictionary<string, Aluno> ExtrairAlunos(List<Aluno> alunos)
             */
            // return q.ToDictionary(a => a.Nome);

            //
        }
    }

    
    // Classe Aluno
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public override string ToString()
        {
            return Nome + " -> " + Nota;
        }
    }
}
