using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Uma forma fácil de criar classes de Exceções é digitar Exception
 * abaixo do namespace e dar tab tab que el irá criar automaticamente
 * a classe para você já herdando dos construtores da classe pai Exception
 * 
 * Geralmente você não cria uma classe Exception para sobrescrever comportamentos
 * e sim reutilizar o que já bem de Exception e usar um throw nesta classe quando
 * achar que em um momento do código caso ocorra tal coisa, lance essa exceção 
 */
 
namespace Estudando.Exceptions2
{

    [Serializable]
    public class ContaCorrenteException : Exception
    {
        public ContaCorrenteException() { }
        public ContaCorrenteException(string message) : base(message) { }
        public ContaCorrenteException(string message, Exception inner) : base(message, inner) { }
        protected ContaCorrenteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
