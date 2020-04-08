using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Struct
 * São estruturas usadas para agrupar dados, bastante similar a uma Class
 * Podem conter fields e métodos, e também preciso serem instanciadas para
 * serem utilizadas
 * 
 * Structs são ValueTypes e Classes ReferenceTypes
 * 
 */

namespace EstudandoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assim como as classes podem serem instanciadas assim

            Teste t1 = new Teste();
            t1.nome = "Renan";
            t1.numero = 19;

            Teste t2 = new Teste
            {
                nome = "",
                numero = 4
            };

            Console.ReadKey();
        }
    }

    struct Teste
    {

        public string nome;
        public int numero;

        public Teste(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;
        }
    }
}