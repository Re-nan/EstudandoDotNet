using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoByte
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tipo BYTE
             */
            int i = 66;
            byte nova = Byte.Parse("1");
            Console.WriteLine(nova);

            //Mesma coisa
            byte n = Convert.ToByte("1");

            byte b1 = 10, b2 = 50;

            Console.WriteLine(b1.CompareTo(b2)); //-40 pq b1 é menor
            Console.WriteLine(b1.Equals(b2)); //FALSE
            Console.WriteLine(Byte.Parse("22"));
            Console.WriteLine("O valor de b1 é: " + b1);





            Console.ReadKey();
        }
    }
}
