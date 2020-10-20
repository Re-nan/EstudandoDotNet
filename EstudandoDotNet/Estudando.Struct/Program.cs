using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Struct
 * São estruturas usadas para agrupar dados, bastante similar a uma Class
 * Podem conter fields/propriedades e métodos, e também precisam serem instanciadas para
 * serem utilizadas
 * 
 * Structs são ValueTypes e Classes ReferenceTypes
 * o fato de struct serem value types impacta na passagem de parâmetros, pois quando usa-se
 * structs como parâmetros, você está passando uma copia desse valor para o parâmetro, já
 * para classes(reference types) como parâmetros você fica a merce do Garbage Collector
 * liberar a memória enquanto structs são liberadas mais rápido pois são armazenadas stack
 * 
 * Sempre que você trabalha com structs, toda struct possu um construtor padrão que já vem
 * declarado implicitamente e não pode ser redefinido
 */

/* Diferenças entre Class e Struct
 * Class são reference type enquanto struct são value type
 * Class são armazenadas no Heap enquanto struct na stack
 * Class pode ter um construtor sem parâmetros enquanto struct sempre tem um construtor com parâmetros
 * Class suporta herança, enquanto struct não suporta
 */

namespace Estudando.Struct
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

        // Erro porque Struct não pode terem seus contrutores padrães redefinidos
        /*
            public Teste()
            {

            }
        */
    }
}