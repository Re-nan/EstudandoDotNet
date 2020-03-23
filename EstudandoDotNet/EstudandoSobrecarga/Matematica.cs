using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* SOBRECARGA DE MÉTODOS
 * É quando você tem métodos com o mesmo nome, mas com parametros diferentes, podendo ter a mesma
 * quantidade de parametros, desde que os tipos sejam diferentes
 * 
 * A CLR do .net se da o trabalho de encaixar a versão do método que melhor atendar os parâmetros
 * 
 * ATENÇÃO
 * Se você tiver 2 métodos com o mesmo nome e mesma quantidade e tipos de de parametros
 * mas o retorno diferente, a CLR dará erro, pois o 
 * 
 * A CLR do .net se da o trabalho de encaixar a versão do método que melhor atendar os parâmetros
 */
namespace EstudandoSobrecarga
{
    class Matematica
    {

        public double Somar(long n1, long n2)
        {
            return n1 + n2;
        }

        public double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Somar(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public double Somar(params double[] values)
        {
            double result = 0;
            foreach(double item in values)
            {
                result += item;
            }

            return result;
        }
    }
}
