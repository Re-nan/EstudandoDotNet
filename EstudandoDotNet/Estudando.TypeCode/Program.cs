using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.TypeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(n.GetType()); //Exibe o tipo da var

            //System.TypeCode assim como System.Int32, System.String, System.Double, System.Object
            System.TypeCode tipoVar = n.GetTypeCode();
            Console.WriteLine(tipoVar);

            if (tipoVar.Equals(System.TypeCode.Int32))
            {
                Console.WriteLine("É do tipo: " + tipoVar);
            }
            else { Console.WriteLine("Não é do tipo int"); }


            //Posso atribuir qualquer tipo para um tipo object
            object o = (object)n;
            Console.WriteLine("\n" + o);

            Console.ReadKey();
        }
    }
}
