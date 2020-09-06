using System;

/* Quando você trabalha com partial class é preciso manter o mesmo namespace 
 * entre os arquivos
 */ 

namespace Estudando.PartialClass
{
    partial class QuartoHotel
    {
        public void Reservar()
        {
            Console.WriteLine("Reserva feita");
        }

        public void CancelarReserva()
        {
            Console.WriteLine("Reserva cancelada");
        }
    }
}