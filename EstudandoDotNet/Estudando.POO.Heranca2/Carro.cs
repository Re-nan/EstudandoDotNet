using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Heranca2
{
    class Carro : IMotorizado
    {
        // prop da classe Carro
        public string NomeCarro { get; set; }

        // prop herdada da interface
        public string NomeMotor { get; set; }

        // implementando método da interface
        public void Ligar()
        {
            Console.WriteLine("Carro ligado");
        }

        // Sobrescrevendo método ToString() da classe Object
        public override string ToString()
        {
            return $"Carro: {NomeCarro} \nMotor: {NomeMotor}"; 
        }
    }
}
