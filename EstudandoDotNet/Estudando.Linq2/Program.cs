using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Realizando consultas simples com LINQ
 * 
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

        }


        // Método Factory para criar instancias de Aluno
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
