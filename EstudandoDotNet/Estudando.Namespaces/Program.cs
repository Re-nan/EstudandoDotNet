using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Namespaces
 * - Permitem organizar o código de forma lógica. Evitam a ambiguidade em nome de elementos
 * - Namespaces são lógicos, não estão associados à arquivos de código fonte ou assemblies.
 * - Recomenda-se utilizar pelos 2 níveis ao nomear seus namespaces
 * Ex. NomeEmpresa.NomeProjeto
 * - Um elemento sempre tem um namespace associado, se você não definir um namespace a sua 
 * classe, ela fará parte de um namespace global/sem nome
 */
 
namespace Estudando.Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /* fully qualified name 
             * é composto pelo nome do pacote/nome dos níveis do namespace
             */ 
            System.Console.WriteLine();
        }
    }
}
