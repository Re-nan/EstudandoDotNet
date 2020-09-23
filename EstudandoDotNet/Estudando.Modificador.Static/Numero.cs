using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Modificador STATIC
 * Pode ser utilizado em diversos locais como Fields, Métodos, Construtores e Classes
 * 
 * Tudo que é static não pode ser acessado através de instancia da Classe
 * mas sim acessado diretamento do NomeClasse.NomeFieldStatic
 */

namespace Estudando.Modificador.Static
{
    class Numero
    {
        /* Um field do tipo static deixa de ser uma proprieda de um obj de instancia
         * e passar a ser uma propriedade da classe
         * 
         * Um field static tem seu valor compartilhado entre todas os objs da Classe
         * 
         * Métodos de instancia podem interagir com elementos estáticos, mas métodos
         * estáticos só podem interagir com elementos estáticos
         */

        public static int QtdInstancias;
        public static int ValorMax;

        public static void ExibirValor(int valor)
        {
            Console.WriteLine("Valor: " + valor);
        }

        //Método não static que acessa field static
        public void ExibirValorMax()
        {
            Console.WriteLine("Valor Max: " + Numero.ValorMax);
        }

        /* Construtor static  são chamados pela CLR na primeira
         * vez em que a classe é utilizada, tem o objetivo de inicializar
         * fields estaticos da classe, eles não possuem parametros, não pode ser
         * sobrecarregado, não possui modificador de acesso, ele é executado
         * apenas 1x independente do número de instancias criadas, ele sempre
         * será executado primeiro que o Contrutor não estático
         */
        static Numero()
        {
            ValorMax = 1000;
        }

        // Construtor de instancia que faz uso de um elemento estático
        public Numero()
        {
            QtdInstancias++;
        }
    }

    /* Uma classe que é definida como static não pode conter instancias
     * Todos os elementos dentro dela também são static
     */ 
    static class Numero2
    {

        private static double PI = 3.1416;

        public static void exibirPI()
        {
            Console.WriteLine(PI);
        }
    }
}
