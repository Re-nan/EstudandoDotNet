using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            Matematica mat = new Matematica();

            result = mat.Somar(5, 10);
            Console.WriteLine(result);

            /* O C# sabe que não tem um método que receba um double e um int
             * então ele procura um método que se encaixe fazendo o cast implícito do valor
             */ 
            result = mat.Somar(5.5, 10);
            Console.WriteLine(result);


            result = mat.Somar(5,5,5,5,5,5);
            Console.WriteLine(result);


            Console.ReadKey();

        }
    }
}
