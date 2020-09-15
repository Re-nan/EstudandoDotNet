using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Exceptions
 * Existem 2 tipos de Exceptions na hierarquia de classes de Exceções 
 * "System Exceptions" e "Application Exceptions" e ambas herdam de "Exception"
 * 
 * System Exceptions 
 * já são definidas pelo sistema, pela api do .net como:
 * NullReferenceException = quando tenta acessar um elemento de um obj cujo valor é null
 * ArgumentException = parametro invalido fornecido ao método
 * DivideByZeroException = quando ocorre uma divisão por zero
 * IOException = algum erro relacionado a I/O (input/output)
 * FileNotFoundException = quando o arquivo não existe
 * 
 * Application Exceptions
 * São execeções definidas pelo aplicativo, a Microsoft queria que os Devs ao criar suas
 * próprias Exceções, derivassem elas de ApplicationExceptions, mas com o tempo isso caiu
 * em desusso e ela recomdento que todas as exceptions criadas pelo Dev deveriam derivar
 * diretamente de Exception.
 * 
 * Como saber se uma Exception é do tipo SystemExceptions, ApplicationException ou se foi
 * criada por um Dev?
 * Basta olhar a hierarquia de herança da exceção, todas as exception definidas na api do
 * C# herdam de System Exceptions ou Application Exceptions, já as criadas na mão pelo
 * Dev herdam de Exceptions.(Não é uma regra de compilação, mas sim um padrão recomendável)
 * 
 * Propriedade da classe Exception
 * - Message = Retorna uma string com a msg do erro
 * - InnerException = Retorna um tipo Exception = exceção aninhada(lançar uma exception no catch de outra)
 * - Data = Retorna um IDictionary = dados em pares de chave/valor
 * - HelpLink = Retorna uma string com um link para mais informações sobre o erro
 * - Source = Retorna uma string com o nome do assembly = caminho do namespace
 * - StackTrace = Retorna uma string com detalhes sobre a pilha de chamadas de métodos
 * - TargetSite = Objeto que representa o método que lançou a exceção
 * 
 * A Message é somente readonly, Valor definido pela Exceção, você só visualiza
 * InnerException, Data e HelpLink = é você quem seta os valores
 * Source, StackTrace e TargetSite = Valores já definidos pela CLR
 */

namespace Estudando.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object o = null;
                o.ToString();

                Matematica m = new Matematica();
                double result = m.Dividir(6, 0);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Namespace: " + ex.Source);
                Console.WriteLine();
                Console.WriteLine("StackTrace: " + ex.StackTrace);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Namespace: " + ex.Source);
                Console.WriteLine();
                Console.WriteLine("StackTrace: " + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Flw");
            }

            Console.ReadKey();
        }

        
    }
}
