using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoModificadorStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            /* o acesso ao field ValorMax é feito através do nome da classe seguido
             * de um ponto e o nome do field desejado
             */ 
            Console.WriteLine("Valor Max: " + Numero.ValorMax);

            Numero.ExibirValor(10);

            // Obj de instancia acessando field static
            Numero n = new Numero();
            n.ExibirValorMax();

            Console.WriteLine("Qtd de instancias: " + Numero.QtdInstancias);

            // Numero2 n2 = new Numero2(); //Erro de compilação

            Console.ReadKey();
        }
    }
}
