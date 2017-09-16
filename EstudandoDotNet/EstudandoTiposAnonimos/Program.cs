using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoTiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Os anonymous type são uma forma de encapsular propriedades, são também muito utilizado na linguagem LinQ que é como se 
             * fosse uma linguagem sql, de busca, seleção de informações e essa linguagem utiliza esses anonymous types para buscar esses valores.
             * Os anonymous types lembram muito a declaração de var que tinhamos em linguagens mais antigas como vb e asp 3.0.
             * Os anonymous types abre essa tipificação para que eu não precise ter todas as informações fortemente tipadas como no caso é o c#.
             * Na pratica a principal utilidade deles é eu ter uma forma de encapsular valores, diversos valores dentro de um obj sem ter que 
             * tipificalo OU SEJA sem eu ter que definir um tipo de var que eu vou utilizar. (Parecido com ao ArrayList mas o ArrayList é 
             * mais relativo a um object doque esse caso em que ele respeita os tipos inserido)
             */

            //Depois que ela recebe um tipo baseado no seu valor, ela se torna imutavel
            var imutavel = "imutavel";
            //imutavel = 1; da erro

            var nomeVar1 = new { idade = 28, nome = "Renan" };
            var nomeVar2 = new[] { new { idade = 28, nome = "Renan" }, new { idade = 21, nome = "Gabriela" } };

            foreach (var elemento in nomeVar2)
            {
                Console.WriteLine("\nNome: " + elemento.nome);
                Console.WriteLine("Idade: " + elemento.idade);
            }

            //Os anonymous type não possuem seu valores anulado(atribuir null)
            //int i1 = null; da erro
            int? i2 = null; //faz ela aceitar nulo


            //ja string é um tipo que pode ser inulavel
            string n = null; //funciona




            Console.ReadKey();
        }

    }
}
