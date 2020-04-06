using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Nested Type (ou inner type)
 * É um tipo definido dentro de uma class ou struct
 * Por padrão todo nested type é privado, mas pode ser alterado
 * sendo assim só poderia ser vistro dentro da class de fora em que ele
 * foi criado
 * 
 * 
 */ 
namespace EstudandoNestedType
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }



    class MinhaClasse1
    {

        MinhaClasse2 obj = new MinhaClasse2();

        class MinhaClasse2 // <--- Nested Type
        {
            string nome;
        }
    }

    struct MinhaStrutura1
    {
        struct MinhaStrutura2 // <--- Nested Type
        {

        }
    }
}
