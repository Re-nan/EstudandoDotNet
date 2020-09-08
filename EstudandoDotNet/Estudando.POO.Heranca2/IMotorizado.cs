using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Heranca2
{
    interface IMotorizado
    {
        string NomeMotor { get; set; }

        void Ligar();
    }
}
