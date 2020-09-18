using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				ContaCorrente c = new ContaCorrente();
				c.Depositar(200);
				c.Sacar(250);
			}
			catch (ContaCorrenteException e)
			{
				Console.WriteLine("ERRO");
				Console.WriteLine("Mensagem: " + e.Message); //Msg do Erro
				Console.WriteLine("Local: " + e.TargetSite); //Método que lançou a except
				Console.WriteLine("Stacktrace: " + e.StackTrace); //pilha de chamadas
			}

			Console.ReadKey();
		}
    }
}
