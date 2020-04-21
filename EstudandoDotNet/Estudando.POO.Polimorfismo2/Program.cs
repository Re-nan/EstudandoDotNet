using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Polimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Note que a referência de Bebida chama o método Preparar() dela
             * que faz uso de métodos que foram sobrescrito em Cafe
             */ 
            Bebida bebida1 = new Cafe();
            bebida1.Preparar();

            Console.WriteLine();

            Bebida bebida2 = new Cha();
            bebida2.Preparar();


            Console.ReadKey();
        }
    }
}
