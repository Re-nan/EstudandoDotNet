using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Exceptions
{
    class Matematica
    {
        public double Dividir(double a, double b)
        {
            if(b == 0)
                throw new DivideByZeroException("O denomindador não pode ser zero");

            return a / b; 
        }
    }
}
