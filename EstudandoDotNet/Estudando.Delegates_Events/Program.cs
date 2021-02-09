using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Delegates e Events
 * 
 * Callback
 * É um conceito universal em programação mas abordado de forma diferente nas linguagens.
 * Significa "Retornar uma ligação", "Ligar de volta". Em programação existem várias técnicas
 * para registro de callback. Em Ce C++ usam se ponteiros para função, já em Java usam uma
 * referência de um obj, já no C# pode se usar igual no Java ou com a forma recomendável que é
 * com o uso de delegates
 * 
 * Delegates
 * É um obj capaz de referenciar um método(ou "apontar para um método"). É um conceito muito
 * semelhante ao ponteiro para função do C/C++, mas garante segurança na tipagem dos dados
 * No C# um delegate é definido como um tipo de dado ex: struct, class e então delegate
 * Internamente quando você cria um delegate o compilador cria uma classe para o delegate, 
 * que herda de System.MultcastDelegate
 * 
 */

namespace Estudando.Delegates_Events
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /* A criação de um delegate é parecida com a de um método
        * Criando delegate chamado AvisoConsulta, que pode apontar para métodos
        * que recebem dois parametros, sendo o primeiro um DateTime e o segundo uma 
        * string e que tenham o tipo de retorno void. Um delegate pode apontar para 
        * qualquer método que respeite a sua assinatura
        */
        delegate void AvisoConsulta(DateTime horario, string obg);


        // Criando método que será referenciado pelo delegate
        static void MostrarConsulta(DateTime horario, string obs)
        {
            Console.WriteLine(horario);
            Console.WriteLine(obs);
        }

        // Criando segundo método para ser referenciado pelo delegate
        static void AgendarConsulta(DateTime horario, string obs)
        {
            Console.WriteLine(horario);
            Console.WriteLine(obs);
        }

        /* Referenciando o método ao delegate
         * Como dito antes, o C# cria uma classe pro implicitamente para o seu delegate
         * por isso callback é um tipo referêmcia AvisoConsulta, e no contrutor é passado
         * como parâmetro o método que eu quero vincular este delegate. Lembrando que a
         * assinatura do método tem que ser compatível com a assinatura do delegate
         * o delegate pode ser usado tanto para métodos static como para de instância 
         */
        AvisoConsulta callback = new AvisoConsulta(MostrarConsulta);
        // ou 



    }
}
