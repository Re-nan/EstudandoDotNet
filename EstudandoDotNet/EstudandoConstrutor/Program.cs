using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Renan");
            Console.WriteLine(a1.Nome);

            //idade recebe zero porque o cosntrutor lá em cima chamou o construtor padrão pra ela implicitamente
            a1.Nome = "Novo renan";
            Console.WriteLine(a1.Nome + " " + a1.Idade); 

            a1.Idade = 28;
            Console.WriteLine(a1.Nome + " " + a1.Idade);

            //Outra forma de setar valores
            Aluno a2 = new Aluno("Danielle")
            {
                Idade = 24
            };
            Console.WriteLine("\n" + a2.Nome + " " + a2.Idade);

            Console.ReadKey();
        }
    }
}
