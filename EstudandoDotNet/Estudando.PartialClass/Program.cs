using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Partial Class
 * - É o conceito de dividir uma arquivo em vários arquivos do tipo .cs (com nomes diferentes)
 * - O modificador partial é utilizado na declaração da classe
 * - Devem serem definidas sob o mesmo namespace
 * - Do ponto de vista de uso da classe, não muda nada, é como se todo código estivesse
 * definido em um só arquivo
 */
 
namespace Estudando.PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            QuartoHotel quarto1 = new QuartoHotel();
            quarto1.Numero = 1901;
            quarto1.Andar = 19;
            quarto1.Fumante = false;
            quarto1.Reservar();
            quarto1.CancelarReserva();

            Console.ReadKey();
        }
    }
}
