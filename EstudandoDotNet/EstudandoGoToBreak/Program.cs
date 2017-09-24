using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoGoToBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            //Se x > 5 ele vai acionar o goto e vai pro rótulo "y:", ignorando TUDO o que tiver em baixo até chegar no y:
            if (x > 5)
            {
                goto y;
            }
            else
            {
                x++;
                Console.WriteLine(x);
            }

            Console.WriteLine("Isso nem aparecerá se x > 5");
            Console.WriteLine("E nem isso");

            y: Console.WriteLine("y: " + y); //Exibe 20


            //Já o break é só utilizado no if se estiver dentro de um container for
            x = 10;
            y = 20;

            for (int i = 0; i < 10; i++)
            {
                if (x > 5)
                {
                    Console.WriteLine("Caiu no break:"); //Isso é exibido e cai no break indo para o Console.ReadKey()
                    break;

                }
                else
                {
                    Console.WriteLine("Não caiu no break:");
                }
            }



            Console.ReadKey();
        }
    }
}
