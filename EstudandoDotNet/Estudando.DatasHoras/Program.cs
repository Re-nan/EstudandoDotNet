using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Para trabalhos com datas e Horas utilizamos a struct DateTime que fica no namespace/pacote 
 * System.DateTime, ela é utilizada para representar uma Data e Hora específica
 * 
 */

namespace Estudando.DatasHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data;
            data = new DateTime(2020, 01, 01);
            // Ano, mês e dia
            Console.WriteLine(data);

            // Ano, mês, dia, hora, minuto, segundo
            Console.WriteLine(new DateTime(2020, 12, 25, 18,30,00));

            /* Parse() é um método static da classe DateTime que recebe uma string e retorna um DateTime
             * ele converte ela de String para DateTime, se você passar uma string que não for capaz de
             * ser convertida em DateTime, este método irá lançar uma exception do tipo FormatException
             */
            data = DateTime.Parse("2020, 07, 19 04:00:00");
            Console.WriteLine(data);

            /* TryParse() é um método static da classe DateTime que recebe uma string e retorna True ou
             * False referente se ele conseguiu converter essa string para DateTime ou não, assim nunca
             * lança uma exception
             */
            DateTime result;
            bool b = DateTime.TryParse("caa", out result);
            Console.WriteLine("{0}, {1}", result, b);

            Console.WriteLine();

            /* A struct/class DateTime possui as propriedades "Now" e "Today", que retornar a data e hora
             * atual do sistema
             */
            Console.WriteLine(DateTime.Now); //Exibe Data e Hora
            Console.WriteLine(DateTime.Today); // Exibe Data e a Hora truncada

            /* O método ToString() de DateTime pode ser utilizado para representar uma data e hora como uma
             * string
             */
            string s;

            // Retorna a Data de hoje no formato do dia mês ano definido no sistema
            s = DateTime.Now.ToString("d"); 
            Console.WriteLine(s);

            // Retorna a Data por extenso
            s = DateTime.Now.ToString("D"); 
            Console.WriteLine(s);

            // Retorna a Hora e minuto mas sem o segundo
            s = DateTime.Now.ToString("t");
            Console.WriteLine(s);

            // Retorna a Hora e minuto e segundo
            s = DateTime.Now.ToString("T"); 
            Console.WriteLine(s);

            // Retorna o que eu definir
            s = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            Console.WriteLine(s);



            Console.ReadKey();
        }
    }
}
