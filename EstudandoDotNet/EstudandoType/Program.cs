using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoTypeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(n.GetType()); //Exibe o tipo da var

            //System.TypeCode assim como System.code, System.string, System.double, System.object
            TypeCode tipoVar = n.GetTypeCode();
            Console.WriteLine(tipoVar);

            if (tipoVar.Equals(TypeCode.Int32))
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
