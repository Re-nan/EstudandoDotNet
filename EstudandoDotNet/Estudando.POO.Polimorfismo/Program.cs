using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.POO.Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somente uma referência do tipo Cachorro pode chamar o método Morder()
            Cachorro c = new Cachorro();
            c.Morder();

            /* Apesar da referência ser de Animal, o obj na memória é de Cachorro
             * portando o Falar() a ser chamado é o de Cachorro por ele ter sobrescrito
             * o Falar() de Animal. Porém a continua podendo chamar o método Andar() de 
             * Animal que não foi sobrescrito em Cachorro
             */ 
            Animal a = new Cachorro();
            a.Falar();
            a.Andar();

            Falar(new Gato());

            Console.WriteLine();

            Animal a2 = new Cachorro();
            //a2.Morder() Erro pois a referência é de Animal que não tem o método Morder() 

            //Verifica se a referência de Animal é do tipo Cachorro
            if(a2 is Cachorro)
            {
                // Realizando cast explícito
                Cachorro c2 = (Cachorro)a2;
                c2.Morder();
            }

            //ou
            Animal a3 = new Cachorro();
            
            // Converta a referência a3 de Animal em Cachorro e copie ela para c3
            Cachorro c3 = a3 as Cachorro;
            if(c3 != null)
            {
                c3.Morder();
            }


            Console.ReadKey();
        }


        /* O método recebe um Animal qualquer que terá seu comportamento conforme
         * o obj na memória
         */ 
        public static void Falar(Animal a)
        {
            a.Falar();
        }
    }
    
}
